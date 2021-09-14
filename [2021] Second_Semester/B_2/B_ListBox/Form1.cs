using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string OrgStr = "";     // 결과 : 저장

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblResult.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.txtList.Text != "")
            {
                this.lbView2.Items.Add(this.txtList.Text);
                this.txtList.Text = "";
            }
            else
            {
                MessageBox.Show("아이템을 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtList.Focus();
            }
        }

        private void lbView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = OrgStr + lbView2.SelectedItem.ToString();
        }

        private void txtList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
                e.SuppressKeyPress = true; // KeyPress 이벤트 사용시 e.handled = true 명령어 사용
            }
        }
    }
}
