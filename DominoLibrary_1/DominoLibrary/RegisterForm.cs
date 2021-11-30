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
                MessageBox.Show("빈 칸을 모두 입력해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtName.Focus();
                return;
            }
            else
            {
                if (upd1 != null)
                {
                    MessageBox.Show("이미 사용중인 아이디 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtID.Focus();
                }
                else if (pwCheck(pw) == false)
                {
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
                this.lblpwCheck.Text = "비밀번호는 8자 이상, 하나 이상의 숫자, 특수문자를 포함해야 합니다.";
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
                MessageBox.Show("빈 칸을 입력해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtID.Focus();
            }
            else
            {
                if (upd1 != null)
                {
                    MessageBox.Show("이미 사용중인 아이디 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtID.Text = "";
                    this.txtID.Focus();
                }
                else
                {
                    Upload upd2 = new Upload()
                    {
                        id = this.txtID.Text
                    };

                    MessageBox.Show("사용 가능한 아이디 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
