using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace TimeTableDesign
{

    public class ScheduleData
    {

        public string Time { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednsday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
    }

    public partial class MainPage : UserControl
    {

        public MainPage()
        {
           
            InitializeComponent();
            InitializeTheTable();
            IntializeTheComboBox();
           
            //Setting up Times required
            TimeSpan start_time = TimeSpan.Parse("8:45");
            TimeSpan interval_time = TimeSpan.Parse("00:15");
            TimeSpan temp_timespan = TimeSpan.Parse("0:00");
            List<ScheduleData> students_schedule = new List<ScheduleData>();
            string time;
            string intial_time = Convert.ToString(start_time);
            students_schedule.Add(new ScheduleData() { Time = intial_time });

            //Lists all the time intervals

            for (int i = 0; i < 100; i++)
            {
         
                if (start_time == TimeSpan.Parse("20:15"))
                    break;
                start_time = start_time.Add(interval_time);
                time = Convert.ToString(start_time);
                students_schedule.Add(new ScheduleData() { Time = time });
               
            }

            TimeTable.ItemsSource = students_schedule;
        }
        public void InitializeTheTable()
        {
            TimeTable.CanUserSortColumns = false;
            TimeTable.IsReadOnly = true;
            TimeTable.CanUserResizeColumns = false;
            TimeTable.CanUserReorderColumns = false;
          /*  Stylize the Table through the style page located at /Style/TimeTableStyle.xaml
           * */
      
        }
        public void IntializeTheComboBox()
        {

            ParamterList.Items.Add("Most Days Off");
            ParamterList.Items.Add("Evening Classes");
            ParamterList.Items.Add("Morning Classes");

        }

        #region CheckBoxSemestersLogic
        private void Fall_checkbox_Checked_1(object sender, RoutedEventArgs e)
        {
            Winter_checkbox.IsEnabled = false;
            Summer_checkbox.IsEnabled = false;
        }

        private void Fall_checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            Winter_checkbox.IsEnabled = true;
            Summer_checkbox.IsEnabled = true;
        }

        private void Winter_checkbox_Checked(object sender, RoutedEventArgs e)
        {
            Fall_checkbox.IsEnabled = false;
            Summer_checkbox.IsEnabled = false;
        }
        private void Winter_checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            Fall_checkbox.IsEnabled = true;
            Summer_checkbox.IsEnabled = true;
        }

        private void Summer_checkbox_Checked(object sender, RoutedEventArgs e)
        {
            Fall_checkbox.IsEnabled = false;
            Winter_checkbox.IsEnabled = false;
        }

        private void Summer_checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            Fall_checkbox.IsEnabled = true;
            Winter_checkbox.IsEnabled = true;
        }


        #endregion

    }



}

