using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACEBuzz.Code
{
    public class QuestionPlayer
    {
        private IList<Question> Questions;

        public QuestionPlayer()
        {
            QuestionLoader questionLoader = new QuestionLoader();
            Questions = questionLoader.Load("Questions\\Quiz1.txt");
        }
    }
}
