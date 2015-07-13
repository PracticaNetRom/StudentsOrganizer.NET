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
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentControl1)).BeginInit();
            this.StudentControl1.SuspendLayout();
            this.StudentPage1.SuspendLayout();
            this.EventsPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students List";
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(38, 107);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(101, 23);
            this.btnCreateNew.TabIndex = 1;
            this.btnCreateNew.Text = "Create New";
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(654, 319);
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
            this.btnDelete.Location = new System.Drawing.Point(173, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(303, 107);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(38, 157);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Edit";
            this.simpleButton1.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FilterBox
            // 
            this.FilterBox.Location = new System.Drawing.Point(537, 109);
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
            this.gridControl2.Location = new System.Drawing.Point(69, 103);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(400, 200);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 750);
            this.Controls.Add(this.StudentControl1);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}