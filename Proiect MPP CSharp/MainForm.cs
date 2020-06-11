using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_MPP_CSharp.Services;
using Proiect_MPP_CSharp.Domain;

namespace Proiect_MPP_CSharp
{
    public partial class MainForm : Form
    {
        private ServExcursie serv;
        private LoginForm login;
        public MainForm(LoginForm login)
        {
            this.login = login;
            this.serv = new ServExcursie(new Repos.RepoExcursie("Excursii"));
            InitializeComponent();
            loadExcursii();
            colorGrid();
            dataGridExcursii.Columns["id"].Visible = false;
        }

        private void loadExcursii() {
            List<Excursie> excursii = (List<Excursie>) serv.getAll();
            dataGridExcursii.DataSource = excursii;
            colorGrid();
        }

        private void loadExcursii(string obiectiv, string ora1, string ora2)
        {
            List<Excursie> excursii = (List<Excursie>)serv.getFiltrare(obiectiv, ora1, ora2);
            dataGridExcursii.DataSource = excursii;
            colorGrid();
        }

        private void buttonCautare_Click(object sender, EventArgs e)
        {
            if (textBoxObiectiv.Text == "") {
                MessageBox.Show("Obiectivul nu poate fi gol");
            }
            else {
                loadExcursii(textBoxObiectiv.Text, textBoxOraPlecare1.Text + ":" + textBoxMinPlecare1.Text, textBoxOraPlecare2.Text + ":" + textBoxMinPlecare2.Text);
            }
        }

        private void buttonRezervare_Click(object sender, EventArgs e)
        {
            Excursie excursie = serv.findOne(dataGridExcursii.CurrentRow.Cells["id"].Value.ToString());
            if (excursie == null)
            {
                MessageBox.Show("Nu ati selectat nicio excursie!");
            }
            else {
                FormRezervare formRezervare = new FormRezervare(excursie);
                formRezervare.Show();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            loadExcursii();
        }

        private void colorGrid()
        {
            foreach (DataGridViewRow row in dataGridExcursii.Rows)
            {
                if ((int)row.Cells["nrLocuri"].Value == 0)
                    row.DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }
}
