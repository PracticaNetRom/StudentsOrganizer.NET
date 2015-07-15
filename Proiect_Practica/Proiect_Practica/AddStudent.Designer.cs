namespace Proiect_Practica
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
            this.label5 = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.Participan = new DevExpress.XtraEditors.LabelControl();
            this.ParticipantsEvents = new DevExpress.XtraEditors.TextEdit();
            this.FirstName = new DevExpress.XtraEditors.TextEdit();
            this.LastName = new DevExpress.XtraEditors.TextEdit();
            this.Female = new DevExpress.XtraEditors.CheckEdit();
            this.Male = new DevExpress.XtraEditors.CheckEdit();
            this.Email = new DevExpress.XtraEditors.TextEdit();
            this.PhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.Faculty = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Gender = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Faultystartyear = new DevExpress.XtraEditors.LabelControl();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ParticipantsEvents.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Female.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Male.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Faculty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(14, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Birth Date";
            this.label5.Click += new System.EventHandler(this.BirthDate_Click);
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(136, 199);
            this.BirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(298, 22);
            this.BirthDate.TabIndex = 12;
            // 
            // Participan
            // 
            this.Participan.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Participan.Location = new System.Drawing.Point(19, 7);
            this.Participan.Margin = new System.Windows.Forms.Padding(4);
            this.Participan.Name = "Participan";
            this.Participan.Size = new System.Drawing.Size(160, 19);
            this.Participan.TabIndex = 22;
            this.Participan.Text = "Participants Events";
            this.Participan.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // ParticipantsEvents
            // 
            this.ParticipantsEvents.Location = new System.Drawing.Point(18, 38);
            this.ParticipantsEvents.Margin = new System.Windows.Forms.Padding(4);
            this.ParticipantsEvents.Name = "ParticipantsEvents";
            this.ParticipantsEvents.Size = new System.Drawing.Size(407, 20);
            this.ParticipantsEvents.TabIndex = 23;
            this.ParticipantsEvents.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(140, 86);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(150, 20);
            this.FirstName.TabIndex = 24;
            this.FirstName.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(136, 128);
            this.LastName.Margin = new System.Windows.Forms.Padding(4);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(150, 20);
            this.LastName.TabIndex = 25;
            // 
            // Female
            // 
            this.Female.Location = new System.Drawing.Point(140, 169);
            this.Female.Margin = new System.Windows.Forms.Padding(4);
            this.Female.Name = "Female";
            this.Female.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Female.Properties.Appearance.Options.UseFont = true;
            this.Female.Properties.Caption = "Female";
            this.Female.Size = new System.Drawing.Size(112, 20);
            this.Female.TabIndex = 26;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // Male
            // 
            this.Male.Location = new System.Drawing.Point(324, 169);
            this.Male.Margin = new System.Windows.Forms.Padding(4);
            this.Male.Name = "Male";
            this.Male.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Male.Properties.Appearance.Options.UseFont = true;
            this.Male.Properties.Caption = "Male";
            this.Male.Size = new System.Drawing.Size(112, 20);
            this.Male.TabIndex = 27;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(156, 235);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(150, 20);
            this.Email.TabIndex = 28;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(156, 281);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(150, 20);
            this.PhoneNumber.TabIndex = 29;
            // 
            // Faculty
            // 
            this.Faculty.Location = new System.Drawing.Point(156, 325);
            this.Faculty.Margin = new System.Windows.Forms.Padding(4);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(150, 20);
            this.Faculty.TabIndex = 30;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl2.Location = new System.Drawing.Point(19, 90);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 16);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "First Name";
            this.labelControl2.Click += new System.EventHandler(this.FisrstNameControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl3.Location = new System.Drawing.Point(18, 132);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 16);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Last Name";
            this.labelControl3.Click += new System.EventHandler(this.LastName_Click);
            // 
            // Gender
            // 
            this.Gender.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gender.Location = new System.Drawing.Point(19, 172);
            this.Gender.Margin = new System.Windows.Forms.Padding(4);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(49, 16);
            this.Gender.TabIndex = 33;
            this.Gender.Text = "Gender";
            this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl5.Location = new System.Drawing.Point(19, 244);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 16);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "Email";
            this.labelControl5.Click += new System.EventHandler(this.Email_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl6.Location = new System.Drawing.Point(18, 289);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(96, 16);
            this.labelControl6.TabIndex = 35;
            this.labelControl6.Text = "Phone Number";
            this.labelControl6.Click += new System.EventHandler(this.PhoneNumber_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl7.Location = new System.Drawing.Point(18, 334);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 16);
            this.labelControl7.TabIndex = 36;
            this.labelControl7.Text = "Faculty";
            this.labelControl7.Click += new System.EventHandler(this.Faculty_Click);
            // 
            // Faultystartyear
            // 
            this.Faultystartyear.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Faultystartyear.Location = new System.Drawing.Point(15, 374);
            this.Faultystartyear.Margin = new System.Windows.Forms.Padding(4);
            this.Faultystartyear.Name = "Faultystartyear";
            this.Faultystartyear.Size = new System.Drawing.Size(120, 16);
            this.Faultystartyear.TabIndex = 37;
            this.Faultystartyear.Text = "Faculty start year";
            this.Faultystartyear.Click += new System.EventHandler(this.Faculty_start_year_Click);
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.DateTime = new System.DateTime(2015, 7, 9, 0, 0, 0, 0);
            this.dateNavigator1.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.Default;
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.Location = new System.Drawing.Point(156, 374);
            this.dateNavigator1.Margin = new System.Windows.Forms.Padding(4);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Size = new System.Drawing.Size(269, 215);
            this.dateNavigator1.TabIndex = 38;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(462, 35);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(84, 23);
            this.simpleButton1.TabIndex = 39;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 613);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dateNavigator1);
            this.Controls.Add(this.Faultystartyear);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Faculty);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.ParticipantsEvents);
            this.Controls.Add(this.Participan);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ParticipantsEvents.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Female.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Male.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Faculty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private DevExpress.XtraEditors.LabelControl Participan;
        private DevExpress.XtraEditors.TextEdit ParticipantsEvents;
        private DevExpress.XtraEditors.TextEdit FirstName;
        private DevExpress.XtraEditors.TextEdit LastName;
        private DevExpress.XtraEditors.CheckEdit Female;
        private DevExpress.XtraEditors.CheckEdit Male;
        private DevExpress.XtraEditors.TextEdit Email;
        private DevExpress.XtraEditors.TextEdit PhoneNumber;
        private DevExpress.XtraEditors.TextEdit Faculty;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl Gender;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl Faultystartyear;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;

    }
}