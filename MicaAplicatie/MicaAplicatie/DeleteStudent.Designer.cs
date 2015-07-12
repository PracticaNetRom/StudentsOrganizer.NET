namespace MicaAplicatie
{
    partial class DeleteStudent
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
            this.SaveStudentDeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.ReturnToAdminPannelButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // SaveStudentDeleteButton
            // 
            this.SaveStudentDeleteButton.Location = new System.Drawing.Point(182, 361);
            this.SaveStudentDeleteButton.Name = "SaveStudentDeleteButton";
            this.SaveStudentDeleteButton.Size = new System.Drawing.Size(118, 30);
            this.SaveStudentDeleteButton.TabIndex = 0;
            this.SaveStudentDeleteButton.Text = "Save";
            this.SaveStudentDeleteButton.Click += new System.EventHandler(this.SaveStudentDeleteButton_Click);
            // 
            // ReturnToAdminPannelButton
            // 
            this.ReturnToAdminPannelButton.Location = new System.Drawing.Point(182, 397);
            this.ReturnToAdminPannelButton.Name = "ReturnToAdminPannelButton";
            this.ReturnToAdminPannelButton.Size = new System.Drawing.Size(118, 30);
            this.ReturnToAdminPannelButton.TabIndex = 1;
            this.ReturnToAdminPannelButton.Text = "Return";
            this.ReturnToAdminPannelButton.Click += new System.EventHandler(this.ReturnToAdminPannelButton_Click);
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 448);
            this.Controls.Add(this.ReturnToAdminPannelButton);
            this.Controls.Add(this.SaveStudentDeleteButton);
            this.Name = "DeleteStudent";
            this.Text = "Delete Student Entry";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SaveStudentDeleteButton;
        private DevExpress.XtraEditors.SimpleButton ReturnToAdminPannelButton;
    }
}