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

namespace Helpdesk.usercontroltech
{
    public partial class ticketflow : UserControl


    {




        public ticketflow()
        {
            InitializeComponent();

        }
        public static SqlConnection GetConnection()
        {
            string strCnx = @"server=.\SQLEXPRESS;database=helpdesk_db;Integrated Security=true";
            SqlConnection cnx = new SqlConnection(strCnx);
            return cnx;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idTicket = int.Parse(labelid.Text);
            int idTechnicien = Classtech.ID;
            String NameTech = Classtech.Nom;
            String prenomTech = Classtech.Prenom;

            using (SqlConnection cnx = GetConnection())
            {
                cnx.Open();

               


                    SqlCommand insertCommand = new SqlCommand($"INSERT INTO Intervention(TicketID, TechnicienID, DateDebut, DateFin, Commentaires, Evaluation) " +
                                        $"VALUES (@TicketID , @TechnicienID, GETDATE(), NULL, NULL, NULL);update Ticket set Statut ='en cours' where TicketID= @TicketID;" +
                                        $"Insert Into NotificationLog (TicketID,MessageNotif,Datenotif,IsRead) values (@TicketID,'Votre ticket ID= ' + CAST(@TicketID AS VARCHAR) + ' a été pris en charge par notre technicien ' + @TechName + ' ' + @Prenom,GETDATE(),0)", cnx);

                    insertCommand.Parameters.AddWithValue("@TicketID", idTicket);
                    insertCommand.Parameters.AddWithValue("@TechnicienID", idTechnicien);
                    insertCommand.Parameters.AddWithValue("@TechName", NameTech);
                    insertCommand.Parameters.AddWithValue("@Prenom", prenomTech);




                    //executer les requetes
                    insertCommand.ExecuteNonQuery();

                  
                   



                
                // MessageBox.Show("Ticket Acceptées");
                MessageBox.Show("Ticket Acceptées", "Acceptation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1); // Default button



            }


            ((Vtickets)this.Parent.Parent).RefreshTickets();


        }








        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
