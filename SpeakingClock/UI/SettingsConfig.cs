using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SpeakingClock
{
    /// <summary>
    /// Encapsulates UI for changing app settings   
    /// </summary>
    public partial class SettingsConfig : Form
    {
        const string SETTINGS_FILE = "speakingclock.settings";
        private ClockSettings settings;
        private string[] announce_interval = { "Never", "1 minute", "5 Minutes", "10 Minutes", "15 Minutes", "30 Minutes", "60 Minutes" };

        /// <summary>
        /// Class constructor
        /// </summary>
        public SettingsConfig()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the form load event. Retrieves the save settings, 
        /// if any, and populates the form controls with the settings values
        /// </summary>
        /// <param name="sender">Originating object</param>
        /// <param name="e">Event arguments</param>
        private void Settings_Load(object sender, EventArgs e)
        {
            settings = LoadSettings();

            InitialiseControls();
        }

        /// <summary>
        /// Handles click event for the 'OK' button
        /// </summary>
        /// <param name="sender">Originating object</param>
        /// <param name="e">Event arguments</param>
        private void uxOK_Click(object sender, EventArgs e)
        {
            RetrieveSettings();
            SaveSettings(settings);
            this.Close();
        }

        /// <summary>
        /// Retrieve the previously saved settings
        /// </summary>
        /// <returns>A populated settings instance</returns>
        public static ClockSettings LoadSettings()
        {
            ClockSettings tmp = null;
            XmlSerializer serializer = new XmlSerializer(typeof(ClockSettings));

            // Retrieve isolated storage file stream
            using (IsolatedStorageFile storeRead = IsolatedStorageFile.GetUserStoreForDomain())
            {
                IsolatedStorageFileStream streamRead = null;

                // Retrieve previously saved settings ...
                try
                {
                    streamRead = new IsolatedStorageFileStream(SETTINGS_FILE, FileMode.Open, storeRead);
                    tmp = (ClockSettings)serializer.Deserialize(streamRead);
                }
                catch (FileNotFoundException)
                {
                    tmp = new ClockSettings();
                    SaveSettings(tmp);
                }
                finally
                {
                    if (streamRead != null) streamRead.Dispose();
                }
            }

            return tmp;
        }

        /// <summary>
        /// Save the current settings to isolated storage
        /// </summary>
        /// <param name="settings">The current settings</param>
        /// <returns>True on success, else false</returns>
        public static bool SaveSettings(ClockSettings settings)
        {
            bool success = false;

            XmlSerializer serializer = new XmlSerializer(typeof(ClockSettings));

            // Retrieve isolated storage file stream
            using (IsolatedStorageFile storeWrite = IsolatedStorageFile.GetUserStoreForDomain())
            {
                // Serialise the current settings to file ...
                using (IsolatedStorageFileStream streamWrite = new IsolatedStorageFileStream(SETTINGS_FILE, FileMode.Create, storeWrite))
                {
                    serializer.Serialize(streamWrite, settings);
                    success = true;
                }
            }

            return success;
        }

        /// <summary>
        /// Populate controls based on 'ClockSettings' values
        /// </summary>
        private void InitialiseControls()
        {
            if (settings.AlarmEnabled)
                uxAlarmOn.Checked = true;
            else
                uxAlarmOff.Checked = true;

            if (settings.DailyAlarm)
                uxRepeatDaily.Checked = true;
            else
                uxRepeatMonFri.Checked = true;

            switch (settings.AnnounceFormat)
            {
                case ClockSettings.TimeFormat.TwentyFourHourClock:
                    ux24Hour.Checked = true;
                    break;

                case ClockSettings.TimeFormat.TwelveHourClock:
                    ux12Hour.Checked = true;
                    break;

                case ClockSettings.TimeFormat.Human:
                    uxHuman.Checked = true;
                    break;

                default:
                    ux24Hour.Checked = true;
                    break;
            }

            uxVolume.Value = settings.AnnounceVolume;

            uxHours.Value = settings.AlarmTriggerTime.Hour;
            uxMinutes.Value = settings.AlarmTriggerTime.Minute;

            uxFrequency.DataSource = announce_interval;
            uxFrequency.SelectedIndex = (int)settings.AnnouncementFrequency;
        }

        /// <summary>
        /// Retrieve the current control values from the form
        /// </summary>
        private void RetrieveSettings()
        {
            if (uxAlarmOn.Checked)
                settings.AlarmEnabled = true;
            else
                settings.AlarmEnabled = false;

            if (uxRepeatDaily.Checked)
                settings.DailyAlarm = true;
            else
                settings.DailyAlarm = false;

            DateTime tmp = new DateTime(DateTime.Now.Year, 
                                        DateTime.Now.Month, 
                                        DateTime.Now.Day, 
                                        (int)uxHours.Value, 
                                        (int)uxMinutes.Value, 
                                        0);

            settings.AlarmTriggerTime = tmp;

            settings.AnnouncementFrequency = (ClockSettings.AnnounceFrequency)uxFrequency.SelectedIndex;

            if (ux24Hour.Checked)
                settings.AnnounceFormat = ClockSettings.TimeFormat.TwentyFourHourClock;
            else if (ux12Hour.Checked)
                settings.AnnounceFormat = ClockSettings.TimeFormat.TwelveHourClock;
            else
                settings.AnnounceFormat = ClockSettings.TimeFormat.Human;

            settings.AnnounceVolume = uxVolume.Value;
        }
    }
}
