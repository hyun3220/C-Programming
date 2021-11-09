
namespace B_Notepad
{
    partial class Form2
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
            this.lblWord = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chOption = new System.Windows.Forms.CheckBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rdb01 = new System.Windows.Forms.RadioButton();
            this.rdb02 = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(12, 18);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(83, 15);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "찾을 내용(&N) :";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(101, 15);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(218, 23);
            this.txtWord.TabIndex = 1;
            this.txtWord.TextChanged += new System.EventHandler(this.txtWord_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(325, 15);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "다음 찾기(&F)";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(325, 44);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chOption
            // 
            this.chOption.AutoSize = true;
            this.chOption.Location = new System.Drawing.Point(12, 89);
            this.chOption.Name = "chOption";
            this.chOption.Size = new System.Drawing.Size(123, 19);
            this.chOption.TabIndex = 4;
            this.chOption.Text = "대/소문자 구분(&C)";
            this.chOption.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rdb01);
            this.groupBox.Controls.Add(this.rdb02);
            this.groupBox.Location = new System.Drawing.Point(163, 49);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(156, 59);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "방향";
            // 
            // rdb01
            // 
            this.rdb01.AutoSize = true;
            this.rdb01.Location = new System.Drawing.Point(6, 25);
            this.rdb01.Name = "rdb01";
            this.rdb01.Size = new System.Drawing.Size(65, 19);
            this.rdb01.TabIndex = 6;
            this.rdb01.Text = "위쪽(&U)";
            this.rdb01.UseVisualStyleBackColor = true;
            // 
            // rdb02
            // 
            this.rdb02.AutoSize = true;
            this.rdb02.Checked = true;
            this.rdb02.Location = new System.Drawing.Point(77, 25);
            this.rdb02.Name = "rdb02";
            this.rdb02.Size = new System.Drawing.Size(78, 19);
            this.rdb02.TabIndex = 7;
            this.rdb02.TabStop = true;
            this.rdb02.Text = "아래쪽(&D)";
            this.rdb02.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 120);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.chOption);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "찾기";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox;
        internal System.Windows.Forms.TextBox txtWord;
        internal System.Windows.Forms.Button btnOk;
        internal System.Windows.Forms.CheckBox chOption;
        internal System.Windows.Forms.RadioButton rdb01;
        internal System.Windows.Forms.RadioButton rdb02;
    }
}