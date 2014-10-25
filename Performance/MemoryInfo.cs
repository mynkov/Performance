using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace Performance
{
    public class MemoryInfo
    {
        private static int _totalMemory;

        public static int TotalMemory
        {
            get
            {
                return _totalMemory;
            }
        }

        static MemoryInfo()
        {
            _totalMemory = GetTotalMemory();
        }

        public static int GetMemoryPercent(int freeMemory)
        {
            return (int)(100 - ((double)freeMemory / (double)_totalMemory) * 100);
        }

        private static int GetTotalMemory()
        {
            int result = 0;

            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();

            foreach (var item in managementObjectCollection)
            {
                result = Convert.ToInt32(item["TotalVisibleMemorySize"]) / 1024;
                break;
            }
            return result;
        }

    }
}
