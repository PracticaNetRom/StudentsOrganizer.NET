namespace DBConnection
{
    partial class Form1
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
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.nameText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.nameText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(309, 288);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 34);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "AddEvent";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(246, 52);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(121, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "eventName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 334);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nameText.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraEditors.TextEdit nameText;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

