namespace StudentOrganizer.GUI
{
    partial class EditStudentForm
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
            this.LastNameTextField = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextField = new DevExpress.XtraEditors.TextEdit();
            this.PhoneNumberTextField = new DevExpress.XtraEditors.TextEdit();
            this.BirthTimeEdit = new DevExpress.XtraEditors.DateEdit();
            this.FacultyStartComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.FacultyComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.SaveEditButton = new DevExpress.XtraEditors.SimpleButton();
            this.FirstNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.LastNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.GenderLabel = new DevExpress.XtraEditors.LabelControl();
            this.BirthLabel = new DevExpress.XtraEditors.LabelControl();
            this.EmailLabel = new DevExpress.XtraEditors.LabelControl();
            this.PhoneLabel = new DevExpress.XtraEditors.LabelControl();
            this.FacultyLabel = new DevExpress.XtraEditors.LabelControl();
            this.FacultyStartLabel = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.GenderComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthTimeEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyStartComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameTextField
            // 
            this.FirstNameTextField.Location = new System.Drawing.Point(232, 115);
            this.FirstNameTextField.Name = "FirstNameTextField";
            this.FirstNameTextField.Size = new System.Drawing.Size(139, 20);
            this.FirstNameTextField.TabIndex = 0;
            // 
            // LastNameTextField
            // 
            this.LastNameTextField.Location = new System.Drawing.Point(232, 146);
            this.LastNameTextField.Name = "LastNameTextField";
            this.LastNameTextField.Size = new System.Drawing.Size(138, 20);
            this.LastNameTextField.TabIndex = 1;
            // 
            // EmailTextField
            // 
            this.EmailTextField.Location = new System.Drawing.Point(232, 256);
            this.EmailTextField.Name = "EmailTextField";
            this.EmailTextField.Size = new System.Drawing.Size(137, 20);
            this.EmailTextField.TabIndex = 6;
            // 
            // PhoneNumberTextField
            // 
            this.PhoneNumberTextField.Location = new System.Drawing.Point(233, 291);
            this.PhoneNumberTextField.Name = "PhoneNumberTextField";
            this.PhoneNumberTextField.Properties.Mask.EditMask = "(+00)00-000-0000";
            this.PhoneNumberTextField.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.PhoneNumberTextField.Properties.Mask.PlaceHolder = '0';
            this.PhoneNumberTextField.Size = new System.Drawing.Size(137, 20);
            this.PhoneNumberTextField.TabIndex = 7;
            // 
            // BirthTimeEdit
            // 
            this.BirthTimeEdit.EditValue = null;
            this.BirthTimeEdit.Location = new System.Drawing.Point(232, 216);
            this.BirthTimeEdit.Name = "BirthTimeEdit";
            this.BirthTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BirthTimeEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BirthTimeEdit.Size = new System.Drawing.Size(137, 20);
            this.BirthTimeEdit.TabIndex = 5;
            // 
            // FacultyStartComboBox
            // 
            this.FacultyStartComboBox.Location = new System.Drawing.Point(233, 374);
            this.FacultyStartComboBox.Name = "FacultyStartComboBox";
            this.FacultyStartComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FacultyStartComboBox.Size = new System.Drawing.Size(138, 20);
            this.FacultyStartComboBox.TabIndex = 9;
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.Location = new System.Drawing.Point(233, 329);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FacultyComboBox.Size = new System.Drawing.Size(138, 20);
            this.FacultyComboBox.TabIndex = 8;
            // 
            // SaveEditButton
            // 
            this.SaveEditButton.Location = new System.Drawing.Point(66, 477);
            this.SaveEditButton.Name = "SaveEditButton";
            this.SaveEditButton.Size = new System.Drawing.Size(91, 27);
            this.SaveEditButton.TabIndex = 10;
            this.SaveEditButton.Text = "Save Changes";
            this.SaveEditButton.Click += new System.EventHandler(this.SaveEditButton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Location = new System.Drawing.Point(80, 118);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(51, 13);
            this.FirstNameLabel.TabIndex = 11;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(78, 149);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(50, 13);
            this.LastNameLabel.TabIndex = 12;
            this.LastNameLabel.Text = "Last Name";
            // 
            // GenderLabel
            // 
            this.GenderLabel.Location = new System.Drawing.Point(80, 179);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(35, 13);
            this.GenderLabel.TabIndex = 13;
            this.GenderLabel.Text = "Gender";
            // 
            // BirthLabel
            // 
            this.BirthLabel.Location = new System.Drawing.Point(80, 219);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(48, 13);
            this.BirthLabel.TabIndex = 14;
            this.BirthLabel.Text = "Birth Date";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Location = new System.Drawing.Point(80, 259);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(24, 13);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "Email";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Location = new System.Drawing.Point(80, 294);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(70, 13);
            this.PhoneLabel.TabIndex = 16;
            this.PhoneLabel.Text = "Phone Number";
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.Location = new System.Drawing.Point(80, 332);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(33, 13);
            this.FacultyLabel.TabIndex = 17;
            this.FacultyLabel.Text = "Facuty";
            // 
            // FacultyStartLabel
            // 
            this.FacultyStartLabel.Location = new System.Drawing.Point(80, 377);
            this.FacultyStartLabel.Name = "FacultyStartLabel";
            this.FacultyStartLabel.Size = new System.Drawing.Size(87, 13);
            this.FacultyStartLabel.TabIndex = 18;
            this.FacultyStartLabel.Text = "Faculty Start Year";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::StudentOrganizer.GUI.Properties.Resources._9551269341017sigla3;
            this.pictureEdit1.Location = new System.Drawing.Point(31, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 21;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Location = new System.Drawing.Point(232, 177);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GenderComboBox.Size = new System.Drawing.Size(137, 20);
            this.GenderComboBox.TabIndex = 4;
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 537);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.FacultyStartLabel);
            this.Controls.Add(this.FacultyLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.BirthLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.SaveEditButton);
            this.Controls.Add(this.FacultyStartComboBox);
            this.Controls.Add(this.FacultyComboBox);
            this.Controls.Add(this.BirthTimeEdit);
            this.Controls.Add(this.PhoneNumberTextField);
            this.Controls.Add(this.EmailTextField);
            this.Controls.Add(this.LastNameTextField);
            this.Controls.Add(this.FirstNameTextField);
            this.Name = "EditStudentForm";
            this.Text = "Edit Student";
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthTimeEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BirthTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyStartComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacultyComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderComboBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit FirstNameTextField;
        private DevExpress.XtraEditors.TextEdit LastNameTextField;
        private DevExpress.XtraEditors.TextEdit EmailTextField;
        private DevExpress.XtraEditors.TextEdit PhoneNumberTextField;
        private DevExpress.XtraEditors.DateEdit BirthTimeEdit;
        private DevExpress.XtraEditors.ComboBoxEdit FacultyStartComboBox;
        private DevExpress.XtraEditors.ComboBoxEdit FacultyComboBox;
        private DevExpress.XtraEditors.SimpleButton SaveEditButton;
        private DevExpress.XtraEditors.LabelControl FirstNameLabel;
        private DevExpress.XtraEditors.LabelControl LastNameLabel;
        private DevExpress.XtraEditors.LabelControl GenderLabel;
        private DevExpress.XtraEditors.LabelControl BirthLabel;
        private DevExpress.XtraEditors.LabelControl EmailLabel;
        private DevExpress.XtraEditors.LabelControl PhoneLabel;
        private DevExpress.XtraEditors.LabelControl FacultyLabel;
        private DevExpress.XtraEditors.LabelControl FacultyStartLabel;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit GenderComboBox;
    }
}