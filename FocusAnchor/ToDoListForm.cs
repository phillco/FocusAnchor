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
    public partial class ToDoListForm : Form
    {
        public ToDoListForm( )
        {
            InitializeComponent( );
            txtActionList.Text = "";
            foreach ( String action in Settings.Default.NextActions )
                txtActionList.Text += action + System.Environment.NewLine;
            txtActionList.SelectionStart = txtActionList.SelectionLength = 0;
        }

        private void btnOK_Click( object sender, EventArgs e )
        {
            Settings.Default.NextActions.Clear( );
            foreach ( String line in txtActionList.Text.Split( System.Environment.NewLine.ToCharArray( ) ) )
            {
                String lineToAdd = line.Trim( );

                // Remove any newlines.
                while ( line.Contains( System.Environment.NewLine ) )
                    lineToAdd = line.Substring( 0, line.Length - System.Environment.NewLine.Length );

                if ( lineToAdd.Length > 0 )
                    Settings.Default.NextActions.Add( lineToAdd );
            }

        }
    }
}
