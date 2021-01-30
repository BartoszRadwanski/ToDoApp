
namespace ToDoApp
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
            this.components = new System.ComponentModel.Container();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxDailyTasks = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelTitleValue = new System.Windows.Forms.Label();
            this.labelPriorityValue = new System.Windows.Forms.Label();
            this.labelStatusValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDates = new System.Windows.Forms.ComboBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.labelNextTaskValue = new System.Windows.Forms.Label();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelLeft.Controls.Add(this.labelHour);
            this.panelLeft.Controls.Add(this.labelDate);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.buttonClose);
            this.panelLeft.Controls.Add(this.buttonHelp);
            this.panelLeft.Controls.Add(this.buttonEdit);
            this.panelLeft.Controls.Add(this.buttonAdd);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(183, 450);
            this.panelLeft.TabIndex = 0;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHour.ForeColor = System.Drawing.Color.White;
            this.labelHour.Location = new System.Drawing.Point(52, 115);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(49, 20);
            this.labelHour.TabIndex = 7;
            this.labelHour.Text = "hours";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(23, 73);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 24);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Todo app";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(27, 384);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(130, 60);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(27, 316);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(130, 60);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(27, 248);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(130, 60);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(27, 180);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 60);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // listBoxDailyTasks
            // 
            this.listBoxDailyTasks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxDailyTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxDailyTasks.FormattingEnabled = true;
            this.listBoxDailyTasks.ItemHeight = 20;
            this.listBoxDailyTasks.Location = new System.Drawing.Point(0, 206);
            this.listBoxDailyTasks.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxDailyTasks.Name = "listBoxDailyTasks";
            this.listBoxDailyTasks.Size = new System.Drawing.Size(247, 244);
            this.listBoxDailyTasks.TabIndex = 1;
            this.listBoxDailyTasks.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 450);
            this.panel2.TabIndex = 2;
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.label2.Location = new System.Drawing.Point(108, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(5, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Priority:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(121, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Description:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Enabled = false;
            this.richTextBoxDescription.Location = new System.Drawing.Point(8, 107);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(296, 153);
            this.richTextBoxDescription.TabIndex = 8;
            this.richTextBoxDescription.Text = "";
            // 
            // labelTitleValue
            // 
            this.labelTitleValue.AutoSize = true;
            this.labelTitleValue.Location = new System.Drawing.Point(51, 40);
            this.labelTitleValue.Name = "labelTitleValue";
            this.labelTitleValue.Size = new System.Drawing.Size(53, 13);
            this.labelTitleValue.TabIndex = 9;
            this.labelTitleValue.Text = "Unknown";
            // 
            // labelPriorityValue
            // 
            this.labelPriorityValue.AutoSize = true;
            this.labelPriorityValue.Location = new System.Drawing.Point(51, 59);
            this.labelPriorityValue.Name = "labelPriorityValue";
            this.labelPriorityValue.Size = new System.Drawing.Size(53, 13);
            this.labelPriorityValue.TabIndex = 10;
            this.labelPriorityValue.Text = "Unknown";
            // 
            // labelStatusValue
            // 
            this.labelStatusValue.AutoSize = true;
            this.labelStatusValue.Location = new System.Drawing.Point(51, 78);
            this.labelStatusValue.Name = "labelStatusValue";
            this.labelStatusValue.Size = new System.Drawing.Size(53, 13);
            this.labelStatusValue.TabIndex = 11;
            this.labelStatusValue.Text = "Unknown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "My daily tasks:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Check date:";
            // 
            // comboBoxDates
            // 
            this.comboBoxDates.FormattingEnabled = true;
            this.comboBoxDates.Location = new System.Drawing.Point(84, 128);
            this.comboBoxDates.Name = "comboBoxDates";
            this.comboBoxDates.Size = new System.Drawing.Size(134, 21);
            this.comboBoxDates.TabIndex = 14;
            this.comboBoxDates.SelectedIndexChanged += new System.EventHandler(this.comboBoxDates_SelectedIndexChanged);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.richTextBoxDescription);
            this.panelRight.Controls.Add(this.labelStatusValue);
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.Controls.Add(this.labelPriorityValue);
            this.panelRight.Controls.Add(this.labelTitleValue);
            this.panelRight.Location = new System.Drawing.Point(443, 184);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(304, 266);
            this.panelRight.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.label9.Location = new System.Drawing.Point(90, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Next task:";
            // 
            // labelNextTaskValue
            // 
            this.labelNextTaskValue.AutoSize = true;
            this.labelNextTaskValue.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNextTaskValue.Location = new System.Drawing.Point(445, 30);
            this.labelNextTaskValue.Name = "labelNextTaskValue";
            this.labelNextTaskValue.Size = new System.Drawing.Size(122, 20);
            this.labelNextTaskValue.TabIndex = 17;
            this.labelNextTaskValue.Text = "nextTaskValue";
            // 
            // panelMiddle
            // 
            this.panelMiddle.Controls.Add(this.listBoxDailyTasks);
            this.panelMiddle.Controls.Add(this.label7);
            this.panelMiddle.Controls.Add(this.label9);
            this.panelMiddle.Controls.Add(this.comboBoxDates);
            this.panelMiddle.Controls.Add(this.label8);
            this.panelMiddle.Location = new System.Drawing.Point(193, 0);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(247, 450);
            this.panelMiddle.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.labelNextTaskValue);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLeft);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            this.panelMiddle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDailyTasks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelTitleValue;
        private System.Windows.Forms.Label labelPriorityValue;
        private System.Windows.Forms.Label labelStatusValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDates;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelNextTaskValue;
        private System.Windows.Forms.Panel panelMiddle;
    }
}

