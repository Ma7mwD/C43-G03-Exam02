using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public int RightAnswerId { get; set; }

        protected Question(string header, string body, int mark, int answerCount)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = new Answer[answerCount];
        }

        public abstract override string ToString();
    }
}
