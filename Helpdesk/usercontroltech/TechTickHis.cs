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

namespace Helpdesk.usercontroltech
{
    public partial class TechTickHis : UserControl
    {
        public TechTickHis()
        {
            InitializeComponent();
            historique();

        }

        private void TechTickHis_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public  void historique()
        {
            SqlConnection cnx = Program.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select  InterventionID , TicketID ,DateDebut, Datefin , Commentaires from Intervention inner join Technicien on Intervention.TechnicienID = Technicien.ID where ID = @id ", cnx);
            adapter.SelectCommand.Parameters.AddWithValue("@id", Classtech.ID);
            adapter.Fill(dt);
            HistoriqueGridView.DataSource=dt;   


        }
    }
}
