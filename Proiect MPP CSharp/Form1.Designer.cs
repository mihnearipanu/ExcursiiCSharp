﻿namespace Proiect_MPP_CSharp
{
    partial class LoginForm
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.CenterToScreen();
            // 
            // textBoxObiectiv
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(173, 178);
            this.textBoxUsername.Name = "textBoxObiectiv";
            this.textBoxUsername.Size = new System.Drawing.Size(198, 26);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxMinPlecare1
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(173, 228);
            this.textBoxPassword.Name = "textBoxMinPlecare1";
            this.textBoxPassword.Size = new System.Drawing.Size(198, 26);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelCautare
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 178);
            this.label1.Name = "labelCautare";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // labelObiectiv
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 228);
            this.label2.Name = "labelObiectiv";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // labelPlecare1
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 95);
            this.label3.Name = "labelPlecare1";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autentificare";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(195, 291);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 41);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 344);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogin;
    }
}

