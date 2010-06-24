using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FocusAnchor.Properties;

namespace FocusAnchor
{
    public partial class LockdownForm : Form
    {
        public LockdownForm( )
        {
            InitializeComponent( );
            lblProcrastinatingOn.Text = "Procrastinating on \"";
            if ( Settings.Default.CurrentTask.Length > 30 )
                lblProcrastinatingOn.Text += Settings.Default.CurrentTask.Substring( 0, 28 ) + "...";
            else
                lblProcrastinatingOn.Text += Settings.Default.CurrentTask;
            lblProcrastinatingOn.Text += "\"?";
        }

        private void btnOK_Click( object sender, EventArgs e )
        {
            Settings.Default.LockdownReleaseTime = DateTime.Now.AddMinutes( (double) timeboxTime.Value );
            Program.UpdateSettings( );
        }
    }
}
