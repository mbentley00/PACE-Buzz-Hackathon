using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PACEBuzz.Code
{
    public class AnswerAnalyzer
    {
        private string textAnalyzerKey;

        public AnswerAnalyzer(string textAnalyzerKey)
        {
            this.textAnalyzerKey = textAnalyzerKey;
        }

        public async Task<IList<string>> AnalyzeAsync(string text)
        {
            var results = new List<string>();

            using (var httpClient = new HttpClient())
            {
                using (var httpRequestMessage = new HttpRequestMessage())
                {
                    httpRequestMessage.Headers.Add("Ocp-Apim-Subscription-Key", textAnalyzerKey);
                    httpRequestMessage.Method = HttpMethod.Post;
                    httpRequestMessage.RequestUri = new Uri("https://westus.api.cognitive.microsoft.com/text/analytics/v2.0/keyPhrases");
                    var textAnalyzeRequest = new TextAnalyzeRequest();
                    textAnalyzeRequest.documents = new List<RequestDocument>{
                        new RequestDocument
                        {
                            language="en",
                            id=1,
                            text=text
                        } };

                    httpRequestMessage.Content = new StringContent(JsonConvert.SerializeObject(textAnalyzeRequest), Encoding.UTF8, "application/json");

                    using (var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage))
                    {
                        if(httpResponseMessage.IsSuccessStatusCode)
                        {
                            var content = await httpResponseMessage.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<TextAnalyzeResult>(content);

                            return result.documents.SelectMany(d => d.KeyPhrases).ToList();
                        }
                    }
                }
            }

            return results;
        }
    }
}
