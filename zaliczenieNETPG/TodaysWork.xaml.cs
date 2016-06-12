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
using System.Collections.ObjectModel;

namespace zaliczenieNETPG
{
    /// <summary>
    /// Interaction logic for TodaysWork.xaml
    /// </summary>
    public partial class TodaysWork : Window
    {
        private ObservableCollection<Weekday> todayTasks = new ObservableCollection<Weekday>();
        public TodaysWork()
        {
            InitializeComponent();

            DateTime todayFullDate = DateTime.Today;
            DayOfWeek todayDOW = todayFullDate.DayOfWeek;
            string todayDayOfTheWeek = todayDOW.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Weekday x in Container.activities)
            {
                MessageBox.Show(x.name, "ERROR", MessageBoxButton.OK);
            }
        }


    }
}
