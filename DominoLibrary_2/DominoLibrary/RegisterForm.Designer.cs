
namespace DominoLibrary
{
    partial class RegisterForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnIdCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblpwCheck = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblIDResult = new System.Windows.Forms.Label();
            this.lblIdOkResult = new System.Windows.Forms.Label();
            this.lblpwCheck2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(49, 126);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 30);
            this.txtName.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(49, 195);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(236, 30);
            this.txtID.TabIndex = 5;
            // 
            // txtPW
            // 
            this.txtPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPW.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPW.Location = new System.Drawing.Point(49, 268);
            this.txtPW.Multiline = true;
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '●';
            this.txtPW.Size = new System.Drawing.Size(236, 30);
            this.txtPW.TabIndex = 6;
            this.txtPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPW_KeyDown);
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.MediumPurple;
            this.btnJoin.FlatAppearance.BorderSize = 0;
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoin.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJoin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJoin.Location = new System.Drawing.Point(49, 367);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(305, 34);
            this.btnJoin.TabIndex = 7;
            this.btnJoin.Text = "Register";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(49, 418);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(305, 34);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnIdCheck
            // 
            this.btnIdCheck.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnIdCheck.FlatAppearance.BorderSize = 0;
            this.btnIdCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdCheck.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIdCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIdCheck.Location = new System.Drawing.Point(303, 195);
            this.btnIdCheck.Name = "btnIdCheck";
            this.btnIdCheck.Size = new System.Drawing.Size(75, 24);
            this.btnIdCheck.TabIndex = 9;
            this.btnIdCheck.Text = "Confirm";
            this.btnIdCheck.UseVisualStyleBackColor = false;
            this.btnIdCheck.Click += new System.EventHandler(this.btnIdCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome to Our Library";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(44, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(44, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(44, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(359, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblpwCheck
            // 
            this.lblpwCheck.AutoSize = true;
            this.lblpwCheck.ForeColor = System.Drawing.Color.Red;
            this.lblpwCheck.Location = new System.Drawing.Point(49, 309);
            this.lblpwCheck.Name = "lblpwCheck";
            this.lblpwCheck.Size = new System.Drawing.Size(0, 15);
            this.lblpwCheck.TabIndex = 15;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(49, 309);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 16;
            // 
            // lblIDResult
            // 
            this.lblIDResult.AutoSize = true;
            this.lblIDResult.ForeColor = System.Drawing.Color.Red;
            this.lblIDResult.Location = new System.Drawing.Point(51, 229);
            this.lblIDResult.Name = "lblIDResult";
            this.lblIDResult.Size = new System.Drawing.Size(0, 15);
            this.lblIDResult.TabIndex = 17;
            // 
            // lblIdOkResult
            // 
            this.lblIdOkResult.AutoSize = true;
            this.lblIdOkResult.ForeColor = System.Drawing.Color.Blue;
            this.lblIdOkResult.Location = new System.Drawing.Point(49, 229);
            this.lblIdOkResult.Name = "lblIdOkResult";
            this.lblIdOkResult.Size = new System.Drawing.Size(0, 15);
            this.lblIdOkResult.TabIndex = 18;
            // 
            // lblpwCheck2
            // 
            this.lblpwCheck2.AutoSize = true;
            this.lblpwCheck2.ForeColor = System.Drawing.Color.Red;
            this.lblpwCheck2.Location = new System.Drawing.Point(49, 333);
            this.lblpwCheck2.Name = "lblpwCheck2";
            this.lblpwCheck2.Size = new System.Drawing.Size(0, 15);
            this.lblpwCheck2.TabIndex = 19;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 508);
            this.Controls.Add(this.lblpwCheck2);
            this.Controls.Add(this.lblIdOkResult);
            this.Controls.Add(this.lblIDResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblpwCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIdCheck);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnIdCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblpwCheck;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblIDResult;
        private System.Windows.Forms.Label lblIdOkResult;
        private System.Windows.Forms.Label lblpwCheck2;
    }
}

