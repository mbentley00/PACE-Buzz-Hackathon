using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PACEBuzz.Code
{
    public class TextToSpeechConvert
    {
        public static string AzureSpeechServiceRequestTemplate = File.ReadAllText("AzureSpeechServiceRequestTemplate.txt");

        public async Task<Stream> Read(string content, string subscriptionKey)
        {
            string token = null;

            using (var httpClient = new HttpClient())
            {
                using (var httpRequestMessage = new HttpRequestMessage())
                {
                    httpRequestMessage.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
                    httpRequestMessage.Headers.TryAddWithoutValidation("Content-type", "application/x-www-form-urlencoded");
                    httpRequestMessage.Method = HttpMethod.Post;
                    httpRequestMessage.RequestUri = new Uri("https://westus.api.cognitive.microsoft.com/sts/v1.0/issueToken");

                    using (var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage))
                    {
                        httpResponseMessage.EnsureSuccessStatusCode();

                        token = await httpResponseMessage.Content.ReadAsStringAsync();
                    }
                }

                using (var httpRequestMessage = new HttpRequestMessage())
                {
                    httpRequestMessage.Headers.Add("X-Microsoft-OutputFormat", "riff-24khz-16bit-mono-pcm");
                    httpRequestMessage.Headers.TryAddWithoutValidation("Authorization", token);
                    httpRequestMessage.Headers.TryAddWithoutValidation("User-Agent", "Test TTS application");
                    httpRequestMessage.Method = HttpMethod.Post;
                    httpRequestMessage.RequestUri = new Uri("https://westus.tts.speech.microsoft.com/cognitiveservices/v1");
                    string requestContent = AzureSpeechServiceRequestTemplate.Replace("{VoiceContent}", content);
                    httpRequestMessage.Content = new StringContent(requestContent, Encoding.UTF8, "application/ssml+xml");

                    var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                    if (!httpResponseMessage.IsSuccessStatusCode)
                    {
                        var error = await httpRequestMessage.Content.ReadAsStringAsync();

                        throw new InvalidOperationException($"{httpResponseMessage.StatusCode}: {error}");
                    }

                    return await httpResponseMessage.Content.ReadAsStreamAsync();
                }
            }
        }
    }
}
