
namespace B_ListView
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
            this.chAge = new System.Windows.Forms.ColumnHeader();
            this.chWork = new System.Windows.Forms.ColumnHeader();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblWork = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvView
            // 
            this.lvView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chAge,
            this.chWork});
            this.lvView.FullRowSelect = true;
            this.lvView.GridLines = true;
            this.lvView.HideSelection = false;
            this.lvView.Location = new System.Drawing.Point(11, 12);
            this.lvView.Name = "lvView";
            this.lvView.Size = new System.Drawing.Size(356, 194);
            this.lvView.TabIndex = 0;
            this.lvView.UseCompatibleStateImageBehavior = false;
            this.lvView.View = System.Windows.Forms.View.Details;
            this.lvView.Click += new System.EventHandler(this.lvView_Click);
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 100;
            // 
            // chAge
            // 
            this.chAge.Text = "나이";
            this.chAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chAge.Width = 100;
            // 
            // chWork
            // 
            this.chWork.Text = "직업";
            this.chWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chWork.Width = 150;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 226);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름 : ";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(23, 259);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 15);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "나이 :";
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(23, 291);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(38, 15);
            this.lblWork.TabIndex = 3;
            this.lblWork.Text = "직업 :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(68, 223);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(68, 256);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(172, 23);
            this.txtAge.TabIndex = 5;
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(68, 288);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(172, 23);
            this.txtWork.TabIndex = 6;
            this.txtWork.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWork_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(277, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 88);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 337);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtWork);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblWork);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lvView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "입력 목록 보기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvView;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.ColumnHeader chWork;
    }
}

