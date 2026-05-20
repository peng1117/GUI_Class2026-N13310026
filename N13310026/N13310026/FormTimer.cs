using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N13310026
{
    public partial class FormTimer : Form
    {
        public FormTimer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int counter = Int32.Parse(labCounter.Text.Replace("秒",""));
            counter+=1; //counter = counter+1;
            labCounter.Text = counter.ToString()+"秒";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labTimer.Text = "0秒";
        }

        
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            int counter = Int32.Parse(labTimer.Text.Replace("秒", ""));
            counter+=1; //counter = counter+1;
            labTimer.Text = counter.ToString()+"秒";
        }
    }
}
