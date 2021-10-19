using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;  
/* [System.IO 네임스페이스]
   파일과 데이터 스트림을 읽고 쓸 수 있게 하는 형식, 
   기본 파일과 디렉터리 지원을 제공하는 인터페이스를 지원한다. */
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_FileRW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRPath_Click(object sender, EventArgs e)
        {
            if(this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtRPath.Text = this.ofdFile.FileName;
            }
        }

        private void btnRARead_Click(object sender, EventArgs e)
        {
            if(txtCheck() == false)
            {
                return;
            }
            if(File.Exists(this.txtRPath.Text))
            {
                /* 파일을 읽어들이는 과정, 파일 입출력을 위한 StreamReader 생성자 생성 */
                /* new StreamReader(파일의 경로, 인코딩 방식) 형식으로 작성한다. */
                /* sr객체에 메모리를 할당 */
                using (StreamReader sr = new StreamReader(this.txtRPath.Text, Encoding.Default))
                {
                    this.txtRView.Text = sr.ReadToEnd();    // 선택한 txt파일의 내용을 출력
                }
            }
            else
            {
                MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool txtCheck()
        {
            if(this.txtRPath.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnRLRead_Click(object sender, EventArgs e)
        {
            if (txtCheck() == false)
            {
                return;
            }
            this.txtRView.Clear();

            if (File.Exists(this.txtRPath.Text))
            {
                using (StreamReader sr = new StreamReader(this.txtRPath.Text, Encoding.Default))
                {
                    string line = null;

                    while((line = sr.ReadLine()) != null)   // 인덱스 번호를 반복해 읽어들이며 출력
                    {
                        this.txtRView.AppendText(line + "\r\n");
                    }
                }
            }
            else
            {
                MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWPath_Click(object sender, EventArgs e)
        {
            if(this.sfdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtWPath.Text = this.sfdFile.FileName;
            }
        }

        private void btnWASave_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.txtWPath.Text))
                {
                    sw.WriteLine(this.txtWView.Text);
                }
            }
            catch (Exception)
            {
                return;
            }
            MessageBox.Show("파일이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnWLSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.txtWPath.Text))
                {
                    foreach (var str in this.txtWView.Lines)    // 입력한 데이터를 한 행씩 읽어서 저장
                    {
                        sw.WriteLine(str);
                    }
                }
            }
            catch (Exception)
            {

                return;
            }
            MessageBox.Show("파일이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
