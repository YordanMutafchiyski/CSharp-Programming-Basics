using System;
using System.Globalization;


namespace Problem_10.Beer_Time
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Come on, tell me the time..");
            DateTime inputTime = DateTime.Parse(Console.ReadLine());

            TimeSpan startTimeSpan = new TimeSpan(13, 00, 00);
            DateTime startTime = DateTime.Today.Add(startTimeSpan);

            TimeSpan endTimeSpan = new TimeSpan(03, 00, 00);
            DateTime endTime = DateTime.Today.Add(endTimeSpan);

            if (inputTime >= startTime && inputTime <= endTime)
            {
                Console.WriteLine("Beer Time");
            }
            else
            {
                Console.WriteLine("Non-beer time.");
            }
        }
    }
}