using Exam002.ExamSystem.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam002.ExamSystem.Exam
{
    public abstract class BaseExam
    {
        public int TimeForExam { get; set; }
        public BaseQuestion[] Questions { get; set; }
        public BaseExam(int TimeForExam)
        {
            TimeForExam = this.TimeForExam;


        }
        public void AddQuestion(BaseQuestion Question)
        {
           Questions.Append(Question);
            
        }



    }
}
