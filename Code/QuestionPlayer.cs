using SharpDX.Multimedia;
using SharpDX.XAudio2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PACEBuzz.Code
{
    public class QuestionPlayer : IDisposable
    {
        private IList<Question> Questions;
        private bool disposed = false;
        private string azureSpeechServiceSubscriptionKey;

        public int QuestionNumber { get; set; }

        public static bool IsAtEndOfQuestion { get; set; }

        public Question CurrentQuestion
        {
            get
            {
                return this.Questions[this.QuestionNumber];
            }
        }

        public QuestionPlayer(string azureSpeechServiceSubscriptionKey)
        {
            if (string.IsNullOrEmpty(azureSpeechServiceSubscriptionKey))
            {
                throw new ArgumentNullException(nameof(azureSpeechServiceSubscriptionKey));
            }

            this.azureSpeechServiceSubscriptionKey = azureSpeechServiceSubscriptionKey;
        }

        public void Reset()
        {
            QuestionLoader questionLoader = new QuestionLoader();
            Questions = questionLoader.Load("Questions\\Quiz1.txt");
            this.QuestionNumber = 0;
        }

        public void Play()
        {
            Stop();
            PlayQuestion(this.QuestionNumber);
        }

        private void PlayQuestion(int questionNumber)
        {
            TextToSpeechConvert textToSpeechConvert = new TextToSpeechConvert();

            string questionWavFileName = $"question{questionNumber}.wav";

            if (!File.Exists(questionWavFileName))
            {
                using (var stream = Task.Run(() => textToSpeechConvert.Read(Questions[questionNumber].Body, azureSpeechServiceSubscriptionKey)).Result)
                {
                    using (var fileStream = File.Create(questionWavFileName))
                    {
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fileStream);
                    }
                }
            }

            SafePlayQuestionSound(questionWavFileName);
        }

        public void PlayText(string text)
        {
            TextToSpeechConvert textToSpeechConvert = new TextToSpeechConvert();

            string wavFileName = $"text.wav";

            using (var stream = Task.Run(() => textToSpeechConvert.Read(text, azureSpeechServiceSubscriptionKey)).Result)
            {
                using (var fileStream = File.Create(wavFileName))
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    stream.CopyTo(fileStream);
                }
            }

            SafePlayNonQuestionSound(wavFileName);
        }

        private void SafePlayQuestionSound(string soundFile)
        {
            try
            {
                if (thread != null)
                {
                    thread.Abort();
                }

                thread = new Thread(new ParameterizedThreadStart(PlayQuestionSound));
                thread.Start(soundFile);

                // TODO: Dispose the thread?
            }
            catch (Exception)
            {
            }
        }

        private void SafePlayNonQuestionSound(string soundFile)
        {
            try
            {
                if (nonQuestionThread != null)
                {
                    nonQuestionThread.Abort();
                }

                nonQuestionThread = new Thread(new ParameterizedThreadStart(PlayOtherSound));
                nonQuestionThread.Start(soundFile);

                // TODO: Dispose the thread?
            }
            catch (Exception)
            {
            }
        }


        private static SourceVoice sourceVoice;
        private Thread thread;
        private Thread nonQuestionThread;
        private bool isPaused;
        private static XAudio2 xaudio2;
        private static MasteringVoice masteringVoice;
        private static AudioBuffer buffer;

        public static void PlayQuestionSound(object soundFile)
        {
            PlayXAudioSound(soundFile, true);
        }

        public static void PlayOtherSound(object soundFile)
        {
            PlayXAudioSound(soundFile, false);
        }

        public static void PlayXAudioSound(object soundFile, bool useQuestionSourceVoice)
        {
            try
            {
                xaudio2 = new XAudio2();
                masteringVoice = new MasteringVoice(xaudio2);

                var stream = new SoundStream(File.OpenRead(soundFile as string));
                var waveFormat = stream.Format;
                buffer = new AudioBuffer
                {
                    Stream = stream.ToDataStream(),
                    AudioBytes = (int)stream.Length,
                    Flags = BufferFlags.EndOfStream
                };
                stream.Close();

                SourceVoice localSourceVoice = null;


                localSourceVoice = new SourceVoice(xaudio2, waveFormat, true);
                localSourceVoice.SubmitSourceBuffer(buffer, stream.DecodedPacketsInfo);
                localSourceVoice.Start();
                if (useQuestionSourceVoice)
                {
                    // Store this source voice so we can pause / unpause
                    sourceVoice = localSourceVoice;
                    IsAtEndOfQuestion = false;
                }

                while (localSourceVoice.State.BuffersQueued > 0)
                {
                    Thread.Sleep(1);
                }

                if (useQuestionSourceVoice)
                {
                    IsAtEndOfQuestion = true;
                }

                localSourceVoice.DestroyVoice();
                localSourceVoice.Dispose();
                localSourceVoice = null;
                buffer.Stream.Dispose();

                xaudio2.Dispose();
                masteringVoice.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Stop()
        {
            thread?.Abort();
            if (sourceVoice != null && buffer != null && xaudio2 != null && masteringVoice != null)
            {
                sourceVoice.DestroyVoice();
                sourceVoice.Dispose();
                sourceVoice = null;
                xaudio2.Dispose();
                masteringVoice.Dispose();
            }
        }

        /// <summary>
        /// Pauses/unpauses the current question
        /// </summary>
        /// <param name="forcePause">Set to true if you only watn to pause (and never resume)</param>
        public void Pause(bool forcePause = false)
        {
            if (sourceVoice == null)
            {
                return;
            }

            if (isPaused && !forcePause)
            {
                sourceVoice.Start();
                isPaused = false;
            }
            else
            {
                sourceVoice.Stop();
                isPaused = true;
            }
        }

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                thread?.Abort();
            }

            disposed = true;
        }
    }
}
