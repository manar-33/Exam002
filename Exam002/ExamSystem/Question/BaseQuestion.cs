using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam002.ExamSystem.Question
{
    public abstract class BaseQuestion
    {
        public string Headerofthequestion { get; set; }
        public string Bodyofthequestion { get; set; }
        public int Mark { get; set; }
        protected BaseQuestion(string header, string body, int mark)
        {
            Headerofthequestion = header;
            Bodyofthequestion = body;
            Mark = mark;
        }
        public abstract bool CheckAnswer(int AnswerId);


    }
}
