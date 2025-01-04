namespace OOPExam
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Subject subject1 = new Subject(101, "Programming");
            
            FinalExam finalExam = new FinalExam(120, 2);
            var question1 = new TrueFalseQuestion("Q1", "C# is a programming language?", 5, 2);
            question1.AnswerList[0] = new Answer(1, "True");
            question1.AnswerList[1] = new Answer(2, "False");
            question1.RightAnswerId = 1;
            finalExam.Questions[0] = question1;
            var question2 = new MCQQuestion("Q2", "Which one is not a programming language?", 10, 3);
            question2.AnswerList[0] = new Answer(1, "Python");
            question2.AnswerList[1] = new Answer(2, "Java");
            question2.AnswerList[2] = new Answer(3, "HTML");
            question2.RightAnswerId = 3;
            finalExam.Questions[1] = question2;


            subject1.CreateExam(finalExam);

            
            Console.WriteLine(subject1);
            subject1.SubjectExam.ShowExam();


            Console.WriteLine("\n");
            

            /*----------------------------------------------------------------------------------*/
            Subject subject2 = new Subject(102, "History");

            PracticalExam practicalExam = new PracticalExam(60, 1);


            var practicalQuestion = new MCQQuestion("Q1", "Which Year 6th October war be?", 5, 3);
            practicalQuestion.AnswerList[0] = new Answer(1, "1973");
            practicalQuestion.AnswerList[1] = new Answer(2, "1980");
            practicalQuestion.AnswerList[2] = new Answer(3, "1956");
            practicalQuestion.RightAnswerId = 1;
            practicalExam.Questions[0] = practicalQuestion;

            subject2.CreateExam(practicalExam);

            Console.WriteLine(subject2);
            subject2.SubjectExam.ShowExam();
        }
    }
}
