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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.IO;


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
            #region IntializeIt
            InitializeComponent();
            InitializeTheTable();
            IntializeTheComboBox();
            IntializeTheAutoCompleteCourses();
            #endregion
            #region SettingUpTimeIntervals
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
            #endregion
        }
        #region StartDataGridSettings
        public void InitializeTheTable()
        {
            TimeTable.CanUserSortColumns = false;
            TimeTable.IsReadOnly = true;
            TimeTable.CanUserResizeColumns = false;
            TimeTable.CanUserReorderColumns = false;
            /*  Stylize the Table through the style page located at /Style/TimeTableStyle.xaml
             * */

        }
        #endregion

        #region ComboBoxLogic
        public void IntializeTheComboBox()
        {

            ParamterList.Items.Add("Most Days Off");
            ParamterList.Items.Add("Evening Classes");
            ParamterList.Items.Add("Morning Classes");

        }
        #endregion

        #region PageGeneratedControl
        public void IntializeThePageGenerator()
        {
            //intialize the page thing changer
           

        }
        #endregion

        #region AutoCompleteLogic
        public void IntializeTheAutoCompleteCourses()
        {
            Course_textbox.MaxDropDownHeight = 80;
            List<string> CourseList = new List<string>();
            CourseList.Add("COEN 231");
            CourseList.Add("COEN 243");
            CourseList.Add("COEN 244");
            CourseList.Add("COEN 317");
            CourseList.Add("COEN 352");
            CourseList.Add("COEN 346");
           
            /*
              when the database for the courses is setup it will only be a couple lines to do it
              foreach(string course in course.database)
             CourseList.add(course);
             */
            Course_textbox.ItemsSource = CourseList;


        }

        #endregion

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

        #region SaveScreenShotSchedule
        private void save_button_Click(object sender, RoutedEventArgs e)
        {
            //the save logic goes here
        }
        #endregion

        #region CourseEnteredClick

        private void Course_entered_Click_1(object sender, RoutedEventArgs e)
        {

        }

        #endregion




    }


}

