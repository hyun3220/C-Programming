using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace DominoLibrary
{
    public partial class LibraryManagement : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private Point mousePoint;

        ///<Summary>
        /// Gets the answer
        ///</Summary>
        
        public LibraryManagement()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panNav.Height = btnLibManager.Height;
            panNav.Top = btnLibManager.Top;
            panNav.Left = btnLibManager.Left;
        }

        private void LibraryManagement_Load(object sender, EventArgs e)
        {
            // 로그인을 한 회원의 이름을 왼쪽 상단에 출력
            if(LoginForm.UserName == null)
            {
                this.lblUserName.Text = "침입자";
            }
            else
            {
                this.lblUserName.Text = LoginForm.UserName.ToString();
            }
        }
        private void btnLibManager_Click(object sender, EventArgs e)
        {
            // 대시보드 메뉴 클릭시 도서관 관리 폼이 오른쪽에 바로 뜨도록 작성

            this.lblTitle.Text = "Domino Library";
            this.pnLibFormLoad.Controls.Clear();
            mainForm mForm = new mainForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            mForm.FormBorderStyle = FormBorderStyle.None;
            this.pnLibFormLoad.Controls.Add(mForm);
            mForm.Show();

            panNav.Height = btnLibManager.Height;
            panNav.Top = btnLibManager.Top;
            panNav.Left = btnLibManager.Left;
            btnLibManager.BackColor = Color.AliceBlue; // 대시보드 왼쪽 panel의 버튼 클릭시 버튼 배경을 오른쪽 메인 화면 배경색과 동일하게 지정
            
            btnBookManager.BackColor = Color.FromArgb(196, 222, 255);
            btnUserManager.BackColor = Color.FromArgb(196, 222, 255);
            btnConfig.BackColor = Color.FromArgb(196, 222, 255);
            btnBreak.BackColor = Color.FromArgb(196, 222, 255);
        }

        private void btnBookManager_Click(object sender, EventArgs e)
        {
            this.lblTitle.Text = "Book Management";

            this.pnLibFormLoad.Controls.Clear();
            BookManagerForm bookMForm = new BookManagerForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            bookMForm.FormBorderStyle = FormBorderStyle.None;
            this.pnLibFormLoad.Controls.Add(bookMForm);
            bookMForm.Show();

            panNav.Height = btnBookManager.Height;
            panNav.Top = btnBookManager.Top;
            btnBookManager.BackColor = Color.AliceBlue;

            btnUserManager.BackColor = Color.FromArgb(196, 222, 255);
            btnLibManager.BackColor = Color.FromArgb(196, 222, 255);
            btnConfig.BackColor = Color.FromArgb(196, 222, 255);
            btnBreak.BackColor = Color.FromArgb(196, 222, 255);
        }

        private void btnUserManager_Click(object sender, EventArgs e)
        {
            this.lblTitle.Text = "User Management";

            this.pnLibFormLoad.Controls.Clear();
            userManagerForm userMForm = new userManagerForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            userMForm.FormBorderStyle = FormBorderStyle.None;
            this.pnLibFormLoad.Controls.Add(userMForm);
            userMForm.Show();

            panNav.Height = btnUserManager.Height;
            panNav.Top = btnUserManager.Top;
            btnUserManager.BackColor = Color.AliceBlue;

            btnLibManager.BackColor = Color.FromArgb(196, 222, 255); 
            btnBookManager.BackColor = Color.FromArgb(196, 222, 255);
            btnConfig.BackColor = Color.FromArgb(196, 222, 255);
            btnBreak.BackColor = Color.FromArgb(196, 222, 255);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            this.lblTitle.Text = "User Cofig";

            this.pnLibFormLoad.Controls.Clear();
            userConfig userConfigForm = new userConfig() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            userConfigForm.FormBorderStyle = FormBorderStyle.None;
            this.pnLibFormLoad.Controls.Add(userConfigForm);
            userConfigForm.Show();

            panNav.Height = btnConfig.Height;
            panNav.Top = btnConfig.Top;
            btnConfig.BackColor = Color.AliceBlue;

            btnLibManager.BackColor = Color.FromArgb(196, 222, 255);
            btnUserManager.BackColor = Color.FromArgb(196, 222, 255);
            btnBookManager.BackColor = Color.FromArgb(196, 222, 255);
            btnBreak.BackColor = Color.FromArgb(196, 222, 255);
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            this.lblTitle.Text = "Delete User Account";

            this.pnLibFormLoad.Controls.Clear();
            DeleteAccountForm deleteAccountForm = new DeleteAccountForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            deleteAccountForm.FormBorderStyle = FormBorderStyle.None;
            this.pnLibFormLoad.Controls.Add(deleteAccountForm);
            deleteAccountForm.Show();

            panNav.Height = btnBreak.Height;
            panNav.Top = btnBreak.Top;
            panNav.Left = btnBreak.Left;
            btnBreak.BackColor = Color.AliceBlue;

            btnLibManager.BackColor = Color.FromArgb(196, 222, 255);
            btnUserManager.BackColor = Color.FromArgb(196, 222, 255);
            btnBookManager.BackColor = Color.FromArgb(196, 222, 255);
            btnConfig.BackColor = Color.FromArgb(196, 222, 255);
        }
        private void btnLibManager_Leave(object sender, EventArgs e)
        {
            btnLibManager.BackColor = Color.FromArgb(196, 222, 255);
        }

        private void btnBookManager_Leave(object sender, EventArgs e)
        {
            btnBookManager.BackColor = Color.FromArgb(196, 222, 255);
        }

        private void btnUserManager_Leave(object sender, EventArgs e)
        {
            btnUserManager.BackColor = Color.FromArgb(196, 222, 255);
        }

        private void btnConfig_Leave(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.FromArgb(196, 222, 255);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LibraryManagement_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); // 현재 윈도우의 좌표 저장
        }

        private void LibraryManagement_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            { 
                int x = mousePoint.X - e.X; 
                int y = mousePoint.Y - e.Y; 
                Location = new Point(this.Left - x, this.Top - y); 
            }
        }

        private void btnBreak_Leave(object sender, EventArgs e)
        {
            btnBreak.BackColor = Color.FromArgb(196, 222, 255);
        }
    }
}
