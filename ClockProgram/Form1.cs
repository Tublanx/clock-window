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
        public TableLayoutPanel table = null;

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
            PlusClock plusClock = new PlusClock();
            plusClock.Show();
        }
    }
}
