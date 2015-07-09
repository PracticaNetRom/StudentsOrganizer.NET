namespace StudentOrganizer.GUI
{
    partial class AddEventForm
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
            DevExpress.XtraEditors.LabelControl eventTypeIDLabel;
            this.SaveEventButton = new DevExpress.XtraEditors.SimpleButton();
            this.eventTypeID = new DevExpress.XtraEditors.TextEdit();
            this.TaskTextBox = new DevExpress.XtraEditors.TextEdit();
            this.DepartamentComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PeriodDate = new DevExpress.XtraEditors.DateEdit();
            this.TaskLabel = new DevExpress.XtraEditors.LabelControl();
            this.periodLabel = new DevExpress.XtraEditors.LabelControl();
            this.DepartamentLabel = new DevExpress.XtraEditors.LabelControl();
            this.RemarksLabel = new DevExpress.XtraEditors.LabelControl();
            this.RemarksTextBox = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            eventTypeIDLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveEventButton
            // 
            this.SaveEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveEventButton.Location = new System.Drawing.Point(43, 366);
            this.SaveEventButton.Name = "SaveEventButton";
            this.SaveEventButton.Size = new System.Drawing.Size(95, 23);
            this.SaveEventButton.TabIndex = 0;
            this.SaveEventButton.Text = "Save";
            this.SaveEventButton.Click += new System.EventHandler(this.SaveEventButton_Click);
            // 
            // eventTypeID
            // 
            this.eventTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.eventTypeID.Location = new System.Drawing.Point(183, 127);
            this.eventTypeID.Name = "eventTypeID";
            this.eventTypeID.Size = new System.Drawing.Size(128, 20);
            this.eventTypeID.TabIndex = 1;
            // 
            // TaskTextBox
            // 
            this.TaskTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskTextBox.Location = new System.Drawing.Point(183, 171);
            this.TaskTextBox.Name = "TaskTextBox";
            this.TaskTextBox.Size = new System.Drawing.Size(128, 20);
            this.TaskTextBox.TabIndex = 2;
            // 
            // DepartamentComboBox
            // 
            this.DepartamentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartamentComboBox.Location = new System.Drawing.Point(183, 252);
            this.DepartamentComboBox.Name = "DepartamentComboBox";
            this.DepartamentComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DepartamentComboBox.Size = new System.Drawing.Size(128, 20);
            this.DepartamentComboBox.TabIndex = 14;
            // 
            // PeriodDate
            // 
            this.PeriodDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodDate.EditValue = null;
            this.PeriodDate.Location = new System.Drawing.Point(183, 210);
            this.PeriodDate.Name = "PeriodDate";
            this.PeriodDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PeriodDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PeriodDate.Size = new System.Drawing.Size(128, 20);
            this.PeriodDate.TabIndex = 15;
            // 
            // eventTypeIDLabel
            // 
            eventTypeIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            eventTypeIDLabel.Location = new System.Drawing.Point(47, 130);
            eventTypeIDLabel.Name = "eventTypeIDLabel";
            eventTypeIDLabel.Size = new System.Drawing.Size(69, 13);
            eventTypeIDLabel.TabIndex = 16;
            eventTypeIDLabel.Text = "Event Type ID";
            // 
            // TaskLabel
            // 
            this.TaskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskLabel.Location = new System.Drawing.Point(47, 174);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(22, 13);
            this.TaskLabel.TabIndex = 17;
            this.TaskLabel.Text = "Task";
            // 
            // periodLabel
            // 
            this.periodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.periodLabel.Location = new System.Drawing.Point(47, 213);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(30, 13);
            this.periodLabel.TabIndex = 18;
            this.periodLabel.Text = "Period";
            // 
            // DepartamentLabel
            // 
            this.DepartamentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartamentLabel.Location = new System.Drawing.Point(47, 255);
            this.DepartamentLabel.Name = "DepartamentLabel";
            this.DepartamentLabel.Size = new System.Drawing.Size(63, 13);
            this.DepartamentLabel.TabIndex = 19;
            this.DepartamentLabel.Text = "Departament";
            // 
            // RemarksLabel
            // 
            this.RemarksLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemarksLabel.Location = new System.Drawing.Point(47, 291);
            this.RemarksLabel.Name = "RemarksLabel";
            this.RemarksLabel.Size = new System.Drawing.Size(41, 13);
            this.RemarksLabel.TabIndex = 20;
            this.RemarksLabel.Text = "Remarks";
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemarksTextBox.Location = new System.Drawing.Point(183, 288);
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.Size = new System.Drawing.Size(128, 20);
            this.RemarksTextBox.TabIndex = 21;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::StudentOrganizer.GUI.Properties.Resources._9551269341017sigla3;
            this.pictureEdit1.Location = new System.Drawing.Point(20, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(118, 86);
            this.pictureEdit1.TabIndex = 22;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 401);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.RemarksTextBox);
            this.Controls.Add(this.RemarksLabel);
            this.Controls.Add(this.DepartamentLabel);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(eventTypeIDLabel);
            this.Controls.Add(this.PeriodDate);
            this.Controls.Add(this.DepartamentComboBox);
            this.Controls.Add(this.TaskTextBox);
            this.Controls.Add(this.eventTypeID);
            this.Controls.Add(this.SaveEventButton);
            this.Name = "AddEventForm";
            this.Text = "Add Event";
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SaveEventButton;
        private DevExpress.XtraEditors.TextEdit eventTypeID;
        private DevExpress.XtraEditors.TextEdit TaskTextBox;
        private DevExpress.XtraEditors.ComboBoxEdit DepartamentComboBox;
        private DevExpress.XtraEditors.DateEdit PeriodDate;
        private DevExpress.XtraEditors.LabelControl TaskLabel;
        private DevExpress.XtraEditors.LabelControl periodLabel;
        private DevExpress.XtraEditors.LabelControl DepartamentLabel;
        private DevExpress.XtraEditors.LabelControl RemarksLabel;
        private DevExpress.XtraEditors.TextEdit RemarksTextBox;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}