using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;

namespace Performance
{
    public partial class HideForm : Form
    {
        public HideForm()
        {
            InitializeComponent();
            InitTimer();
        }

        private void InitTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            int freeMemory = (int)perfMemory.NextValue();
            int useMemory = MemoryInfo.TotalMemory - freeMemory;
            int percentMemory = MemoryInfo.GetMemoryPercent(freeMemory);
            iconMemory.Text = string.Format("Memory: {0}%" + Environment.NewLine +
                "Free: {1} MB" + Environment.NewLine +
                "Use: {2} MB" + Environment.NewLine +
                 "Total: {3} MB" + Environment.NewLine
                , percentMemory, freeMemory, useMemory, MemoryInfo.TotalMemory);

            switch ((percentMemory + 5) / 10)
            {
                case 0:
                    iconMemory.Icon = new Icon("Pictures/Memory/0.ico");
                    break;
                case 1:
                    iconMemory.Icon = new Icon("Pictures/Memory/10.ico");
                    break;
                case 2:
                    iconMemory.Icon = new Icon("Pictures/Memory/20.ico");
                    break;
                case 3:
                    iconMemory.Icon = new Icon("Pictures/Memory/30.ico");
                    break;
                case 4:
                    iconMemory.Icon = new Icon("Pictures/Memory/40.ico");
                    break;
                case 5:
                    iconMemory.Icon = new Icon("Pictures/Memory/50.ico");
                    break;
                case 6:
                    iconMemory.Icon = new Icon("Pictures/Memory/60.ico");
                    break;
                case 7:
                    iconMemory.Icon = new Icon("Pictures/Memory/70.ico");
                    break;
                case 8:
                    iconMemory.Icon = new Icon("Pictures/Memory/80.ico");
                    break;
                case 9:
                    iconMemory.Icon = new Icon("Pictures/Memory/90.ico");
                    break;
                default:
                    iconMemory.Icon = new Icon("Pictures/Memory/100.ico");
                    break;
            }

            int valueCPU = (int)perfCPU.NextValue();
            iconCPU.Text = string.Format("CPU: {0}%", valueCPU);

            switch ((valueCPU + 5)/ 10)
            {
                case 0:
                    iconCPU.Icon = new Icon("Pictures/CPU/0.ico");
                    break;
                case 1:
                    iconCPU.Icon = new Icon("Pictures/CPU/10.ico");
                    break;
                case 2:
                    iconCPU.Icon = new Icon("Pictures/CPU/20.ico");
                    break;
                case 3:
                    iconCPU.Icon = new Icon("Pictures/CPU/30.ico");
                    break;
                case 4:
                    iconCPU.Icon = new Icon("Pictures/CPU/40.ico");
                    break;
                case 5:
                    iconCPU.Icon = new Icon("Pictures/CPU/50.ico");
                    break;
                case 6:
                    iconCPU.Icon = new Icon("Pictures/CPU/60.ico");
                    break;
                case 7:
                    iconCPU.Icon = new Icon("Pictures/CPU/70.ico");
                    break;
                case 8:
                    iconCPU.Icon = new Icon("Pictures/CPU/80.ico");
                    break;
                case 9:
                    iconCPU.Icon = new Icon("Pictures/CPU/90.ico");
                    break;
                default:
                    iconCPU.Icon = new Icon("Pictures/CPU/100.ico");
                    break;
            }

            int valueHardDisk = (int)perfHardDisk.NextValue();
            iconHardDisk.Text = string.Format("HardDisk: {0}%", valueHardDisk);

            switch ((valueHardDisk + 5)/ 10)
            {
                case 0:
                    iconHardDisk.Icon = new Icon("Pictures/HardDisk/0.ico");
                    break;
                case 1:
                    iconHardDisk.Icon = new Icon("Pictures/HardDisk/10.ico");
                    break;
                case 2:
                    iconHardDisk.Icon = new Icon("Pictures/HardDisk/20.ico");
                    break;
                case 3:
                    iconHardDisk.Icon = new Icon("Pictures/HardDisk/30.ico");
                    break;
                case 4:
                    iconHardDisk.Icon = new Icon("Pictures/HardDisk/40.ico");
                    break;
                case 5:
                    iconHardDisk.Icon = new Icon("Pictures/HardDisk/50.ico");
                    break;
                case 6:
                    iconHardDisk.Icon = new Icon("Pictures/HardDisk/60.ico");
                    break;
                case 7:
                    iconHardDisk.Icon = new Icon("Pictures/HardDisk/70.ico");
                    break;
                case 8:
                    iconHardDisk.Icon = new Icon("Pictures/HardDisk/80.ico");
                    break;
                case 9:
                    iconHardDisk.Icon = new Icon("Pictures/HardDisk/90.ico");
                    break;
                default:
                    iconHardDisk.Icon = new Icon("Pictures/HardDisk/100.ico");
                    break;
            }

           

        }
    }
}
