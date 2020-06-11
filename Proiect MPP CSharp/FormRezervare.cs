using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_MPP_CSharp.Domain;
using Proiect_MPP_CSharp.Services;

namespace Proiect_MPP_CSharp
{
    public partial class FormRezervare : Form
    {
        private Excursie excursie;
        private ServBilet serv;
        private MainForm form;
        public FormRezervare(Excursie excursie)
        {
            this.excursie = excursie;
            this.serv = new ServBilet(new Repos.RepoBilet("Bilete"), 
                new Repos.RepoExcursie("Excursii"));
            InitializeComponent();
            textBoxIdExcursie.Text = excursie.id;
            textBoxIdExcursie.ReadOnly = true;
        }

        private void buttonRezervare_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxNrTel.Text;
                string idExcursie = textBoxIdExcursie.Text;
                string numeClient = textBoxNumeClient.Text;
                int nrTel = int.Parse(textBoxNrTel.Text);
                int nrLocuri = int.Parse(textBoxNrLocuri.Text);
                Bilet bilet = new Bilet(id, idExcursie, numeClient, nrTel, nrLocuri);
                if (excursie.nrLocuri < nrLocuri)
                {
                    MessageBox.Show("Mai sunt doar " + excursie.nrLocuri + " locuri ramase!");
                }
                else {
                    serv.rezervare(bilet);
                    MessageBox.Show("Rezervare efectuata!");
                    this.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Doar numere sunt permise in campurile Numar Telefon si Nrumar Locuri!");
            }
        }
    }
}
