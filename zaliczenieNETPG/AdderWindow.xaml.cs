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

            //testing
            Weekend newDay = new Weekend("Saturday", "Outdoor", "Programowanko", 56);
            Weekend newDay1 = new Weekend("Sunday", "Project", "Programowanko", 63);
            Weekend newDay2 = new Weekend("Saturday", "Outdoor", "Bieganko", 56);
            Weekend newDay3 = new Weekend("Sunday", "Outdoor", "Bieganko", 56);
            Weekend newDay4 = new Weekend("Saturday", "Other", "Spraweczka", 56);
            Weekend newDay5 = new Weekend("Saturday", "Outdoor", "Bieżace projekty", 56);

            Workday newDay7 = new Workday("Monday", "Outdoor", "Programowanko", 56);
            Workday newDay8 = new Workday("Tuesday", "Outdoor", "Programowanko", 56);
            Workday newDay9 = new Workday("Thursday", "Outdoor", "Bieżące projekty", 56);
            Workday newDay10 = new Workday("Wednesday", "Outdoor", "Bieganko", 56);
            Workday newDay11 = new Workday("Friday", "Outdoor", "Spraweczka", 56);
            Workday newDay12 = new Workday("Tuesday", "Outdoor", "Spraweczka", 56);

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
