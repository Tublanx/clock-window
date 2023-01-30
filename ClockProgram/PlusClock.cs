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

        Label hourLbl = null;
        Label minuteLbl = null;
        Label secondLbl = null;

        TextBox tbxTitle = null;

        public PlusClock()
        {
            InitializeComponent();

            hourLbl = this.Controls.OfType<Label>().FirstOrDefault(c => c.Name == "lblHour");
            minuteLbl = this.Controls.OfType<Label>().FirstOrDefault(c => c.Name == "lblMin");
            secondLbl = this.Controls.OfType<Label>().FirstOrDefault(c => c.Name == "lblSec");

            tbxTitle = this.Controls.OfType<TextBox>().FirstOrDefault(c => c.Name == "tbxTtle");

            tbxTitle.Text = "타이머1";
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
        /// 저장 버튼 클릭 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPressSave_Click(object sender, EventArgs e)
        {

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
            hourLbl.Text = hour.ToString().PadLeft(2, '0');
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
            minuteLbl.Text = minute.ToString().PadLeft(2, '0');
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
            secondLbl.Text = second.ToString().PadLeft(2, '0');
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
            hourLbl.Text = hour.ToString().PadLeft(2, '0');
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
            minuteLbl.Text = minute.ToString().PadLeft(2, '0');
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
            secondLbl.Text = second.ToString().PadLeft(2, '0');
        }
    }
}
