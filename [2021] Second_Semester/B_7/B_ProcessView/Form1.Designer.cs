
namespace B_ProcessView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvView = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chPid = new System.Windows.Forms.ColumnHeader();
            this.chTime = new System.Windows.Forms.ColumnHeader();
            this.chMemory = new System.Windows.Forms.ColumnHeader();
            this.btnKill = new System.Windows.Forms.Button();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tsslProcess = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCpu = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMem = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvView
            // 
            this.lvView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPid,
            this.chTime,
            this.chMemory});
            this.lvView.FullRowSelect = true;
            this.lvView.GridLines = true;
            this.lvView.HideSelection = false;
            this.lvView.Location = new System.Drawing.Point(-3, 0);
            this.lvView.Name = "lvView";
            this.lvView.Size = new System.Drawing.Size(502, 390);
            this.lvView.TabIndex = 0;
            this.lvView.UseCompatibleStateImageBehavior = false;
            this.lvView.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 105;
            // 
            // chPid
            // 
            this.chPid.Text = "PID";
            this.chPid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPid.Width = 65;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTime.Width = 90;
            // 
            // chMemory
            // 
            this.chMemory.Text = "메모리";
            this.chMemory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chMemory.Width = 100;
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(408, 396);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(79, 28);
            this.btnKill.TabIndex = 1;
            this.btnKill.Text = "작업 끝내기";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslProcess,
            this.tsslCpu,
            this.tsslMem});
            this.ssBar.Location = new System.Drawing.Point(0, 429);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(495, 22);
            this.ssBar.TabIndex = 2;
            this.ssBar.Text = "statusStrip1";
            // 
            // tsslProcess
            // 
            this.tsslProcess.Name = "tsslProcess";
            this.tsslProcess.Size = new System.Drawing.Size(85, 17);
            this.tsslProcess.Text = "프로세스 : 0개";
            // 
            // tsslCpu
            // 
            this.tsslCpu.Name = "tsslCpu";
            this.tsslCpu.Size = new System.Drawing.Size(86, 17);
            this.tsslCpu.Text = "CPU 사용 : 0%";
            // 
            // tsslMem
            // 
            this.tsslMem.Name = "tsslMem";
            this.tsslMem.Size = new System.Drawing.Size(99, 17);
            this.tsslMem.Text = "실제 메모리 : 0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 451);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.lvView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Process View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvView;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPid;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chMemory;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslProcess;
        private System.Windows.Forms.ToolStripStatusLabel tsslCpu;
        private System.Windows.Forms.ToolStripStatusLabel tsslMem;
    }
}

