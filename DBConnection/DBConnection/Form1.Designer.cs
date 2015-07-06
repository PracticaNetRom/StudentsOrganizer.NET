namespace StudentOrganizer.GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogInButton = new DevExpress.XtraEditors.SimpleButton();
            this.userNameTextField = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextField = new DevExpress.XtraEditors.TextEdit();
            this.userNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.passwordLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextField.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInButton.Location = new System.Drawing.Point(257, 280);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(75, 23);
            this.LogInButton.TabIndex = 0;
            this.LogInButton.Text = "Log In";
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // userNameTextField
            // 
            this.userNameTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextField.Location = new System.Drawing.Point(168, 53);
            this.userNameTextField.Name = "userNameTextField";
            this.userNameTextField.Size = new System.Drawing.Size(100, 20);
            this.userNameTextField.TabIndex = 1;
            // 
            // passwordTextField
            // 
            this.passwordTextField.Location = new System.Drawing.Point(168, 110);
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.Size = new System.Drawing.Size(100, 20);
            this.passwordTextField.TabIndex = 2;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Location = new System.Drawing.Point(71, 56);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(52, 13);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "User Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(71, 113);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(46, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 324);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.userNameTextField);
            this.Controls.Add(this.LogInButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextField.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton LogInButton;
        private DevExpress.XtraEditors.TextEdit userNameTextField;
        private DevExpress.XtraEditors.TextEdit passwordTextField;
        private DevExpress.XtraEditors.LabelControl userNameLabel;
        private DevExpress.XtraEditors.LabelControl passwordLabel;


    }
}

