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
    public partial class userConfig : Form
    {
        public userConfig()
        {
            InitializeComponent();
        }
        FirebaseConfig fdc = new FirebaseConfig
        {
            AuthSecret = "tVFOq3eKA6ELM1KaGPUMbshm2rZxz0Ipuv4GpT68",
            BasePath = "https://dominolibraryjoin-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void userConfig_Load(object sender, EventArgs e)
        {
            this.txtUsername.Text = LoginForm.userID.ToString();
            this.txtName.Text = LoginForm.UserName.ToString();
            this.txtUsername.Enabled = false;
            this.txtName.Focus();

            try
            {
                client = new FireSharp.FirebaseClient(fdc);
            }
            catch
            {
                MessageBox.Show("오류가 발생했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtPW.Text != this.txtPWCheck.Text)
            {
                this.lblPWCheck.Text = "* 비밀번호가 서로 일치하지 않습니다.";
                this.lblBlank.Text = "";
                this.txtPW.Text = "";
                this.txtPWCheck.Text = "";
            }
            else
            {
                var result = client.Get("가입자 명단/" + this.txtUsername.Text);
                Upload upd1 = result.ResultAs<Upload>();

                if (this.txtName.Text == "" || this.txtPW.Text == "" || this.txtPWCheck.Text == "")
                {
                    this.lblBlank.Text = "* 빈 칸을 모두 입력해 주세요.";
                }
                else
                {
                    this.lblPWCheck.Text = "";
                    var configResult = MessageBox.Show("정말 수정 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (configResult == DialogResult.Yes)
                    {
                        Upload upd2 = new Upload()
                        {
                            name = this.txtName.Text,
                            id = this.txtUsername.Text,
                            pw = this.txtPW.Text
                        };

                        var send = client.Set("가입자 명단/" + this.txtUsername.Text, upd2);
                        MessageBox.Show("회원 정보가 변경되었습니다." + "\n" + "다시 로그인 해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtPW.Text = "";
            this.txtPWCheck.Text = "";
            this.pnMain.Visible = true;
        }
    }
}
