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
        private ObservableCollection<String> start = new ObservableCollection<string>();    //bloody hell I'm so sorry
        public TodaysWork()
        {
            InitializeComponent();

            this.tasksList.ItemsSource = todayTasks;
            this.buttons.ItemsSource = start;

            DateTime todayFullDate = DateTime.Today;
            DayOfWeek todayDOW = todayFullDate.DayOfWeek;
            string todayDayOfTheWeek = todayDOW.ToString();

            foreach(Weekday x in Container.activities)
            {
                if (x.day == todayDayOfTheWeek)
                {
                    todayTasks.Add(x);
                    start.Add("Start");
                }
                
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application curApp = Application.Current;
            curApp.Shutdown();
        }

        private void DoubleClick(object sender, RoutedEventArgs e)  //TODO!
        {
            MessageBox.Show("Being short on time, i didn't manage to finish this one part of app :(\nBut well, there we go, what is left is to do the countdown, all but this works\nIt is set as TODO so at least I know a clear direction for further development!", "Darn it!", MessageBoxButton.OK);
        }





    }
}
