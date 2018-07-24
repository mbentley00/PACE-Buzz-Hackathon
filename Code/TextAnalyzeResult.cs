using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACEBuzz.Code
{
    public class TextAnalyzeResult
    {
        public IList<Document> documents { get; set; }
    }

    public class Document
    {
        public IList<string> KeyPhrases { get; set; }
    }

    public class TextAnalyzeRequest
    {
        public IList<RequestDocument> documents { get; set; }
    }

     public class RequestDocument
    {
        public string language { get; set; }
        public int id { get; set; }
        public string text { get; set; }
    }


}
