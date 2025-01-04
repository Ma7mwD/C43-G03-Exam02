using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark) : base(header, body, mark) { }

        public override string ToString()
        {
            return $"[MCQ] {Header}: {Body} ({Mark} Marks)";
        }
    }
}
