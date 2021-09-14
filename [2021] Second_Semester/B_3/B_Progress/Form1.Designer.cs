
namespace B_Progress
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
            this.components = new System.ComponentModel.Container();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnInitialization = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(12, 12);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(350, 23);
            this.pbStatus.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 46);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "상태 : ";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(226, 39);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(65, 29);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "진행";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnInitialization
            // 
            this.btnInitialization.Location = new System.Drawing.Point(297, 39);
            this.btnInitialization.Name = "btnInitialization";
            this.btnInitialization.Size = new System.Drawing.Size(65, 29);
            this.btnInitialization.TabIndex = 3;
            this.btnInitialization.Text = "초기화";
            this.btnInitialization.UseVisualStyleBackColor = true;
            this.btnInitialization.Click += new System.EventHandler(this.btnInitialization_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 80);
            this.Controls.Add(this.btnInitialization);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "상태 진행";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnInitialization;
        private System.Windows.Forms.Timer Timer;
    }
}

