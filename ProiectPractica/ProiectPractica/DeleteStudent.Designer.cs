namespace ProiectPractica
{
    partial class DeleteStudent
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DeleteTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.BackButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteTextEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(114, 151);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id Student";
            // 
            // DeleteTextEdit1
            // 
            this.DeleteTextEdit1.Location = new System.Drawing.Point(238, 151);
            this.DeleteTextEdit1.Name = "DeleteTextEdit1";
            this.DeleteTextEdit1.Size = new System.Drawing.Size(100, 20);
            this.DeleteTextEdit1.TabIndex = 1;
            // 
            // BackButton1
            // 
            this.BackButton1.Location = new System.Drawing.Point(393, 291);
            this.BackButton1.Name = "BackButton1";
            this.BackButton1.Size = new System.Drawing.Size(75, 23);
            this.BackButton1.TabIndex = 2;
            this.BackButton1.Text = "Back";
            this.BackButton1.Click += new System.EventHandler(this.BackButton1_Click);
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 397);
            this.Controls.Add(this.BackButton1);
            this.Controls.Add(this.DeleteTextEdit1);
            this.Controls.Add(this.labelControl1);
            this.Name = "DeleteStudent";
            this.Text = "DeleteStudent";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteTextEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit DeleteTextEdit1;
        private DevExpress.XtraEditors.SimpleButton BackButton1;
    }
}