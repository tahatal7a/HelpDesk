using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.AdminUserControls
{
    public partial class UserControlAdminTech : UserControl
    {
        public static SqlConnection cnx;

        public UserControlAdminTech()
        {
            InitializeComponent();
            actualisertech(dataGridViewtech);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlAdminTech_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            inserttechinfo();
            actualisertech(dataGridViewtech);


        }
        public void inserttechinfo()
        {
            cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand commande = new SqlCommand("SELECT COUNT (ID) FROM Technicien where UserName=@UserName", cnx);
            commande.Parameters.Add(new SqlParameter("@UserName", txtUsername.Text));
            int nbre = (int)commande.ExecuteScalar();
            if (nbre > 0)
            {
                MessageBox.Show($"Le nom d'utilisateur '{txtUsername.Text}' est déjà utilisé. Veuillez choisir un nom d'utilisateur différent.", "Nom d'utilisateur existant", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into Technicien(Nom,Prenom,UserName,MotDePasse,Departement,N_Service,NumBureau,NumTel,Specialite) values(@Nom,@Prenom,@UserName,@MotDePasse,@Departement,@N_Service,@NumBureau,@NumTel,@specialite)", cnx);
                cmd.Parameters.Add(new SqlParameter("@Nom", txtName.Text));
                cmd.Parameters.Add(new SqlParameter("@Prenom", txtPrenom.Text));
                cmd.Parameters.Add(new SqlParameter("@UserName", txtUsername.Text));
                cmd.Parameters.Add(new SqlParameter("@MotDePasse", txtPass.Text));
                cmd.Parameters.Add(new SqlParameter("@NumTel", txtTelephone.Text));
                cmd.Parameters.Add(new SqlParameter("@N_Service", txtService.Text));
                cmd.Parameters.Add(new SqlParameter("@Departement", txtDepartement.Text));
                cmd.Parameters.Add(new SqlParameter("@NumBureau", txtBureau.Text));
                cmd.Parameters.Add(new SqlParameter("@Specialite", txtspecialite.Text));
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable datatech()
        {
            cnx = Program.GetConnection();
            DataTable dl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Technicien", cnx);
            adapter.Fill(dl);
            return dl;
        }
        public DataGridView actualisertech(DataGridView datagridviewtech)
        {
            datagridviewtech.DataSource = datatech();
            return datagridviewtech;
        }
        public static void deletetech(DataGridView tech)
        {
            cnx = Program.GetConnection();

            if (tech.SelectedRows.Count >= 0)
            {
                cnx.Open();
                int id = (int)tech.SelectedRows[0].Cells["ID"].Value;
                SqlCommand cmd = new SqlCommand("delete from Intervention where TechnicienID = @id ; delete from Technicien where ID =@id", cnx);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.ExecuteNonQuery();
            }


        }
        public void updatetech()
        {
            if (dataGridViewtech.SelectedRows.Count > 0)
            {
                cnx.Open();
                int id = (int)dataGridViewtech.SelectedRows[0].Cells["ID"].Value;
                SqlCommand cmd = new SqlCommand("UPDATE Technicien SET Nom = @Nom, Prenom = @Prenom, UserName = @UserName, MotDePasse = @MotDePasse, Departement = @Departement, N_Service = @N_Service, NumBureau = @NumBureau, NumTel = @NumTel, Specialite = @specialite where ID = @id", cnx);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.Parameters.AddWithValue("@Nom", txtName.Text);
                cmd.Parameters.AddWithValue("@Prenom", txtPrenom.Text);
                cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                cmd.Parameters.AddWithValue("@MotDePasse", txtPass.Text);
                cmd.Parameters.AddWithValue("@Departement", txtDepartement.Text);
                cmd.Parameters.AddWithValue("@N_Service", txtService.Text);
                cmd.Parameters.AddWithValue("@NumBureau", txtBureau.Text);
                cmd.Parameters.AddWithValue("@NumTel", txtTelephone.Text);
                cmd.Parameters.AddWithValue("@Specialite", txtspecialite.Text);

                cmd.ExecuteNonQuery();
                cnx.Close();
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            deletetech(dataGridViewtech);
            actualisertech(dataGridViewtech);
        }
        public void viderboxes()
        {
            txtName.Clear();
            txtPrenom.Clear();
            txtBureau.Clear();
            txtDepartement.Clear();
            txtTelephone.Clear();
            txtService.Clear();
            txtspecialite.Clear();
            txtUsername.Clear();
            txtPass.Clear();

        }

        private void btnmettreajour_Click(object sender, EventArgs e)
        {

        }

        private void txtspecialite_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmettreajour_Click_1(object sender, EventArgs e)
        {
            updatetech();
            actualisertech(dataGridViewtech);
        }

        private void btnvider_Click(object sender, EventArgs e)
        {
            viderboxes();
        }

        private void dataGridViewtech_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) {
                DataGridViewRow row = this.dataGridViewtech.Rows[e.RowIndex];
                txtName.Text = row.Cells["Nom"].Value.ToString();
                txtPrenom.Text = row.Cells["Prenom"].Value.ToString();
                txtUsername.Text = row.Cells["UserName"].Value.ToString();
                txtPass.Text = row.Cells["MotDepasse"].Value.ToString();
                txtTelephone.Text = row.Cells["NumTel"].Value.ToString();
                txtDepartement.Text = row.Cells["Departement"].Value.ToString(); 
                txtspecialite.Text = row.Cells["specialite"].Value.ToString();
                txtService.Text = row.Cells["N_service"].Value.ToString();
                txtBureau.Text = row.Cells["NumBureau"].Value.ToString();


            }
        }
    }
}
