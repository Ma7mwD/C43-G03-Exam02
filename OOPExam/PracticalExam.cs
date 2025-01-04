using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam:");
            foreach (var question in Questions)
            {
                Console.WriteLine(question);
                foreach (var answer in question.AnswerList)
                {
                    Console.WriteLine(answer);
                }
            }
        }
    }
}
