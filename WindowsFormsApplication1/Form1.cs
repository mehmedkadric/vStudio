using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = " ";
            
            
                 if (checkBox1.Checked) msg += "Ponedjeljak ";
                 if (checkBox2.Checked) msg += "Utorak ";
                 if (checkBox3.Checked) msg += "Srijeda ";
                 if (checkBox4.Checked) msg += "Četvrtak ";
                 if (checkBox5.Checked) msg += "Petak ";
                 if (checkBox6.Checked) msg += "Subota ";
                 if (checkBox7.Checked) msg += "Nedjelja";
            

            textBox1.Text = msg;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
