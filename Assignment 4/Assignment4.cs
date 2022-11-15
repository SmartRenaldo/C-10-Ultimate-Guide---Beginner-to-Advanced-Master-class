public class Assignment4
{
    static void Main()
    {
        int seconds = 288970;

        int remaining_seconds = seconds;
        const int seconds_per_minute = 60;
        const int seconds_per_hour = 60 * 60;
        const int seconds_per_day = 24 * 60 * 60;

        int days = remaining_seconds / seconds_per_day;
        remaining_seconds -= days * seconds_per_day;

        int hours = remaining_seconds / seconds_per_hour;
        remaining_seconds -= hours * seconds_per_hour;
        int minutes = remaining_seconds / seconds_per_minute;
        remaining_seconds -= minutes * seconds_per_minute;

        System.Console.WriteLine(days + " days, " + hours + " hours, " + minutes + " minutes, " + remaining_seconds + " seconds");
        System.Console.ReadKey();
    }
}
