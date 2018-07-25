using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACEBuzz.Code
{
    public class Question
    {
        public string Body { get; set; }
        public string Answer { get; set; }
        public string Category { get; set; }

        public string FormattedAnswer
        {
            get
            {
                string answer = this.Answer.Substring(9);
                string[] answerParts = answer.Split('[');
                return answerParts[0].Trim();
            }
        }
    }
}
