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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Helpdesk.UserControls
{
    public partial class UserControlCreateticket : UserControl
    {
        public event EventHandler TicketCreated;
        private int caID;
        public UserControlCreateticket()
        {
            InitializeComponent();
        }

        private void UserControlCreateticket_Load(object sender, EventArgs e)
        {
            RefreshComboBox();

        }

        //actualisation des informations de combo box de Categorie
        private void RefreshComboBox()
        {

            DataTable categoryTable = Categorie.Category();
            comboBoxCat.DataSource = null;
            comboBoxCat.DataSource = categoryTable;
            comboBoxCat.DisplayMember = "Nom";
            comboBoxCat.SelectedIndex = 0;
            comboBoxP.SelectedIndex = 2;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //appel de la fonction qui permet de convertir CategorieNom a son ID
            caID = Categorie.catID(comboBoxCat);


            Form1.cnx = Program.GetConnection();
            Form1.cnx.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Ticket (Description, CategorieID, EmployeID, DateOuverture, DateCloture, Statut, Priorité) VALUES (@desc, @catgoryid, @employeid, @dateouverture, NULL, 'Ouvert', @Priorité)", Form1.cnx);
            cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
            cmd.Parameters.AddWithValue("@catgoryid", caID);
            cmd.Parameters.AddWithValue("@employeid", Employe.id);
            cmd.Parameters.AddWithValue("@dateouverture", DateTime.Now);
            cmd.Parameters.AddWithValue("@Priorité", comboBoxP.SelectedItem.ToString());
            cmd.ExecuteNonQuery();

            TicketCreated?.Invoke(this, EventArgs.Empty);

            MessageBox.Show("votre ticket a été créé avec succès",   "Confirmation",  MessageBoxButtons.OK,  MessageBoxIcon.Information,  MessageBoxDefaultButton.Button1); // Default button


            RefreshComboBox();
        }
    }

}

