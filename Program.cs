using System;

namespace CypherCrescentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programme frontEnd = new Frontend();
            Programme backEnd = new Backend();
            Human[] humans = new Human[]
                            {
                                new Facilitator("Dozie","dozie@gmail.com",1, frontEnd),
                                new Facilitator("Mathew","Mat@gmail.com",1, backEnd),
                                new Student("Imeh","dozie@gmail.com",1, frontEnd),
                                new Student("Bosun","dozie@gmail.com",1, frontEnd),
                                new Student("Promise","dozie@gmail.com",1, frontEnd),
                                new Student("MAry","dozie@gmail.com",1, frontEnd),
                                new Student("Imeh","dozie@gmail.com",1, backEnd),
                                new Student("Bosun","dozie@gmail.com",1, backEnd),
                                new Student("Promise","dozie@gmail.com",1, backEnd),
                                new Student("MAry","dozie@gmail.com",1, backEnd),
                            };

            foreach (var human in humans)
            {
                human.AttendClass(WeekDays.Monday);
                human.AttendClass(WeekDays.Wednesday);
            }

            var facilitator1 = new Facilitator("Dozie", "dozie@gmail.com", 1, frontEnd);
            facilitator1.AskQuestion(new Student("Imeh", "dozie@gmail.com", 1, frontEnd));

            var student1 = new Student("Imeh", "dozie@gmail.com", 1, frontEnd);
            var student2 = new Student("Imeh", "dozie@gmail.com", 1, backEnd);
            student1.AskQuestion(facilitator1);
            student1.AskQuestion(student2);

            Console.Read();
        }
    }
}
