using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoverUp.Properties;

namespace CoverUp
{
    public partial class CoverUp : Form
    {
        private object CoreApplication;

        public CoverUp()
        {
            InitializeComponent();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            //var coreTitleBar = new bar;
            if (this.BackColor == System.Drawing.Color.Black)
            {
                this.BackColor = System.Drawing.Color.White;
                
                this.Color.BackColor = System.Drawing.Color.White;
            }
            else
            {
                this.BackColor = System.Drawing.Color.Black;
                this.Color.BackColor = System.Drawing.Color.Black;
            }
        }

        private void OnTop_Click(object sender, EventArgs e)
        {
            if (this.TopMost == true)
                this.TopMost = false;
            else this.TopMost = true;
        }

        private void CoverUp_FormLoad(object sender, EventArgs e)
        {
            this.Location = Settings.Default.WindowLocation;        
            this.Size = Settings.Default.WindowSize;
        }

        private void CoverUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Copy window location to app settings
            Settings.Default.WindowLocation = this.Location;
            // Copy window size to app settings
            if (this.WindowState == FormWindowState.Normal)
            {
                Settings.Default.WindowSize = this.Size;
            }
            else
            {
                Settings.Default.WindowSize = this.RestoreBounds.Size;
            }
            // Save settings
            Settings.Default.Save();
        }
    }
}
