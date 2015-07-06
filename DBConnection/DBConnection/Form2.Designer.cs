namespace StudentOrganizer.GUI
{
    partial class Form2
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
            this.studentMenuButton = new DevExpress.XtraEditors.SimpleButton();
            this.eventMenuButton = new DevExpress.XtraEditors.SimpleButton();
            this.studentEventMenuButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // studentMenuButton
            // 
            this.studentMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.studentMenuButton.Location = new System.Drawing.Point(118, 60);
            this.studentMenuButton.Name = "studentMenuButton";
            this.studentMenuButton.Size = new System.Drawing.Size(108, 23);
            this.studentMenuButton.TabIndex = 0;
            this.studentMenuButton.Text = "Student Menu";
            this.studentMenuButton.Click += new System.EventHandler(this.studentMenuButton_Click);
            // 
            // eventMenuButton
            // 
            this.eventMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.eventMenuButton.Location = new System.Drawing.Point(118, 117);
            this.eventMenuButton.Name = "eventMenuButton";
            this.eventMenuButton.Size = new System.Drawing.Size(108, 23);
            this.eventMenuButton.TabIndex = 1;
            this.eventMenuButton.Text = "Event Menu";
            // 
            // studentEventMenuButton
            // 
            this.studentEventMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.studentEventMenuButton.Location = new System.Drawing.Point(118, 166);
            this.studentEventMenuButton.Name = "studentEventMenuButton";
            this.studentEventMenuButton.Size = new System.Drawing.Size(108, 23);
            this.studentEventMenuButton.TabIndex = 2;
            this.studentEventMenuButton.Text = "Student Event Menu";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 303);
            this.Controls.Add(this.studentEventMenuButton);
            this.Controls.Add(this.eventMenuButton);
            this.Controls.Add(this.studentMenuButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton studentMenuButton;
        private DevExpress.XtraEditors.SimpleButton eventMenuButton;
        private DevExpress.XtraEditors.SimpleButton studentEventMenuButton;
    }
}