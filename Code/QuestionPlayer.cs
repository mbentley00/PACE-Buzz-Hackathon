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
    public class QuestionPlayer:IDisposable
    {
        private IList<Question> Questions;
        private bool disposed = false;
        private string azureSpeechServiceSubscriptionKey;

        public QuestionPlayer(string azureSpeechServiceSubscriptionKey)
        {
            if(string.IsNullOrEmpty(azureSpeechServiceSubscriptionKey))
            {
                throw new ArgumentNullException(nameof(azureSpeechServiceSubscriptionKey));
            }

            this.azureSpeechServiceSubscriptionKey = azureSpeechServiceSubscriptionKey;
            QuestionLoader questionLoader = new QuestionLoader();
            Questions = questionLoader.Load("Questions\\Quiz1.txt");
        }

        public void Play()
        {
            Random random = new Random();
            var questionNumber=random.Next(0, Questions.Count);

            Stop();
            PlayQuestion(questionNumber);
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

            SafePlaySound(questionWavFileName);
        }

        private void SafePlaySound(string soundFile)
        {
            try
            {
                if(thread!=null)
                {
                    thread.Abort();
                }

                thread = new Thread(new ParameterizedThreadStart(PlayXAudioSound));
                thread.Start(soundFile);

                // TODO: Dispose the thread?
            }
            catch (Exception)
            {

            }

            return;
        }

        private static SourceVoice sourceVoice;
        private Thread thread;
        private bool isPaused;
        private static XAudio2 xaudio2;
        private static MasteringVoice masteringVoice;
        private static AudioBuffer buffer;

        public static void PlayXAudioSound(object soundFile)
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

                sourceVoice = new SourceVoice(xaudio2, waveFormat, true);
                sourceVoice.SubmitSourceBuffer(buffer, stream.DecodedPacketsInfo);
                sourceVoice.Start();

                while (sourceVoice.State.BuffersQueued > 0)
                {
                    Thread.Sleep(1);
                }

                sourceVoice.DestroyVoice();
                sourceVoice.Dispose();
                sourceVoice = null;
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
            if(sourceVoice!=null&&buffer!=null&&xaudio2!=null&&masteringVoice!=null)
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
            if(sourceVoice==null)
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
