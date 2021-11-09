using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Excel 파일을 읽고 쓰는데 필요한 클래스, 메소드등의 인터페이스 사용을 쉽게 한다.
// 네임스페이스의 별칭을 부여해 Excel로 편하게 사용한다.
using Excel = Microsoft.Office.Interop.Excel;   


namespace B_FileExcelSave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* 인스턴스 객체, 변수를 초기화 하지 않으면 쓰레기 값이 나올 여지가 생김*/

        FileInfo fi = null;     // 파일 정보 가져오기 (FileInfo : System.IO(입출력) 관련 클래스)
        string FsPath = "";     // 파일 경로 저장 (파일 멤버에 변수, 메소드, 속성, 생성자 등 포함)

        private void btnPath_Click(object sender, EventArgs e)
        {
            if(this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string f in this.ofdFile.FileNames)
                {
                    fi = new FileInfo(f);

                    this.lvFile.Items.Add(new ListViewItem(new string[] 
                    { fi.Name, fi.LastWriteTime.ToString(), fi.Extension.Split('.')[1], 
                        GetFileSize(fi.Length), fi.FullName }));
                }
            }
        }

        private string GetFileSize(double byteCount)
        {
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
            {
                // {0:##.##} : 0 = Index 번호 (byteCount / 1073741824.0) 값 해당, ##.## = 표현 형식 지정
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            }
            else if (byteCount >= 1048576.0)
            {
                size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            }
            else if (byteCount >= 1024.0)
            {
                size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            }
            else if (byteCount > 0 && byteCount < 1024.0)
            {
                size = byteCount.ToString() + " Bytes";
            }

            return size;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.lvFile.Items.Count == 0)
            {
                MessageBox.Show("저장할 파일 정보가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }
            if (this.rbText.Checked == true)
            {
                this.sfdFile.Filter = "텍스트 파일(*.txt) | *.txt";
                if (this.sfdFile.ShowDialog() == DialogResult.OK)
                {
                    FsPath = this.sfdFile.FileName;
                    TxtSave();
                }
            }
            else
            {
                this.sfdFile.Filter = "엑셀 파일(*.xlsx) | *.xlsx";
                if (this.sfdFile.ShowDialog() == DialogResult.OK)
                {
                    FsPath = this.sfdFile.FileName;
                    ExcelSave();
                }
            }
        }
        private void TxtSave()
        {
            // using : 메모리를 할당하는 객체 선언, 안정적으로 메모리 할당 가능 using을 벗어날 경우에도 안정적인 메모리 해제가 가능
            using (StreamWriter sw = new StreamWriter(FsPath))
            {
                sw.WriteLine("이름" + "\t" + "수정한 날짜" + "\t" + "유형" + "\t" + "크기" + "\t" + "경로" + "\t");

                for(int n = 0; n < this.lvFile.Items.Count; n++)
                {
                    string FInfo = "";

                    for(int i = 0; i < this.lvFile.Items[n].SubItems.Count; i++)
                    {
                        FInfo += this.lvFile.Items[n].SubItems[i].Text + "\t";
                    }
                    sw.WriteLine(FInfo);
                }
                sw.Close();
            }
        }

        private void ExcelSave()
        {
            Excel.Application eApp;
            Excel.Workbook eWorkbook;
            Excel.Worksheet eWorkSheet;

            string[,] data;

            eApp = new Excel.Application();
            eWorkbook = eApp.Workbooks.Add(true);
            eWorkSheet = (Excel.Worksheet)eWorkbook.Sheets[1];  // Excel Sheet 배열은 1부터 시작한다.

            int rNum = this.lvFile.Items.Count + 1;
            int cNum = 5;

            data = new string[rNum, cNum];
            data[0, 0] = "이름";
            data[0, 1] = "수정한 날짜";
            data[0, 2] = "유형";
            data[0, 3] = "크기";
            data[0, 4] = "경로";

            for (int n = 0; n < this.lvFile.Items.Count; n++)
            {
                for(int i = 0; i < this.lvFile.Items[n].SubItems.Count; i++)
                {
                    data[n + 1, i] = this.lvFile.Items[n].SubItems[i].Text;
                }
            }
            string EndStr = "E" + rNum.ToString();
            eWorkSheet.get_Range("A1 : " + EndStr).Value2 = data;
            eWorkbook.SaveAs(FsPath, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, Excel.XlSaveAsAccessMode.xlShared, false, false, Type.Missing, Type.Missing, Type.Missing);
            eWorkbook.Close(false, Type.Missing, Type.Missing);
            eApp.Quit();

        }
    }
}

