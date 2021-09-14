
namespace B_Timer
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(65, 45);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(137, 23);
            this.txtNum.TabIndex = 0;
            // 
            // txtCountDown
            // 
            this.txtCountDown.Location = new System.Drawing.Point(65, 90);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.ReadOnly = true;
            this.txtCountDown.Size = new System.Drawing.Size(137, 23);
            this.txtCountDown.TabIndex = 1;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(230, 45);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(86, 68);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "카운트 다운";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 170);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.txtNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "타이머";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtCountDown;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Timer Timer;
    }
}

