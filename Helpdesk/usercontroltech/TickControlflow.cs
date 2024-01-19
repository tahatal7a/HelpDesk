using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Helpdesk.usercontroltech
{
    public partial class TickControlflow : UserControl

    {
       
        public TickControlflow()


        {
            InitializeComponent();
            label8.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;

            label9.Parent = pictureBox1;
            label9.BackColor = Color.Transparent;

            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;

            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;

            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;

            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


       


        private void button1_Click(object sender, EventArgs e)
        {

          

         





            int idTicket = int.Parse(label1.Text);


            string statut = comboBox1.Text.ToLower();

                if (statut == "fermé")
                {
                    MessageBox.Show("Ticket fermé ! ", "Fermeture", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    updatefermer();
                }
                else if (statut == "ouvert")
                {
                updatestatut();


                    MessageBox.Show("Ticket Ouvert ! ", "Ouverture", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else if (statut == "résolu")
                {
                    MessageBox.Show("Ticket résolu ! ", "Resolution", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                updatestatut();
                }
                else
                {
                    MessageBox.Show("Aucun statut choisie! ", "veuiller choisir le statut", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    
                }



            
        }

        private void updatefermer()
        {
            SqlConnection cnx = Program.GetConnection();
            cnx.Open();
            int idTicket = int.Parse(label1.Text);

            SqlCommand datefin = new SqlCommand($"UPDATE Intervention SET DateFin = GETDATE() WHERE TicketID = @TicketID;" +
                                                             $"UPDATE Ticket SET DateCloture = GETDATE(), Statut = 'fermé' WHERE TicketID = @TicketID;" +
                                                             $"INSERT INTO NotificationLog (TicketID, MessageNotif, Datenotif, IsRead) " +
                                                             $"VALUES (@TicketID, 'Votre ticket ID= ' + CAST(@TicketID AS VARCHAR) + ' a été ' + @Statut, GETDATE(), 0)", cnx);
            datefin.Parameters.AddWithValue("@TicketID", idTicket);
            datefin.Parameters.AddWithValue("@Statut", comboBox1.Text);
            datefin.ExecuteNonQuery();
            (this.Parent.Parent as ticteccontrole)?.Ticketbox();



        }


        private void updatestatut()
        {
            int idTicket = int.Parse(label1.Text);

            using (SqlConnection cnx = Program.GetConnection())
            {
                cnx.Open();
                SqlCommand UpdateCommand = new SqlCommand(
                    $"UPDATE Intervention SET Commentaires = @Commentaires WHERE TicketID = @TicketID; " +
                    $"UPDATE Ticket SET Statut = @Statut WHERE TicketID = @TicketID;" +
                    $"INSERT INTO NotificationLog (TicketID, MessageNotif, Datenotif, IsRead) " +
                    $"VALUES (@TicketID, 'Votre ticket ID= ' + CAST(@TicketID AS VARCHAR) + ' a été ' + @Statut, GETDATE(), 0) ", cnx);

                UpdateCommand.Parameters.AddWithValue("@Commentaires", textBox1.Text);
                UpdateCommand.Parameters.AddWithValue("@Statut", comboBox1.Text);
                UpdateCommand.Parameters.AddWithValue("@TicketID", idTicket);







                          // exécuter les requêtes
                                UpdateCommand.ExecuteNonQuery();
                (this.Parent.Parent as ticteccontrole)?.Ticketbox();

            }
          


        }
       private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
