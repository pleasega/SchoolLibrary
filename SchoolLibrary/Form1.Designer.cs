﻿namespace SchoolLibrary
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
            this.borrow_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // borrow_btn
            // 
            this.borrow_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow_btn.Location = new System.Drawing.Point(12, 12);
            this.borrow_btn.Name = "borrow_btn";
            this.borrow_btn.Size = new System.Drawing.Size(418, 100);
            this.borrow_btn.TabIndex = 0;
            this.borrow_btn.Text = "Borrow";
            this.borrow_btn.UseVisualStyleBackColor = true;
            this.borrow_btn.Click += new System.EventHandler(this.borrow_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.Location = new System.Drawing.Point(12, 118);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(418, 100);
            this.return_btn.TabIndex = 1;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(398, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "v1.2.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.borrow_btn);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "School Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button borrow_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Label label1;
    }
}

