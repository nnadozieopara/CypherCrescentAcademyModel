using System;

namespace CypherCrescentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Student Dozie = new Student("Dozie","nnadozie.opara@yahoo.com",8,new Frontend());
            //Dozie.AskQuestion(new Facilitator("Murphy","Murphy@gmail.com",78, new Frontend()));
            //Dozie.AskQuestion(Dozie);
            //Dozie.AnswerQuestion();
            //Dozie.AttendClass(WeekDays.Monday);
            //Dozie.AttendClass(WeekDays.Thursday);
            //Dozie.AttendClass(WeekDays.Tuesday);
            //Console.Read();

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

            Console.Read();
        }
    }
}
