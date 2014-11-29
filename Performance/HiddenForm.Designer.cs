namespace Performance
{
    partial class HiddenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HiddenForm));
            this.iconMemory = new System.Windows.Forms.NotifyIcon(this.components);
            this.perfCPU = new System.Diagnostics.PerformanceCounter();
            this.iconCPU = new System.Windows.Forms.NotifyIcon(this.components);
            this.perfMemory = new System.Diagnostics.PerformanceCounter();
            this.perfHardDrive = new System.Diagnostics.PerformanceCounter();
            this.iconHardDrive = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.perfCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfHardDrive)).BeginInit();
            this.SuspendLayout();
            // 
            // iconMemory
            // 
            this.iconMemory.Text = "notifyIcon1";
            this.iconMemory.Visible = true;
            // 
            // perfCPU
            // 
            this.perfCPU.CategoryName = "Процессор";
            this.perfCPU.CounterName = "% загруженности процессора";
            this.perfCPU.InstanceName = "_Total";
            // 
            // iconCPU
            // 
            this.iconCPU.Visible = true;
            // 
            // perfMemory
            // 
            this.perfMemory.CategoryName = "Память";
            this.perfMemory.CounterName = "Доступно МБ";
            // 
            // perfHardDrive
            // 
            this.perfHardDrive.CategoryName = "Логический диск";
            this.perfHardDrive.CounterName = "% активности диска";
            this.perfHardDrive.InstanceName = "_Total";
            // 
            // iconHardDrive
            // 
            this.iconHardDrive.Text = "notifyIcon1";
            this.iconHardDrive.Visible = true;
            // 
            // HiddenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HiddenForm";
            this.ShowInTaskbar = false;
            this.Text = "HiddenForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.perfCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfHardDrive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon iconCPU;
        private System.Diagnostics.PerformanceCounter perfCPU;
        private System.Diagnostics.PerformanceCounter perfMemory;
        private System.Diagnostics.PerformanceCounter perfHardDrive;
        private System.Windows.Forms.NotifyIcon iconHardDrive;
        private System.Windows.Forms.NotifyIcon iconMemory;
    }
}

