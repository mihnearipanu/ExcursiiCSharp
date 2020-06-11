namespace Proiect_MPP_CSharp
{
    partial class MainForm
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
            this.dataGridExcursii = new System.Windows.Forms.DataGridView();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonRezervare = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxObiectiv = new System.Windows.Forms.TextBox();
            this.textBoxMinPlecare1 = new System.Windows.Forms.TextBox();
            this.textBoxOraPlecare1 = new System.Windows.Forms.TextBox();
            this.textBoxOraPlecare2 = new System.Windows.Forms.TextBox();
            this.textBoxMinPlecare2 = new System.Windows.Forms.TextBox();
            this.buttonCautare = new System.Windows.Forms.Button();
            this.labelCautare = new System.Windows.Forms.Label();
            this.labelObiectiv = new System.Windows.Forms.Label();
            this.labelPlecare1 = new System.Windows.Forms.Label();
            this.labelPlecare2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExcursii)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridExcursii
            // 
            this.dataGridExcursii.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridExcursii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExcursii.Location = new System.Drawing.Point(13, 13);
            this.dataGridExcursii.Name = "dataGridExcursii";
            this.dataGridExcursii.RowHeadersWidth = 62;
            this.dataGridExcursii.RowTemplate.Height = 28;
            this.dataGridExcursii.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridExcursii.Size = new System.Drawing.Size(844, 427);
            this.dataGridExcursii.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1001, 489);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 38);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonRezervare
            // 
            this.buttonRezervare.Location = new System.Drawing.Point(888, 489);
            this.buttonRezervare.Name = "buttonRezervare";
            this.buttonRezervare.Size = new System.Drawing.Size(108, 38);
            this.buttonRezervare.TabIndex = 2;
            this.buttonRezervare.Text = "Rezervare";
            this.buttonRezervare.UseVisualStyleBackColor = true;
            this.buttonRezervare.Click += new System.EventHandler(this.buttonRezervare_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(13, 446);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(89, 30);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxObiectiv
            // 
            this.textBoxObiectiv.Location = new System.Drawing.Point(969, 82);
            this.textBoxObiectiv.Name = "textBoxObiectiv";
            this.textBoxObiectiv.Size = new System.Drawing.Size(104, 26);
            this.textBoxObiectiv.TabIndex = 4;
            // 
            // textBoxMinPlecare1
            // 
            this.textBoxMinPlecare1.Location = new System.Drawing.Point(1024, 114);
            this.textBoxMinPlecare1.Name = "textBoxMinPlecare1";
            this.textBoxMinPlecare1.Size = new System.Drawing.Size(30, 26);
            this.textBoxMinPlecare1.TabIndex = 5;
            // 
            // textBoxOraPlecare1
            // 
            this.textBoxOraPlecare1.Location = new System.Drawing.Point(988, 114);
            this.textBoxOraPlecare1.Name = "textBoxOraPlecare1";
            this.textBoxOraPlecare1.Size = new System.Drawing.Size(30, 26);
            this.textBoxOraPlecare1.TabIndex = 6;
            // 
            // textBoxOraPlecare2
            // 
            this.textBoxOraPlecare2.Location = new System.Drawing.Point(988, 146);
            this.textBoxOraPlecare2.Name = "textBoxOraPlecare2";
            this.textBoxOraPlecare2.Size = new System.Drawing.Size(30, 26);
            this.textBoxOraPlecare2.TabIndex = 7;
            // 
            // textBoxMinPlecare2
            // 
            this.textBoxMinPlecare2.Location = new System.Drawing.Point(1024, 146);
            this.textBoxMinPlecare2.Name = "textBoxMinPlecare2";
            this.textBoxMinPlecare2.Size = new System.Drawing.Size(30, 26);
            this.textBoxMinPlecare2.TabIndex = 8;
            // 
            // buttonCautare
            // 
            this.buttonCautare.Location = new System.Drawing.Point(932, 190);
            this.buttonCautare.Name = "buttonCautare";
            this.buttonCautare.Size = new System.Drawing.Size(86, 30);
            this.buttonCautare.TabIndex = 9;
            this.buttonCautare.Text = "Cautare";
            this.buttonCautare.UseVisualStyleBackColor = true;
            this.buttonCautare.Click += new System.EventHandler(this.buttonCautare_Click);
            // 
            // labelCautare
            // 
            this.labelCautare.AutoSize = true;
            this.labelCautare.Location = new System.Drawing.Point(943, 41);
            this.labelCautare.Name = "labelCautare";
            this.labelCautare.Size = new System.Drawing.Size(66, 20);
            this.labelCautare.TabIndex = 10;
            this.labelCautare.Text = "Cautare";
            // 
            // labelObiectiv
            // 
            this.labelObiectiv.AutoSize = true;
            this.labelObiectiv.Location = new System.Drawing.Point(884, 85);
            this.labelObiectiv.Name = "labelObiectiv";
            this.labelObiectiv.Size = new System.Drawing.Size(73, 20);
            this.labelObiectiv.TabIndex = 11;
            this.labelObiectiv.Text = "Obiectiv: ";
            // 
            // labelPlecare1
            // 
            this.labelPlecare1.AutoSize = true;
            this.labelPlecare1.Location = new System.Drawing.Point(884, 117);
            this.labelPlecare1.Name = "labelPlecare1";
            this.labelPlecare1.Size = new System.Drawing.Size(79, 20);
            this.labelPlecare1.TabIndex = 12;
            this.labelPlecare1.Text = "Plecare 1:";
            // 
            // labelPlecare2
            // 
            this.labelPlecare2.AutoSize = true;
            this.labelPlecare2.Location = new System.Drawing.Point(884, 149);
            this.labelPlecare2.Name = "labelPlecare2";
            this.labelPlecare2.Size = new System.Drawing.Size(79, 20);
            this.labelPlecare2.TabIndex = 13;
            this.labelPlecare2.Text = "Plecare 2:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 539);
            this.Controls.Add(this.labelPlecare2);
            this.Controls.Add(this.labelPlecare1);
            this.Controls.Add(this.labelObiectiv);
            this.Controls.Add(this.labelCautare);
            this.Controls.Add(this.buttonCautare);
            this.Controls.Add(this.textBoxMinPlecare2);
            this.Controls.Add(this.textBoxOraPlecare2);
            this.Controls.Add(this.textBoxOraPlecare1);
            this.Controls.Add(this.textBoxMinPlecare1);
            this.Controls.Add(this.textBoxObiectiv);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonRezervare);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.dataGridExcursii);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExcursii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridExcursii;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonRezervare;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonCautare;
        private System.Windows.Forms.TextBox textBoxObiectiv;
        private System.Windows.Forms.TextBox textBoxOraPlecare1;
        private System.Windows.Forms.TextBox textBoxMinPlecare1;
        private System.Windows.Forms.TextBox textBoxOraPlecare2;
        private System.Windows.Forms.TextBox textBoxMinPlecare2;
        private System.Windows.Forms.Label labelCautare;
        private System.Windows.Forms.Label labelObiectiv;
        private System.Windows.Forms.Label labelPlecare1;
        private System.Windows.Forms.Label labelPlecare2;
    }
}