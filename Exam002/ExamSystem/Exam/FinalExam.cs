using Exam002.ExamSystem.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam002.ExamSystem.Exam
{
    internal class FinalExam : BaseExam
    {
        public FinalExam(int TimeForExam, int NumOfQuestions) : base(TimeForExam)
        {
            Questions = new MCQ[NumOfQuestions];
        }
    }
}
