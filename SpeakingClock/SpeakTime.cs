using System;
using System.Speech.Synthesis;
using System.Text;

namespace SpeakingClock
{
    /// <summary>
    /// Encapsulates the actual text-to-speach functionality
    /// </summary>
    public class SpeakTime
    {
    	/// <summary>
    	/// Speaks the supplied time according to the specified format and volume level
    	/// </summary>
    	/// <param name="announce_time">A DateTime value to be spoken</param>
    	/// <param name="format">A TimeFormat enum specifying the required format</param>
    	/// <param name="volume">An integer, in the range 0-100, which specifies the volume level</param>
        public static void SayTheTime(DateTime announce_time, ClockSettings.TimeFormat format, int volume)
        {
            using (SpeechSynthesizer speaker = new SpeechSynthesizer())
            {
                speaker.Volume = volume;
                speaker.Speak(TimeString(announce_time, format));
            }
        }

        /// <summary>
        /// Speak the supplied text, using the supplied volume level
        /// </summary>
        /// <param name="spoken_text">A string containing the text to speak</param>
        /// <param name="volume">An integer, in the range 0-100, specifying the volume level to use</param>
        public static void SayText(string spoken_text, int volume)
        {
            using (SpeechSynthesizer speaker = new SpeechSynthesizer())
            {
                speaker.Volume = volume;
                speaker.Speak(spoken_text);
            }
        }

        /// <summary>
        /// Speak the supplied text, using the default volume level
        /// </summary>
        /// <param name="spoken_text">A string containing the text to speak</param>
        public static void SayText(string spoken_text)
        {
            SayText(spoken_text, 50);
        }

        /// <summary>
        /// Converts the supplied time into a text string according to the supplied time format,
        /// i.e. 24H, 12H, or 'Human' format
        /// </summary>
        /// <param name="announce_time">A DateTime value to convert</param>
        /// <param name="format">A TimeFormat enum specifying the required format</param>
        /// <returns></returns>
        public static string TimeString(DateTime announce_time, ClockSettings.TimeFormat format)
        {
            StringBuilder speak_text = new StringBuilder();
            speak_text.Append("The time is now ");
            bool is_am = false;

            switch (format)
            {
            	// Convert to 24H format ...
                case ClockSettings.TimeFormat.TwentyFourHourClock:                    
                    speak_text.Append(announce_time.Hour.ToString());
                    speak_text.Append(" ");

                    if (announce_time.Minute < 10)
                        speak_text.Append("O");

                    speak_text.Append(announce_time.Minute.ToString());
                    break;

                // Conver to 12H format
                case ClockSettings.TimeFormat.TwelveHourClock:

                    if (announce_time.Hour > 12)
                        speak_text.Append((announce_time.Hour - 12).ToString());
                    else
                    {
                        speak_text.Append(announce_time.Hour.ToString());
                        is_am = true;
                    }

                    speak_text.Append(" ");

                    if (announce_time.Minute < 10)
                        speak_text.Append("O");

                    speak_text.Append(announce_time.Minute.ToString() + " ");

                    if (is_am)
                        speak_text.Append("Ayh M");
                    else
                        speak_text.Append("Pea M");
                    break;

                // Convert to 'Human' format
                case ClockSettings.TimeFormat.Human:
                    int hour = (announce_time.Hour > 12 ? announce_time.Hour - 12 : announce_time.Hour);

                    if (hour == 0) hour = 12;

                    if (announce_time.Minute >= 0 && announce_time.Minute <= 4)
                    {
                        speak_text.Append("nearly five past ");
                        speak_text.Append(hour.ToString());
                    }
                    else if (announce_time.Minute >= 5 && announce_time.Minute <= 9)
                    {
                        speak_text.Append("nearly ten past ");
                        speak_text.Append(hour.ToString());
                    }
                    else if (announce_time.Minute >= 10 && announce_time.Minute <= 14)
                    {
                        speak_text.Append("nearly quarter past ");
                        speak_text.Append(hour.ToString());
                    }
                    else if (announce_time.Minute >= 15 && announce_time.Minute <= 19)
                    {
                        speak_text.Append("nearly twenty past ");
                        speak_text.Append(hour.ToString());
                    }
                    else if (announce_time.Minute >= 20 && announce_time.Minute <= 24)
                    {
                        speak_text.Append("nearly twenty five past ");
                        speak_text.Append(hour.ToString());
                    }
                    else if (announce_time.Minute >= 25 && announce_time.Minute <= 29)
                    {
                        speak_text.Append("nearly half past ");
                        speak_text.Append(hour.ToString());
                    }
                    else if (announce_time.Minute >= 30 && announce_time.Minute <= 34)
                    {
                        hour++;
                        speak_text.Append("nearly twenty five to ");
                        speak_text.Append(hour.ToString());
                    }
                    else if (announce_time.Minute >= 35 && announce_time.Minute <= 39)
                    {
                        hour++;
                        speak_text.Append("nearly twenty to ");
                        speak_text.Append(hour.ToString());
                    }
                    else if (announce_time.Minute >= 40 && announce_time.Minute <= 44)
                    {
                        hour++;
                        speak_text.Append("nearly quarter to ");
                        speak_text.Append(hour.ToString());
                    }
                    else if (announce_time.Minute >= 45 && announce_time.Minute <= 49)
                    {
                        hour++;
                        speak_text.Append("nearly ten to ");
                        speak_text.Append(hour.ToString());
                    }
                    else if (announce_time.Minute >= 50 && announce_time.Minute <= 54)
                    {
                        hour++;
                        speak_text.Append("nearly five to ");
                        speak_text.Append(hour.ToString());
                    }
                    else if (announce_time.Minute >= 55)
                    {
                        hour++;
                        speak_text.Append(hour.ToString() + " o clock");
                    }

                    break;
            }

            return speak_text.ToString();
        }
    }
}
