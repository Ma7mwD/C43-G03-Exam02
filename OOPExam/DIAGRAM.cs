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
           Attributes: Header string , Body string ,  Mark int , answerCount int , 
           Answer[] AnswerList , RightAnswerId int
           Methods: ToString() abstract

           Subclasses: 
           TrueFalseQuestion Inherits Question , Overrides ToString()
           MCQQuestion Inherits Question , Overrides ToString()

           Class: Answer
           Attributes: AnswerId int , AnswerText string
           Methods: ToString()

           Abstract Class: Exam
           Attributes: Time int , NumberOfQuestions int, Question[] Questions
           Methods: ShowExam() abstract

           Subclasses: 
           FinalExam Inherits Exam , Overrides ShowExam()

           PracticalExam Inherits Exam , Overrides: ShowExam()
           Class: Subject
           Attributes: SubjectId int , SubjectName string , SubjectExam Exam
           Methods: CreateExam(Exam) void


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
