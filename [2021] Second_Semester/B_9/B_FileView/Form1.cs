using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace B_FileView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread threadFileView = null;   // 쓰레드 객체 생성

        private delegate void OnDelegateFile(string fp, string fn, string fl, string fc);
        private OnDelegateFile OnFile = null;   // 델리게이트 생성

        bool Flag = true;   // 일반 파일, 숨김 파일 구분
        int DirCount = 0;
        int FileCount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            OnFile = new OnDelegateFile(FileResult);
        }

        private void FileResult(string fp, string fn, string fl, string fc)
        {
            string fSize = GetFileSize(Convert.ToDouble(fl));
            this.lvFile.Items.Add(new ListViewItem(new string[] { fp, fn, fc, fSize }));
            this.tsslblResult.Text = String.Format("폴더 : {0}개, 파일 : {1}개", DirCount, FileCount);
        }

        private string GetFileSize(double byteCount)
        {
            string size = "0 Bytes";

            if(byteCount >= 1073741824.0)
            {
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";   // 2^30 (1GB)
            }
            else if(byteCount >= 1048576.0)
            {
                size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";      // 2^20 (1MB)
            }
            else if (byteCount >= 1024.0)
            {
                size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";         // 2^10 (1KB)
            }
            else if (byteCount > 0 && byteCount < 1024.0)
            {
                size = byteCount.ToString() + " Bytes";
            }

            return size;
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            ItemsClear();   // 변수, listView의 아이템 속성들, 파일의 경로 등을 초기화 하는 메소드
            Flag = true;

            if(threadFileView != null)  // 쓰레드가 실행 중이라면 쓰레드를 종료시킴
            {
                threadFileView.Abort();
            }
            if(this.txtPath.Text != "") // TextBox가 비어있지 않으면 쓰레드를 실행시킴 (FileView)
            {
                this.lvFile.Items.Clear();
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }
        private void ItemsClear()
        {
            DirCount = 0;
            FileCount = 0;
            this.lvFile.Items.Clear();
        }

        private void FileView(object path)
        {
            DirCount++;

            DirectoryInfo di = new DirectoryInfo((string)path);
            DirectoryInfo[] dti = di.GetDirectories();  // GetDirectories 메소드를 이용해 di 객체에 선언된 폴더의 하위 폴더 정보를 DirectoryInfo 배열의 객체 변수 dti에 저장

            foreach (var f in di.GetFiles())
            {
                if(Flag == true)
                {
                    FileCount++;
                    Invoke(OnFile, f.DirectoryName, f.Name, f.Length.ToString(), f.CreationTime.ToString());
                }
                else
                {
                    if (f.Attributes.ToString().Contains(FileAttributes.Hidden.ToString()))
                    {
                        FileCount++;
                        Invoke(OnFile, f.DirectoryName, f.Name, f.Length.ToString(), f.CreationTime.ToString());
                    }
                }
            }

            for(int i = 0; i < di.GetDirectories().Length; i++)
            {
                try
                {
                    FileView(dti[i].FullName);
                }
                catch
                {
                    continue;
                }
            }
        }

        private void rbtnHidden_CheckedChanged(object sender, EventArgs e)
        {
            ItemsClear();
            Flag = false;

            if(threadFileView != null)
            {
                threadFileView.Abort();
            }
            if(this.txtPath.Text != "")
            {
                this.lvFile.Items.Clear();
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if(this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                ItemsClear();
                this.txtPath.Text = this.fbdFolder.SelectedPath;
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }
    }
}
