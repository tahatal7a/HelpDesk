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

namespace Helpdesk.AdminUserControls
{
    public partial class UserControlAdminTickets : UserControl
    {
        public static SqlConnection cnx;
        public UserControlAdminTickets()
        {
            InitializeComponent();
            actualiserticket();


        }

        private void UserControlAdminTickets_Load(object sender, EventArgs e)
        {

        }

        private void DateOuverture_ValueChanged(object sender, EventArgs e)
        {
            txtouvert.CustomFormat = "dd/MM/yyyy hh:mm";

        }

        private void DateOuverture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtouvert.CustomFormat = " ";
            }
        }

        private void DateCloture_ValueChanged(object sender, EventArgs e)
        {
            txtcloture.CustomFormat = "dd/MM/yyyy hh:mm";

        }

        private void DateCloture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                txtcloture.CustomFormat = " ";
            }
        }

        private void comboBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void insertticket()
        {
            cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("insert into Ticket(CategorieID, Description, EmployeID, DateOuverture, DateCloture, Statut, Priorité) values(@CategorieID,@Description, @EmployeID, @DateOuverture, @DateCloture, @Statut, @Priorité)", cnx);
            cmd.Parameters.Add(new SqlParameter("@CategorieID", txtcategorie.Text));
            cmd.Parameters.Add(new SqlParameter("@Description", txtdescription.Text));
            cmd.Parameters.Add(new SqlParameter("@EmployeID", txtemploye.Text));
            cmd.Parameters.Add(new SqlParameter("@DateOuverture", txtouvert.Value));
            cmd.Parameters.Add(new SqlParameter("@DateCloture", txtcloture.Value));
            cmd.Parameters.Add(new SqlParameter("@Statut", txtstatut.Text));
            cmd.Parameters.Add(new SqlParameter("@Priorité", txtpriorite.Text));
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public static DataTable dataticket()
        {
            cnx = Program.GetConnection();
            DataTable dticket = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Ticket", cnx);
            adapter.Fill(dticket);
            return dticket;
        }
        public DataGridView actualiserticket()
        {
            datagridviewticket.DataSource = dataticket();
            return datagridviewticket;
        }
        public void deleteticket()
        {
            cnx = Program.GetConnection();
            if (datagridviewticket.SelectedRows.Count >= 0)
            {
                cnx.Open();
                int id = (int)datagridviewticket.SelectedRows[0].Cells["TicketID"].Value;
                SqlCommand cmd = new SqlCommand(" delete from Ticket where TicketID =@id", cnx);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.ExecuteNonQuery();
            }
        }
        public void updateticket()
        {
            if (datagridviewticket.SelectedRows.Count > 0)
            {
                cnx.Open();
                int id = (int)datagridviewticket.SelectedRows[0].Cells["TicketID"].Value;
                SqlCommand cmd = new SqlCommand("UPDATE Ticket SET CategorieID= @CategorieID,Description= @Description, EmployeID= @EmployeID,DateOuverture= @DateOuverture,DateCloture= @DateCloture, Statut=@Statut,Priorité= @Priorité where TicketID = @id", cnx);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.Parameters.AddWithValue("@CategorieID", txtcategorie.Text);
                cmd.Parameters.AddWithValue("@Description", txtdescription.Text);
                cmd.Parameters.AddWithValue("@EmployeID", txtemploye.Text);
                cmd.Parameters.AddWithValue("@DateOuverture", txtouvert.Value);
                cmd.Parameters.AddWithValue("@DateCloture", txtcloture.Value);
                cmd.Parameters.AddWithValue("@Statut", txtstatut.Text);
                cmd.Parameters.AddWithValue("@Priorité", txtpriorite.Text);
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
        }
        public void viderboxes()
        {
            txtcategorie.SelectedIndex = -1;
            txtdescription.Clear();
            txtemploye.Clear();
            txtpriorite.SelectedIndex = -1;
            txtstatut.SelectedIndex = -1;






        }
        private void btnajouter_Click(object sender, EventArgs e)
        {
            insertticket();
            actualiserticket();
        }

        private void btnvider_Click(object sender, EventArgs e)
        {
            viderboxes();
        }

        private void btnmettreajour_Click(object sender, EventArgs e)
        {
            notificationupdate();
            updateticket();
            actualiserticket();
         
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            deleteticket();
            actualiserticket();
        }
        private void notificationupdate()
        {
            cnx.Open();
            int id = (int)datagridviewticket.SelectedRows[0].Cells["TicketID"].Value;

            SqlCommand cmd = new SqlCommand("INSERT INTO NotificationLog(TicketID,MessageNotif,Datenotif,IsRead) Values(@TicketID,'Un admin a mis a jour votre ticket de ID='+cast(@TicketID as varchar)+'',GETDATE(),0)",cnx
                );
            cmd.Parameters.AddWithValue("@TicketID", id);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void datagridviewticket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.datagridviewticket.Rows[e.RowIndex];

                txtcategorie.Text = row.Cells["CategorieID"].Value.ToString();
                txtemploye.Text = row.Cells["EmployeID"].Value.ToString();
                txtstatut.Text = row.Cells["Statut"].Value.ToString();
                txtstatut.Text = row.Cells["Statut"].Value.ToString();
                txtstatut.Text = row.Cells["Statut"].Value.ToString();
                txtdescription.Text = row.Cells["Description"].Value.ToString();
                txtpriorite.Text = row.Cells["Priorité"].Value.ToString();
                txtouvert.Text = row.Cells["DateOuverture"].Value.ToString();
                txtcloture.Text = row.Cells["DateCloture"].Value.ToString();




            }










        }

        private void txtcategorie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

