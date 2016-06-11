using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenieNETPG
{
    public class Workday : Weekday
    {
        private int minutesLeftToday;
        private int secondsLeftToday = 0;
        public Workday(string dayOfWeek, string typeOfActivity, string nameOfActivity, int durationInMinutes) 
            : base(dayOfWeek, typeOfActivity, nameOfActivity, durationInMinutes)
        {

        }

        public override bool validate() 
        {
            if (durationInMinutes >= 960)
            {
                Console.WriteLine("Given duration is longer that 16 hours in a workday!");
                return false;
            }
            else
                return true;
        }

        public override void setTimeLeft(int minutes, int seconds)
        {
            this.minutesLeftToday = minutes;
            this.secondsLeftToday = seconds;
        }
    }
}
