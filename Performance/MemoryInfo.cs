using System;
using System.Linq;
using System.Management;

namespace Performance
{
    public class MemoryInfo
    {
        public static readonly int TotalMemory = GetTotalMemory();

        public static int GetMemoryPercent(int freeMemory)
        {
            return (int)(100 - ((double)freeMemory / (double)TotalMemory) * 100);
        }

        private static int GetTotalMemory()
        {
            var managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            var managementBaseObject = managementObjectSearcher.Get().Cast<ManagementBaseObject>().First();

            return Convert.ToInt32(managementBaseObject["TotalVisibleMemorySize"]) / 1024;
        }
    }
}
