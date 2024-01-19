using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;


namespace Helpdesk
{
    public partial class Form1 : Form

    {
        public static SqlConnection cnx;
        public static DataSet ds;
        public static SqlDataAdapter adapter;
        public string Nom;
        public string Prenom;
        public string departement, service, numtel, numbureau;
        public int etage;


        SqlCommand cmd;
        MainForm MainForm;
        TechnicienForm TechnicienForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {    //si l'user laisse les champs vide
            if (txtUser.Text == "")
            {
                MessageBox.Show("Veuillez saisir votre nom d'utilisateur.", "Connexion requise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Veuillez saisir votre mot de passe.", "Connexion requise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //a l aide des fonctions on verifie le type de l'utilisateur


            if (IsValidEmploye(txtUser, txtPass))
            {
                // affichage de (mainform) form qui correspendant a l employee
                ticket.ticketfun();
                MainForm = new MainForm();
                MainForm.Show();
                this.Hide();
            }
            else if (isValidTechnicien(txtUser, txtPass))
            {
                //afffichage de technicien form 
                TechnicienForm = new TechnicienForm();
                TechnicienForm.Show();
                this.Hide();

            }
            else if (txtUser.Text == "admin" && txtPass.Text == "admin")
            {
                //affichage de adminform
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();


            }

            else
            {
                // si aucune fontion n'est validé (meessage d erreur)
                MessageBox.Show("Nom d'utilisateur ou mot de passe invalide. Veuillez réessayer.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        //fonction qui verfie si les valeurs entré par utilisateir se trouve dans table employe si c'est vrai on stock les informations dans class Employe
        public static bool IsValidEmploye(TextBox txtUser, TextBox txtPass)
        {

            cnx = Program.GetConnection();
            cnx.Open();
            int Count = 0;


            ds = new DataSet();
            adapter = new SqlDataAdapter("select * from Employe where UserName = @username and MotDePasse = @password", cnx);
            adapter.SelectCommand.Parameters.AddWithValue("@username", txtUser.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@password", txtPass.Text);
            adapter.Fill(ds, "valid");

            if (ds.Tables["valid"].Rows.Count > 0)
            {
                Count = 1;
                Employe.id = (int)ds.Tables["valid"].Rows[0]["ID"];
                Employe.nom = (string)ds.Tables["valid"].Rows[0]["Nom"];
                Employe.prenom = (string)ds.Tables["valid"].Rows[0]["Prenom"];
                Employe.departement = (string)ds.Tables["valid"].Rows[0]["Departement"];
                Employe.service = (string)ds.Tables["valid"].Rows[0]["N_Service"];
                Employe.numbureau = (string)ds.Tables["valid"].Rows[0]["NumBureau"];
                Employe.numtel = (string)ds.Tables["valid"].Rows[0]["NumTel"];
                Employe.etage = (int)ds.Tables["valid"].Rows[0]["Etage"];




            }


            return Count == 1;




        }

        //fonction qui verifie si les valeurs entré par utilisateur se trouve dans table Technicien si c'est vrai on stock les informations dans class Classtech
        public static bool isValidTechnicien(TextBox txtUser, TextBox txtPass)

        {
            cnx = Program.GetConnection();
            cnx.Open();
            int Count = 0;
            ds = new DataSet();
            adapter = new SqlDataAdapter("select * from Technicien where UserName = @username and MotDePasse = @password", cnx);
            adapter.SelectCommand.Parameters.AddWithValue("@username", txtUser.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@password", txtPass.Text);
            adapter.Fill(ds, "Technicien");

            if (ds.Tables["Technicien"].Rows.Count > 0)
            {
                Classtech.ID = (int)ds.Tables["Technicien"].Rows[0]["ID"];
                Classtech.Nom = (string)ds.Tables["Technicien"].Rows[0]["Nom"];
                Classtech.Prenom = (string)ds.Tables["Technicien"].Rows[0]["Prenom"];
                Classtech.Departement = (string)ds.Tables["Technicien"].Rows[0]["Departement"];
                Classtech.Service = (string)ds.Tables["Technicien"].Rows[0]["N_Service"];
                Classtech.Nbureau = (string)ds.Tables["Technicien"].Rows[0]["NumBureau"];
                Classtech.Ntel = (string)ds.Tables["Technicien"].Rows[0]["NumTel"];
                Classtech.Specialité = (string)ds.Tables["Technicien"].Rows[0]["Specialite"];

                Count = 1;
            }
            return Count == 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}