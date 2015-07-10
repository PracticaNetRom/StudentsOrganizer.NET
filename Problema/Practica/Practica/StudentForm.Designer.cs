namespace Practica
{
    partial class StudentForm
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
            this.ID = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.facText = new System.Windows.Forms.TextBox();
            this.genderText = new System.Windows.Forms.TextBox();
            this.LastText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.birth = new DevExpress.XtraEditors.DateEdit();
            this.start = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.birth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(161, 49);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 43;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(65, 52);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(15, 13);
            this.labelControl7.TabIndex = 42;
            this.labelControl7.Text = "ID:";
            // 
            // facText
            // 
            this.facText.Location = new System.Drawing.Point(161, 197);
            this.facText.Name = "facText";
            this.facText.Size = new System.Drawing.Size(100, 20);
            this.facText.TabIndex = 41;
            // 
            // genderText
            // 
            this.genderText.Location = new System.Drawing.Point(161, 138);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(100, 20);
            this.genderText.TabIndex = 40;
            // 
            // LastText
            // 
            this.LastText.Location = new System.Drawing.Point(161, 111);
            this.LastText.Name = "LastText";
            this.LastText.Size = new System.Drawing.Size(100, 20);
            this.LastText.TabIndex = 39;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(161, 80);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 38;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(65, 200);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 35;
            this.labelControl5.Text = "Faculty:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(65, 226);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "Faculty Start:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(65, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "Gender";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(65, 171);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "Birth Date:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(65, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "Last Name:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(65, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "First Name:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(161, 279);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 44;
            this.simpleButton1.Text = "ADD";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // birth
            // 
            this.birth.EditValue = null;
            this.birth.Location = new System.Drawing.Point(161, 171);
            this.birth.Name = "birth";
            this.birth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birth.Size = new System.Drawing.Size(100, 20);
            this.birth.TabIndex = 45;
            // 
            // start
            // 
            this.start.EditValue = null;
            this.start.Location = new System.Drawing.Point(161, 219);
            this.start.Name = "start";
            this.start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.start.Size = new System.Drawing.Size(100, 20);
            this.start.TabIndex = 46;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 334);
            this.Controls.Add(this.start);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.facText);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.LastText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "StudentForm";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.birth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox facText;
        private System.Windows.Forms.TextBox genderText;
        private System.Windows.Forms.TextBox LastText;
        private System.Windows.Forms.TextBox nameText;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit birth;
        private DevExpress.XtraEditors.DateEdit start;
    }
}