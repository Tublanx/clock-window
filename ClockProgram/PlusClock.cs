using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClockProgram
{
    public partial class PlusClock : Form
    {

        private int hour = 0;
        private int minute = 0;
        private int second = 0;

        private Label lblTime = null;
        private Button btnStart = null;
        private Button btnDel = null;
        private Timer timer = null;

        public PlusClock()
        {
            InitializeComponent();

            tbxTtle.Text = "타이머" + (Form1.table.Controls.Count + 1).ToString();
        }

        /// <summary>
        /// lblHour 라벨 숫자 플러스하는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPressHourUp_Click(object sender, EventArgs e)
        {
            if (hour == 99) hour = 0;

            hour++;
            lblHour.Text = hour.ToString().PadLeft(2, '0');
        }

        /// <summary>
        /// lblMin 라벨 숫자 플러스하는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPressMinUp_Click(object sender, EventArgs e)
        {
            if (minute == 60) minute = 0;

            minute++;
            lblMin.Text = minute.ToString().PadLeft(2, '0');
        }

        /// <summary>
        /// lblSec 라벨 숫자 플러스하는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPressSecUp_Click(object sender, EventArgs e)
        {
            if (second == 60) second = 0;

            second++;
            lblSec.Text = second.ToString().PadLeft(2, '0');
        }

        /// <summary>
        /// lblHour 라벨 숫자 마이너스하는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPressHourDown_Click(object sender, EventArgs e)
        {
            if (hour == 0) return;

            hour--;
            lblHour.Text = hour.ToString().PadLeft(2, '0');
        }

        /// <summary>
        /// lblMin 라벨 숫자 마이너스하는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPressMinDown_Click(object sender, EventArgs e)
        {
            if (minute == 0) return;

            minute--;
            lblMin.Text = minute.ToString().PadLeft(2, '0');
        }

        /// <summary>
        /// lblSec 라벨 숫자 마이너스하는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPressSecDown_Click(object sender, EventArgs e)
        {
            if (second == 0) return;

            second--;
            lblSec.Text = second.ToString().PadLeft(2, '0');
        }

        /// <summary>
        /// 저장 버튼 클릭 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPressSave_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flowLayout = new FlowLayoutPanel();
            FlowLayoutPanel southLayout = new FlowLayoutPanel();

            Label titleLbl = new Label();
            lblTime = new Label();
            btnStart = new Button();
            btnDel= new Button();

            titleLbl.Text = tbxTtle.Text;
            lblTime.Text = lblHour.Text + ":" + lblMin.Text + ":" + lblSec.Text;
            btnStart.Text = "시작";
            btnDel.Text = "삭제";

            lblTime.AutoSize = true;

            flowLayout.Dock = DockStyle.Fill;
            flowLayout.FlowDirection = FlowDirection.TopDown;
            
            titleLbl.Height = 50;

            titleLbl.Font = new Font("맑은 고딕", 20, FontStyle.Bold);
            lblTime.Font = new Font("맑은 고딕", 25);

            flowLayout.Controls.Add(titleLbl);
            flowLayout.Controls.Add(lblTime);
            flowLayout.Controls.Add(southLayout);
            southLayout.Controls.Add(btnStart);
            southLayout.Controls.Add(btnDel);

            southLayout.SetBounds(0, 0, 300, 70);

            Form1.table.Controls.Add(flowLayout);

            this.btnStart.Click += BtnClick_Start;

            Close();
        }

        /// <summary>
        /// 취소 버튼 클릭 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 시작 버튼 클릭 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClick_Start(Object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Tick += Timer_Tick;

            // 선택한 시간만큼 타이머 돌리기
            timer.Interval = 1000;
            timer.Start();
        }

        /// <summary>
        /// 타이머 이벤트 핸들러 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if(hour == 0 && minute == 0 && second == 0)
            {
                timer.Stop();
                return;
            }

            if (second == 0)
            {
                if(minute == 0 && hour > 0)
                {
                    minute = 59;
                    hour--;
                } else
                {
                    minute--;
                }
                second = 59;
            }
            else
            {
                second--;
            }

            if(minute == 0) {
                hour--;
            }

            if(hour == 0)
            {
                if(minute == 0 && second == 0)
                {
                    timer.Stop();
                }
            }
            lblTime.Text = hour.ToString("D2") + ":" + minute.ToString("D2") + ":" + second.ToString("D2");
        }
    }
}
