using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FocusAnchor.Properties;

namespace FocusAnchor
{
    /// <summary>
    /// FocusAnchor's core form. Hovers over the user's desktop and shows them their current task.
    /// </summary>
    public partial class HoverForm : Form
    {
        public enum Corner { TopLeft, TopRight, BottomLeft, BottomRight };

        // Which corner is the form docked to?
        private Corner dockingLocation = Settings.Default.DockLocation;

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

        /// <summary>
        /// Updates the form to reflect the current task.
        /// </summary>
        public void UpdateDisplay( )
        {
            lblAction.Text = Settings.Default.CurrentTask;

            // Style the form differently if there's no set task.
            if ( Settings.Default.CurrentTask.Length <= 0 )
            {
                lblAction.Text = "(none)";
                BackColor = System.Drawing.Color.IndianRed;
            }
            else
                BackColor = System.Drawing.SystemColors.GradientInactiveCaption;

            Relocate( );
        }

        /// <summary>
        /// Docks the form to the appropriate corner.
        /// </summary>
        private void Relocate( )
        {
            Rectangle workingArea = Screen.GetWorkingArea( this );
            this.Size = lblAction.Size;
            this.Left = workingArea.Left;
            this.Top = workingArea.Top;
            if ( dockingLocation == Corner.TopRight || dockingLocation == Corner.BottomRight )
                Left = Screen.GetWorkingArea( this ).Width - Width;
            if ( dockingLocation == Corner.BottomLeft || dockingLocation == Corner.BottomRight )
                Top = Screen.GetWorkingArea( this ).Height - Height;
            Settings.Default.DockLocation = dockingLocation;
        }

        /// <summary>
        /// Shows a right-click menu that lets the user change the task (among other things).
        /// </summary>
        private void ShowContextMenu( Point location )
        {
            // Update the context menu's items.
            nextToolStripMenuItem.Enabled = ( Settings.Default.NextActions.Count > 0 );
            topleftToolStripMenuItem.Checked = ( dockingLocation == Corner.TopLeft );
            toprightToolStripMenuItem.Checked = ( dockingLocation == Corner.TopRight );
            bottomleftToolStripMenuItem.Checked = ( dockingLocation == Corner.BottomLeft );
            bottomrightToolStripMenuItem.Checked = ( dockingLocation == Corner.BottomRight );

            // Show it!
            Point displayLocation = this.Location;
            displayLocation.Offset( location );
            rightClickMenu.Show( displayLocation );
        }

        /************************************************************************/
        /*                      EVENT HANDLERS                                  */
        /************************************************************************/

        private void lblAction_MouseClick( object sender, MouseEventArgs e )
        {
            switch ( e.Button )
            {
                case MouseButtons.Left:
                    Program.PromptForAction( );
                    break;
                case MouseButtons.Right:
                    ShowContextMenu( e.Location );
                    break;
            }
        }

        private void HoverForm_Shown( object sender, EventArgs e )
        {
            UpdateDisplay( );
        }

        /************************************************************************/
        /*                     RIGHT-CLICK MENU HANDLERS                        */
        /************************************************************************/

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

        private void bottomleftToolStripMenuItem_Click( object sender, EventArgs e )
        {
            dockingLocation = Corner.BottomLeft;
            UpdateDisplay( );
        }

        private void bottomrightToolStripMenuItem_Click( object sender, EventArgs e )
        {
            dockingLocation = Corner.BottomRight;
            UpdateDisplay( );
        }

        private void toprightToolStripMenuItem_Click( object sender, EventArgs e )
        {
            dockingLocation = Corner.TopRight;
            UpdateDisplay( );
        }

        private void topleftToolStripMenuItem_Click( object sender, EventArgs e )
        {
            dockingLocation = Corner.TopLeft;
            UpdateDisplay( );
        }
    }
}
