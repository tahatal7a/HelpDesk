using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Helpdesk.AdminUserControls
{
    public partial class UserControlAdminEmploye : UserControl
    {
        public static SqlConnection cnx;
        public UserControlAdminEmploye()
        {
            InitializeComponent();
            refresh(dataGridViewemp);
            searchboxcombo.SelectedIndex = 0;
            searchbox.TextChanged += searchfunction;

        }
        //cette fonction permet de filtrer datagridview  selon le search box
        private void searchfunction(object sender, EventArgs e) 
        {
        DataView dv = new DataView(dataemp());
            if (!string.IsNullOrEmpty(searchbox.Text))
            {
                if (searchboxcombo.SelectedIndex == 0)
                {
                    try
                    {
                        dv.RowFilter = $"ID = {searchbox.Text}";
                    }
                    catch {
                        MessageBox.Show("Veuillez entrer un nombre valide comme ID.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    dv.RowFilter = $"{searchboxcombo.SelectedItem} LIKE '%{searchbox.Text}%'";
                }

                
            }
            dataGridViewemp.DataSource = dv;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewemp.Rows[e.RowIndex];
                txtName.Text = row.Cells["Nom"].Value.ToString();
                txtPrenom.Text = row.Cells["Prenom"].Value.ToString();
                txtUsername.Text = row.Cells["UserName"].Value.ToString();
                txtPass.Text = row.Cells["MotDePasse"].Value.ToString();
                txtTelephone.Text = row.Cells["NumTel"].Value.ToString();
                txtService.Text = row.Cells["N_Service"].Value.ToString();
                txtEtage.Text = row.Cells["Etage"].Value.ToString();
                txtBureau.Text = row.Cells["NumBureau"].Value.ToString();
                txtDepartement.Text = row.Cells["Departement"].Value.ToString();









            }
        }

        private void UserControlAdminEmploye_Load(object sender, EventArgs e)
        {

        }
        public void insertempinfo()
        {
            cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand commande = new SqlCommand("SELECT COUNT (ID) FROM Employe where UserName=@UserName", cnx);
            commande.Parameters.Add(new SqlParameter("@UserName", txtUsername.Text));
            int nbre = (int)commande.ExecuteScalar();
            if (nbre > 0)
            {
                MessageBox.Show($"Le nom d'utilisateur '{txtUsername.Text}' est déjà utilisé. Veuillez choisir un nom d'utilisateur différent.", "Nom d'utilisateur existant", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into Employe(Nom,Prenom,UserName,MotDePasse,Departement,N_Service,NumBureau,NumTel,Etage) values(@Nom,@Prenom,@UserName,@MotDePasse,@Departement,@N_Service,@NumBureau,@NumTel,@Etage)", cnx);
                cmd.Parameters.Add(new SqlParameter("@Nom", txtName.Text));
                cmd.Parameters.Add(new SqlParameter("@Prenom", txtPrenom.Text));
                cmd.Parameters.Add(new SqlParameter("@UserName", txtUsername.Text));
                cmd.Parameters.Add(new SqlParameter("@MotDePasse", txtPass.Text));
                cmd.Parameters.Add(new SqlParameter("@NumTel", txtTelephone.Text));
                cmd.Parameters.Add(new SqlParameter("@N_Service", txtService.Text));
                cmd.Parameters.Add(new SqlParameter("@Departement", txtDepartement.Text));
                cmd.Parameters.Add(new SqlParameter("@Etage", txtEtage.Text));
                cmd.Parameters.Add(new SqlParameter("@NumBureau", txtBureau.Text));
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
        }
        public static DataTable dataemp()
        {
            cnx = Program.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Employe", cnx);
            adapter.Fill(dt);
            return dt;

        }
        public static void deleterow(DataGridView dtv)
        {
            cnx = Program.GetConnection();

            if (dtv.SelectedRows.Count >= 0)
            {
                cnx.Open();
                int id = (int)dtv.SelectedRows[0].Cells["ID"].Value;
                SqlCommand cmd = new SqlCommand("delete from Employe where ID =@id", cnx);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.ExecuteNonQuery();

            }
        }
        public static DataGridView refresh(DataGridView dataGridViewemp)
        {
            DataTable empable = dataemp();
            dataGridViewemp.DataSource = empable;

            return dataGridViewemp;

        }
        public void updatetable()
        {
            if (dataGridViewemp.SelectedRows.Count > 0)
            {
                cnx.Open();
                int id = (int)dataGridViewemp.SelectedRows[0].Cells["ID"].Value;
                SqlCommand cmd = new SqlCommand("UPDATE Employe SET Nom = @Nom, Prenom = @Prenom, UserName = @UserName, MotDePasse = @MotDePasse, Departement = @Departement, N_Service = @N_Service, NumBureau = @NumBureau, NumTel = @NumTel, Etage = @Etage WHERE ID = @ID", cnx);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.Parameters.AddWithValue("@Nom", txtName.Text);
                cmd.Parameters.AddWithValue("@Prenom", txtPrenom.Text);
                cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                cmd.Parameters.AddWithValue("@MotDePasse", txtPass.Text);
                cmd.Parameters.AddWithValue("@Departement", txtDepartement.Text);
                cmd.Parameters.AddWithValue("@N_Service", txtService.Text);
                cmd.Parameters.AddWithValue("@NumBureau", txtBureau.Text);
                cmd.Parameters.AddWithValue("@NumTel", txtTelephone.Text);
                cmd.Parameters.AddWithValue("@Etage", txtEtage.Text);

                cmd.ExecuteNonQuery();
                cnx.Close();
            }
        }

        public void clearboxes()
        {
            txtName.Clear();
            txtPrenom.Clear();
            txtBureau.Clear();
            txtDepartement.Clear();
            txtTelephone.Clear();
            txtService.Clear();
            txtEtage.Clear();
            txtUsername.Clear();
            txtPass.Clear();

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            insertempinfo();
            refresh(dataGridViewemp);

        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            deleterow(dataGridViewemp);
            refresh(dataGridViewemp);


        }

        private void btnvider_Click(object sender, EventArgs e)
        {
            clearboxes();
        }

        private void btnmettreajour_Click(object sender, EventArgs e)
        {
            updatetable();
            refresh(dataGridViewemp);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
