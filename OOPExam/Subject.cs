using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int _subjectId, string _subjectName)
        {
            SubjectId = _subjectId;
            SubjectName = _subjectName;
            SubjectExam = new FinalExam(0, 0);
        }

        public void CreateExam(Exam exam)
        {
            SubjectExam = exam;
        }

       

        public override string ToString()
        {
            return $"Subject: {SubjectName} (ID: {SubjectId})";
        }

    }
}
