using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenieNETPG
{
    public abstract class Weekday
    {
        private string dayOfWeek;
        private string typeOfActivity;
        private string nameOfActivity;

        protected int durationInMinutes;

        public Weekday(string dayOfWeek, string typeOfActivity, string nameOfActivity, int durationInMinutes)
        {
            this.dayOfWeek = dayOfWeek;
            this.typeOfActivity = typeOfActivity;
            this.nameOfActivity = nameOfActivity;
            this.durationInMinutes = durationInMinutes;
        }

        public abstract bool validate();

        public abstract void setTimeLeft(int minutes, int seconds);
        public virtual string day
        {
            get { return dayOfWeek; }
            set { dayOfWeek = value; }
        }
        public virtual string type
        {
            get { return typeOfActivity; }
            set { typeOfActivity = value; }
        }
        public virtual string name
        {
            get { return nameOfActivity; }
            set { nameOfActivity = value; }
        }
        public virtual int duration
        {
            get { return durationInMinutes; }
            set { durationInMinutes = value; }
        }


    }
}
