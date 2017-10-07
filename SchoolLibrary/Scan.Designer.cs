namespace SchoolLibrary
{
    partial class Scan
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
            this.label1 = new System.Windows.Forms.Label();
            this.book1ISBN_textbox = new System.Windows.Forms.TextBox();
            this.continue_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.book2ISBN_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.book3ISBN_textbox = new System.Windows.Forms.TextBox();
            this.book4ISBN_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scan book barcode";
            // 
            // book1ISBN_textbox
            // 
            this.book1ISBN_textbox.Location = new System.Drawing.Point(62, 59);
            this.book1ISBN_textbox.Name = "book1ISBN_textbox";
            this.book1ISBN_textbox.Size = new System.Drawing.Size(187, 20);
            this.book1ISBN_textbox.TabIndex = 1;
            // 
            // continue_btn
            // 
            this.continue_btn.Location = new System.Drawing.Point(12, 171);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(118, 23);
            this.continue_btn.TabIndex = 2;
            this.continue_btn.Text = "Continue";
            this.continue_btn.UseVisualStyleBackColor = true;
            this.continue_btn.Click += new System.EventHandler(this.continue_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(136, 171);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(113, 23);
            this.cancel_btn.TabIndex = 3;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Book 2:";
            // 
            // book2ISBN_textbox
            // 
            this.book2ISBN_textbox.Location = new System.Drawing.Point(62, 84);
            this.book2ISBN_textbox.Name = "book2ISBN_textbox";
            this.book2ISBN_textbox.Size = new System.Drawing.Size(187, 20);
            this.book2ISBN_textbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Book 3:";
            // 
            // book3ISBN_textbox
            // 
            this.book3ISBN_textbox.Location = new System.Drawing.Point(62, 110);
            this.book3ISBN_textbox.Name = "book3ISBN_textbox";
            this.book3ISBN_textbox.Size = new System.Drawing.Size(187, 20);
            this.book3ISBN_textbox.TabIndex = 8;
            // 
            // book4ISBN_textbox
            // 
            this.book4ISBN_textbox.Location = new System.Drawing.Point(62, 137);
            this.book4ISBN_textbox.Name = "book4ISBN_textbox";
            this.book4ISBN_textbox.Size = new System.Drawing.Size(187, 20);
            this.book4ISBN_textbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Book 4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Leave field(s) blank if no book(s).";
            // 
            // Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 206);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.book4ISBN_textbox);
            this.Controls.Add(this.book3ISBN_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.book2ISBN_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.continue_btn);
            this.Controls.Add(this.book1ISBN_textbox);
            this.Controls.Add(this.label1);
            this.Name = "Scan";
            this.ShowIcon = false;
            this.Text = "Scan Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox book1ISBN_textbox;
        private System.Windows.Forms.Button continue_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox book2ISBN_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox book3ISBN_textbox;
        private System.Windows.Forms.TextBox book4ISBN_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}