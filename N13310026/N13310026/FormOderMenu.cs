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

namespace N13310026
{
    public partial class FormOderMenu : Form
    {
        public FormOderMenu()
        {
            InitializeComponent();
            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv","時間,主食,配菜,飲品,甜點\n",Encoding.UTF8);
        }

        private void btnSendOder_Click(object sender, EventArgs e)
        {
            DateTime currentDataTime = DateTime.Now;
            string formattedDateTime = currentDataTime.ToString("yyyy/MM/dd HH:mm:ss");

            string food = "", sideFood = "", drink = "", dessert = "";

            foreach (Control c in panel3.Controls) //飲料
            {
                if(c is CheckBox) 
                {
                    CheckBox temp = (CheckBox)c;
                    if(temp.Checked ==true )
                    {
                        //MessageBox.Show(temp.Text);
                        drink+=" "+temp.Text;
                    }
                }
            }
            foreach (Control c in panel2.Controls) //點心
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked ==true)
                    {
                        //MessageBox.Show(temp.Text);
                        dessert+=" "+temp.Text;
                    }
                }
            }
            foreach (Control c in panel4.Controls) //配菜
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked ==true)
                    {
                        //MessageBox.Show(temp.Text);
                        sideFood+=" "+temp.Text;
                    }
                }
            }
            foreach (Control c in panel1.Controls) //主食
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked ==true)
                    {
                        //MessageBox.Show(temp.Text);
                        food+=" "+temp.Text;
                    }
                }
            }
            File.AppendAllText("OrderData.csv", formattedDateTime+","+food+","+sideFood+","+drink+","+dessert+"\n");
            MessageBox.Show("點餐完成!製作中請稍等!");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
       
    }
}
