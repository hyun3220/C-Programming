
namespace DominoLibrary
{
    partial class DeleteAccountForm
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
            this.lblPWCheck = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPWCheck = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.lblMain2 = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPWCheck
            // 
            this.lblPWCheck.AutoSize = true;
            this.lblPWCheck.ForeColor = System.Drawing.Color.Red;
            this.lblPWCheck.Location = new System.Drawing.Point(489, 204);
            this.lblPWCheck.Name = "lblPWCheck";
            this.lblPWCheck.Size = new System.Drawing.Size(0, 15);
            this.lblPWCheck.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(157, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password Check :";
            // 
            // txtPWCheck
            // 
            this.txtPWCheck.Location = new System.Drawing.Point(295, 244);
            this.txtPWCheck.Name = "txtPWCheck";
            this.txtPWCheck.PasswordChar = '●';
            this.txtPWCheck.Size = new System.Drawing.Size(175, 23);
            this.txtPWCheck.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(295, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Delete My Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(200, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Username :";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.BackColor = System.Drawing.Color.AliceBlue;
            this.lblPW.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPW.Location = new System.Drawing.Point(205, 204);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(84, 19);
            this.lblPW.TabIndex = 14;
            this.lblPW.Text = "Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(295, 156);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(175, 23);
            this.txtUsername.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("12롯데마트드림Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(401, 285);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 29);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("12롯데마트드림Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(325, 285);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 29);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "탈퇴";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(295, 200);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '●';
            this.txtPW.Size = new System.Drawing.Size(175, 23);
            this.txtPW.TabIndex = 16;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.lblMain2);
            this.pnMain.Controls.Add(this.lblMain);
            this.pnMain.Location = new System.Drawing.Point(12, 12);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(677, 434);
            this.pnMain.TabIndex = 25;
            this.pnMain.Visible = false;
            // 
            // lblMain2
            // 
            this.lblMain2.AutoSize = true;
            this.lblMain2.Font = new System.Drawing.Font("12롯데마트드림Medium", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMain2.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMain2.Location = new System.Drawing.Point(149, 215);
            this.lblMain2.Name = "lblMain2";
            this.lblMain2.Size = new System.Drawing.Size(401, 24);
            this.lblMain2.TabIndex = 1;
            this.lblMain2.Text = "왼쪽 메뉴를 클릭해 사용이 가능합니다.";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("12롯데마트드림Medium", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMain.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMain.Location = new System.Drawing.Point(73, 163);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(577, 32);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Domino Library에 오신것을 환영합니다 !";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.ForeColor = System.Drawing.Color.Red;
            this.lblCheck.Location = new System.Drawing.Point(489, 248);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(0, 15);
            this.lblCheck.TabIndex = 26;
            // 
            // DeleteAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(701, 459);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.lblPWCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPWCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteAccountForm";
            this.Text = "DeleteAccountForm";
            this.Load += new System.EventHandler(this.DeleteAccountForm_Load);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPWCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPWCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label lblMain2;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblCheck;
    }
}