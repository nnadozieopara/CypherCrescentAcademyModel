using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherCrescentAcademy
{
    public class Facilitator : Human,IQuestion
    {
        public int EmploymentNumber { get; set; }
        public Facilitator(string name, string email, int employmentNumber,Programme programme) : base(name, email,programme)
        {
            EmploymentNumber = employmentNumber;
        }

        public void AnswerQuestion()
        {
            Console.WriteLine("Your question has been answered and here are some resources for futher studies");
        }
        public void AskQuestion(Student student)
        {
            Console.WriteLine($"{student.Name}, would you answer this question");
        }

        
    }
}
