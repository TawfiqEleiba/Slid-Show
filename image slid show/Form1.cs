using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_slid_show
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SlidpictureBox1_Click(object sender, EventArgs e)
        {

        }
        private int imageno = 1;
        private void Lodingnextimage()
        {
            if (imageno == 4)
            {
                imageno = 1;
            }
            SlidpictureBox1.ImageLocation = string.Format(@"images\{0}.jpg", imageno);
            imageno++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Lodingnextimage();
        }
    }
}
