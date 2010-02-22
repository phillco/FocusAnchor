using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FocusAnchor
{
    public partial class HoverForm : Form
    {
        // Code needed to hide the window from Alt+Tab.
        private const int GWL_EXSTYLE = ( -20 );
        private const int WS_EX_TOOLWINDOW = 0x80;
        private const int WS_EX_APPWINDOW = 0x40000;
        [DllImport( "user32", CharSet = CharSet.Auto )]
        private static extern int GetWindowLong( IntPtr hWnd, int nIndex );
        [DllImport( "user32", CharSet = CharSet.Auto )]
        private static extern int SetWindowLong( IntPtr hWnd, int nIndex, int dwNewLong );

        public HoverForm( )
        {
            InitializeComponent( );

            // Hide this window from Alt+Tab.
            SetWindowLong( this.Handle, GWL_EXSTYLE, ( GetWindowLong( this.Handle, GWL_EXSTYLE ) | WS_EX_TOOLWINDOW ) & ~WS_EX_APPWINDOW );
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
