using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Performance
{
    public partial class HiddenForm : Form
	{
        private List<Icon> _cpuIcons;

        private List<Icon> _hardDriveIcons;

        private List<Icon> _memoryIcons;

        private bool IsAllIconHidden
        {
            get
            {
                return !iconCPU.Visible && !iconHardDrive.Visible && !iconMemory.Visible;
            }
        }

		public HiddenForm()
		{
			InitializeComponent();
			InitIconEvents();
			InitIconLists();
			InitTimer();
		}

		private void InitIconLists()
		{
			_cpuIcons = GetListIcons("Performance.Pictures.CPU");
			_hardDriveIcons = GetListIcons("Performance.Pictures.HardDrive");
			_memoryIcons = GetListIcons("Performance.Pictures.Memory");
		}

        private List<Icon> GetListIcons(string namespacePictures)
		{
			var list = new List<Icon>();
			for (var i = 0; i <= 10; i++)
			{
                list.Add(new Icon(Assembly.GetEntryAssembly().GetManifestResourceStream(string.Format("{0}.{1}.ico", namespacePictures, i))));
			}
			return list;
		}

		private void InitIconEvents()
		{
			iconMemory.MouseClick += IconMouseClick;
			iconCPU.MouseClick += IconMouseClick;
			iconHardDrive.MouseClick += IconMouseClick;
		}

		private void IconMouseClick(object sender, MouseEventArgs e)
		{
		    var notifyIcon = (NotifyIcon) sender;
            notifyIcon.Visible = e.Button != MouseButtons.Right;

			if (IsAllIconHidden)
				Application.Exit();
		}

		private void InitTimer()
		{
			var timer = new Timer {Interval = 1000};
		    timer.Tick += TimerTick;
			timer.Start();
		}

		private void TimerTick(object sender, EventArgs e)
		{
			FillMemory();
            FillCPU();
			FillHardDrive();
		}

		private void FillHardDrive()
		{
			var percent = Math.Min(100, (int)perfHardDrive.NextValue());
            var index = (percent + 5) / 10;

            iconHardDrive.Text = string.Format("Hard Drive: {0}%", percent);
			iconHardDrive.Icon = _hardDriveIcons[index];
		}

		private void FillCPU()
		{
			var percent = (int)perfCPU.NextValue();
            var index = (percent + 5) / 10;

            iconCPU.Text = string.Format("CPU: {0}%", percent);
			iconCPU.Icon = _cpuIcons[index];
		}

        private void FillMemory()
        {
            var freeMemory = (int) perfMemory.NextValue();
            var usedMemory = MemoryInfo.TotalMemory - freeMemory;
            var memoryPercent = MemoryInfo.GetMemoryPercent(freeMemory);
            var index = (memoryPercent + 5)/10;

            iconMemory.Text = string.Format(
@"Memory: {0}%
Free: {1} MB
Used: {2} MB
Total: {3} MB",
                memoryPercent,
                freeMemory,
                usedMemory,
                MemoryInfo.TotalMemory);
            iconMemory.Icon = _memoryIcons[index];
        }
	}
}
