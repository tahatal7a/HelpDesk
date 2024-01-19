using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.UserControls
{
    public partial class UserControlEmploye : UserControl
    {


        public UserControlEmploye()
        {
            InitializeComponent();




            Nom.Text = Employe.nom;
            Prnm.Text = Employe.prenom;
            Departement.Text = Employe.departement;
            sevice.Text = Employe.service;
            nbureau.Text = Employe.numbureau;
            ntel.Text = Employe.numtel;
            netage.Text = Employe.etage.ToString();
            Nom.Parent = Id_card;
            Prnm.Parent = Id_card;
            Nom.BackColor = Color.Transparent;
            Prnm.BackColor = Color.Transparent;






        }

        private void label1_Click(object sender, EventArgs e)
        {




        }

        private void UserControlEmploye_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ntel_Click(object sender, EventArgs e)
        {

        }

        private void Id_card_Click(object sender, EventArgs e)
        {

        }

        private void sevice_Click(object sender, EventArgs e)
        {

        }

        private void netage_Click(object sender, EventArgs e)
        {

        }
    }
}
