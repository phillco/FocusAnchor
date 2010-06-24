namespace FocusAnchor
{
    partial class HoverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container( );
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( HoverForm ) );
            this.lblAction = new System.Windows.Forms.Label( );
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.setActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.doneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.lockdownModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator( );
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.topleftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toprightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.bottomleftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.bottomrightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator( );
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.doneTimer = new System.Windows.Forms.Timer( this.components );
            this.tbTaskEntry = new System.Windows.Forms.TextBox( );
            this.tipBalloon = new System.Windows.Forms.ToolTip( this.components );
            this.taskIcon = new System.Windows.Forms.PictureBox( );
            this.lockdownTimer = new System.Windows.Forms.Timer( this.components );
            this.rightClickMenu.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) ( this.taskIcon ) ).BeginInit( );
            this.SuspendLayout( );
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font( "Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.lblAction.Location = new System.Drawing.Point( 38, 0 );
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size( 195, 40 );
            this.lblAction.TabIndex = 0;
            this.lblAction.Text = "action here...";
            this.lblAction.MouseClick += new System.Windows.Forms.MouseEventHandler( this.lblAction_MouseClick );
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.setActionToolStripMenuItem,
            this.doneToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.lockdownModeToolStripMenuItem,
            this.toolStripSeparator3,
            this.locationToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem} );
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size( 174, 148 );
            // 
            // setActionToolStripMenuItem
            // 
            this.setActionToolStripMenuItem.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Bold );
            this.setActionToolStripMenuItem.Name = "setActionToolStripMenuItem";
            this.setActionToolStripMenuItem.Size = new System.Drawing.Size( 173, 22 );
            this.setActionToolStripMenuItem.Text = "Set current task...";
            this.setActionToolStripMenuItem.Click += new System.EventHandler( this.setActionToolStripMenuItem_Click );
            // 
            // doneToolStripMenuItem
            // 
            this.doneToolStripMenuItem.Image = global::FocusAnchor.Properties.Resources.tick_32;
            this.doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            this.doneToolStripMenuItem.Size = new System.Drawing.Size( 173, 22 );
            this.doneToolStripMenuItem.Text = "Done";
            this.doneToolStripMenuItem.Click += new System.EventHandler( this.doneToolStripMenuItem_Click );
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Image = global::FocusAnchor.Properties.Resources.alacarte_16;
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size( 173, 22 );
            this.manageToolStripMenuItem.Text = "Task list...";
            this.manageToolStripMenuItem.Click += new System.EventHandler( this.manageToolStripMenuItem_Click_1 );
            // 
            // lockdownModeToolStripMenuItem
            // 
            this.lockdownModeToolStripMenuItem.Image = global::FocusAnchor.Properties.Resources.danger_16;
            this.lockdownModeToolStripMenuItem.Name = "lockdownModeToolStripMenuItem";
            this.lockdownModeToolStripMenuItem.Size = new System.Drawing.Size( 173, 22 );
            this.lockdownModeToolStripMenuItem.Text = "Lockdown mode";
            this.lockdownModeToolStripMenuItem.Click += new System.EventHandler( this.lockdownModeToolStripMenuItem_Click );
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size( 170, 6 );
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.topleftToolStripMenuItem,
            this.toprightToolStripMenuItem,
            this.bottomleftToolStripMenuItem,
            this.bottomrightToolStripMenuItem} );
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size( 173, 22 );
            this.locationToolStripMenuItem.Text = "Location";
            // 
            // topleftToolStripMenuItem
            // 
            this.topleftToolStripMenuItem.Name = "topleftToolStripMenuItem";
            this.topleftToolStripMenuItem.Size = new System.Drawing.Size( 144, 22 );
            this.topleftToolStripMenuItem.Text = "Top-left";
            this.topleftToolStripMenuItem.Click += new System.EventHandler( this.topleftToolStripMenuItem_Click );
            // 
            // toprightToolStripMenuItem
            // 
            this.toprightToolStripMenuItem.Name = "toprightToolStripMenuItem";
            this.toprightToolStripMenuItem.Size = new System.Drawing.Size( 144, 22 );
            this.toprightToolStripMenuItem.Text = "Top-right";
            this.toprightToolStripMenuItem.Click += new System.EventHandler( this.toprightToolStripMenuItem_Click );
            // 
            // bottomleftToolStripMenuItem
            // 
            this.bottomleftToolStripMenuItem.Name = "bottomleftToolStripMenuItem";
            this.bottomleftToolStripMenuItem.Size = new System.Drawing.Size( 144, 22 );
            this.bottomleftToolStripMenuItem.Text = "Bottom-left";
            this.bottomleftToolStripMenuItem.Click += new System.EventHandler( this.bottomleftToolStripMenuItem_Click );
            // 
            // bottomrightToolStripMenuItem
            // 
            this.bottomrightToolStripMenuItem.Name = "bottomrightToolStripMenuItem";
            this.bottomrightToolStripMenuItem.Size = new System.Drawing.Size( 144, 22 );
            this.bottomrightToolStripMenuItem.Text = "Bottom-right";
            this.bottomrightToolStripMenuItem.Click += new System.EventHandler( this.bottomrightToolStripMenuItem_Click );
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size( 170, 6 );
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size( 173, 22 );
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler( this.exitToolStripMenuItem_Click );
            // 
            // doneTimer
            // 
            this.doneTimer.Interval = 700;
            this.doneTimer.Tick += new System.EventHandler( this.doneTimer_Tick );
            // 
            // tbTaskEntry
            // 
            this.tbTaskEntry.AcceptsReturn = true;
            this.tbTaskEntry.Font = new System.Drawing.Font( "Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.tbTaskEntry.Location = new System.Drawing.Point( 44, -1 );
            this.tbTaskEntry.Name = "tbTaskEntry";
            this.tbTaskEntry.Size = new System.Drawing.Size( 251, 46 );
            this.tbTaskEntry.TabIndex = 2;
            this.tbTaskEntry.Visible = false;
            this.tbTaskEntry.KeyDown += new System.Windows.Forms.KeyEventHandler( this.tbTaskEntry_KeyDown );
            this.tbTaskEntry.Leave += new System.EventHandler( this.tbTaskEntry_Leave );
            this.tbTaskEntry.MouseClick += new System.Windows.Forms.MouseEventHandler( this.tbTaskEntry_MouseClick );
            // 
            // tipBalloon
            // 
            this.tipBalloon.IsBalloon = true;
            this.tipBalloon.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipBalloon.ToolTipTitle = "Tip!";
            // 
            // taskIcon
            // 
            this.taskIcon.Image = global::FocusAnchor.Properties.Resources.tick_32;
            this.taskIcon.Location = new System.Drawing.Point( 6, 5 );
            this.taskIcon.Name = "taskIcon";
            this.taskIcon.Size = new System.Drawing.Size( 32, 32 );
            this.taskIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.taskIcon.TabIndex = 1;
            this.taskIcon.TabStop = false;
            this.taskIcon.Visible = false;
            // 
            // lockdownTimer
            // 
            this.lockdownTimer.Interval = 1000;
            this.lockdownTimer.Tick += new System.EventHandler( this.lockdownTimer_Tick );
            // 
            // HoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size( 474, 40 );
            this.Controls.Add( this.lblAction );
            this.Controls.Add( this.taskIcon );
            this.Controls.Add( this.tbTaskEntry );
            this.Font = new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "HoverForm";
            this.Opacity = 0.75;
            this.ShowInTaskbar = false;
            this.Text = "FocusAnchor";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler( this.HoverForm_Deactivate );
            this.Shown += new System.EventHandler( this.HoverForm_Shown );
            this.rightClickMenu.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) ( this.taskIcon ) ).EndInit( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem setActionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topleftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toprightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomleftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomrightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doneToolStripMenuItem;
        private System.Windows.Forms.Timer doneTimer;
        private System.Windows.Forms.PictureBox taskIcon;
        private System.Windows.Forms.TextBox tbTaskEntry;
        private System.Windows.Forms.ToolTip tipBalloon;
        private System.Windows.Forms.ToolStripMenuItem lockdownModeToolStripMenuItem;
        private System.Windows.Forms.Timer lockdownTimer;
    }
}