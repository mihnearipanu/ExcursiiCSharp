using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Proiect_MPP_CSharp.Services;

namespace Proiect_MPP_CSharp
{
    public partial class LoginForm : Form
    {
        private ServUser serv;
        public LoginForm()
        {
            this.serv = new ServUser(new Repos.RepoUser("Useri"));
            InitializeComponent();
            textBoxPassword.Text = "admin";
            textBoxUsername.Text = "admin";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (serv.verifica(textBoxUsername.Text, textBoxPassword.Text))
            {
                MainForm form = new MainForm(this);
                this.Hide();
                form.Show();
            }
            else 
            {
                MessageBox.Show("Username sau parola incorecta!");
            }
        }
    }
}
