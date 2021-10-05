using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace B_TrayMsg
{
    public partial class Form2 : Form
    {
        private void plBack_Paint(object sender, PaintEventArgs e) { }

        private static System.Timers.Timer TimerEvent;  // Timer 객체 생성

        public Form2()
        {
            /* 아래 코드는 초기화 구성 단계 */

            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 20;   // 스크린의 가로위치
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;      // 스크린의 세로위치

            DesktopLocation = new Point(x, y);  // 폼의 위치 설정
            this.Size = new Size(170, 0);       // 폼의 크기 설정

            /* 초기화 구성 끝 */

            InitializeComponent();
        }

        public string MsgText
        {
            set
            {
                this.lblResult.Text = value;
            }
        }
        
        private delegate void OnDelegateHeight(int Flag);   // 델리게이트 선언
        private OnDelegateHeight OnHeight = null;           // 델리게이트 개체 생성

        // Form2를 Load 한다는 것은 
        private void Form2_Load(object sender, EventArgs e)
        {
            OnHeight = new OnDelegateHeight(MsgView);
            this.Size = new System.Drawing.Size(170, 0);
            this.Location = new System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - 20,
                                                     Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            TimerEvent = new System.Timers.Timer(2);

            TimerEvent.Elapsed += new ElapsedEventHandler(OnPopUp);
            TimerEvent.Start();
        }

        public void MsgView(int Flag)
        {
            if (Flag == 0)
            {
                Height++;
                Top--;
            }
            else if (Flag == 1)
            {
                Height--;
                Top++;
            }
            else if (Flag == 2)
            {
                this.Close();
            }
        }

        public void OnPopUp(object sender, ElapsedEventArgs e)
        {
            if(Height < 120)
            {
                Invoke(OnHeight, 0);   // Invoke를 통해 델리게이트를 불러와 Flag 매개변수 값을 입력받아 처리 (트레이 올려줌)
            }
            else
            {
                TimerEvent.Stop();
                TimerEvent.Elapsed -= new ElapsedEventHandler(OnPopUp);  // Timer 이벤트 발생 시 시간의 흐름을 등록 (OnPopUp 기능을 해제)

                TimerEvent.Elapsed += new ElapsedEventHandler(OnPopOut);
                TimerEvent.Interval = 3000;
                TimerEvent.Start();

            }
            Application.DoEvents();
        }

        public void OnPopOut(object sender, ElapsedEventArgs e)
        {
            while (Height > 2)
            {
                Invoke(OnHeight, 1);   // 트레이를 내려줌
            }
            TimerEvent.Stop();
            Application.DoEvents();
            Invoke(OnHeight, 2);       // 트레이 폼 종료
        }

        private void lblResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            TimerEvent.Stop();
        }
    }
}
