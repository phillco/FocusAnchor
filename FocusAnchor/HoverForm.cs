using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FocusAnchor
{
    public partial class HoverForm : Form
    {
        public HoverForm( )
        {
            InitializeComponent( );
        }

        private void HoverForm_Shown( object sender, EventArgs e )
        {
            UpdateDisplay( );
        }

        public void UpdateDisplay( )
        {
            if ( Program.currentAction.Length <= 0 )
            {
                lblAction.Text = "(none)";
                BackColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                lblAction.Text = Program.currentAction;
            }

            Size = lblAction.Size;
            Left = Screen.GetWorkingArea( this ).Width - Width;
            Top = Screen.GetWorkingArea( this ).Height - Height;
        }

        private void lblAction_MouseClick( object sender, MouseEventArgs e )
        {
            nextToolStripMenuItem.Enabled = ( Program.nextActions.Count > 0 );
            switch ( e.Button )
            {
                case MouseButtons.Left:
                    Program.PromptForAction( );
                    break;
                case MouseButtons.Right:
                    Point displayLocation = this.Location;
                    displayLocation.Offset( e.Location );
                    rightClickMenu.Show( displayLocation );
                    break;
            }
        }

        private void exitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Program.Quit( );
        }

        private void setActionToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Program.PromptForAction( );
        }

        private void clearToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Program.ClearAction( );
        }

        private void manageToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Program.PromptForActionList( );
        }

        private void nextToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Program.NextAction( );
        }

        private void queueActionToolStripMenuItem1_Click( object sender, EventArgs e )
        {
            Program.EnqueueAction( );
        }
    }
}
