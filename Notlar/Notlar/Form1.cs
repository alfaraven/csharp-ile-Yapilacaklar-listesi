using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UserControl1 useontrol1 = new UserControl1();
            flowLayoutPanel1.Controls.Add(useontrol1);
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            useontrol1.BackColor = Color.DeepSkyBlue;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserControl1 useontrol1 = new UserControl1();
            flowLayoutPanel1.Controls.Add(useontrol1);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            useontrol1.BackColor = Color.Gray;
        }
    }
}
