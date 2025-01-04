using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class DIAGRAM
    {
        /*
           Abstract Class: Question
           Attributes: Header string , Body string ,  Mark int, AnswerList List<Answer> , RightAnswerId int
           Methods: ToString() abstract

           Subclasses: 
           TrueFalseQuestion Inherits Question , Overrides ToString()
           MCQQuestion Inherits Question , Overrides ToString()

           Class: Answer
           Attributes: AnswerId int , AnswerText string
           Methods: ToString()

           Abstract Class: Exam
           Attributes: Time int , NumberOfQuestions int, Questions List<Question>
           Methods: ShowExam() abstract

           Subclasses: 
           FinalExam Inherits Exam , Overrides ShowExam()

           PracticalExam Inherits Exam , Overrides: ShowExam()
           Class: Subject
           Attributes: SubjectId int , SubjectName string , SubjectExam Exam
           Methods: CreateExam(Exam) void

           Clone(): object (Implements ICloneable)
           CompareTo(Subject): int (Implements IComparable)
           ToString(): string

                Relationships

           Inheritance:
                Question → TrueFalseQuestion, MCQQuestion
                Exam → FinalExam, PracticalExam

           Associations:
                Subject has 1 Exam.
                Exam has many Questions.
                Question has many Answers.
         
         */
    }
}
