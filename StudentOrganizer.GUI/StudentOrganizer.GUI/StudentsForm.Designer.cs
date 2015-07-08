namespace StudentOrganizer.GUI
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(12, 125);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(94, 25);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create New";
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
            this.GridControl.Location = new System.Drawing.Point(12, 186);
            this.GridControl.MainView = this.gridView1;
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(759, 316);
            this.GridControl.TabIndex = 3;
            this.GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 525);
            this.Controls.Add(this.GridControl);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.createButton);
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

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


    }
}