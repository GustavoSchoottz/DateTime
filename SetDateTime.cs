using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    public class SetDateTime
    {
        public static void Set(long year, long month, long day, long hour, long minute, long seconds)
        {
            // [DllImport("kernel32.dll", EntryPoint = "GetSystemTime", SetLastError = true)]
            // extern static void Win32GetSystemTime(ref SystemTime sysTime);

            [DllImport("kernel32.dll", EntryPoint = "SetSystemTime", SetLastError = true)]
            extern static bool Win32SetSystemTime(ref SystemTime sysTime);


            //private void button1_Click(object sender, EventArgs e)
            //{
            // Set system date and time
            SystemTime updatedTime = new SystemTime();
            updatedTime.Year = (ushort)year;
            updatedTime.Month = (ushort)month;
            updatedTime.Day = (ushort)day;
            updatedTime.Hour = (ushort)hour;
            updatedTime.Minute = (ushort)minute;
            updatedTime.Second = (ushort)seconds;
            // Call the unmanaged function that sets the new date and time instantly
            Win32SetSystemTime(ref updatedTime);
            //}

        }

        public struct SystemTime
        {
            public ushort Year;
            public ushort Month;
            public ushort DayOfWeek;
            public ushort Day;
            public ushort Hour;
            public ushort Minute;
            public ushort Second;
            public ushort Millisecond;
        };

    }
}
