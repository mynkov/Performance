namespace Performance
{
    partial class HideForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HideForm));
            this.iconMemory = new System.Windows.Forms.NotifyIcon(this.components);
            this.perfCPU = new System.Diagnostics.PerformanceCounter();
            this.iconCPU = new System.Windows.Forms.NotifyIcon(this.components);
            this.perfMemory = new System.Diagnostics.PerformanceCounter();
            this.perfHardDisk = new System.Diagnostics.PerformanceCounter();
            this.iconHardDisk = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.perfCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfHardDisk)).BeginInit();
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
            // perfHardDisk
            // 
            this.perfHardDisk.CategoryName = "Логический диск";
            this.perfHardDisk.CounterName = "% активности диска";
            this.perfHardDisk.InstanceName = "_Total";
            // 
            // iconHardDisk
            // 
            this.iconHardDisk.Text = "notifyIcon1";
            this.iconHardDisk.Visible = true;
            // 
            // HideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HideForm";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.perfCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfHardDisk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon iconCPU;
        private System.Diagnostics.PerformanceCounter perfCPU;
        private System.Diagnostics.PerformanceCounter perfMemory;
        private System.Diagnostics.PerformanceCounter perfHardDisk;
        private System.Windows.Forms.NotifyIcon iconHardDisk;
        private System.Windows.Forms.NotifyIcon iconMemory;
    }
}

