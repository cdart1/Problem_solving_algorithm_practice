using System;
using System.Collections.Generic;
using System.Text;

namespace TimeConvert
{
    class TimeConvertProblem
    {
        public static void TimeConverter(int num)
        {
            TimeSpan timeSpan = TimeSpan.FromMinutes(num);
            string time = timeSpan.ToString("hh':'mm");

            Console.WriteLine(time);
        }

        public static void TimeConverter2(int min)
        {
            int hours = min / 60;
            int minutes = min % 60;

            Console.WriteLine(hours.ToString() + ':' + minutes.ToString());

        }
    }
}
