using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ItachiUIBunifu
{
    public partial class AppBar : UserControl
    {
        public Point mouseLocation;
        public AppBar()
        {
            InitializeComponent();
        }

        [Category("Custom Bunifu By Uchiha Itachi#0425")]
        public string TextTabsTitle
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        [Category("Custom Bunifu By Uchiha Itachi#0425")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                label1.ForeColor = value;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             
        }

        private void AppBar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void AppBar_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void AppBar_MouseDown(object sender, MouseEventArgs e)
        {
            //mouseLocation = new Point(-e.X, -e.Y);
        }

        private void AppBar_Load(object sender, EventArgs e)
        {

        }
    }
}
