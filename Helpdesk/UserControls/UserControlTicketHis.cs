using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.UserControls
{
    public partial class UserControlTicketHis : UserControl
    {
        public UserControlTicketHis()
        {
            InitializeComponent();
            Displaydata();
        }
        //affichage historique de ticket
        public void Displaydata()
        {
            Form1.cnx = Program.GetConnection();
            Form1.ds = new DataSet();
            Form1.adapter = new SqlDataAdapter("select TicketID,t.Description,Nom as Categorie,DateOuverture,DateCloture,statut from Ticket t inner join CategorieProbleme c on t.CategorieID=c.CategorieID  where EmployeID=@ID ", Form1.cnx);
            Form1.adapter.SelectCommand.Parameters.AddWithValue("@ID", Employe.id);
            Form1.adapter.Fill(Form1.ds, "ticketss");
            dataGridView1.DataSource = Form1.ds.Tables["ticketss"];

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlTicketHis_Load(object sender, EventArgs e)
        {

        }
    }
}
