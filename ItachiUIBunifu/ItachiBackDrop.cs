using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ItachiUIBunifu
{
    /// <summary>
    /// Class trasparentBg1
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form"/>
    public partial class ItachiBackDrop : Form
    {
        /// <summary>
        /// The Child
        /// </summary>
        private Form _child = null;
        #region CTORS
        /// <summary>
        /// Initialzes a new instance of <see cref="ItachiBackDrop"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="child">The child.</param>
        public ItachiBackDrop(Form parent, Form child)
        {
            InitializeComponent();  
            _child = child;

            this.Location = parent.Location;
            this.Size = parent.Size;
            this.ShowDialog();
        }
        public ItachiBackDrop(Form child)
        {
            InitializeComponent();

            _child = child;
            this.WindowState = FormWindowState.Maximized;
            this.ShowDialog();
        }
        public ItachiBackDrop(Form parent, bool ignore)
        {
            InitializeComponent();

            formlauncher.Stop();
            this.Show();
            this.Location = parent.Location;
            this.Size = parent.Size;
        }
        #endregion CTORS
        /// <summary>
        /// Handle the tick event of timer1 control
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containce the event data.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            formlauncher.Stop();
            _child?.ShowDialog();
            this.Close();
        }
        public static Form Show(Form child,Form parent = null)
        {
            if(parent==null)
            {
                new ItachiBackDrop(child);
                return child;
            }
            new ItachiBackDrop(parent, child);
            return child;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formlauncher = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // formlauncher
            // 
            this.formlauncher.Enabled = true;
            this.formlauncher.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ItachiBackDrop
            // 
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(741, 458);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItachiBackDrop";
            this.Opacity = 0.7D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ItachiBackDrop_Load);
            this.ResumeLayout(false);

    }
        private Timer formlauncher;
        private System.ComponentModel.IContainer components;

        private void ItachiBackDrop_Load(object sender, EventArgs e)
        {

        }
    }
}
