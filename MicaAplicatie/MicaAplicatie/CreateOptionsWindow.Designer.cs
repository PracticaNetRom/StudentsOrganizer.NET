namespace MicaAplicatie
{
    partial class CreateOptionsWindow
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
            this.SelectAddEventButton = new DevExpress.XtraEditors.SimpleButton();
            this.SelectAddStudentButton = new DevExpress.XtraEditors.SimpleButton();
            this.ReturnToAdminPannelButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // SelectAddEventButton
            // 
            this.SelectAddEventButton.Location = new System.Drawing.Point(91, 90);
            this.SelectAddEventButton.Name = "SelectAddEventButton";
            this.SelectAddEventButton.Size = new System.Drawing.Size(121, 34);
            this.SelectAddEventButton.TabIndex = 0;
            this.SelectAddEventButton.Text = "New Event Entry";
            this.SelectAddEventButton.Click += new System.EventHandler(this.SelectAddEventButton_Click);
            // 
            // SelectAddStudentButton
            // 
            this.SelectAddStudentButton.Location = new System.Drawing.Point(91, 144);
            this.SelectAddStudentButton.Name = "SelectAddStudentButton";
            this.SelectAddStudentButton.Size = new System.Drawing.Size(121, 34);
            this.SelectAddStudentButton.TabIndex = 1;
            this.SelectAddStudentButton.Text = "New Student Entry";
            this.SelectAddStudentButton.Click += new System.EventHandler(this.SelectAddStudentButton_Click);
            // 
            // ReturnToAdminPannelButton
            // 
            this.ReturnToAdminPannelButton.Location = new System.Drawing.Point(109, 205);
            this.ReturnToAdminPannelButton.Name = "ReturnToAdminPannelButton";
            this.ReturnToAdminPannelButton.Size = new System.Drawing.Size(84, 23);
            this.ReturnToAdminPannelButton.TabIndex = 2;
            this.ReturnToAdminPannelButton.Text = "Return";
            this.ReturnToAdminPannelButton.Click += new System.EventHandler(this.ReturnToAdminPannelButton_Click);
            // 
            // CreateOptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 262);
            this.Controls.Add(this.ReturnToAdminPannelButton);
            this.Controls.Add(this.SelectAddStudentButton);
            this.Controls.Add(this.SelectAddEventButton);
            this.Name = "CreateOptionsWindow";
            this.Text = "New Entry";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SelectAddEventButton;
        private DevExpress.XtraEditors.SimpleButton SelectAddStudentButton;
        private DevExpress.XtraEditors.SimpleButton ReturnToAdminPannelButton;
    }
}