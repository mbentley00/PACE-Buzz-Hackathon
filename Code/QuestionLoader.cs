using PACEBuzz.Code.Questions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACEBuzz.Code
{
    public class QuestionLoader
    {
        public IList<Question> Load(string fileName)
        {
            var lines = File.ReadAllLines(fileName);
            var questions = new List<Question>();

            for (int i = 0; i < lines.Length; i += 4)
            {
                Question question = new Question();
                question.Body = lines[i];
                question.Answer = lines[i + 1];
                question.Category = lines[i + 2];

                questions.Add(question);
            }

            return questions;
        }
    }
}
