using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenieNETPG
{
    public class Weekend : Weekday
    {

        private int minutesLeftToday;
        private int secondsLeftToday = 0;

        public Weekend(string dayOfWeek, string typeOfActivity, string nameOfActivity, int durationInMinutes) 
            : base(dayOfWeek, typeOfActivity, nameOfActivity, durationInMinutes)
        {}

        public override void setTimeLeft(int minutes, int seconds)
        {
            this.minutesLeftToday = minutes;
            this.secondsLeftToday = seconds;
        }
        public override bool validate()
        {
            if (durationInMinutes >= 1440)
            {
                Console.WriteLine("Given duration is longer that 24 hours!");
                return false;
            }
            else
                return true;
        }

    }
}
