using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam002.ExamSystem.Question
{
    internal class TureOrFalse : MCQ
    {
        static Answer[] Answers = new Answer[] {
         new Answer() { AnswerId=1, AnswerText="True"},
         new Answer() { AnswerId=2, AnswerText="False"}};
        public TureOrFalse(int rightanswer, string body, int mark) :
            base(rightanswer, Answers, body, mark, "True or false")
        { }


    }
}
