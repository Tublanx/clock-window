using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockProgram
{
    public partial class Form1 : Form
    {
        static public TableLayoutPanel table = null;

        public Form1()
        {
            InitializeComponent();

            table = this.Controls.OfType<TableLayoutPanel>().FirstOrDefault(c => c.Name == "tablePanel");
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            if (table.Controls.Count == 4)
            {
                MessageBox.Show("최대 4개까지만 가능합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PlusClock plusClock = new PlusClock();
            plusClock.Show();
        }
    }
}
