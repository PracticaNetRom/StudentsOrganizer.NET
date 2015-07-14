namespace StudentOrganizer.GUI
{
    partial class PagingToolBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackButton = new DevExpress.XtraEditors.SimpleButton();
            this.NextButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BackButton.Location = new System.Drawing.Point(26, 16);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(77, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "<- Last Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NextButton.Location = new System.Drawing.Point(107, 16);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(77, 23);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next Page ->";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PagingToolBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BackButton);
            this.Name = "PagingToolBar";
            this.Size = new System.Drawing.Size(215, 57);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BackButton;
        private DevExpress.XtraEditors.SimpleButton NextButton;
    }
}
