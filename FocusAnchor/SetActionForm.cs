﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FocusAnchor.Properties;

namespace FocusAnchor
{
    public partial class SetActionForm : Form
    {
        public SetActionForm( )
        {
            InitializeComponent( );
            txtAction.Text = Settings.Default.CurrentTask;
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
    }
}
