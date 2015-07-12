namespace MicaAplicatie
{
    partial class EditStudent
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
            this.ReturnToAdminPannelButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveStudentEditButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // ReturnToAdminPannelButton
            // 
            this.ReturnToAdminPannelButton.Location = new System.Drawing.Point(191, 384);
            this.ReturnToAdminPannelButton.Name = "ReturnToAdminPannelButton";
            this.ReturnToAdminPannelButton.Size = new System.Drawing.Size(118, 30);
            this.ReturnToAdminPannelButton.TabIndex = 3;
            this.ReturnToAdminPannelButton.Text = "Return";
            this.ReturnToAdminPannelButton.Click += new System.EventHandler(this.ReturnToAdminPannelButton_Click);
            // 
            // SaveStudentEditButton
            // 
            this.SaveStudentEditButton.Location = new System.Drawing.Point(191, 348);
            this.SaveStudentEditButton.Name = "SaveStudentEditButton";
            this.SaveStudentEditButton.Size = new System.Drawing.Size(118, 30);
            this.SaveStudentEditButton.TabIndex = 2;
            this.SaveStudentEditButton.Text = "Save";
            this.SaveStudentEditButton.Click += new System.EventHandler(this.SaveStudentEditButton_Click);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 442);
            this.Controls.Add(this.ReturnToAdminPannelButton);
            this.Controls.Add(this.SaveStudentEditButton);
            this.Name = "EditStudent";
            this.Text = "Edit Student Entry";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ReturnToAdminPannelButton;
        private DevExpress.XtraEditors.SimpleButton SaveStudentEditButton;
    }
}