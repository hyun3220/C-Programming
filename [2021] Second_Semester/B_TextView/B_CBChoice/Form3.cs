using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_CBChoice
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        // 초기 콤보박스 데이터 설정
        string[] SList = new string[] { "스테이크", "카레라이스", "라면", "만둣국", "김밥" };

        // 선택 결과 저장
        string orgStr = "";

        private void Form3_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < SList.Length; i++)
            {
                this.cbList.Items.Add(SList[i]);
            }
            orgStr = this.lblResult.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtList.Text != "")
            {
                this.cbList.Items.Add(this.txtList.Text);
                MessageBox.Show("아이템을 추가했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("아이템을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtList.Focus();
            }
            this.txtList.Text = "";
        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbList.Text != "")
            {
                this.lblResult.Text = orgStr + this.cbList.Text;
            }
        }
    }
}
