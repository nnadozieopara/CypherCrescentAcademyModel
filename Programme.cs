using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherCrescentAcademy
{
    public abstract class Programme
    {
        public List<WeekDays> ClassDays { get; set; } = new List<WeekDays> { WeekDays.Tuesday, WeekDays.Thursday };
        public List<Student> Students { get; set; }
        public List<Facilitator> Facilitators { get; set; }
    }
}
