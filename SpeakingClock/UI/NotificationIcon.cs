/*
 * Created by SharpDevelop.
 * User: aross
 * Date: 24/08/2008
 * Time: 17:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SpeakingClock
{
    public sealed class NotificationIcon
    {
        const int TIMER_INTERVAL = 5 * 1000;

        private NotifyIcon notifyIcon;
        private ContextMenu notificationMenu;

        public static ClockSettings clock_settings = SettingsConfig.LoadSettings();
        public static System.Threading.Timer main_timer;

        public static DateTime last_triggered = DateTime.MinValue;

        #region Initialize icon and menu

        public NotificationIcon()
        {
            notifyIcon = new NotifyIcon();
            notificationMenu = new ContextMenu(InitializeMenu());

            notifyIcon.DoubleClick += menuSayTimeClick;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationIcon));
            // notifyIcon.Icon = (Icon)resources.GetObject("$this.Icon");
            notifyIcon.Icon = (Icon)resources.GetObject("chat32_01");
            notifyIcon.ContextMenu = notificationMenu;
        }

        private MenuItem[] InitializeMenu()
        {
            MenuItem[] menu = new MenuItem[] {
				new MenuItem("About", menuAboutClick),
                new MenuItem("Settings", menuSettingsClick),
				new MenuItem("Exit", menuExitClick)
			};
            return menu;
        }

        #endregion

        #region Main - Program entry point

        /// <summary>Program entry point.</summary>
        /// <param name="args">Command Line Arguments</param>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool isFirstInstance;
            TimerCallback timer_callback = new TimerCallback(TimerCallbackRoutine);
            
            main_timer = new System.Threading.Timer(timer_callback, null, 0, TIMER_INTERVAL);

            // Please use a unique name for the mutex to prevent conflicts with other programs
            using (Mutex mtx = new Mutex(true, "SpeakingClock", out isFirstInstance))
            {
                if (isFirstInstance)
                {
                    NotificationIcon notificationIcon = new NotificationIcon();
                    notificationIcon.notifyIcon.Visible = true;
                    Application.Run();
                    notificationIcon.notifyIcon.Dispose();
                }
                else
                {
                    Application.Exit();
                }
            } // releases the Mutex
        }

        #endregion

        #region Event Handlers

        private void menuAboutClick(object sender, EventArgs e)
        {
            About info = new About();
            info.Show();
        }

        private void menuExitClick(object sender, EventArgs e)
        {
            SettingsConfig.SaveSettings(clock_settings);
            SpeakTime.SayText("Goodbye", 100);
            Application.Exit();
        }

        private void menuSayTimeClick(object sender, EventArgs e)
        {
            SpeakTime.SayTheTime(DateTime.Now, clock_settings.AnnounceFormat, clock_settings.AnnounceVolume);
        }

        private void menuSettingsClick(object sender, EventArgs e)
        {
            SettingsConfig settingsForm = new SettingsConfig();
            settingsForm.Show();

            // Re-load the settings
            settingsForm.FormClosed += new FormClosedEventHandler(settingsForm_FormClosed);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Originating object</param>
        /// <param name="e">Event parameters</param>
        void settingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            clock_settings = SettingsConfig.LoadSettings();
        }

        /// <summary>
        /// Handles timer events
        /// </summary>
        /// <param name="state_info"></param>
        public static void TimerCallbackRoutine(object state_info)
        {
            DateTime tmp = last_triggered;
            tmp = tmp.AddSeconds(clock_settings.AnnouncementFrequencyInSecs);

            // Time for an announcement ? ...
            if (tmp.CompareTo(DateTime.Now) < 0 && 
                clock_settings.AnnouncementFrequency != ClockSettings.AnnounceFrequency.Never)
            {
                // Yep, so speak the time 
                SpeakTime.SayTheTime(DateTime.Now, clock_settings.AnnounceFormat, clock_settings.AnnounceVolume);

                // DEBUG 
                // DateTime test = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 8, 0);
                // SpeakTime.SayTheTime(test, clock_settings.AnnounceFormat, clock_settings.AnnounceVolume);

                // Update 'last triggered', N.B. always set to zero secs past the minute ...
                last_triggered = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);                                               
            }

            // check if alarm due ...
            if (IsAlarmDue())
            {
                SpeakTime.SayText("Alarm, Alarm, Alarm !", 100);
                SpeakTime.SayTheTime(DateTime.Now, clock_settings.AnnounceFormat, clock_settings.AnnounceVolume);
            }
        }

        /// <summary>
        /// Check if an alarm is due
        /// </summary>
        /// <returns>True if alarm due, else false</returns>
        private static bool IsAlarmDue()
        {
            bool alarm_due = false;

            if (clock_settings.AlarmTriggerTime.Hour == DateTime.Now.Hour &&
                clock_settings.AlarmTriggerTime.Minute == DateTime.Now.Minute &&
                clock_settings.AlarmEnabled)
                alarm_due = true;
            
            if (!clock_settings.DailyAlarm &&
                (DateTime.Now.DayOfWeek == DayOfWeek.Saturday ||
                DateTime.Now.DayOfWeek == DayOfWeek.Sunday))
                alarm_due = false;

            return alarm_due;
        }

        #endregion
    }
}
