using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;    // OleDbConnection, OleDbCommand 클래스 등을 사용하기 위해 선언

namespace B_HumanList
{
    public partial class Form1 : Form
    {
        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=humaninfo.accdb;Mode=ReadWrite";    // DB 연결 문자열
        private int num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCheck() == true)
            {
                var conn = new OleDbConnection(StrSQL);
                conn.Open();

                string SQL = "INSERT INTO t_info(m_name, m_age, m_phone, m_job) VALUES('";

                SQL += this.txtName.Text + "'," + Convert.ToInt32(this.txtAge.Text) + ", '" + this.txtPhone.Text + "', '" + this.txtJob.Text + "')";

                var comm = new OleDbCommand(SQL, conn);
                int i = comm.ExecuteNonQuery();
                conn.Close();

                if(i == 1)
                {
                    MessageBox.Show("정상적으로 데이터가 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lvList_DataSet_View();
                    txtClear();
                }
                else
                {
                    MessageBox.Show("오류가 발생했습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool txtCheck()
        {
            if(this.txtName.Text == "")
            {
                this.txtName.Focus();
                return false;
            }
            if (this.txtAge.Text == "")
            {
                this.txtAge.Focus();
                return false;
            }
            if (this.txtPhone.Text == "")
            {
                this.txtPhone.Focus();
                return false;
            }
            if (this.txtJob.Text == "")
            {
                this.txtJob.Focus();
                return false;
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvList_OleDb_View();
        }

        private void lvList_OleDb_View()
        {
            this.lvList.Items.Clear();

            var conn = new OleDbConnection(StrSQL);
            conn.Open();

            var comm = new OleDbCommand("SELECT * FROM t_info", conn);
            var myRead = comm.ExecuteReader();

            while(myRead.Read())
            {
                this.lvList.Items.Add(new ListViewItem(new string[] {myRead[0].ToString(), myRead[1].ToString(),
                myRead[2].ToString(), myRead[3].ToString(), myRead[4].ToString()}));
            }

            myRead.Close();
            conn.Close();
        }

        private void txtClear() // 입력란 공백 처리
        {
            this.txtName.Clear();
            this.txtAge.Clear();
            this.txtPhone.Clear();
            this.txtJob.Clear();
        }

        private void lvList_Click(object sender, EventArgs e)
        {
            if(this.lvList.SelectedItems.Count > 0)
            {
                num = Convert.ToInt32(this.lvList.SelectedItems[0].SubItems[0].Text);

                this.txtName.Text = this.lvList.SelectedItems[0].SubItems[1].Text;
                this.txtAge.Text = this.lvList.SelectedItems[0].SubItems[2].Text;
                this.txtPhone.Text = this.lvList.SelectedItems[0].SubItems[3].Text;
                this.txtJob.Text = this.lvList.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if(txtCheck() == true)
            {
                var conn = new OleDbConnection(StrSQL);
                conn.Open();
                string SQL = "UPDATE t_info SET m_name ='" + this.txtName.Text + "', m_age=" +
                Convert.ToInt32(this.txtAge.Text);
                SQL += ", m_phone='" + this.txtPhone.Text + "', m_job= '" + this.txtJob.Text + "'WHERE m_id = " + num + "";
                var comm = new OleDbCommand(SQL, conn);
                int i = comm.ExecuteNonQuery();

                conn.Close();

                if (i == 1)
                {
                    MessageBox.Show("정상적으로 데이터가 수정되었습니다.", "알림",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvList_DataSet_View();
                    txtClear();
                }
                else
                {
                    MessageBox.Show("데이터가 수정되지 않았습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lvList_DataSet_View()
        {
            this.lvList.Items.Clear();

            var conn = new OleDbConnection(StrSQL);
            conn.Open();

            var OleAdapter = new OleDbDataAdapter("SELECT * FROM t_info", conn);

            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("dsTable");
            OleAdapter.Fill(ds, "dsTable");

            IEnumerable<DataRow> query = from Humaninfo in dt.AsEnumerable() select Humaninfo;

            foreach (DataRow HumData in query)
            {
                var strArray = new String[] { HumData.Field<int>("m_id").ToString(), HumData.Field<string>("m_name"), HumData.Field<int>("m_age").ToString(),
                            HumData.Field<string>("m_phone"), HumData.Field<string>("m_job")};

                this.lvList.Items.Add(new ListViewItem(strArray));
            }

            conn.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(this.lvList.SelectedItems.Count > 0)
            {
                DialogResult dlr = MessageBox.Show("선택한 데이터를 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (dlr)
                {
                    case DialogResult.Yes:
                        var Conn = new OleDbConnection(StrSQL);
                        Conn.Open();
                        string Sql = "DELETE FROM t_info WHERE m_id =" + num + "";
                        var Comm = new OleDbCommand(Sql, Conn);
                        int i = Comm.ExecuteNonQuery();
                        Conn.Close();

                        if(i == 1)
                        {
                            MessageBox.Show("정상적으로 데이터가 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lvList_DataSetRamda_View();
                            txtClear();
                        }
                        else
                        {
                            MessageBox.Show("데이터가 삭제되지 않았습니다.", "에러",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case DialogResult.No:
                        break;
                }
            }
        }

        private void lvList_DataSetRamda_View()
        {
            this.lvList.Items.Clear();
            var conn = new OleDbConnection(StrSQL);
            conn.Open();

            var OleAdapter = new OleDbDataAdapter("SELECT * FROM t_info", conn);

            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("dsTable");

            OleAdapter.Fill(ds, "dsTable");

            var query = dt.AsEnumerable().
            Select(HumanInfo => new
            {
                Id = HumanInfo.Field<int>("m_id").ToString(),
                Name = HumanInfo.Field<string>("m_name"),
                Age = HumanInfo.Field<int>("m_age").ToString(),
                Phone = HumanInfo.Field<string>("m_phone"),
                Job = HumanInfo.Field<string>("m_job"),
            });

            foreach (var HumData in query)
            {
                var strArray = new String[] { HumData.Id, HumData.Name, HumData.Age, HumData.Phone, HumData.Job };
                this.lvList.Items.Add(new ListViewItem(strArray));
            }
            conn.Close();
        }
    }
}
