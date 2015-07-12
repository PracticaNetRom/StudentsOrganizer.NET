namespace MicaAplicatie
{
    partial class AddEvent
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
            this.SaveEventButton = new DevExpress.XtraEditors.SimpleButton();
            this.ReturnToAdminPannelButton = new DevExpress.XtraEditors.SimpleButton();
            this.EventDescLabel = new DevExpress.XtraEditors.LabelControl();
            this.EventDescTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StartDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.EventDepartmentLabel = new DevExpress.XtraEditors.LabelControl();
            this.EventRemarksLabel = new DevExpress.XtraEditors.LabelControl();
            this.EventTaskLabel = new DevExpress.XtraEditors.LabelControl();
            this.StartDateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DeptTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TaskTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RemarksTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.EventDescTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveEventButton
            // 
            this.SaveEventButton.Location = new System.Drawing.Point(181, 258);
            this.SaveEventButton.Name = "SaveEventButton";
            this.SaveEventButton.Size = new System.Drawing.Size(108, 28);
            this.SaveEventButton.TabIndex = 0;
            this.SaveEventButton.Text = "Save";
            this.SaveEventButton.Click += new System.EventHandler(this.SaveEventButton_Click);
            // 
            // ReturnToAdminPannelButton
            // 
            this.ReturnToAdminPannelButton.Location = new System.Drawing.Point(181, 292);
            this.ReturnToAdminPannelButton.Name = "ReturnToAdminPannelButton";
            this.ReturnToAdminPannelButton.Size = new System.Drawing.Size(108, 28);
            this.ReturnToAdminPannelButton.TabIndex = 1;
            this.ReturnToAdminPannelButton.Text = "Return";
            this.ReturnToAdminPannelButton.Click += new System.EventHandler(this.ReturnToAdminPannelButton_Click);
            // 
            // EventDescLabel
            // 
            this.EventDescLabel.Location = new System.Drawing.Point(45, 80);
            this.EventDescLabel.Name = "EventDescLabel";
            this.EventDescLabel.Size = new System.Drawing.Size(84, 13);
            this.EventDescLabel.TabIndex = 2;
            this.EventDescLabel.Text = "Event Description";
            // 
            // EventDescTextEdit
            // 
            this.EventDescTextEdit.Location = new System.Drawing.Point(156, 73);
            this.EventDescTextEdit.Name = "EventDescTextEdit";
            this.EventDescTextEdit.Size = new System.Drawing.Size(181, 20);
            this.EventDescTextEdit.TabIndex = 3;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.Location = new System.Drawing.Point(45, 107);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(50, 13);
            this.StartDateLabel.TabIndex = 4;
            this.StartDateLabel.Text = "Start Date";
            // 
            // EventDepartmentLabel
            // 
            this.EventDepartmentLabel.Location = new System.Drawing.Point(45, 134);
            this.EventDepartmentLabel.Name = "EventDepartmentLabel";
            this.EventDepartmentLabel.Size = new System.Drawing.Size(57, 13);
            this.EventDepartmentLabel.TabIndex = 5;
            this.EventDepartmentLabel.Text = "Department";
            // 
            // EventRemarksLabel
            // 
            this.EventRemarksLabel.Location = new System.Drawing.Point(45, 188);
            this.EventRemarksLabel.Name = "EventRemarksLabel";
            this.EventRemarksLabel.Size = new System.Drawing.Size(41, 13);
            this.EventRemarksLabel.TabIndex = 7;
            this.EventRemarksLabel.Text = "Remarks";
            // 
            // EventTaskLabel
            // 
            this.EventTaskLabel.Location = new System.Drawing.Point(45, 161);
            this.EventTaskLabel.Name = "EventTaskLabel";
            this.EventTaskLabel.Size = new System.Drawing.Size(22, 13);
            this.EventTaskLabel.TabIndex = 8;
            this.EventTaskLabel.Text = "Task";
            // 
            // StartDateTextEdit
            // 
            this.StartDateTextEdit.Location = new System.Drawing.Point(156, 100);
            this.StartDateTextEdit.Name = "StartDateTextEdit";
            this.StartDateTextEdit.Size = new System.Drawing.Size(100, 20);
            this.StartDateTextEdit.TabIndex = 9;
            // 
            // DeptTextEdit
            // 
            this.DeptTextEdit.Location = new System.Drawing.Point(156, 127);
            this.DeptTextEdit.Name = "DeptTextEdit";
            this.DeptTextEdit.Size = new System.Drawing.Size(100, 20);
            this.DeptTextEdit.TabIndex = 10;
            // 
            // TaskTextEdit
            // 
            this.TaskTextEdit.Location = new System.Drawing.Point(156, 154);
            this.TaskTextEdit.Name = "TaskTextEdit";
            this.TaskTextEdit.Size = new System.Drawing.Size(248, 20);
            this.TaskTextEdit.TabIndex = 11;
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.Location = new System.Drawing.Point(156, 181);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(248, 20);
            this.RemarksTextEdit.TabIndex = 12;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 359);
            this.Controls.Add(this.RemarksTextEdit);
            this.Controls.Add(this.TaskTextEdit);
            this.Controls.Add(this.DeptTextEdit);
            this.Controls.Add(this.StartDateTextEdit);
            this.Controls.Add(this.EventTaskLabel);
            this.Controls.Add(this.EventRemarksLabel);
            this.Controls.Add(this.EventDepartmentLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.EventDescTextEdit);
            this.Controls.Add(this.EventDescLabel);
            this.Controls.Add(this.ReturnToAdminPannelButton);
            this.Controls.Add(this.SaveEventButton);
            this.Name = "AddEvent";
            this.Text = "New Event Entry";
            ((System.ComponentModel.ISupportInitialize)(this.EventDescTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SaveEventButton;
        private DevExpress.XtraEditors.SimpleButton ReturnToAdminPannelButton;
        private DevExpress.XtraEditors.LabelControl EventDescLabel;
        private DevExpress.XtraEditors.TextEdit EventDescTextEdit;
        private DevExpress.XtraEditors.LabelControl StartDateLabel;
        private DevExpress.XtraEditors.LabelControl EventDepartmentLabel;
        private DevExpress.XtraEditors.LabelControl EventRemarksLabel;
        private DevExpress.XtraEditors.LabelControl EventTaskLabel;
        private DevExpress.XtraEditors.TextEdit StartDateTextEdit;
        private DevExpress.XtraEditors.TextEdit DeptTextEdit;
        private DevExpress.XtraEditors.TextEdit TaskTextEdit;
        private DevExpress.XtraEditors.TextEdit RemarksTextEdit;
    }
}