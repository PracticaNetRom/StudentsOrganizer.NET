namespace StudentOrganizer.GUI
{
    partial class AddStudentForm
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
            this.FirstNameTextField = new DevExpress.XtraEditors.TextEdit();
            this.FistNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.phoneNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.PhoneNumberTextField = new DevExpress.XtraEditors.TextEdit();
            this.emailLabel = new DevExpress.XtraEditors.LabelControl();
            this.EmailTextField = new DevExpress.XtraEditors.TextEdit();
            this.lastNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.LastNameTextField = new DevExpress.XtraEditors.TextEdit();
            this.GenderLabel = new DevExpress.XtraEditors.LabelControl();
            this.FacultyLabel = new DevExpress.XtraEditors.LabelControl();
            this.BirthLabel = new DevExpress.XtraEditors.LabelControl();
            this.FacultyStartLabel = new DevExpress.XtraEditors.LabelControl();
            this.FacultyComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.FacultyStartComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.SaveStudentButton = new DevExpress.XtraEditors.SimpleButton();
            this.BirthTimeEdit = new DevExpress.XtraEditors.DateEdit();
            this.eventListCheckBox = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.eventListCheck = new DevExpress.XtraEditors.LabelControl();
            this.GenderComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyStartComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthTimeEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventListCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameTextField
            // 
            this.FirstNameTextField.Location = new System.Drawing.Point(220, 121);
            this.FirstNameTextField.Name = "FirstNameTextField";
            this.FirstNameTextField.Size = new System.Drawing.Size(138, 20);
            this.FirstNameTextField.TabIndex = 0;
            // 
            // FistNameLabel
            // 
            this.FistNameLabel.Location = new System.Drawing.Point(75, 124);
            this.FistNameLabel.Name = "FistNameLabel";
            this.FistNameLabel.Size = new System.Drawing.Size(51, 13);
            this.FistNameLabel.TabIndex = 1;
            this.FistNameLabel.Text = "First Name";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Location = new System.Drawing.Point(75, 299);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(70, 13);
            this.phoneNumberLabel.TabIndex = 12;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // PhoneNumberTextField
            // 
            this.PhoneNumberTextField.Location = new System.Drawing.Point(220, 296);
            this.PhoneNumberTextField.Name = "PhoneNumberTextField";
            this.PhoneNumberTextField.Properties.Mask.EditMask = "(+00)00-000-0000";
            this.PhoneNumberTextField.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.PhoneNumberTextField.Properties.Mask.PlaceHolder = '0';
            this.PhoneNumberTextField.Size = new System.Drawing.Size(138, 20);
            this.PhoneNumberTextField.TabIndex = 11;
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(75, 258);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(24, 13);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email";
            // 
            // EmailTextField
            // 
            this.EmailTextField.Location = new System.Drawing.Point(220, 255);
            this.EmailTextField.Name = "EmailTextField";
            this.EmailTextField.Size = new System.Drawing.Size(138, 20);
            this.EmailTextField.TabIndex = 9;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(76, 155);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(50, 13);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // LastNameTextField
            // 
            this.LastNameTextField.Location = new System.Drawing.Point(220, 152);
            this.LastNameTextField.Name = "LastNameTextField";
            this.LastNameTextField.Size = new System.Drawing.Size(138, 20);
            this.LastNameTextField.TabIndex = 2;
            // 
            // GenderLabel
            // 
            this.GenderLabel.Location = new System.Drawing.Point(75, 185);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(35, 13);
            this.GenderLabel.TabIndex = 6;
            this.GenderLabel.Text = "Gender";
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.Location = new System.Drawing.Point(75, 344);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(35, 13);
            this.FacultyLabel.TabIndex = 14;
            this.FacultyLabel.Text = "Faculty";
            // 
            // BirthLabel
            // 
            this.BirthLabel.Location = new System.Drawing.Point(75, 222);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(48, 13);
            this.BirthLabel.TabIndex = 8;
            this.BirthLabel.Text = "Brith Date";
            // 
            // FacultyStartLabel
            // 
            this.FacultyStartLabel.Location = new System.Drawing.Point(75, 393);
            this.FacultyStartLabel.Name = "FacultyStartLabel";
            this.FacultyStartLabel.Size = new System.Drawing.Size(87, 13);
            this.FacultyStartLabel.TabIndex = 16;
            this.FacultyStartLabel.Text = "Faculty Start Year";
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.Location = new System.Drawing.Point(220, 341);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FacultyComboBox.Size = new System.Drawing.Size(138, 20);
            this.FacultyComboBox.TabIndex = 13;
            // 
            // FacultyStartComboBox
            // 
            this.FacultyStartComboBox.Location = new System.Drawing.Point(220, 386);
            this.FacultyStartComboBox.Name = "FacultyStartComboBox";
            this.FacultyStartComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FacultyStartComboBox.Size = new System.Drawing.Size(138, 20);
            this.FacultyStartComboBox.TabIndex = 15;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::StudentOrganizer.GUI.Properties.Resources._9551269341017sigla3;
            this.pictureEdit1.Location = new System.Drawing.Point(26, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 20;
            // 
            // SaveStudentButton
            // 
            this.SaveStudentButton.Location = new System.Drawing.Point(75, 511);
            this.SaveStudentButton.Name = "SaveStudentButton";
            this.SaveStudentButton.Size = new System.Drawing.Size(75, 23);
            this.SaveStudentButton.TabIndex = 19;
            this.SaveStudentButton.Text = "Save";
            this.SaveStudentButton.Click += new System.EventHandler(this.SaveStudentButton_Click);
            // 
            // BirthTimeEdit
            // 
            this.BirthTimeEdit.EditValue = null;
            this.BirthTimeEdit.Location = new System.Drawing.Point(220, 221);
            this.BirthTimeEdit.Name = "BirthTimeEdit";
            this.BirthTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BirthTimeEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BirthTimeEdit.Size = new System.Drawing.Size(137, 20);
            this.BirthTimeEdit.TabIndex = 7;
            // 
            // eventListCheckBox
            // 
            this.eventListCheckBox.Location = new System.Drawing.Point(220, 425);
            this.eventListCheckBox.Name = "eventListCheckBox";
            this.eventListCheckBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.eventListCheckBox.Size = new System.Drawing.Size(137, 20);
            this.eventListCheckBox.TabIndex = 17;
            // 
            // eventListCheck
            // 
            this.eventListCheck.Location = new System.Drawing.Point(75, 428);
            this.eventListCheck.Name = "eventListCheck";
            this.eventListCheck.Size = new System.Drawing.Size(70, 13);
            this.eventListCheck.TabIndex = 18;
            this.eventListCheck.Text = "Participates At";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Location = new System.Drawing.Point(220, 182);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GenderComboBox.Size = new System.Drawing.Size(137, 20);
            this.GenderComboBox.TabIndex = 5;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 564);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.eventListCheck);
            this.Controls.Add(this.eventListCheckBox);
            this.Controls.Add(this.BirthTimeEdit);
            this.Controls.Add(this.SaveStudentButton);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.FacultyStartComboBox);
            this.Controls.Add(this.FacultyComboBox);
            this.Controls.Add(this.FacultyStartLabel);
            this.Controls.Add(this.BirthLabel);
            this.Controls.Add(this.FacultyLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.LastNameTextField);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.EmailTextField);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.PhoneNumberTextField);
            this.Controls.Add(this.FistNameLabel);
            this.Controls.Add(this.FirstNameTextField);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyStartComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthTimeEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventListCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderComboBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit FirstNameTextField;
        private DevExpress.XtraEditors.LabelControl FistNameLabel;
        private DevExpress.XtraEditors.LabelControl phoneNumberLabel;
        private DevExpress.XtraEditors.TextEdit PhoneNumberTextField;
        private DevExpress.XtraEditors.LabelControl emailLabel;
        private DevExpress.XtraEditors.TextEdit EmailTextField;
        private DevExpress.XtraEditors.LabelControl lastNameLabel;
        private DevExpress.XtraEditors.TextEdit LastNameTextField;
        private DevExpress.XtraEditors.LabelControl GenderLabel;
        private DevExpress.XtraEditors.LabelControl FacultyLabel;
        private DevExpress.XtraEditors.LabelControl BirthLabel;
        private DevExpress.XtraEditors.LabelControl FacultyStartLabel;
        private DevExpress.XtraEditors.ComboBoxEdit FacultyComboBox;
        private DevExpress.XtraEditors.ComboBoxEdit FacultyStartComboBox;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton SaveStudentButton;
        private DevExpress.XtraEditors.DateEdit BirthTimeEdit;
        private DevExpress.XtraEditors.CheckedComboBoxEdit eventListCheckBox;
        private DevExpress.XtraEditors.LabelControl eventListCheck;
        private DevExpress.XtraEditors.ComboBoxEdit GenderComboBox;
    }
}