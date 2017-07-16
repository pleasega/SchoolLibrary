namespace SchoolLibrary
{
    partial class Action
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
            this.studentName_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.action_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.studentID_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.action_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentName_textbox
            // 
            this.studentName_textbox.Location = new System.Drawing.Point(96, 57);
            this.studentName_textbox.Name = "studentName_textbox";
            this.studentName_textbox.Size = new System.Drawing.Size(151, 20);
            this.studentName_textbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Name:";
            // 
            // action_btn
            // 
            this.action_btn.Location = new System.Drawing.Point(9, 88);
            this.action_btn.Name = "action_btn";
            this.action_btn.Size = new System.Drawing.Size(118, 23);
            this.action_btn.TabIndex = 6;
            this.action_btn.Text = "Action";
            this.action_btn.UseVisualStyleBackColor = true;
            this.action_btn.Click += new System.EventHandler(this.action_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(129, 88);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(118, 23);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student ID:";
            // 
            // studentID_textbox
            // 
            this.studentID_textbox.Location = new System.Drawing.Point(96, 31);
            this.studentID_textbox.Name = "studentID_textbox";
            this.studentID_textbox.Size = new System.Drawing.Size(151, 20);
            this.studentID_textbox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Action: ";
            // 
            // action_label
            // 
            this.action_label.AutoSize = true;
            this.action_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.action_label.Location = new System.Drawing.Point(55, 9);
            this.action_label.Name = "action_label";
            this.action_label.Size = new System.Drawing.Size(10, 13);
            this.action_label.TabIndex = 11;
            this.action_label.Text = "-";
            // 
            // Action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 122);
            this.Controls.Add(this.action_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentID_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.action_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentName_textbox);
            this.Name = "Action";
            this.ShowIcon = false;
            this.Text = "School Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentName_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button action_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentID_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label action_label;
    }
}