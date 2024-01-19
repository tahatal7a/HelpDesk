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
    public partial class UserControlAdminDash : UserControl
    {
        public static SqlConnection cnx;

        public UserControlAdminDash()
        {

            InitializeComponent();

            ticketresolut.Text = TicketResolueadmin().ToString();
            nombretech.Text = nombretech1().ToString();
            nombreticket.Text = nombreticket1().ToString();
            nombreemploye.Text = nombreemploye1().ToString();
            ticketresolut.Parent = TickResPicture;
            ticketresolut.BackColor = Color.Transparent;
            nombreticket.Parent = pictureBox2;
            nombreticket.BackColor = Color.Transparent;
            nombreemploye.Parent = pictureBox3;
            nombreemploye.BackColor = Color.Transparent;
            nombretech.Parent = pictureBox1;
            nombretech.BackColor = Color.Transparent;
            nombretech.ForeColor = Color.White;
            nombreticket.ForeColor = Color.White;




        }

        private void ticketresolut_Click(object sender, EventArgs e)
        {

        }
        public static int TicketResolueadmin()
        {
            cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select count(TicketID) from Ticket where Statut ='résolu';", cnx);
            int nombreTicketsResolus = (int)cmd.ExecuteScalar();

            return nombreTicketsResolus;


        }
        public static int nombretech1()
        {
            cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select count(Id) from Technicien", cnx);
            int nombreteech = (int)cmd.ExecuteScalar();
            return nombreteech;

        }
        public static int nombreticket1()
        {
            cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select count(TicketID) from Ticket", cnx);
            int nombreticket1 = (int)cmd.ExecuteScalar();
            return nombreticket1;

        }
        public static int nombreemploye1()
        {
            cnx = Program.GetConnection();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select count(ID) from Employe", cnx);
            int nombreemploye1 = (int)cmd.ExecuteScalar();
            return nombreemploye1;

        }

        private void nombretech_Click(object sender, EventArgs e)
        {

        }

        private void nombreticket_Click(object sender, EventArgs e)
        {

        }

        private void UserControlAdminDash_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nombreemploye_Click(object sender, EventArgs e)
        {

        }
    }
}
