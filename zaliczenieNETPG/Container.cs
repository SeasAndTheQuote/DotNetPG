using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenieNETPG
{
    public static class Container
    {
        public static List<Weekday> activities = new List<Weekday>();

        public enum weekdays
        {
            Monday = 0,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }

}
