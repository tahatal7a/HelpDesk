using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk
{
    internal class Classtechtick
    {
        public static int TicketID;
        public static string Descriptio;
        public static int CategorieID;
        public static int EmployeID;
        public static DateTime? DateOuverture;
        public static DateTime? DateCloture;
        public static string Statut;
        public static SqlConnection cnx = Program.GetConnection();

        public static  int TicketInformation()
        {
            
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT TicketID FROM Ticket WHERE Statut = 'ouvert'", cnx);
            adapter.Fill(dataTable);

            return dataTable.Rows.Count;

           
        }

        public static int TicketResolue2() {
             cnx.Open();
            SqlCommand cmd = new SqlCommand("select count (Ticket.TicketID) from Ticket inner join Intervention on Ticket.TicketID =Intervention.TicketID where Statut = 'résolu' and TechnicienID=@id", cnx);
            cmd.Parameters.AddWithValue("@id", Classtech.ID);
            int nombreTicketsResolus = (int)cmd.ExecuteScalar();
            cnx.Close();
            return nombreTicketsResolus;
        


        }
        public static int tickref ()
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(TicketID) FROM Ticket WHERE Statut = 'ouvert';", cnx);
            int nombreTicketsRef = (int)cmd.ExecuteScalar();
            cnx.Close();
            return nombreTicketsRef;


        }

    }

}




