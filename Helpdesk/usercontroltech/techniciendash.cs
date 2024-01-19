using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.usercontroltech
{
    public partial class techniciendash : UserControl
    {
        public techniciendash()
        {




            InitializeComponent();
            idlabel.Parent = idpicture;
            TickResLabel.Parent = TickResPicture;
            tickOuvLabel.Parent = TIckOuvPicture;
            idlabel.Text = Classtech.ID.ToString();
            idlabel.ForeColor = System.Drawing.Color.White;
            refreshinfo();
            tickOuvLabel.ForeColor = System.Drawing.Color.White;
            TickResLabel.ForeColor = System.Drawing.Color.White;



                  
        }




        //actulisation des information de dashboard
        public void refreshinfo ()
        {
            tickOuvLabel.Text = nbreticketouv().ToString();

            TickResLabel.Text = Classtechtick.TicketResolue2().ToString();
          



        }

        //fonction pour rendre le nombre de ticket ouvert en cours
        private int nbreticketouv()
        {
            SqlConnection cnx =Program.GetConnection();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select COUNT(t.TicketID) from Ticket t  full outer join Intervention I on t.TicketID = I.TicketID inner join Employe e on t.EmployeID=e.ID where i.TicketID IS NULL", cnx);
            int nombreTicketsResolus = (int)cmd.ExecuteScalar();
            cnx.Close();
            return nombreTicketsResolus;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void techniciendash_Load(object sender, EventArgs e)
        {

        }
    }
}
