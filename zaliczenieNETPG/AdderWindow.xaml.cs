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
    /// Interaction logic for AdderWindow.xaml
    /// </summary>
    /// 
    public partial class AdderWindow : Window
    {
        public AdderWindow()
        {
            InitializeComponent();

            foreach(var item in Enum.GetValues(typeof(Container.weekdays)))
            {
                weekbox.Items.Add(item);
            }

            foreach(var item in Enum.GetValues(typeof(activityTypes)))
            {
                activityBox.Items.Add(item);
            }
        }
        
        
        
        

        enum activityTypes
        {
            Studying = 1,
            Outdoor,
            Project,
            Other
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Add_Event(object sender, RoutedEventArgs e)
        {
            String s = weekbox.Text;
            Weekday newDay;
            int time = 0;

            try 
            { 
                time = Convert.ToInt32(duration.Text); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Error in duration time", "ERROR", MessageBoxButton.OK);
                return;
            }


            if(s == "Saturday" || s == "Sunday")
                newDay = new Weekend(s, activityBox.Text, activity.Text, time);
            else
                newDay = new Workday(s, activityBox.Text, activity.Text, time);

            if (newDay.validate() == false)
            {
                MessageBox.Show("Activity duration longer than a day", "ERROR", MessageBoxButton.OK);
                return;
            }
            else
            {
                MessageBox.Show("Success", "INFO", MessageBoxButton.OK);
                Container.activities.Add(newDay);
            }

            
        }


    }
}
