using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk
{
    public static class ticket
    {
        public static int TicketID;
        public static string Descriptio;
        public static int CategorieID;
        public static int EmployeID;
        public static DateTime? DateOuverture;
        public static DateTime? DateCloture;
        public static string Statut;
        public static void ticketfun()
        {
            Form1.adapter = new SqlDataAdapter("select * from Ticket t Inner join Employe e on t.EmployeID=e.ID where  t.EmployeID=@emplyeid order by DateOuverture DESC ", Form1.cnx);
            Form1.adapter.SelectCommand.Parameters.AddWithValue("@emplyeid", Employe.id);

            Form1.adapter.Fill(Form1.ds, "ticket");
            if (Form1.ds.Tables["ticket"].Rows.Count > 0){ 
            ticket.TicketID = (int)Form1.ds.Tables["ticket"].Rows[0]["TicketID"];
            ticket.Statut = (string)Form1.ds.Tables["ticket"].Rows[0]["statut"];
            }
            else
            {
                ticket.TicketID = 0;
                ticket.Statut = "Pas de Ticket";
            }
        }

        public static int resolvedticket()
        {
            Form1.adapter = new SqlDataAdapter("select * from Ticket t Inner join Employe e on t.EmployeID=e.ID where  t.EmployeID=@emplyeid  and t.Statut='Resolved' ", Form1.cnx);
            Form1.adapter.SelectCommand.Parameters.AddWithValue("@emplyeid", Employe.id);
            Form1.adapter.Fill(Form1.ds, "resolved");
            int resolve = Form1.ds.Tables["resolved"].Rows.Count;

            return resolve;
        }
        }



    }



