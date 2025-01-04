using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public abstract class Exam
    {
        public int Time { get; set; } // in minutes
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }

        protected Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new List<Question>();
        }

        public abstract void ShowExam();
    }
}
