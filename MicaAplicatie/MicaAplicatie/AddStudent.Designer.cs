namespace MicaAplicatie
{
    partial class AddStudent
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
            this.SaveStudentButton = new DevExpress.XtraEditors.SimpleButton();
            this.ReturnToAdminPannelButton = new DevExpress.XtraEditors.SimpleButton();
            this.FirstNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.FstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.GenderLabel = new DevExpress.XtraEditors.LabelControl();
            this.LastNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.GenderDropDownButton = new DevExpress.XtraEditors.DropDownButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemColorEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BirthDateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhoneNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FacultyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FacultyStartYearTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailLabel = new DevExpress.XtraEditors.LabelControl();
            this.PhoneNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.FacultyLabel = new DevExpress.XtraEditors.LabelControl();
            this.FacultyStartYearLabel = new DevExpress.XtraEditors.LabelControl();
            this.EventTypeLabel = new DevExpress.XtraEditors.LabelControl();
            this.EventTypeDropDownButton = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.FstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyStartYearTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveStudentButton
            // 
            this.SaveStudentButton.Location = new System.Drawing.Point(179, 340);
            this.SaveStudentButton.Name = "SaveStudentButton";
            this.SaveStudentButton.Size = new System.Drawing.Size(107, 30);
            this.SaveStudentButton.TabIndex = 0;
            this.SaveStudentButton.Text = "Save";
            this.SaveStudentButton.Click += new System.EventHandler(this.SaveStudentButton_Click);
            // 
            // ReturnToAdminPannelButton
            // 
            this.ReturnToAdminPannelButton.Location = new System.Drawing.Point(179, 376);
            this.ReturnToAdminPannelButton.Name = "ReturnToAdminPannelButton";
            this.ReturnToAdminPannelButton.Size = new System.Drawing.Size(107, 30);
            this.ReturnToAdminPannelButton.TabIndex = 1;
            this.ReturnToAdminPannelButton.Text = "Return";
            this.ReturnToAdminPannelButton.Click += new System.EventHandler(this.ReturnToAdminPannelButton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Location = new System.Drawing.Point(53, 66);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(51, 13);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FstNameTextEdit
            // 
            this.FstNameTextEdit.Location = new System.Drawing.Point(153, 59);
            this.FstNameTextEdit.Name = "FstNameTextEdit";
            this.FstNameTextEdit.Size = new System.Drawing.Size(123, 20);
            this.FstNameTextEdit.TabIndex = 4;
            // 
            // LstNameTextEdit
            // 
            this.LstNameTextEdit.Location = new System.Drawing.Point(153, 89);
            this.LstNameTextEdit.Name = "LstNameTextEdit";
            this.LstNameTextEdit.Size = new System.Drawing.Size(123, 20);
            this.LstNameTextEdit.TabIndex = 5;
            // 
            // GenderLabel
            // 
            this.GenderLabel.Location = new System.Drawing.Point(53, 124);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(35, 13);
            this.GenderLabel.TabIndex = 7;
            this.GenderLabel.Text = "Gender";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(53, 96);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(50, 13);
            this.LastNameLabel.TabIndex = 9;
            this.LastNameLabel.Text = "Last Name";
            // 
            // GenderDropDownButton
            // 
            this.GenderDropDownButton.Location = new System.Drawing.Point(153, 115);
            this.GenderDropDownButton.Name = "GenderDropDownButton";
            this.GenderDropDownButton.Size = new System.Drawing.Size(123, 22);
            this.GenderDropDownButton.TabIndex = 10;
            this.GenderDropDownButton.Text = "choose gender...";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItem1});
            this.barManager1.MaxItemId = 1;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemColorEdit1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(457, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 427);
            this.barDockControlBottom.Size = new System.Drawing.Size(457, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 427);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(457, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 427);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemColorEdit1;
            this.barEditItem1.Id = 0;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemColorEdit1
            // 
            this.repositoryItemColorEdit1.AutoHeight = false;
            this.repositoryItemColorEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(53, 154);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Birthdate";
            // 
            // BirthDateTextEdit
            // 
            this.BirthDateTextEdit.Location = new System.Drawing.Point(153, 147);
            this.BirthDateTextEdit.MenuManager = this.barManager1;
            this.BirthDateTextEdit.Name = "BirthDateTextEdit";
            this.BirthDateTextEdit.Size = new System.Drawing.Size(94, 20);
            this.BirthDateTextEdit.TabIndex = 16;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.Location = new System.Drawing.Point(153, 174);
            this.EmailTextEdit.MenuManager = this.barManager1;
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(94, 20);
            this.EmailTextEdit.TabIndex = 17;
            // 
            // PhoneNumberTextEdit
            // 
            this.PhoneNumberTextEdit.Location = new System.Drawing.Point(153, 201);
            this.PhoneNumberTextEdit.MenuManager = this.barManager1;
            this.PhoneNumberTextEdit.Name = "PhoneNumberTextEdit";
            this.PhoneNumberTextEdit.Size = new System.Drawing.Size(94, 20);
            this.PhoneNumberTextEdit.TabIndex = 18;
            this.PhoneNumberTextEdit.UseWaitCursor = true;
            // 
            // FacultyTextEdit
            // 
            this.FacultyTextEdit.Location = new System.Drawing.Point(153, 228);
            this.FacultyTextEdit.MenuManager = this.barManager1;
            this.FacultyTextEdit.Name = "FacultyTextEdit";
            this.FacultyTextEdit.Size = new System.Drawing.Size(94, 20);
            this.FacultyTextEdit.TabIndex = 19;
            // 
            // FacultyStartYearTextEdit
            // 
            this.FacultyStartYearTextEdit.Location = new System.Drawing.Point(153, 255);
            this.FacultyStartYearTextEdit.MenuManager = this.barManager1;
            this.FacultyStartYearTextEdit.Name = "FacultyStartYearTextEdit";
            this.FacultyStartYearTextEdit.Size = new System.Drawing.Size(94, 20);
            this.FacultyStartYearTextEdit.TabIndex = 20;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Location = new System.Drawing.Point(53, 181);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(24, 13);
            this.EmailLabel.TabIndex = 21;
            this.EmailLabel.Text = "Email";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.Location = new System.Drawing.Point(53, 204);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(70, 13);
            this.PhoneNumberLabel.TabIndex = 22;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.Location = new System.Drawing.Point(53, 231);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(35, 13);
            this.FacultyLabel.TabIndex = 23;
            this.FacultyLabel.Text = "Faculty";
            // 
            // FacultyStartYearLabel
            // 
            this.FacultyStartYearLabel.Location = new System.Drawing.Point(53, 258);
            this.FacultyStartYearLabel.Name = "FacultyStartYearLabel";
            this.FacultyStartYearLabel.Size = new System.Drawing.Size(87, 13);
            this.FacultyStartYearLabel.TabIndex = 24;
            this.FacultyStartYearLabel.Text = "Faculty Start Year";
            // 
            // EventTypeLabel
            // 
            this.EventTypeLabel.Location = new System.Drawing.Point(53, 289);
            this.EventTypeLabel.Name = "EventTypeLabel";
            this.EventTypeLabel.Size = new System.Drawing.Size(28, 13);
            this.EventTypeLabel.TabIndex = 25;
            this.EventTypeLabel.Text = "Event";
            // 
            // EventTypeDropDownButton
            // 
            this.EventTypeDropDownButton.AllowDrop = true;
            this.EventTypeDropDownButton.Location = new System.Drawing.Point(153, 282);
            this.EventTypeDropDownButton.MenuManager = this.barManager1;
            this.EventTypeDropDownButton.Name = "EventTypeDropDownButton";
            this.EventTypeDropDownButton.Size = new System.Drawing.Size(135, 20);
            this.EventTypeDropDownButton.TabIndex = 26;
            this.EventTypeDropDownButton.Text = "choose event...";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 427);
            this.Controls.Add(this.EventTypeDropDownButton);
            this.Controls.Add(this.EventTypeLabel);
            this.Controls.Add(this.FacultyStartYearLabel);
            this.Controls.Add(this.FacultyLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.FacultyStartYearTextEdit);
            this.Controls.Add(this.FacultyTextEdit);
            this.Controls.Add(this.PhoneNumberTextEdit);
            this.Controls.Add(this.EmailTextEdit);
            this.Controls.Add(this.BirthDateTextEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.GenderDropDownButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.LstNameTextEdit);
            this.Controls.Add(this.FstNameTextEdit);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.ReturnToAdminPannelButton);
            this.Controls.Add(this.SaveStudentButton);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "AddStudent";
            this.Text = "New Student Entry";
            ((System.ComponentModel.ISupportInitialize)(this.FstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthDateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyStartYearTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SaveStudentButton;
        private DevExpress.XtraEditors.SimpleButton ReturnToAdminPannelButton;
        private DevExpress.XtraEditors.LabelControl FirstNameLabel;
        private DevExpress.XtraEditors.TextEdit FstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit LstNameTextEdit;
        private DevExpress.XtraEditors.LabelControl GenderLabel;
        private DevExpress.XtraEditors.LabelControl LastNameLabel;
        private DevExpress.XtraEditors.DropDownButton GenderDropDownButton;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorEdit repositoryItemColorEdit1;
        private DevExpress.XtraEditors.LabelControl EmailLabel;
        private DevExpress.XtraEditors.TextEdit FacultyStartYearTextEdit;
        private DevExpress.XtraEditors.TextEdit FacultyTextEdit;
        private DevExpress.XtraEditors.TextEdit PhoneNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit BirthDateTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl FacultyStartYearLabel;
        private DevExpress.XtraEditors.LabelControl FacultyLabel;
        private DevExpress.XtraEditors.LabelControl PhoneNumberLabel;
        private DevExpress.XtraEditors.DropDownButton EventTypeDropDownButton;
        private DevExpress.XtraEditors.LabelControl EventTypeLabel;
    }
}