using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenieNETPG
{
    public abstract class Weekday
    {
        protected string dayOfWeek;
        protected string typeOfActivity;
        protected string nameOfActivity;
        protected int durationInMinutes;
        protected int minutesLeftToday;
        protected int secondsLeftToday = 0;

        public Weekday(string dayOfWeek, string typeOfActivity, string nameOfActivity, int durationInMinutes)
        {
            this.dayOfWeek = dayOfWeek;
            this.typeOfActivity = typeOfActivity;
            this.nameOfActivity = nameOfActivity;
            this.durationInMinutes = durationInMinutes;
            this.minutesLeftToday = durationInMinutes;
        }

        public abstract bool validate();

        public virtual void timeLeft(int minutes, int seconds)
        {
            this.minutesLeftToday = minutes;
            this.secondsLeftToday = seconds;
        }

    }
}
