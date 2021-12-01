using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace DominoLibrary
{
    public partial class RegisterForm : Form
    {
        private Point mousePoint;
        public RegisterForm()
        {
            InitializeComponent();
        }
        FirebaseConfig fdc = new FirebaseConfig
        {
            AuthSecret = "tVFOq3eKA6ELM1KaGPUMbshm2rZxz0Ipuv4GpT68", BasePath = "https://dominolibraryjoin-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fdc);
            }
            catch
            {
                MessageBox.Show("오류가 발생했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Visible = true;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var result = client.Get("가입자 명단/" + this.txtID.Text);
            Upload upd1 = result.ResultAs<Upload>();

            string name = this.txtName.Text;
            string id = this.txtID.Text;
            string pw = this.txtPW.Text;
            

            if (name == "" || id == "" || pw == "")
            {
                /*MessageBox.Show("빈 칸을 모두 입력해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                this.lblResult.Text = "* 빈 칸을 모두 입력해 주세요.";
                this.lblpwCheck.Text = "";
                this.lblpwCheck2.Text = "";
                this.txtName.Focus();
                return;
            }
            else
            {
                if (upd1 != null)
                {
                    /*MessageBox.Show("이미 사용중인 아이디 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
                    this.lblIDResult.Text = "* 이미 사용중인 아이디 입니다.";
                    this.lblResult.Text = "";
                    this.txtID.Focus();
                }
                else if (pwCheck(pw) == false)
                {
                    this.lblResult.Text = "";
                    this.lblIDResult.Text = "";
                    this.lblpwCheck.Text = "비밀번호는 알파벳, 숫자, 특수문자로 작성해 주세요.";
                }
                else
                {
                    Upload upd2 = new Upload()
                    {
                        name = this.txtName.Text,
                        id = this.txtID.Text,
                        pw = this.txtPW.Text
                    };

                    var send = client.Set("가입자 명단/" + this.txtID.Text, upd2);
                    MessageBox.Show("회원가입 되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Visible = true;
                }
            }

            if (pwCheck(pw) == false)
            {
                this.lblpwCheck.Text = " ❗ 8자 이상의 숫자가 포함되어야 합니다.";
                this.lblpwCheck2.Text = " ❗ 하나 이상의 특수문자를 포함해야 합니다.";
            }
            else
            {
                this.lblpwCheck.Text = "";
            }
        }

        public static bool pwCheck(string password)
        {
            Regex regex = new Regex(@"^(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            Match match = regex.Match(password);
            return match.Success;
        }

        private void btnIdCheck_Click(object sender, EventArgs e)
        {
            var result = client.Get("가입자 명단/" + this.txtID.Text);
            Upload upd1 = result.ResultAs<Upload>();

            string id = this.txtID.Text;

            if(id == "")
            {
                this.lblIDResult.Text = "* 빈 칸을 입력해 주세요.";
                this.txtID.Focus();
            }
            else
            {
                if (upd1 != null)
                {
                    this.lblIDResult.Text = "* 이미 사용중인 아이디 입니다.";
                    this.lblIdOkResult.Text = "";
                    this.txtID.Text = "";
                    this.txtID.Focus();
                }
                else
                {
                    Upload upd2 = new Upload()
                    {
                        id = this.txtID.Text
                    };
                    this.lblIDResult.Text = "";
                    this.lblIdOkResult.Text = "* 사용 가능한 아이디 입니다.";
                    this.txtID.Focus();
                }
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Visible = true;
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }

        // Enter키 누르면 바로 회원가입 되도록 설정
        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnJoin_Click(sender, e);
            }
        }
    }
}
