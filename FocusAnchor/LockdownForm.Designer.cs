namespace FocusAnchor
{
    partial class LockdownForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( LockdownForm ) );
            this.btnCancel = new System.Windows.Forms.Button( );
            this.btnOK = new System.Windows.Forms.Button( );
            this.timeboxTime = new System.Windows.Forms.NumericUpDown( );
            this.label1 = new System.Windows.Forms.Label( );
            this.label4 = new System.Windows.Forms.Label( );
            this.lblProcrastinatingOn = new System.Windows.Forms.Label( );
            this.pictureBox1 = new System.Windows.Forms.PictureBox( );
            this.label2 = new System.Windows.Forms.Label( );
            this.label5 = new System.Windows.Forms.Label( );
            ( (System.ComponentModel.ISupportInitialize) ( this.timeboxTime ) ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize) ( this.pictureBox1 ) ).BeginInit( );
            this.SuspendLayout( );
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point( 395, 202 );
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size( 69, 24 );
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point( 316, 202 );
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size( 73, 24 );
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "Engage!";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler( this.btnOK_Click );
            // 
            // timeboxTime
            // 
            this.timeboxTime.Font = new System.Drawing.Font( "Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.timeboxTime.Location = new System.Drawing.Point( 158, 82 );
            this.timeboxTime.Name = "timeboxTime";
            this.timeboxTime.Size = new System.Drawing.Size( 54, 25 );
            this.timeboxTime.TabIndex = 23;
            this.timeboxTime.Value = new decimal( new int[] {
            30,
            0,
            0,
            0} );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.label1.Location = new System.Drawing.Point( 218, 84 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 185, 17 );
            this.label1.TabIndex = 19;
            this.label1.Text = "minutes to chipping away at it.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font( "Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.label4.Location = new System.Drawing.Point( 38, 85 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 109, 17 );
            this.label4.TabIndex = 22;
            this.label4.Text = "Dedicate the next";
            // 
            // lblProcrastinatingOn
            // 
            this.lblProcrastinatingOn.AutoSize = true;
            this.lblProcrastinatingOn.Font = new System.Drawing.Font( "Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.lblProcrastinatingOn.Location = new System.Drawing.Point( 47, 14 );
            this.lblProcrastinatingOn.Name = "lblProcrastinatingOn";
            this.lblProcrastinatingOn.Size = new System.Drawing.Size( 254, 21 );
            this.lblProcrastinatingOn.TabIndex = 17;
            this.lblProcrastinatingOn.Text = "Procrastinating on an ugly task?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FocusAnchor.Properties.Resources.danger_32;
            this.pictureBox1.Location = new System.Drawing.Point( 12, 17 );
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size( 32, 32 );
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.label2.Location = new System.Drawing.Point( 48, 36 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 82, 13 );
            this.label2.TabIndex = 26;
            this.label2.Text = "Use timeboxing.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 48, 125 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 357, 39 );
            this.label5.TabIndex = 27;
            this.label5.Text = "During this time, don\'t work on anything else. Progress is irrelevant.\n\nWhen the " +
                "time\'s up, feel free to quit or reward yourself.";
            // 
            // LockdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 482, 238 );
            this.Controls.Add( this.label5 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.pictureBox1 );
            this.Controls.Add( this.label4 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.timeboxTime );
            this.Controls.Add( this.btnCancel );
            this.Controls.Add( this.btnOK );
            this.Controls.Add( this.lblProcrastinatingOn );
            this.Font = new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LockdownForm";
            this.Text = "Lockdown mode";
            ( (System.ComponentModel.ISupportInitialize) ( this.timeboxTime ) ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize) ( this.pictureBox1 ) ).EndInit( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown timeboxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProcrastinatingOn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}