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
                MessageBox.Show("빈 칸을 모두 입력해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtID.Focus();
                return;
            }
            else
            {
                if (upd == null || this.txtPW.Text != upd.pw)
                {
                    MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtID.Text = "";
                    this.txtPW.Text = "";
                    this.txtID.Focus();
                }
                else
                {
                    MessageBox.Show("로그인 되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserName = upd.name;
                    this.txtID.Text = "";
                    this.txtPW.Text = "";
                    this.txtID.Focus();
                    LibraryManagement libManagement = new LibraryManagement();
                    libManagement.Show();
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
    }
}
