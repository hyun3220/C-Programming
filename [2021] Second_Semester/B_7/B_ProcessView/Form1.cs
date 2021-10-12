using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_ProcessView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Thread ProcessThread;   // 프로세스 나타내는 스레드
        Thread checkThread = null;      // 실시간 시스템 정보 체크

        private delegate void ProcessUpdateDelegate();      // 델리게이트 생성
        private ProcessUpdateDelegate UpProc = null;        // 델리게이트 객체 생성

        private delegate void TotalUpdateDelegate(int m, int n);    // status bar에 성능 표시
        private TotalUpdateDelegate OnTotal = null;

        private PerformanceCounter oCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");    // 시스템 CPU 성능 카운터
        private PerformanceCounter oMem = new PerformanceCounter("Memory", "% Committed Bytes In Use");         // 시스템 Memory 성능 카운터
        private PerformanceCounter pCPU = new PerformanceCounter(); // 시스템이 성능을 카운팅 하기 위함

        /*PerformanceCounter 사용법 
         * 첫번째 인자 Performance Object (IP,Processor,WMI,Memory
         * 두번째 인자 해당 Object의 카운터(Processor 인 경우 % Processor Time,% User Time, Thread Count)
         * (Memory 인 경우 Available MByte,Available KByte)
         * 세번째 인자 프로세스의 이름
         * cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total"); //new PerformanceCounter("Processor", "% Processor Time", appName);
         * ramCounter = new PerformanceCounter("Memory", "Available MBytes");
         */

        bool bExit = false;
        int cp = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            ProcessView();  // 프로세스 출력 (ProcessView 메소드 호출)

            UpProc = new ProcessUpdateDelegate(ProcessView);    // 델리게이트에 구동 메소드 입력
            OnTotal = new TotalUpdateDelegate(TotalView);

            ProcessThread = new Thread(ProcessUpdate);  // 스레드 대리자에 구동 메소드 입력
            ProcessThread.Start();  // 스레드 시작

            checkThread = new Thread(getCPU_Info);
            checkThread.Start();
        }

        private void ProcessUpdate()
        {
            try
            {
                while(true)
                {
                    var oldlist = new ArrayList();

                    foreach (var oldproc in Process.GetProcesses()) // 실행중인 모든 프로세스 목록을 가져옴
                    {
                        oldlist.Add(oldproc.Id.ToString()); // oldlist에 프로세스들을 하나씩 Add 시킴(String 형으로 Add)
                    }
                    Thread.Sleep(1000);    // 1초마다 스레드를 정지 (1초 단위로 프로세스를 Add 시킨다 생각)

                    var newproc = Process.GetProcesses();

                    if(oldlist.Count != newproc.Length)
                    {
                        Invoke(UpProc); // Invoke를 통해 델리게이트를 불러와 메인 스레드에게 작업을 대신 요청
                        continue;       // 실행을 재개
                    }

                    int i = 0;

                    foreach (var rewproc in Process.GetProcesses())
                    {
                        if(oldlist[i++].ToString() != rewproc.Id.ToString())
                        {
                            Invoke(UpProc);
                            break;
                        }
                    }
                }
            } 
            catch { }
        }
        private void ProcessView()
        {
            try
            {
                this.lvView.Items.Clear();
                cp = 0;
                foreach (var proc in Process.GetProcesses())
                {
                    string[] str;
                    try
                    {
                        str = proc.TotalProcessorTime.ToString().Split(new char[] { '.' });
                    }
                    catch
                    {
                        str = new string[] { "" };
                    }

                    var strArray = new string[] {proc.ProcessName.ToString(), proc.Id.ToString(),
                                                    str[0], NumFormat(proc.WorkingSet64)};

                    var lvt = new ListViewItem(strArray);
                    this.lvView.Items.Add(lvt);
                    cp++;
                }
            }
            catch
            {
                this.tsslProcess.Text = "프로세스 : " + cp.ToString() + "개";
            }
        }
        private void TotalView(int m, int n)
        {
            this.tsslCpu.Text = "CPU 사용 : " + m.ToString() + "%";
            this.tsslMem.Text = "실제 메모리 : " + n.ToString() + "%";
        }

        private string NumFormat(long MemNum)
        {
            MemNum = MemNum / 1024;
            return String.Format("{0:N}", MemNum) + " KB";
        }

        private void getCPU_Info()
        {
            while(!bExit)
            {
                int iCPU = (int)oCPU.NextValue();
                int iMem = (int)oMem.NextValue();
                Invoke(OnTotal, iCPU, iMem);    // Invoke를 통해 델리게이트를 불러와 iCPU, iMem 매개변수 값을 입력받아 처리
                                                // 어떤 Form에서 작업을 하는데, 다른 스레드에서 접근할 때 충돌이 일어날 수 있기 때문에
                                                // Invoke를 사용해 충돌을 최소화 시켜줌
                Thread.Sleep(1000);
            }
        }
 
        private void btnKill_Click(object sender, EventArgs e)
        {
            ProcessKill();
        }

        private void ProcessKill()
        {
            try
            {
                int PID = Convert.ToInt32(this.lvView.SelectedItems[0].SubItems[1].Text);
                Process tProcess = Process.GetProcessById(PID);
                if (!(tProcess == null))
                {
                    var dlr = MessageBox.Show(this.lvView.SelectedItems[0].SubItems[0].Text +
                    " 프로세스를 끝내시겠습니까?", "알림", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                    if (dlr == DialogResult.Yes)
                    {
                        tProcess.Kill();
                        ProcessView();
                    }
                }
                else
                {
                    MessageBox.Show(this.lvView.SelectedItems[0].SubItems[0].Text +
                    "프로세스는 존재하지 않습니다", "알림", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    ProcessView();
                }
            }
            catch
            {
                return;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(ProcessThread == null))
                ProcessThread.Abort();  //스레드 종료
            if (!(checkThread == null))
                checkThread.Abort();    //스레드 종료
        }
    }
}
