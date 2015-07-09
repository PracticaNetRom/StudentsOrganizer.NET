namespace StudentOrganizarFinalVersion
{
    partial class List
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.First_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Last_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Birth_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phone_Number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Faculty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Faculty_start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Event = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 35);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Create new";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // GridControl
            // 
            gridLevelNode1.RelationName = "Level1";
            this.GridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.GridControl.Location = new System.Drawing.Point(12, 74);
            this.GridControl.MainView = this.gridView1;
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(726, 368);
            this.GridControl.TabIndex = 2;
            this.GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.First_Name,
            this.Last_Name,
            this.Gender,
            this.Birth_Date,
            this.Email,
            this.Phone_Number,
            this.Faculty,
            this.Faculty_start,
            this.Event,
            this.ID});
            this.gridView1.GridControl = this.GridControl;
            this.gridView1.Name = "gridView1";
            // 
            // First_Name
            // 
            this.First_Name.Caption = "First Name";
            this.First_Name.Name = "First_Name";
            this.First_Name.Visible = true;
            this.First_Name.VisibleIndex = 1;
            // 
            // Last_Name
            // 
            this.Last_Name.Caption = "Last Name";
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Visible = true;
            this.Last_Name.VisibleIndex = 2;
            // 
            // Gender
            // 
            this.Gender.Caption = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.Visible = true;
            this.Gender.VisibleIndex = 3;
            // 
            // Birth_Date
            // 
            this.Birth_Date.Caption = "Birth Date";
            this.Birth_Date.Name = "Birth_Date";
            this.Birth_Date.Visible = true;
            this.Birth_Date.VisibleIndex = 4;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 5;
            // 
            // Phone_Number
            // 
            this.Phone_Number.Caption = "Phone Number";
            this.Phone_Number.Name = "Phone_Number";
            this.Phone_Number.Visible = true;
            this.Phone_Number.VisibleIndex = 6;
            // 
            // Faculty
            // 
            this.Faculty.Caption = "Faculty";
            this.Faculty.Name = "Faculty";
            this.Faculty.Visible = true;
            this.Faculty.VisibleIndex = 7;
            // 
            // Faculty_start
            // 
            this.Faculty_start.Caption = "Faculty start";
            this.Faculty_start.Name = "Faculty_start";
            this.Faculty_start.Visible = true;
            this.Faculty_start.VisibleIndex = 8;
            // 
            // Event
            // 
            this.Event.Caption = "Event";
            this.Event.Name = "Event";
            this.Event.Visible = true;
            this.Event.VisibleIndex = 9;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 442);
            this.Controls.Add(this.GridControl);
            this.Controls.Add(this.simpleButton1);
            this.Name = "List";
            this.Text = "List";
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn First_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Last_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Gender;
        private DevExpress.XtraGrid.Columns.GridColumn Birth_Date;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Phone_Number;
        private DevExpress.XtraGrid.Columns.GridColumn Faculty;
        private DevExpress.XtraGrid.Columns.GridColumn Faculty_start;
        private DevExpress.XtraGrid.Columns.GridColumn Event;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
    }
}