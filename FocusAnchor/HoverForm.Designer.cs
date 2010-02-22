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
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator( );
            this.todoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.queueActionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem( );
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator( );
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.bottomrightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.bottomleftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.topleftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toprightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator( );
            this.rightClickMenu.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAction.Font = new System.Drawing.Font( "Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.lblAction.Location = new System.Drawing.Point( 0, 0 );
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
            this.clearToolStripMenuItem,
            this.toolStripSeparator3,
            this.todoListToolStripMenuItem,
            this.toolStripSeparator1,
            this.locationToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem} );
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size( 153, 154 );
            // 
            // setActionToolStripMenuItem
            // 
            this.setActionToolStripMenuItem.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Bold );
            this.setActionToolStripMenuItem.Name = "setActionToolStripMenuItem";
            this.setActionToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.setActionToolStripMenuItem.Text = "Set current...";
            this.setActionToolStripMenuItem.Click += new System.EventHandler( this.setActionToolStripMenuItem_Click );
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler( this.clearToolStripMenuItem_Click );
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size( 149, 6 );
            // 
            // todoListToolStripMenuItem
            // 
            this.todoListToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.queueActionToolStripMenuItem1,
            this.nextToolStripMenuItem} );
            this.todoListToolStripMenuItem.Name = "todoListToolStripMenuItem";
            this.todoListToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.todoListToolStripMenuItem.Text = "To-do list";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size( 154, 22 );
            this.manageToolStripMenuItem.Text = "Manage...";
            this.manageToolStripMenuItem.Click += new System.EventHandler( this.manageToolStripMenuItem_Click );
            // 
            // queueActionToolStripMenuItem1
            // 
            this.queueActionToolStripMenuItem1.Name = "queueActionToolStripMenuItem1";
            this.queueActionToolStripMenuItem1.Size = new System.Drawing.Size( 154, 22 );
            this.queueActionToolStripMenuItem1.Text = "Queue action...";
            this.queueActionToolStripMenuItem1.Click += new System.EventHandler( this.queueActionToolStripMenuItem1_Click );
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size( 154, 22 );
            this.nextToolStripMenuItem.Text = "Next!";
            this.nextToolStripMenuItem.Click += new System.EventHandler( this.nextToolStripMenuItem_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 149, 6 );
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler( this.exitToolStripMenuItem_Click );
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.topleftToolStripMenuItem,
            this.toprightToolStripMenuItem,
            this.bottomleftToolStripMenuItem,
            this.bottomrightToolStripMenuItem} );
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.locationToolStripMenuItem.Text = "Location";
            // 
            // bottomrightToolStripMenuItem
            // 
            this.bottomrightToolStripMenuItem.Name = "bottomrightToolStripMenuItem";
            this.bottomrightToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.bottomrightToolStripMenuItem.Text = "Bottom-right";
            this.bottomrightToolStripMenuItem.Click += new System.EventHandler( this.bottomrightToolStripMenuItem_Click );
            // 
            // bottomleftToolStripMenuItem
            // 
            this.bottomleftToolStripMenuItem.Name = "bottomleftToolStripMenuItem";
            this.bottomleftToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.bottomleftToolStripMenuItem.Text = "Bottom-left";
            this.bottomleftToolStripMenuItem.Click += new System.EventHandler( this.bottomleftToolStripMenuItem_Click );
            // 
            // topleftToolStripMenuItem
            // 
            this.topleftToolStripMenuItem.Name = "topleftToolStripMenuItem";
            this.topleftToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.topleftToolStripMenuItem.Text = "Top-left";
            this.topleftToolStripMenuItem.Click += new System.EventHandler( this.topleftToolStripMenuItem_Click );
            // 
            // toprightToolStripMenuItem
            // 
            this.toprightToolStripMenuItem.Name = "toprightToolStripMenuItem";
            this.toprightToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
            this.toprightToolStripMenuItem.Text = "Top-right";
            this.toprightToolStripMenuItem.Click += new System.EventHandler( this.toprightToolStripMenuItem_Click );
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size( 149, 6 );
            // 
            // HoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size( 368, 45 );
            this.Controls.Add( this.lblAction );
            this.Font = new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "HoverForm";
            this.Opacity = 0.75;
            this.ShowInTaskbar = false;
            this.Text = "FocusAnchor";
            this.TopMost = true;
            this.Shown += new System.EventHandler( this.HoverForm_Shown );
            this.rightClickMenu.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem setActionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todoListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queueActionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topleftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toprightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomleftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomrightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}