using System.Collections.ObjectModel;

namespace ConvertToUtcTime
{
    internal class ConvertToUtcTime
    {
        static void Main(string[] args)
        {
            // UTC(Universal Time Coordinated) is a time standard that is widely used as a reference for global timekeeping and synchronization

            ReadOnlyCollection<TimeZoneInfo> timeZones = TimeZoneInfo.GetSystemTimeZones();

            DateTime UtcNow = DateTime.UtcNow;
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("UTC Now: " + UtcNow.ToString());
            Console.WriteLine("---------------------------------------------------------------------------------\n");

            foreach (TimeZoneInfo timeZone in timeZones)
            {
                // Get UTC offset from atual region
                TimeSpan offset = timeZone.BaseUtcOffset;

                // Display the region name and the actual datetime
                Console.WriteLine($"{timeZone.DisplayName} | DateTime now: {UtcNow.AddHours(offset.TotalHours)}\n");

            }
            Console.WriteLine("-----------------------------------------------------------------------------------");
        }
    }
}