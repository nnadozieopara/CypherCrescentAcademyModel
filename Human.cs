using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CypherCrescentAcademy
{
    public abstract class Human
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Programme Programme { get; set; }
        public Human(string name, string email,Programme programme)
        {
            Name = name;
            Email = email;
            Programme = programme;
        }
        public void AttendClass(WeekDays weekDay)
        {
            if (Programme.ClassDays.Contains(weekDay))
            {
                Console.WriteLine($"{Name},The host will let you in shortly");
                Thread.Sleep(5000);
                Console.WriteLine("You're in\n");
            }
            else
            {
                Console.WriteLine($"{Name}, no class today\n");
            }
        }
    }
}
