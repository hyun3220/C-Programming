
namespace DominoLibrary
{
    partial class LibraryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panNav = new System.Windows.Forms.Panel();
            this.btnLibManager = new System.Windows.Forms.Button();
            this.btnUserManager = new System.Windows.Forms.Button();
            this.btnBookManager = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnLibFormLoad = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnLibFormLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panNav);
            this.panel1.Controls.Add(this.btnLibManager);
            this.panel1.Controls.Add(this.btnUserManager);
            this.panel1.Controls.Add(this.btnBookManager);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnBreak);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 539);
            this.panel1.TabIndex = 0;
            // 
            // panNav
            // 
            this.panNav.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panNav.Location = new System.Drawing.Point(0, 172);
            this.panNav.Name = "panNav";
            this.panNav.Size = new System.Drawing.Size(3, 152);
            this.panNav.TabIndex = 2;
            // 
            // btnLibManager
            // 
            this.btnLibManager.FlatAppearance.BorderSize = 0;
            this.btnLibManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibManager.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLibManager.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLibManager.Image = ((System.Drawing.Image)(resources.GetObject("btnLibManager.Image")));
            this.btnLibManager.Location = new System.Drawing.Point(0, 159);
            this.btnLibManager.Name = "btnLibManager";
            this.btnLibManager.Size = new System.Drawing.Size(167, 55);
            this.btnLibManager.TabIndex = 4;
            this.btnLibManager.Text = "도서관 관리";
            this.btnLibManager.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLibManager.UseVisualStyleBackColor = true;
            this.btnLibManager.Click += new System.EventHandler(this.btnLibManager_Click);
            this.btnLibManager.Leave += new System.EventHandler(this.btnLibManager_Leave);
            // 
            // btnUserManager
            // 
            this.btnUserManager.FlatAppearance.BorderSize = 0;
            this.btnUserManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManager.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUserManager.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUserManager.Image = ((System.Drawing.Image)(resources.GetObject("btnUserManager.Image")));
            this.btnUserManager.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserManager.Location = new System.Drawing.Point(0, 281);
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.Size = new System.Drawing.Size(167, 55);
            this.btnUserManager.TabIndex = 1;
            this.btnUserManager.Text = "사용자 관리";
            this.btnUserManager.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUserManager.UseVisualStyleBackColor = true;
            this.btnUserManager.Click += new System.EventHandler(this.btnUserManager_Click);
            this.btnUserManager.Leave += new System.EventHandler(this.btnUserManager_Leave);
            // 
            // btnBookManager
            // 
            this.btnBookManager.FlatAppearance.BorderSize = 0;
            this.btnBookManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookManager.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBookManager.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBookManager.Image = ((System.Drawing.Image)(resources.GetObject("btnBookManager.Image")));
            this.btnBookManager.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookManager.Location = new System.Drawing.Point(0, 220);
            this.btnBookManager.Name = "btnBookManager";
            this.btnBookManager.Size = new System.Drawing.Size(167, 55);
            this.btnBookManager.TabIndex = 1;
            this.btnBookManager.Text = "도서 관리";
            this.btnBookManager.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBookManager.UseVisualStyleBackColor = true;
            this.btnBookManager.Click += new System.EventHandler(this.btnBookManager_Click);
            this.btnBookManager.Leave += new System.EventHandler(this.btnBookManager_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 153);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "방문을 환영합니다!";
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(40, 112);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(80, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBreak
            // 
            this.btnBreak.FlatAppearance.BorderSize = 0;
            this.btnBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreak.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBreak.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBreak.Image = ((System.Drawing.Image)(resources.GetObject("btnBreak.Image")));
            this.btnBreak.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBreak.Location = new System.Drawing.Point(0, 470);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(167, 55);
            this.btnBreak.TabIndex = 5;
            this.btnBreak.Text = "회원 탈퇴";
            this.btnBreak.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            this.btnBreak.Leave += new System.EventHandler(this.btnBreak_Leave);
            // 
            // btnConfig
            // 
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfig.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfig.Location = new System.Drawing.Point(0, 409);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(167, 55);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "정보 수정";
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            this.btnConfig.Leave += new System.EventHandler(this.btnConfig_Leave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(173, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Domino Library";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnExit.Location = new System.Drawing.Point(881, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnLibFormLoad
            // 
            this.pnLibFormLoad.Controls.Add(this.label3);
            this.pnLibFormLoad.Controls.Add(this.label2);
            this.pnLibFormLoad.Location = new System.Drawing.Point(187, 55);
            this.pnLibFormLoad.Name = "pnLibFormLoad";
            this.pnLibFormLoad.Size = new System.Drawing.Size(745, 470);
            this.pnLibFormLoad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("12롯데마트드림Medium", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(186, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "왼쪽 메뉴를 클릭해 사용이 가능합니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("12롯데마트드림Medium", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(110, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Domino Library에 오신것을 환영합니다 !";
            // 
            // LibraryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(936, 537);
            this.Controls.Add(this.pnLibFormLoad);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibraryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "도서관 관리";
            this.Load += new System.EventHandler(this.LibraryManagement_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LibraryManagement_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LibraryManagement_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnLibFormLoad.ResumeLayout(false);
            this.pnLibFormLoad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBookManager;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnUserManager;
        private System.Windows.Forms.Panel panNav;
        private System.Windows.Forms.Button btnLibManager;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnLibFormLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBreak;
    }
}