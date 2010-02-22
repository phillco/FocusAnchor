using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FocusAnchor
{
    public partial class SetActionForm : Form
    {
        public SetActionForm( )
        {
            InitializeComponent( );
            txtAction.Text = Program.currentAction;
        }

        public string ShowMainDialog( )
        {
            ShowDialog( );
            return txtAction.Text;
        }

        public string ShowQueueDialog( )
        {
            this.Text = "Add an action to the queue";
            this.label1.Text = "New action:";
            return ShowMainDialog( );
        }

        private void btnSet_Click( object sender, EventArgs e )
        {
            
        }
    }
}
