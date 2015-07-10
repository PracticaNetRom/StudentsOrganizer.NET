﻿namespace StudentOrganizer.GUI
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.createButton = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Faculty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FacutyStartYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Action = new DevExpress.XtraGrid.Columns.GridColumn();
            this.createEventButton = new DevExpress.XtraEditors.SimpleButton();
            this.EditStudentButton = new DevExpress.XtraEditors.SimpleButton();
            this.TabControl = new DevExpress.XtraTab.XtraTabControl();
            this.StudentList = new DevExpress.XtraTab.XtraTabPage();
            this.EventList = new DevExpress.XtraTab.XtraTabPage();
            this.EventListControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EventTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Period = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Departament = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Task = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PeriodComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.StudentList.SuspendLayout();
            this.EventList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventListControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(12, 114);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(94, 25);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Add Student";
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 2;
            // 
            // GridControl
            // 
            this.GridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControl.Location = new System.Drawing.Point(4, 3);
            this.GridControl.MainView = this.gridView1;
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(765, 305);
            this.GridControl.TabIndex = 3;
            this.GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GridControl.Click += new System.EventHandler(this.GridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirstName,
            this.LastName,
            this.Gender,
            this.BirthDate,
            this.Email,
            this.PhoneNumber,
            this.Faculty,
            this.FacutyStartYear,
            this.Action});
            this.gridView1.GridControl = this.GridControl;
            this.gridView1.Name = "gridView1";
            // 
            // FirstName
            // 
            this.FirstName.Caption = "First Name";
            this.FirstName.FieldName = "firstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 0;
            // 
            // LastName
            // 
            this.LastName.Caption = "Last Name";
            this.LastName.FieldName = "lastName";
            this.LastName.Name = "LastName";
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 1;
            // 
            // Gender
            // 
            this.Gender.Caption = "Gender";
            this.Gender.FieldName = "gender";
            this.Gender.Name = "Gender";
            this.Gender.Visible = true;
            this.Gender.VisibleIndex = 2;
            // 
            // BirthDate
            // 
            this.BirthDate.Caption = "Birth Date";
            this.BirthDate.FieldName = "birthDate";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Visible = true;
            this.BirthDate.VisibleIndex = 3;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 4;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Caption = "Phone Number";
            this.PhoneNumber.FieldName = "phoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Visible = true;
            this.PhoneNumber.VisibleIndex = 5;
            // 
            // Faculty
            // 
            this.Faculty.Caption = "Faculty";
            this.Faculty.FieldName = "faculty";
            this.Faculty.Name = "Faculty";
            this.Faculty.Visible = true;
            this.Faculty.VisibleIndex = 6;
            // 
            // FacutyStartYear
            // 
            this.FacutyStartYear.Caption = "Faculty Start Year";
            this.FacutyStartYear.FieldName = "facultyStartYear";
            this.FacutyStartYear.Name = "FacutyStartYear";
            this.FacutyStartYear.Visible = true;
            this.FacutyStartYear.VisibleIndex = 7;
            // 
            // Action
            // 
            this.Action.Caption = "Actions";
            this.Action.Name = "Action";
            // 
            // createEventButton
            // 
            this.createEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createEventButton.Location = new System.Drawing.Point(143, 115);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(94, 24);
            this.createEventButton.TabIndex = 4;
            this.createEventButton.Text = "Add Event";
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // EditStudentButton
            // 
            this.EditStudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditStudentButton.Location = new System.Drawing.Point(12, 145);
            this.EditStudentButton.Name = "EditStudentButton";
            this.EditStudentButton.Size = new System.Drawing.Size(94, 25);
            this.EditStudentButton.TabIndex = 5;
            this.EditStudentButton.Text = "Edit Student";
            this.EditStudentButton.Click += new System.EventHandler(this.EditStudentButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Location = new System.Drawing.Point(12, 176);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.StudentList;
            this.TabControl.Size = new System.Drawing.Size(770, 339);
            this.TabControl.TabIndex = 6;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.StudentList,
            this.EventList});
            // 
            // StudentList
            // 
            this.StudentList.Controls.Add(this.GridControl);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(764, 311);
            this.StudentList.Text = "Studens List";
            // 
            // EventList
            // 
            this.EventList.Controls.Add(this.EventListControl);
            this.EventList.Name = "EventList";
            this.EventList.Size = new System.Drawing.Size(764, 311);
            this.EventList.Text = "Events List";
            // 
            // EventListControl
            // 
            this.EventListControl.Location = new System.Drawing.Point(3, 3);
            this.EventListControl.MainView = this.gridView2;
            this.EventListControl.Name = "EventListControl";
            this.EventListControl.Size = new System.Drawing.Size(755, 305);
            this.EventListControl.TabIndex = 7;
            this.EventListControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EventTypeID,
            this.Period,
            this.Departament,
            this.Task,
            this.Remarks});
            this.gridView2.GridControl = this.EventListControl;
            this.gridView2.Name = "gridView2";
            // 
            // EventTypeID
            // 
            this.EventTypeID.Caption = "EventTypeID";
            this.EventTypeID.FieldName = "eventTypes_ID";
            this.EventTypeID.Name = "EventTypeID";
            this.EventTypeID.Visible = true;
            this.EventTypeID.VisibleIndex = 0;
            // 
            // Period
            // 
            this.Period.Caption = "Period";
            this.Period.FieldName = "period";
            this.Period.Name = "Period";
            this.Period.Visible = true;
            this.Period.VisibleIndex = 1;
            // 
            // Departament
            // 
            this.Departament.Caption = "Departament";
            this.Departament.FieldName = "departament";
            this.Departament.Name = "Departament";
            this.Departament.Visible = true;
            this.Departament.VisibleIndex = 2;
            // 
            // Task
            // 
            this.Task.Caption = "Task";
            this.Task.FieldName = "task";
            this.Task.Name = "Task";
            this.Task.Visible = true;
            this.Task.VisibleIndex = 3;
            // 
            // Remarks
            // 
            this.Remarks.Caption = "Remarks";
            this.Remarks.FieldName = "remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.Visible = true;
            this.Remarks.VisibleIndex = 4;
            // 
            // PeriodComboBox
            // 
            this.PeriodComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodComboBox.Location = new System.Drawing.Point(434, 119);
            this.PeriodComboBox.Name = "PeriodComboBox";
            this.PeriodComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PeriodComboBox.Size = new System.Drawing.Size(94, 20);
            this.PeriodComboBox.TabIndex = 7;
            this.PeriodComboBox.SelectedIndexChanged += new System.EventHandler(this.PeriodComboBox_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(352, 122);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Select Period";
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 525);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.PeriodComboBox);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.EditStudentButton);
            this.Controls.Add(this.createEventButton);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.createButton);
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.StudentList.ResumeLayout(false);
            this.EventList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EventListControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodComboBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton createButton;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraGrid.GridControl GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn Gender;
        private DevExpress.XtraGrid.Columns.GridColumn BirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn Faculty;
        private DevExpress.XtraGrid.Columns.GridColumn FacutyStartYear;
        private DevExpress.XtraGrid.Columns.GridColumn Action;
        private DevExpress.XtraEditors.SimpleButton createEventButton;
        private DevExpress.XtraEditors.SimpleButton EditStudentButton;
        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraTab.XtraTabPage StudentList;
        private DevExpress.XtraTab.XtraTabPage EventList;
        private DevExpress.XtraGrid.GridControl EventListControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn EventTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn Period;
        private DevExpress.XtraGrid.Columns.GridColumn Departament;
        private DevExpress.XtraGrid.Columns.GridColumn Task;
        private DevExpress.XtraGrid.Columns.GridColumn Remarks;
        private DevExpress.XtraEditors.ComboBoxEdit PeriodComboBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;


    }
}