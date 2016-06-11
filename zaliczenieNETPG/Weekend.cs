using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenieNETPG
{
    public class Weekend : Weekday
    {
        /*private string dayOfWeek;
        private string typeOfActivity;
        private string nameOfActivity;
        private int durationInMinutes;
        private int secondsLeftToday;
        private int minutesLeftToday;*/
        public Weekend(string dayOfWeek, string typeOfActivity, string nameOfActivity, int durationInMinutes) 
            : base(dayOfWeek, typeOfActivity, nameOfActivity, durationInMinutes)
        {

        }

        public string day
        {
            get { return dayOfWeek; }
            set { dayOfWeek = value; }
        }

        public string type
        {
            get { return typeOfActivity; }
            set { typeOfActivity = value; }
        }

        public string name
        {
            get { return nameOfActivity; }
            set { nameOfActivity = value; }
        }

        public int duration
        {
            get { return durationInMinutes; }
            set { durationInMinutes = value; }
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
