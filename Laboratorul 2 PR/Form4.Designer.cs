﻿namespace LAB_2_IDWEB
{
    partial class Form4
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
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listmess = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Subjects = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(296, 59);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(146, 20);
            this.user.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Authorization";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(296, 96);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(146, 20);
            this.pass.TabIndex = 5;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listmess
            // 
            this.listmess.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.listmess.Location = new System.Drawing.Point(222, 208);
            this.listmess.Name = "listmess";
            this.listmess.Size = new System.Drawing.Size(469, 229);
            this.listmess.TabIndex = 11;
            this.listmess.Text = "Message";
            this.listmess.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(729, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 75);
            this.button2.TabIndex = 12;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Subjects
            // 
            this.Subjects.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Subjects.FormattingEnabled = true;
            this.Subjects.Location = new System.Drawing.Point(222, 146);
            this.Subjects.Name = "Subjects";
            this.Subjects.Size = new System.Drawing.Size(469, 56);
            this.Subjects.TabIndex = 13;
            this.Subjects.SelectedIndexChanged += new System.EventHandler(this.Subjects_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 450);
            this.Controls.Add(this.Subjects);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listmess);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user);
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox listmess;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox Subjects;
    }
}