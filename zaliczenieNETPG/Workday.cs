using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenieNETPG
{
    public class Workday : Weekday
    {

        /*private string dayOfWeek;
        private string typeOfActivity;
        private string nameOfActivity;
        private int durationInMinutes;
        private int secondsLeftToday;
        private int minutesLeftToday;*/
        public Workday(string dayOfWeek, string typeOfActivity, string nameOfActivity, int durationInMinutes) 
            : base(dayOfWeek, typeOfActivity, nameOfActivity, durationInMinutes)
        {
            /*this.dayOfWeek = dayOfWeek;
            this.typeOfActivity = typeOfActivity;
            this.nameOfActivity = nameOfActivity;
            this.durationInMinutes = durationInMinutes;*/
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
            if (durationInMinutes >= 960)
            {
                Console.WriteLine("Given duration is longer that 16 hours in a workday!");
                return false;
            }
            else
                return true;

        }
    }
}
