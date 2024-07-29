using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam002.ExamSystem.Question
{
    internal class MCQ : BaseQuestion
    {
        public int RightAnswerId { get; set; }
        public Answer[] Answers { get; set; }
        public MCQ(int rightanswer, Answer[] answers,  string body, int mark, string header = "Select right answer") : base(header, body, mark)
        {
            RightAnswerId = rightanswer;
            Answers = answers;
        }
        public override bool CheckAnswer(int answerId)
        {
            return answerId == RightAnswerId;
        }
    }
}
