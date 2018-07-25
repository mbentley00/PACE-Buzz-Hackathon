using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;

namespace PACEBuzz.Code
{
    public class SpeechToTextConverter
    {
        public static void BingSpeech()
        {

        }

        public static async Task<string> RecognitionWithMicrophoneAsync()
        {
            // <recognitionWithMicrophone>
            // Creates an instance of a speech factory with specified subscription key and service region.
            // Replace with your own subscription key and service region (e.g., "westus").
            var factory = SpeechFactory.FromSubscription("841aed53d12a4473928b1001431dbea4", "westus");

            // Creates a speech recognizer using microphone as audio input. The default language is "en-us".
            using (var recognizer = factory.CreateSpeechRecognizer())
            {
                // Starts recognizing.
                Console.WriteLine("Say something...");

                // Performs recognition.
                // RecognizeAsync() returns when the first utterance has been recognized, so it is suitable 
                // only for single shot recognition like command or query. For long-running recognition, use
                // StartContinuousRecognitionAsync() instead.
                var result = await recognizer.RecognizeAsync().ConfigureAwait(false);

                // Checks result.
                if (result.RecognitionStatus != RecognitionStatus.Recognized)
                {
                    Console.WriteLine($"Recognition status: {result.RecognitionStatus.ToString()}");
                    if (result.RecognitionStatus == RecognitionStatus.Canceled)
                    {
                        Console.WriteLine($"There was an error, reason: {result.RecognitionFailureReason}");
                    }
                    else
                    {
                        Console.WriteLine("No speech could be recognized.\n");
                    }

                    return string.Empty;
                }
                else
                {
                    Console.WriteLine($"We recognized: {result.Text}, Offset: {result.OffsetInTicks}, Duration: {result.Duration}.");
                    return result.Text;
                }
            }
            // </recognitionWithMicrophone>
        }
    }
}
