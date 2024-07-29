using Exam002.ExamSystem.Exam;
using Exam002.ExamSystem.Question;
using System.Reflection.Metadata;

namespace Exam002
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string TypeOfExam;
            string TimeForExam;
            string NumOfQuestion;

            Console.WriteLine("Please Enter The Type Of Exam : 1.Practical | 2.Final");
            TypeOfExam = Console.ReadLine();

            Console.WriteLine("Enter Time for Exam : 30M to 180M ");
            TimeForExam = Console.ReadLine();

            Console.WriteLine("Enter Number Of Questions ");
            NumOfQuestion = Console.ReadLine();

            BaseExam exam;


            if (TypeOfExam == "1")
            {
                exam = new PracticalExam(int.Parse(TimeForExam), int.Parse(NumOfQuestion));



                for (int x = 0; x < NumOfQuestion.Length; x++)
                {
                    Answer[] answers = new Answer[3];
                    Console.WriteLine("Enter the body Of the Question:");
                    string body = Console.ReadLine();
                    Console.WriteLine("Enter The Mark Of the Question:");
                    int Mark = int.Parse(Console.ReadLine());
                    Console.WriteLine("Choices of Question :");
                    for (int i = 0; i < answers.Length; i++)
                    {
                        Answer answer = new Answer() { AnswerId = i, AnswerText = Console.ReadLine() };
                        answers[i] = answer;
                    }
                    Console.WriteLine("Enter The Right Answer ID");
                    int RightAnswerID = int.Parse(Console.ReadLine());
                    Console.Clear();
                    MCQ mcqQuestion = new MCQ(RightAnswerID, answers, body, Mark);
                    exam.AddQuestion(mcqQuestion);
                }
            }
            else if (TypeOfExam == "2")
            {

                exam = new PracticalExam(int.Parse(TimeForExam), int.Parse(NumOfQuestion));



                for (int x = 0; x < NumOfQuestion.Length; x++)
                {
                    Console.WriteLine("Please Enter The Type Of Question: 1.MCQ | 2.TrueOrfalse");
                    var qType = Console.ReadLine();
                    if (qType == "1")

                    {
                        Answer[] answers = new Answer[3];
                        Console.WriteLine("Enter the body Of the Question:");
                        string body = Console.ReadLine();
                        Console.WriteLine("Enter The Mark Of the Question:");
                        int Mark = int.Parse(Console.ReadLine());
                        Console.WriteLine("Choices of Question :");
                        for (int i = 0; i < answers.Length; i++)
                        {
                            Answer answer = new Answer() { AnswerId = i, AnswerText = Console.ReadLine() };
                            answers[i] = answer;
                        }
                        Console.WriteLine("Enter The Right Answer ID");
                        int RightAnswerID = int.Parse(Console.ReadLine());
                        Console.Clear();
                        MCQ mcqQuestion = new MCQ(RightAnswerID, answers, body, Mark);
                        exam.AddQuestion(mcqQuestion);

                    }
                    else if (qType == "2") {

                        Console.WriteLine("Enter the body Of the Question:");
                        string body = Console.ReadLine();
                        Console.WriteLine("Enter The Mark Of the Question:");
                        int Mark = int.Parse(Console.ReadLine());
                       
                        Console.WriteLine("Enter The Right Answer ID");
                        int RightAnswerID = int.Parse(Console.ReadLine());
                        Console.Clear();
                        TureOrFalse question = new TureOrFalse(RightAnswerID, body, Mark);
                        exam.AddQuestion(question);

                    }
                }
              


                }
            else { Console.WriteLine("Error try again");
            }
            Console.WriteLine("click any key to start exam");
            Console.ReadLine();
           
           
        }
        }
    }

