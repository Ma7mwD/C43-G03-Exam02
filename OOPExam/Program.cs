namespace OOPExam
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Subject subject = new Subject(101, "Programming");
            Subject sub = new Subject(102, "History");

            
            FinalExam finalExam = new FinalExam(120, 2);
            PracticalExam practicalExam = new PracticalExam(20, 1);

            
            var question1 = new TrueFalseQuestion("Q1", "C# is a programming language?", 5);
            question1.AnswerList.Add(new Answer(1, "True"));
            question1.AnswerList.Add(new Answer(2, "False"));
            question1.RightAnswerId = 1;
            finalExam.Questions.Add(question1);

            var question2 = new MCQQuestion("Q2", "Which one is a programming language?", 10);
            question2.AnswerList.Add(new Answer(1, "Python"));
            question2.AnswerList.Add(new Answer(2, "CSS"));
            question2.AnswerList.Add(new Answer(3, "HTML"));
            question2.RightAnswerId = 3;
            finalExam.Questions.Add(question2);

            
            subject.CreateExam(finalExam);

            
            Console.WriteLine(subject);
            subject.SubjectExam.ShowExam();

            var question3 = new MCQQuestion("Q3", "Which Year 6th Octoper war be?", 10);
            question3.AnswerList.Add(new Answer(1, "1973"));
            question3.AnswerList.Add(new Answer(2, "1980"));
            question3.AnswerList.Add(new Answer(3, "1956"));
            question3.RightAnswerId = 1;
            practicalExam.Questions.Add(question3);

            sub.CreateExam(practicalExam);
            Console.WriteLine(sub);
            sub.SubjectExam.ShowExam();
        }
    }
}
