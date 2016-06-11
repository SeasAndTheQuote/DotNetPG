using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace zaliczenieNETPG
{
    /// <summary>
    /// Interaction logic for TodaysWork.xaml
    /// </summary>
    public partial class TodaysWork : Window
    {
        public TodaysWork()
        {
            InitializeComponent();

            DateTime todayFullDate = DateTime.Today;
            DayOfWeek todayDOW = todayFullDate.DayOfWeek;
            string todayDayOfTheWeek = todayDOW.ToString();
        }


    }
}
