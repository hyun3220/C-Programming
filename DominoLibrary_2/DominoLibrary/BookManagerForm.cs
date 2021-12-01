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
    public partial class BookManagerForm : Form
    {
        public BookManagerForm()
        {
            InitializeComponent();
            // 데이터 그리드 설정
            dataGridView1.DataSource = DataManager.Books;
            /*dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;*/
            /*dataGridView1.CellClick += dataGridView1_CellClick;*/
        }
        private Point mousePoint;
        

        private void BookManagerForm_Load(object sender, EventArgs e)
        {
            this.textBox1.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                Book book = dataGridView1.CurrentRow.DataBoundItem as Book;
                textBox1.Text = book.Isbn;
                textBox2.Text = book.Name;
                textBox3.Text = book.Publisher;
                textBox4.Text = book.Page.ToString();
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
                if (DataManager.Books.Exists((x) => x.Isbn == textBox1.Text))
                {
                    MessageBox.Show("이미 존재하는 도서입니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Book book = new Book()
                    {
                        Isbn = textBox1.Text,
                        Name = textBox2.Text,
                        Publisher = textBox3.Text,
                        Page = int.Parse(textBox4.Text)
                    };
                    DataManager.Books.Add(book);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Books;
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
                Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                book.Name = textBox2.Text;
                book.Publisher = textBox3.Text;
                book.Page = int.Parse(textBox4.Text);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Books;
                DataManager.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show("존재하지 않는 도서입니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 삭제 버튼
            try
            {
                Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                DataManager.Books.Remove(book);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Books;
                DataManager.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show("존재하지 않는 도서입니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookManagerForm_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void BookManagerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }
    }
}
