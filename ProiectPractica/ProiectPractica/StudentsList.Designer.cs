namespace ProiectPractica
{
    partial class StudentsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsList));
            this.btnCreateNew = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.FilterBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.StudentControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.StudentPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.EventsPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.periodLabel = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentControl1)).BeginInit();
            this.StudentControl1.SuspendLayout();
            this.StudentPage1.SuspendLayout();
            this.EventsPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(201, 26);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(87, 23);
            this.btnCreateNew.TabIndex = 1;
            this.btnCreateNew.Text = "Add Student";
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(879, 363);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(201, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(329, 87);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(329, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Edit Student";
            this.simpleButton1.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FilterBox
            // 
            this.FilterBox.Location = new System.Drawing.Point(751, 83);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FilterBox.Size = new System.Drawing.Size(100, 20);
            this.FilterBox.TabIndex = 7;
            this.FilterBox.SelectedIndexChanged += new System.EventHandler(this.FilterBox_SelectedIndexChanged);
            // 
            // StudentControl1
            // 
            this.StudentControl1.Location = new System.Drawing.Point(26, 207);
            this.StudentControl1.Name = "StudentControl1";
            this.StudentControl1.SelectedTabPage = this.StudentPage1;
            this.StudentControl1.Size = new System.Drawing.Size(885, 391);
            this.StudentControl1.TabIndex = 8;
            this.StudentControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.StudentPage1,
            this.EventsPage2});
            // 
            // StudentPage1
            // 
            this.StudentPage1.Controls.Add(this.gridControl1);
            this.StudentPage1.Name = "StudentPage1";
            this.StudentPage1.Size = new System.Drawing.Size(879, 363);
            this.StudentPage1.Text = "Students";
            // 
            // EventsPage2
            // 
            this.EventsPage2.Controls.Add(this.gridControl2);
            this.EventsPage2.Name = "EventsPage2";
            this.EventsPage2.Size = new System.Drawing.Size(879, 363);
            this.EventsPage2.Text = "Events";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(-1, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(880, 368);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // periodLabel
            // 
            this.periodLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodLabel.Location = new System.Drawing.Point(661, 87);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(69, 16);
            this.periodLabel.TabIndex = 9;
            this.periodLabel.Text = "Period Filter";
            this.periodLabel.Click += new System.EventHandler(this.periodLabel_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(27, 26);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(135, 153);
            this.pictureEdit1.TabIndex = 10;
            // 
            // StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 604);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.StudentControl1);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateNew);
            this.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "StudentsList";
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentControl1)).EndInit();
            this.StudentControl1.ResumeLayout(false);
            this.StudentPage1.ResumeLayout(false);
            this.EventsPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCreateNew;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit FilterBox;
        private DevExpress.XtraTab.XtraTabControl StudentControl1;
        private DevExpress.XtraTab.XtraTabPage StudentPage1;
        private DevExpress.XtraTab.XtraTabPage EventsPage2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl periodLabel;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}