namespace Practica
{
    partial class Evidenta
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.TableQuery tableQuery1 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo1 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo1 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo2 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo3 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo4 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo5 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo6 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo7 = new DevExpress.DataAccess.Sql.ColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evidenta));
            DevExpress.DataAccess.Sql.TableQuery tableQuery2 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo2 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo8 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo9 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo10 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo11 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo12 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo13 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo14 = new DevExpress.DataAccess.Sql.ColumnInfo();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.data2 = new System.Windows.Forms.DateTimePicker();
            this.data1 = new System.Windows.Forms.DateTimePicker();
            this.nameText = new System.Windows.Forms.TextBox();
            this.LastText = new System.Windows.Forms.TextBox();
            this.genderText = new System.Windows.Forms.TextBox();
            this.facText = new System.Windows.Forms.TextBox();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.evidentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evidentaDataSet = new Practica.EvidentaDataSet();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.evidentaTableAdapter = new Practica.EvidentaDataSetTableAdapters.EvidentaTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaculty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacultyStartYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.ID = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.evidentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(100, 257);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Insert";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(400, 257);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Evenimente";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(47, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "First Name:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(47, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Last Name:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(47, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Gender";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(47, 134);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Birth Date:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(47, 163);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Faculty:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(47, 189);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Faculty Start:";
            // 
            // data2
            // 
            this.data2.Location = new System.Drawing.Point(143, 189);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(184, 20);
            this.data2.TabIndex = 16;
            // 
            // data1
            // 
            this.data1.Location = new System.Drawing.Point(143, 128);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(184, 20);
            this.data1.TabIndex = 17;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(143, 43);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 20;
            // 
            // LastText
            // 
            this.LastText.Location = new System.Drawing.Point(143, 74);
            this.LastText.Name = "LastText";
            this.LastText.Size = new System.Drawing.Size(100, 20);
            this.LastText.TabIndex = 21;
            // 
            // genderText
            // 
            this.genderText.Location = new System.Drawing.Point(143, 101);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(100, 20);
            this.genderText.TabIndex = 22;
            // 
            // facText
            // 
            this.facText.Location = new System.Drawing.Point(143, 160);
            this.facText.Name = "facText";
            this.facText.Size = new System.Drawing.Size(100, 20);
            this.facText.TabIndex = 23;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "snap.Evidenta.dbo";
            this.sqlDataSource1.Name = "sqlDataSource1";
            tableQuery1.Name = "Evidenta";
            tableInfo1.Name = "Evidenta";
            columnInfo1.Name = "ID";
            columnInfo2.Name = "FirstName";
            columnInfo3.Name = "LastName";
            columnInfo4.Name = "Gender";
            columnInfo5.Name = "BirthDate";
            columnInfo6.Name = "Faculty";
            columnInfo7.Name = "FacultyStartYear";
            tableInfo1.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo1,
            columnInfo2,
            columnInfo3,
            columnInfo4,
            columnInfo5,
            columnInfo6,
            columnInfo7});
            tableQuery1.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo1});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // evidentaBindingSource
            // 
            this.evidentaBindingSource.DataMember = "Evidenta";
            this.evidentaBindingSource.DataSource = this.evidentaDataSet;
            // 
            // evidentaDataSet
            // 
            this.evidentaDataSet.DataSetName = "EvidentaDataSet";
            this.evidentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "snap.Evidenta.dbo";
            this.sqlDataSource2.Name = "sqlDataSource2";
            tableQuery2.Name = "Evidenta";
            tableInfo2.Name = "Evidenta";
            columnInfo8.Name = "ID";
            columnInfo9.Name = "FirstName";
            columnInfo10.Name = "LastName";
            columnInfo11.Name = "Gender";
            columnInfo12.Name = "BirthDate";
            columnInfo13.Name = "Faculty";
            columnInfo14.Name = "FacultyStartYear";
            tableInfo2.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo8,
            columnInfo9,
            columnInfo10,
            columnInfo11,
            columnInfo12,
            columnInfo13,
            columnInfo14});
            tableQuery2.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo2});
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // evidentaTableAdapter
            // 
            this.evidentaTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.evidentaBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(399, 7);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 24;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFirstName,
            this.colLastName,
            this.colGender,
            this.colBirthDate,
            this.colFaculty,
            this.colFacultyStartYear,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 3;
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 4;
            // 
            // colFaculty
            // 
            this.colFaculty.FieldName = "Faculty";
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.Visible = true;
            this.colFaculty.VisibleIndex = 5;
            // 
            // colFacultyStartYear
            // 
            this.colFacultyStartYear.FieldName = "FacultyStartYear";
            this.colFacultyStartYear.Name = "colFacultyStartYear";
            this.colFacultyStartYear.Visible = true;
            this.colFacultyStartYear.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(603, 257);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 26;
            this.simpleButton3.Text = "Login";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(249, 257);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 27;
            this.simpleButton4.Text = "Delete";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(143, 12);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 29;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(47, 15);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(15, 13);
            this.labelControl7.TabIndex = 28;
            this.labelControl7.Text = "ID:";
            // 
            // Evidenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 334);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.facText);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.LastText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Evidenta";
            this.Text = "Evidenta";
            this.Load += new System.EventHandler(this.Evidenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evidentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DateTimePicker data2;
        private System.Windows.Forms.DateTimePicker data1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox LastText;
        private System.Windows.Forms.TextBox genderText;
        private System.Windows.Forms.TextBox facText;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private EvidentaDataSet evidentaDataSet;
        private System.Windows.Forms.BindingSource evidentaBindingSource;
        private EvidentaDataSetTableAdapters.EvidentaTableAdapter evidentaTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFaculty;
        private DevExpress.XtraGrid.Columns.GridColumn colFacultyStartYear;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.TextBox ID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}

