namespace MicaAplicatie
{
    partial class StudentListWindow
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
            this.ReturnToAdminPannelBUtton = new DevExpress.XtraEditors.SimpleButton();
            this.StudentList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FirstNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Faculty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FacultyStartYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.EventListControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.eventTypes_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.perioada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Departament = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Task = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remarks = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventListControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnToAdminPannelBUtton
            // 
            this.ReturnToAdminPannelBUtton.Location = new System.Drawing.Point(347, 510);
            this.ReturnToAdminPannelBUtton.Name = "ReturnToAdminPannelBUtton";
            this.ReturnToAdminPannelBUtton.Size = new System.Drawing.Size(75, 23);
            this.ReturnToAdminPannelBUtton.TabIndex = 0;
            this.ReturnToAdminPannelBUtton.Text = "Return";
            this.ReturnToAdminPannelBUtton.Click += new System.EventHandler(this.ReturnToAdminPannelButton_Click);
            // 
            // StudentList
            // 
            this.StudentList.Location = new System.Drawing.Point(0, 0);
            this.StudentList.MainView = this.gridView1;
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(735, 451);
            this.StudentList.TabIndex = 1;
            this.StudentList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.StudentList.Click += new System.EventHandler(this.StudentList_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirstNameColumn,
            this.LastNameColumn,
            this.Email,
            this.PhoneNumber,
            this.Gender,
            this.Faculty,
            this.FacultyStartYear,
            this.BirthDate});
            this.gridView1.GridControl = this.StudentList;
            this.gridView1.Name = "gridView1";
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.Caption = "First Name";
            this.FirstNameColumn.FieldName = "FirstName";
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.Visible = true;
            this.FirstNameColumn.VisibleIndex = 0;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.Caption = "Last Name";
            this.LastNameColumn.FieldName = "LastName";
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.Visible = true;
            this.LastNameColumn.VisibleIndex = 1;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 2;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Caption = "Phone No";
            this.PhoneNumber.FieldName = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Visible = true;
            this.PhoneNumber.VisibleIndex = 3;
            // 
            // Gender
            // 
            this.Gender.Caption = "Gender";
            this.Gender.FieldName = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.Visible = true;
            this.Gender.VisibleIndex = 4;
            // 
            // Faculty
            // 
            this.Faculty.Caption = "Faculty";
            this.Faculty.FieldName = "Faculty";
            this.Faculty.Name = "Faculty";
            this.Faculty.Visible = true;
            this.Faculty.VisibleIndex = 5;
            // 
            // FacultyStartYear
            // 
            this.FacultyStartYear.Caption = "Start Year";
            this.FacultyStartYear.FieldName = "FacultyStartYear";
            this.FacultyStartYear.Name = "FacultyStartYear";
            this.FacultyStartYear.Visible = true;
            this.FacultyStartYear.VisibleIndex = 6;
            // 
            // BirthDate
            // 
            this.BirthDate.Caption = "Birthdate";
            this.BirthDate.FieldName = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Visible = true;
            this.BirthDate.VisibleIndex = 7;
            // 
            // TabControl
            // 
            this.TabControl.Location = new System.Drawing.Point(13, 13);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.xtraTabPage1;
            this.TabControl.Size = new System.Drawing.Size(741, 479);
            this.TabControl.TabIndex = 2;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.StudentList);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(735, 451);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.EventListControl);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(735, 451);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // EventListControl
            // 
            this.EventListControl.Location = new System.Drawing.Point(0, 0);
            this.EventListControl.MainView = this.gridView2;
            this.EventListControl.Name = "EventListControl";
            this.EventListControl.Size = new System.Drawing.Size(735, 451);
            this.EventListControl.TabIndex = 0;
            this.EventListControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.eventTypes_ID,
            this.perioada,
            this.Departament,
            this.Task,
            this.Remarks});
            this.gridView2.GridControl = this.EventListControl;
            this.gridView2.Name = "gridView2";
            // 
            // eventTypes_ID
            // 
            this.eventTypes_ID.Caption = "Event Description";
            this.eventTypes_ID.Name = "eventTypes_ID";
            this.eventTypes_ID.Visible = true;
            this.eventTypes_ID.VisibleIndex = 0;
            // 
            // perioada
            // 
            this.perioada.Caption = "Period";
            this.perioada.Name = "perioada";
            this.perioada.Visible = true;
            this.perioada.VisibleIndex = 1;
            // 
            // Departament
            // 
            this.Departament.Caption = "Department";
            this.Departament.Name = "Departament";
            this.Departament.Visible = true;
            this.Departament.VisibleIndex = 2;
            // 
            // Task
            // 
            this.Task.Caption = "Task";
            this.Task.Name = "Task";
            this.Task.Visible = true;
            this.Task.VisibleIndex = 3;
            // 
            // Remarks
            // 
            this.Remarks.Caption = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.Visible = true;
            this.Remarks.VisibleIndex = 4;
            // 
            // StudentListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 557);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.ReturnToAdminPannelBUtton);
            this.Name = "StudentListWindow";
            this.Text = "Student List";
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EventListControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ReturnToAdminPannelBUtton;
        private DevExpress.XtraGrid.GridControl StudentList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn FirstNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn LastNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn Gender;
        private DevExpress.XtraGrid.Columns.GridColumn Faculty;
        private DevExpress.XtraGrid.Columns.GridColumn FacultyStartYear;
        private DevExpress.XtraGrid.Columns.GridColumn BirthDate;
        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl EventListControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn eventTypes_ID;
        private DevExpress.XtraGrid.Columns.GridColumn perioada;
        private DevExpress.XtraGrid.Columns.GridColumn Departament;
        private DevExpress.XtraGrid.Columns.GridColumn Task;
        private DevExpress.XtraGrid.Columns.GridColumn Remarks;
    }
}