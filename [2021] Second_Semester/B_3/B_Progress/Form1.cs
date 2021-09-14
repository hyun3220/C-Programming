using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_Progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Num = 0;    // 진행 숫자
        string OrgStr = ""; // 결과 : 저장

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblStatus.Text;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Num++;

            if(Num > 100)
            {
                this.Timer.Enabled = false;
                MessageBox.Show("진행이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
            this.pbStatus.Value = Num;
            this.lblStatus.Text = OrgStr + "(" + Num.ToString() + "/100%)";
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Num = 0;
            this.Timer.Enabled = true;
            this.pbStatus.Value = Num;
            this.lblStatus.Text = OrgStr + "(" + Num.ToString() + "/100%)";
        }

        private void btnInitialization_Click(object sender, EventArgs e)
        {
            Num = 0;
            this.Timer.Enabled = false;
            this.pbStatus.Value = Num;
            this.lblStatus.Text = OrgStr + "(" + Num.ToString() + "/100%)";
        }
    }
}
