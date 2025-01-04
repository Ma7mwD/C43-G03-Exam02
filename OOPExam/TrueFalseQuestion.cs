using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark) : base(header, body, mark) { }

        public override string ToString()
        {
            return $"[True/False] {Header}: {Body} ({Mark} Marks)";
        }
    }
}
