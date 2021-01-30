
namespace ToDoApp
{
    partial class FormAdd
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonPriorityHigh = new System.Windows.Forms.RadioButton();
            this.radioButtonPriorityMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonPriorityLow = new System.Windows.Forms.RadioButton();
            this.panelPriority = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonStatusCanceled = new System.Windows.Forms.RadioButton();
            this.radioButtonStatusDone = new System.Windows.Forms.RadioButton();
            this.radioButtonStatusInProgress = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.panelButtons.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelPriority.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelButtons.Controls.Add(this.buttonEdit);
            this.panelButtons.Controls.Add(this.buttonClose);
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 245);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(359, 131);
            this.panelButtons.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(1, 47);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(358, 41);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(0, 91);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(359, 37);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(0, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(359, 41);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.label2);
            this.panelStatus.Controls.Add(this.radioButtonPriorityHigh);
            this.panelStatus.Controls.Add(this.radioButtonPriorityMedium);
            this.panelStatus.Controls.Add(this.radioButtonPriorityLow);
            this.panelStatus.Location = new System.Drawing.Point(255, 2);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(103, 98);
            this.panelStatus.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Priority:";
            // 
            // radioButtonPriorityHigh
            // 
            this.radioButtonPriorityHigh.AutoSize = true;
            this.radioButtonPriorityHigh.Location = new System.Drawing.Point(23, 68);
            this.radioButtonPriorityHigh.Name = "radioButtonPriorityHigh";
            this.radioButtonPriorityHigh.Size = new System.Drawing.Size(47, 17);
            this.radioButtonPriorityHigh.TabIndex = 2;
            this.radioButtonPriorityHigh.TabStop = true;
            this.radioButtonPriorityHigh.Text = "High";
            this.radioButtonPriorityHigh.UseVisualStyleBackColor = true;
            // 
            // radioButtonPriorityMedium
            // 
            this.radioButtonPriorityMedium.AutoSize = true;
            this.radioButtonPriorityMedium.Location = new System.Drawing.Point(23, 45);
            this.radioButtonPriorityMedium.Name = "radioButtonPriorityMedium";
            this.radioButtonPriorityMedium.Size = new System.Drawing.Size(62, 17);
            this.radioButtonPriorityMedium.TabIndex = 1;
            this.radioButtonPriorityMedium.TabStop = true;
            this.radioButtonPriorityMedium.Text = "Medium";
            this.radioButtonPriorityMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonPriorityLow
            // 
            this.radioButtonPriorityLow.AutoSize = true;
            this.radioButtonPriorityLow.Location = new System.Drawing.Point(23, 22);
            this.radioButtonPriorityLow.Name = "radioButtonPriorityLow";
            this.radioButtonPriorityLow.Size = new System.Drawing.Size(45, 17);
            this.radioButtonPriorityLow.TabIndex = 0;
            this.radioButtonPriorityLow.TabStop = true;
            this.radioButtonPriorityLow.Text = "Low";
            this.radioButtonPriorityLow.UseVisualStyleBackColor = true;
            // 
            // panelPriority
            // 
            this.panelPriority.Controls.Add(this.label1);
            this.panelPriority.Controls.Add(this.radioButtonStatusCanceled);
            this.panelPriority.Controls.Add(this.radioButtonStatusDone);
            this.panelPriority.Controls.Add(this.radioButtonStatusInProgress);
            this.panelPriority.Location = new System.Drawing.Point(255, 106);
            this.panelPriority.Name = "panelPriority";
            this.panelPriority.Size = new System.Drawing.Size(103, 99);
            this.panelPriority.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Staus:";
            // 
            // radioButtonStatusCanceled
            // 
            this.radioButtonStatusCanceled.AutoSize = true;
            this.radioButtonStatusCanceled.Location = new System.Drawing.Point(16, 72);
            this.radioButtonStatusCanceled.Name = "radioButtonStatusCanceled";
            this.radioButtonStatusCanceled.Size = new System.Drawing.Size(70, 17);
            this.radioButtonStatusCanceled.TabIndex = 2;
            this.radioButtonStatusCanceled.TabStop = true;
            this.radioButtonStatusCanceled.Text = "Canceled";
            this.radioButtonStatusCanceled.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusDone
            // 
            this.radioButtonStatusDone.AutoSize = true;
            this.radioButtonStatusDone.Location = new System.Drawing.Point(16, 49);
            this.radioButtonStatusDone.Name = "radioButtonStatusDone";
            this.radioButtonStatusDone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonStatusDone.TabIndex = 1;
            this.radioButtonStatusDone.TabStop = true;
            this.radioButtonStatusDone.Text = "Done";
            this.radioButtonStatusDone.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusInProgress
            // 
            this.radioButtonStatusInProgress.AutoSize = true;
            this.radioButtonStatusInProgress.Location = new System.Drawing.Point(16, 26);
            this.radioButtonStatusInProgress.Name = "radioButtonStatusInProgress";
            this.radioButtonStatusInProgress.Size = new System.Drawing.Size(77, 17);
            this.radioButtonStatusInProgress.TabIndex = 0;
            this.radioButtonStatusInProgress.TabStop = true;
            this.radioButtonStatusInProgress.Text = "In progress";
            this.radioButtonStatusInProgress.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBoxDescription);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 204);
            this.panel1.TabIndex = 3;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(72, 40);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(165, 164);
            this.richTextBoxDescription.TabIndex = 4;
            this.richTextBoxDescription.Text = "";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(72, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(165, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(-1, 234);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 10);
            this.panel2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date:";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(45, 211);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(194, 20);
            this.textBoxDate.TabIndex = 8;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 376);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPriority);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdd";
            this.panelButtons.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelPriority.ResumeLayout(false);
            this.panelPriority.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonPriorityHigh;
        private System.Windows.Forms.RadioButton radioButtonPriorityMedium;
        private System.Windows.Forms.RadioButton radioButtonPriorityLow;
        private System.Windows.Forms.Panel panelPriority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonStatusCanceled;
        private System.Windows.Forms.RadioButton radioButtonStatusDone;
        private System.Windows.Forms.RadioButton radioButtonStatusInProgress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Button buttonEdit;
    }
}