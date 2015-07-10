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
            this.eventTypeName = new DevExpress.XtraEditors.TextEdit();
            this.DepartamentComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PeriodDate = new DevExpress.XtraEditors.DateEdit();
            this.TaskLabel = new DevExpress.XtraEditors.LabelControl();
            this.periodLabel = new DevExpress.XtraEditors.LabelControl();
            this.DepartamentLabel = new DevExpress.XtraEditors.LabelControl();
            this.RemarksLabel = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.TaskTextArea = new DevExpress.XtraEditors.MemoEdit();
            this.RemarksTextArea = new DevExpress.XtraEditors.MemoEdit();
            eventTypeIDLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskTextArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextArea.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // eventTypeIDLabel
            // 
            eventTypeIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            eventTypeIDLabel.Location = new System.Drawing.Point(47, 134);
            eventTypeIDLabel.Name = "eventTypeIDLabel";
            eventTypeIDLabel.Size = new System.Drawing.Size(58, 13);
            eventTypeIDLabel.TabIndex = 16;
            eventTypeIDLabel.Text = "Event Name";
            eventTypeIDLabel.Click += new System.EventHandler(this.eventTypeIDLabel_Click);
            // 
            // SaveEventButton
            // 
            this.SaveEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveEventButton.Location = new System.Drawing.Point(47, 517);
            this.SaveEventButton.Name = "SaveEventButton";
            this.SaveEventButton.Size = new System.Drawing.Size(122, 23);
            this.SaveEventButton.TabIndex = 0;
            this.SaveEventButton.Text = "Save";
            this.SaveEventButton.Click += new System.EventHandler(this.SaveEventButton_Click);
            // 
            // eventTypeName
            // 
            this.eventTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.eventTypeName.Location = new System.Drawing.Point(262, 131);
            this.eventTypeName.Name = "eventTypeName";
            this.eventTypeName.Size = new System.Drawing.Size(156, 20);
            this.eventTypeName.TabIndex = 1;
            this.eventTypeName.EditValueChanged += new System.EventHandler(this.eventTypeID_EditValueChanged);
            // 
            // DepartamentComboBox
            // 
            this.DepartamentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartamentComboBox.Location = new System.Drawing.Point(262, 333);
            this.DepartamentComboBox.Name = "DepartamentComboBox";
            this.DepartamentComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DepartamentComboBox.Size = new System.Drawing.Size(156, 20);
            this.DepartamentComboBox.TabIndex = 4;
            // 
            // PeriodDate
            // 
            this.PeriodDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodDate.EditValue = null;
            this.PeriodDate.Location = new System.Drawing.Point(262, 291);
            this.PeriodDate.Name = "PeriodDate";
            this.PeriodDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PeriodDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PeriodDate.Size = new System.Drawing.Size(156, 20);
            this.PeriodDate.TabIndex = 3;
            // 
            // TaskLabel
            // 
            this.TaskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskLabel.Location = new System.Drawing.Point(47, 214);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(22, 13);
            this.TaskLabel.TabIndex = 17;
            this.TaskLabel.Text = "Task";
            // 
            // periodLabel
            // 
            this.periodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.periodLabel.Location = new System.Drawing.Point(47, 294);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(30, 13);
            this.periodLabel.TabIndex = 18;
            this.periodLabel.Text = "Period";
            // 
            // DepartamentLabel
            // 
            this.DepartamentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartamentLabel.Location = new System.Drawing.Point(47, 336);
            this.DepartamentLabel.Name = "DepartamentLabel";
            this.DepartamentLabel.Size = new System.Drawing.Size(63, 13);
            this.DepartamentLabel.TabIndex = 19;
            this.DepartamentLabel.Text = "Departament";
            // 
            // RemarksLabel
            // 
            this.RemarksLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemarksLabel.Location = new System.Drawing.Point(47, 403);
            this.RemarksLabel.Name = "RemarksLabel";
            this.RemarksLabel.Size = new System.Drawing.Size(41, 13);
            this.RemarksLabel.TabIndex = 20;
            this.RemarksLabel.Text = "Remarks";
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
            // TaskTextArea
            // 
            this.TaskTextArea.Location = new System.Drawing.Point(262, 172);
            this.TaskTextArea.Name = "TaskTextArea";
            this.TaskTextArea.Size = new System.Drawing.Size(156, 96);
            this.TaskTextArea.TabIndex = 2;
            // 
            // RemarksTextArea
            // 
            this.RemarksTextArea.Location = new System.Drawing.Point(262, 370);
            this.RemarksTextArea.Name = "RemarksTextArea";
            this.RemarksTextArea.Size = new System.Drawing.Size(156, 85);
            this.RemarksTextArea.TabIndex = 5;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 562);
            this.Controls.Add(this.RemarksTextArea);
            this.Controls.Add(this.TaskTextArea);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.RemarksLabel);
            this.Controls.Add(this.DepartamentLabel);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(eventTypeIDLabel);
            this.Controls.Add(this.PeriodDate);
            this.Controls.Add(this.DepartamentComboBox);
            this.Controls.Add(this.eventTypeName);
            this.Controls.Add(this.SaveEventButton);
            this.Name = "AddEventForm";
            this.Text = "Add Event";
            this.Load += new System.EventHandler(this.AddEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskTextArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextArea.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SaveEventButton;
        private DevExpress.XtraEditors.TextEdit eventTypeName;
        private DevExpress.XtraEditors.ComboBoxEdit DepartamentComboBox;
        private DevExpress.XtraEditors.DateEdit PeriodDate;
        private DevExpress.XtraEditors.LabelControl TaskLabel;
        private DevExpress.XtraEditors.LabelControl periodLabel;
        private DevExpress.XtraEditors.LabelControl DepartamentLabel;
        private DevExpress.XtraEditors.LabelControl RemarksLabel;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.MemoEdit TaskTextArea;
        private DevExpress.XtraEditors.MemoEdit RemarksTextArea;
    }
}