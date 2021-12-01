using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace DominoLibrary
{

    public partial class LoginForm : Form
    {
        static public string UserName;
        static public string userID;
        private Point mousePoint;

        public LoginForm()
        {
            InitializeComponent();
        }

        FirebaseConfig fdc = new FirebaseConfig
        {
            AuthSecret = "tVFOq3eKA6ELM1KaGPUMbshm2rZxz0Ipuv4GpT68",
            BasePath = "https://dominolibraryjoin-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fdc);
            }
            catch
            {
                MessageBox.Show("오류가 발생했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.txtID.Focus();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = client.Get("가입자 명단/" + this.txtID.Text);
            Upload upd = result.ResultAs<Upload>();

            string id = this.txtID.Text;
            string pw = this.txtPW.Text;

            if(id == "" || pw == "")
            {
                this.lblResult.Text = "* 빈 칸을 모두 입력해 주세요.";
                this.txtID.Focus();
                return;
            }
            else
            {
                if (upd == null || this.txtPW.Text != upd.pw)
                {
                    this.lblResult.Text = "* 아이디 또는 비밀번호가 일치하지 않습니다.";
                    this.txtID.Text = "";
                    this.txtPW.Text = "";
                    this.txtID.Focus();
                }
                else
                {
                    UserName = upd.name;
                    userID = upd.id;
                    this.txtID.Text = "";
                    this.txtPW.Text = "";
                    this.txtID.Focus();
                    LibraryManagement libManagement = new LibraryManagement();
                    libManagement.Show();

                    this.Visible = false;    // 도서관 관리 페이지 로드시 로그인 페이지 감춤
                }
            }

            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Visible = false;
            registerForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }

        // 엔터키 누르면 바로 로그인 가능하도록 구현
        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
