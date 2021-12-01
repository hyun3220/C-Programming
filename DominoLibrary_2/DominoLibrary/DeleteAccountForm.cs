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
    public partial class DeleteAccountForm : Form
    {
        public static string userPW;
        public DeleteAccountForm()
        {
            InitializeComponent();
        }

        FirebaseConfig fdc = new FirebaseConfig
        {
            AuthSecret = "tVFOq3eKA6ELM1KaGPUMbshm2rZxz0Ipuv4GpT68",
            BasePath = "https://dominolibraryjoin-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = client.Get("가입자 명단/" + this.txtUsername.Text);
            Upload upd = result.ResultAs<Upload>();

            userPW = upd.pw.ToString();

            if (userPW == this.txtPW.Text && userPW == this.txtPWCheck.Text && this.txtPW.Text == this.txtPWCheck.Text)
            {
                var dlr = MessageBox.Show("정말 탈퇴하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlr == DialogResult.Yes)
                {
                    var deleteAccount = client.Delete("가입자 명단/" + this.txtUsername.Text);
                    MessageBox.Show("회원 탈퇴를 완료했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.lblPWCheck.Text = "";
                    this.txtPW.Text = "";
                    this.txtPWCheck.Text = "";

                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            else
            {
                this.lblPWCheck.Text = "* 현재 비밀번호가 일치하지 않습니다.";
                this.lblCheck.Text = "";

                if(this.txtPW.Text != this.txtPWCheck.Text)
                {
                    this.lblPWCheck.Text = "";
                    this.lblCheck.Text = "* 비밀번호가 서로 일치하지 않습니다.";
                }

                this.txtPW.Text = "";
                this.txtPWCheck.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtPW.Text = "";
            this.txtPWCheck.Text = "";
            this.pnMain.Visible = true;
            this.lblCheck.Text = "";
            this.lblPWCheck.Text = "";
        }

        private void DeleteAccountForm_Load(object sender, EventArgs e)
        {
            this.txtUsername.Text = LoginForm.userID.ToString();
            this.txtUsername.Enabled = false;
            this.txtPW.Focus();

            try
            {
                client = new FireSharp.FirebaseClient(fdc);
            }
            catch
            {
                MessageBox.Show("오류가 발생했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
