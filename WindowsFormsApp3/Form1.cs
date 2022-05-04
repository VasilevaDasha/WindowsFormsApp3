using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        PictureBox MouseDoubleClick;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MouseDoubleClick.MouseEnter += new EventHandler(this.MouseDoubleClick_MouseEnter);
            MouseDoubleClick.MouseLeave += new EventHandler(this.MouseDoubleClick_MouseLeave);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x_mouse = e.X;
            int y_mouse = e.Y;
            MessageBox.Show("Координаты мыши внутри Form" + x_mouse + " " + y_mouse);
        }
        private void MouseDoubleClick_MouseEnter(object sender, EventArgs e)
        {
            // MouseDoubleClick.BackColor = Color.CadetBlue;
            MouseDoubleClick.Image = Image.FromFile("c:\\mouse2.png");
            MouseDoubleClick.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void MouseDoubleClick_MouseLeave(object sender, EventArgs e)
        {
            // MouseDoubleClick.BackColor = Color.AliceBlue;
            MouseDoubleClick.Image = Image.FromFile("c:\\mouse1.png");
            MouseDoubleClick.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
