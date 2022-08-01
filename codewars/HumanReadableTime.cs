namespace Codewars
{
    public class HumanReadableTime
    //Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
    //HH = hours, padded to 2 digits, range: 00 - 99
    //MM = minutes, padded to 2 digits, range: 00 - 59
    //SS = seconds, padded to 2 digits, range: 00 - 59
    //The maximum time never exceeds 359999 (99:59:59)
    {
        public static string GetReadableTime(int seconds)
        {
            int secondsLeft = seconds % 60;
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            
            string result = $"{hours.ToString("00")}:{minutes.ToString("00")}:{secondsLeft.ToString("00")}";
            return result;
        }
    }
}
