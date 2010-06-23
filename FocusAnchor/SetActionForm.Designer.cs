namespace FocusAnchor
{
    partial class SetActionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( SetActionForm ) );
            this.label1 = new System.Windows.Forms.Label( );
            this.txtAction = new System.Windows.Forms.TextBox( );
            this.btnSet = new System.Windows.Forms.Button( );
            this.btnCancel = new System.Windows.Forms.Button( );
            this.SuspendLayout( );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 15, 19 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 84, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Current action:";
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point( 105, 16 );
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size( 284, 22 );
            this.txtAction.TabIndex = 1;
            // 
            // btnSet
            // 
            this.btnSet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSet.Location = new System.Drawing.Point( 241, 49 );
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size( 73, 24 );
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point( 320, 49 );
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size( 69, 24 );
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SetActionForm
            // 
            this.AcceptButton = this.btnSet;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size( 405, 85 );
            this.Controls.Add( this.btnCancel );
            this.Controls.Add( this.btnSet );
            this.Controls.Add( this.txtAction );
            this.Controls.Add( this.label1 );
            this.Font = new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetActionForm";
            this.Text = "What are you working on?";
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnCancel;
    }
}

