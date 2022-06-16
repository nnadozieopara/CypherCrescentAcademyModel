using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherCrescentAcademy
{
    public class Student : Human,IQuestion
    {
        public int EnrollmentNumber { get; set; }
        public Student(string name, string email, int enrollmentNumber,Programme programme) : base(name, email,programme)
        {
            EnrollmentNumber = enrollmentNumber;
        }

        public void AskQuestion(Human human)
        {
            Console.WriteLine($"{human.Name}, would you answer this question"); ;
        }
        

        public void AnswerQuestion()
        {
            Console.WriteLine("This is the answer to your question");
        }
    }
}
