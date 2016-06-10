using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenieNETPG
{
    public abstract class Weekday
    {
        string dayOfWeek;
        string typeOfActivity;
        string nameOfActivity;
        int durationInMinutes;
        public Weekday(string dayOfWeek, string typeOfActivity, string nameOfActivity, int durationInMinutes)
        {
            this.dayOfWeek = dayOfWeek;
            this.typeOfActivity = typeOfActivity;
            this.nameOfActivity = nameOfActivity;
            this.durationInMinutes = durationInMinutes;
        }

        public abstract bool validate();

    }
}
