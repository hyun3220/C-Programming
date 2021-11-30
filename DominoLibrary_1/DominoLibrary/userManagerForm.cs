using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominoLibrary
{
    public partial class userManagerForm : Form
    {
        public userManagerForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = DataManager.Users;

        }

        private void userManagerForm_Load(object sender, EventArgs e)
        {
            this.textBox1.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                User user = dataGridView1.CurrentRow.DataBoundItem as User;
                textBox1.Text = user.Id.ToString();
                textBox2.Text = user.Name;
            }
            catch (Exception exception)
            {
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 추가 버튼
            try
            {
                if (DataManager.Users.Exists((x) => x.Id == int.Parse(textBox1.Text)))
                {
                    MessageBox.Show("ID가 이미 사용중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    User user = new User()
                    {
                        Id = int.Parse(textBox1.Text),
                        Name = textBox2.Text
                    };
                    DataManager.Users.Add(user);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Users;
                    DataManager.Save();
                }
            }
            catch (Exception exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 수정 버튼
            try
            {
                User user = DataManager.Users.Single((x) => x.Id == int.Parse(textBox1.Text));
                user.Name = textBox2.Text;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Users;
            }
            catch (Exception exception)
            {
                MessageBox.Show("존재하지 않는 사용자입니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 삭제 버튼
            try
            {
                User user = DataManager.Users.Single((x) => x.Id == int.Parse(textBox1.Text));
                DataManager.Users.Remove(user);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Users;
                DataManager.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show("존재하지 않는 사용자입니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
