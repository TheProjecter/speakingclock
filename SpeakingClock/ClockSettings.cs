using System;

namespace SpeakingClock
{
    [Serializable]
    public class ClockSettings
    {
    	#region Enumerations
    	
    	/// <summary>
    	/// An enum which represents possible announcement frequencies
    	/// </summary>
        public enum AnnounceFrequency
        {
            Never,
            OneMinute,
            FiveMinutes,
            TenMinutes,
            FifteenMinutes,
            ThirtyMinutes,
            SixtyMinutes
        }

        /// <summary>
        /// An enum which represents the supported spoken time formats
        /// </summary>
        public enum TimeFormat
        {
            TwentyFourHourClock = 0,
            TwelveHourClock,
            Human
        }
    	
    	#endregion

    	#region Private fields
    	
        private AnnounceFrequency announce_frequency;
        private TimeFormat announce_format;
        private bool alarm_enabled;
        private DateTime alarm_trigger_time;
        private bool daily_alarm;
        private int announce_volume;
    	
    	#endregion

        #region Public Properties

        /// <summary>
        /// Specifies the announcement volume.
        /// 
        /// Range of 0-100
        /// </summary>
        public int AnnounceVolume
        {
            get { return announce_volume; }
            set { announce_volume = value; }
        }

        /// <summary>
        /// Specifies the announcement frequency
        /// </summary>
        public AnnounceFrequency AnnouncementFrequency
        {
            get { return announce_frequency; }
            set { announce_frequency = value; }
        }

        /// <summary>
        /// Specifies the announcement format
        /// </summary>
        public TimeFormat AnnounceFormat
        {
            get { return announce_format; }
            set { announce_format = value; }
        }

        /// <summary>
        /// Specifies the announcement frequency in seconds
        /// </summary>
        public int AnnouncementFrequencyInSecs
        {
            get 
            {
                switch (announce_frequency)
                {
                    case AnnounceFrequency.OneMinute:
                        return 1 * 60;

                    case AnnounceFrequency.FiveMinutes:
                        return 5 * 60;

                    case AnnounceFrequency.TenMinutes:
                        return 10 * 60;

                    case AnnounceFrequency.FifteenMinutes:
                        return 15 * 60;

                    case AnnounceFrequency.ThirtyMinutes:
                        return 30 * 60;

                    case AnnounceFrequency.SixtyMinutes:
                        return 60 * 60;

                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// Specifies if the alarm facility is enabled
        /// </summary>
        public bool AlarmEnabled
        {
            get { return alarm_enabled; }
            set { alarm_enabled = value; }
        }

        /// <summary>
        /// Specifies the alarm trigger time
        /// </summary>
        public DateTime AlarmTriggerTime
        {
            get { return alarm_trigger_time; }
            set { alarm_trigger_time = value; }
        }

        /// <summary>
        /// Specifies if there is a daily alarm
        /// </summary>
        public bool DailyAlarm
        {
            get { return daily_alarm; }
            set { daily_alarm = value; }
        }

        #endregion 

        #region Class constructor
        
        public ClockSettings()
        {
            announce_format = TimeFormat.TwentyFourHourClock;
            announce_frequency = AnnounceFrequency.FiveMinutes;
            alarm_enabled = false;
            alarm_trigger_time = DateTime.Now;
            daily_alarm = true;
        }        
        
        #endregion

    }
}
