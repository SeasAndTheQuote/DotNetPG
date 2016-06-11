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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zaliczenieNETPG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();

        }

        private void AddEvent(object sender, RoutedEventArgs e)
        {
            AdderWindow add = new AdderWindow();
            add.ShowDialog();
            
        }

        private void GoToWeek(object sender, RoutedEventArgs e)
        {
            WeeklyAgenda agenda = new WeeklyAgenda();
            agenda.ShowDialog();
        }

        private void StartToday(object sender, RoutedEventArgs e)
        {
            TodaysWork working = new TodaysWork();
            working.Show();
            this.Close();
        }
    }
}
