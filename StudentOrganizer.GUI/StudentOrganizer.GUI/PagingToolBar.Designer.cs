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
            this.StartNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.EndNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BeginLabel = new DevExpress.XtraEditors.LabelControl();
            this.EndLabel = new DevExpress.XtraEditors.LabelControl();
            this.PageNrLabel = new System.Windows.Forms.Label();
            this.PageNumberComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.StartNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageNumberComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BackButton.Location = new System.Drawing.Point(3, 16);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(77, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "<- Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NextButton.Location = new System.Drawing.Point(84, 16);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(77, 23);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next ->";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // StartNumber
            // 
            this.StartNumber.Location = new System.Drawing.Point(206, 18);
            this.StartNumber.Name = "StartNumber";
            this.StartNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartNumber.Size = new System.Drawing.Size(32, 20);
            this.StartNumber.TabIndex = 2;
            // 
            // EndNumber
            // 
            this.EndNumber.Location = new System.Drawing.Point(281, 18);
            this.EndNumber.Name = "EndNumber";
            this.EndNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndNumber.Size = new System.Drawing.Size(32, 20);
            this.EndNumber.TabIndex = 3;
            // 
            // BeginLabel
            // 
            this.BeginLabel.Location = new System.Drawing.Point(176, 21);
            this.BeginLabel.Name = "BeginLabel";
            this.BeginLabel.Size = new System.Drawing.Size(24, 13);
            this.BeginLabel.TabIndex = 4;
            this.BeginLabel.Text = "From";
            // 
            // EndLabel
            // 
            this.EndLabel.Location = new System.Drawing.Point(263, 21);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(12, 13);
            this.EndLabel.TabIndex = 5;
            this.EndLabel.Text = "To";
            // 
            // PageNrLabel
            // 
            this.PageNrLabel.AutoSize = true;
            this.PageNrLabel.Location = new System.Drawing.Point(336, 21);
            this.PageNrLabel.Name = "PageNrLabel";
            this.PageNrLabel.Size = new System.Drawing.Size(45, 13);
            this.PageNrLabel.TabIndex = 6;
            this.PageNrLabel.Text = "Page Nr";
            // 
            // PageNumberComboBox
            // 
            this.PageNumberComboBox.Location = new System.Drawing.Point(387, 18);
            this.PageNumberComboBox.Name = "PageNumberComboBox";
            this.PageNumberComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PageNumberComboBox.Size = new System.Drawing.Size(31, 20);
            this.PageNumberComboBox.TabIndex = 7;
            // 
            // PagingToolBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PageNumberComboBox);
            this.Controls.Add(this.PageNrLabel);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.BeginLabel);
            this.Controls.Add(this.EndNumber);
            this.Controls.Add(this.StartNumber);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BackButton);
            this.Name = "PagingToolBar";
            this.Size = new System.Drawing.Size(442, 55);
            ((System.ComponentModel.ISupportInitialize)(this.StartNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageNumberComboBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BackButton;
        private DevExpress.XtraEditors.SimpleButton NextButton;
        private DevExpress.XtraEditors.ComboBoxEdit StartNumber;
        private DevExpress.XtraEditors.ComboBoxEdit EndNumber;
        private DevExpress.XtraEditors.LabelControl BeginLabel;
        private DevExpress.XtraEditors.LabelControl EndLabel;
        private System.Windows.Forms.Label PageNrLabel;
        private DevExpress.XtraEditors.ComboBoxEdit PageNumberComboBox;
    }
}
