using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockProgram
{
    public partial class PlusClock : Form
    {

        int hour = 0;
        int minute = 0;
        int second = 0;

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

            Label titleLbl = new Label();
            Label timeLbl = new Label();

            titleLbl.Text = tbxTtle.Text;
            timeLbl.Text = lblHour.Text + ":" + lblMin.Text + ":" + lblSec.Text;

            titleLbl.TextAlign = ContentAlignment.MiddleCenter;
            timeLbl.TextAlign = ContentAlignment.MiddleCenter;
            titleLbl.AutoSize = false;
            timeLbl.AutoSize = false;

            titleLbl.Height = 50;

            titleLbl.Font = new Font("맑은 고딕", 20, FontStyle.Bold);
            timeLbl.Font = new Font("맑은 고딕", 14);

            flowLayout.Controls.Add(titleLbl);
            flowLayout.Controls.Add(timeLbl);

            Form1.table.Controls.Add(flowLayout);

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

    }
}
