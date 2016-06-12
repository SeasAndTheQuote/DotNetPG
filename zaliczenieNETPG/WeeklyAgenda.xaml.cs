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
    /// Interaction logic for WeeklyAgenda.xaml
    /// </summary>
    public partial class WeeklyAgenda : Window
    {
        private ObservableCollection<String>[] fullWeek = new ObservableCollection<String>[7];
        public WeeklyAgenda()
        {
            InitializeComponent();


            for (int i = 0; i < 7; i++)
            {
                fullWeek[i] = new ObservableCollection<String>();
            }

            foreach(Weekday x in Container.activities)
            {
                string dayTemp = x.day;
                string nameTemp = x.name;
                int column = (int)((Container.weekdays) Enum.Parse(typeof(Container.weekdays), dayTemp));

                try
                {
                    fullWeek[column].Add(x.name);
                }
                catch(NullReferenceException)
                {
                    MessageBox.Show(nameTemp, "ERROR", MessageBoxButton.OK);
                }
            }

            this.List0.ItemsSource = fullWeek[0];
            this.List1.ItemsSource = fullWeek[1];
            this.List2.ItemsSource = fullWeek[2];
            this.List3.ItemsSource = fullWeek[3];
            this.List4.ItemsSource = fullWeek[4];
            this.List5.ItemsSource = fullWeek[5];
            this.List6.ItemsSource = fullWeek[6];


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
