namespace Proiect_MPP_CSharp
{
    partial class FormRezervare
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
            this.textBoxIdExcursie = new System.Windows.Forms.TextBox();
            this.textBoxNumeClient = new System.Windows.Forms.TextBox();
            this.textBoxNrTel = new System.Windows.Forms.TextBox();
            this.textBoxNrLocuri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRezervare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIdExcursie
            // 
            this.textBoxIdExcursie.Location = new System.Drawing.Point(197, 149);
            this.textBoxIdExcursie.Name = "textBoxIdExcursie";
            this.textBoxIdExcursie.Size = new System.Drawing.Size(187, 26);
            this.textBoxIdExcursie.TabIndex = 0;
            // 
            // textBoxNumeClient
            // 
            this.textBoxNumeClient.Location = new System.Drawing.Point(197, 191);
            this.textBoxNumeClient.Name = "textBoxNumeClient";
            this.textBoxNumeClient.Size = new System.Drawing.Size(187, 26);
            this.textBoxNumeClient.TabIndex = 1;
            // 
            // textBoxNrTel
            // 
            this.textBoxNrTel.Location = new System.Drawing.Point(197, 233);
            this.textBoxNrTel.Name = "textBoxNrTel";
            this.textBoxNrTel.Size = new System.Drawing.Size(187, 26);
            this.textBoxNrTel.TabIndex = 2;
            // 
            // textBoxNrLocuri
            // 
            this.textBoxNrLocuri.Location = new System.Drawing.Point(197, 275);
            this.textBoxNrLocuri.Name = "textBoxNrLocuri";
            this.textBoxNrLocuri.Size = new System.Drawing.Size(187, 26);
            this.textBoxNrLocuri.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rezervare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id Excursie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numar Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numar locuri";
            // 
            // buttonRezervare
            // 
            this.buttonRezervare.Location = new System.Drawing.Point(223, 350);
            this.buttonRezervare.Name = "buttonRezervare";
            this.buttonRezervare.Size = new System.Drawing.Size(87, 43);
            this.buttonRezervare.TabIndex = 9;
            this.buttonRezervare.Text = "Rezerva";
            this.buttonRezervare.UseVisualStyleBackColor = true;
            this.buttonRezervare.Click += new System.EventHandler(this.buttonRezervare_Click);
            // 
            // FormRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 405);
            this.Controls.Add(this.buttonRezervare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNrLocuri);
            this.Controls.Add(this.textBoxNrTel);
            this.Controls.Add(this.textBoxNumeClient);
            this.Controls.Add(this.textBoxIdExcursie);
            this.Name = "FormRezervare";
            this.Text = "FormRezervare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIdExcursie;
        private System.Windows.Forms.TextBox textBoxNumeClient;
        private System.Windows.Forms.TextBox textBoxNrTel;
        private System.Windows.Forms.TextBox textBoxNrLocuri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRezervare;
    }
}