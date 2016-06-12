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

        private void TestEvent(object sender, RoutedEventArgs e)
        {
            //testing
            Weekend newDay = new Weekend("Saturday", "Outdoor", "Programming", 56);
            Weekend newDay1 = new Weekend("Sunday", "Project", "Programming", 63);
            Weekend newDay2 = new Weekend("Saturday", "Outdoor", "Running", 56);
            Weekend newDay3 = new Weekend("Sunday", "Outdoor", "Running", 56);
            Weekend newDay4 = new Weekend("Saturday", "Other", "Studies", 56);
            Weekend newDay5 = new Weekend("Saturday", "Outdoor", "Studies Projects", 56);

            Workday newDay6 = new Workday("Monday", "Outdoor", "Programming", 56);
            Workday newDay7 = new Workday("Monday", "Outdoor", "Programming", 52);
            Workday newDay8 = new Workday("Tuesday", "Outdoor", "Programming", 83);
            Workday newDay81 = new Workday("Tuesday", "Outdoor", "Programming", 18);
            Workday newDay9 = new Workday("Thursday", "Outdoor", "Studies Projects", 56);
            Workday newDay91 = new Workday("Thursday", "Studying", "Studying", 56);
            Workday newDay10 = new Workday("Wednesday", "Outdoor", "Running", 85);
            Workday newDay101 = new Workday("Wednesday", "Studying", "Studying", 85);
            Workday newDay11 = new Workday("Friday", "Outdoor", "Studies", 56);
            Workday newDay112 = new Workday("Friday", "Outdoor", "Recent Projects", 56);
            Workday newDay111 = new Workday("Friday", "Outdoor", "Partying woohoo!", 180);
            Workday newDay12 = new Workday("Tuesday", "Outdoor", "Studies", 56);

            Container.activities.Add(newDay);
            Container.activities.Add(newDay1);
            Container.activities.Add(newDay2);
            Container.activities.Add(newDay3);
            Container.activities.Add(newDay4);
            Container.activities.Add(newDay5);
            Container.activities.Add(newDay7);
            Container.activities.Add(newDay8);
            Container.activities.Add(newDay9);
            Container.activities.Add(newDay10);
            Container.activities.Add(newDay11);
            Container.activities.Add(newDay12);
            Container.activities.Add(newDay81);
            Container.activities.Add(newDay91);
            Container.activities.Add(newDay101);
            Container.activities.Add(newDay111);
            Container.activities.Add(newDay112);

            MessageBox.Show("Done!");


        }


    }
}
