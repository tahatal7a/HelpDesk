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

namespace Helpdesk.UserControls
{
    public partial class UserControlNotification : UserControl
    {
        public event EventHandler redflaghide;
        SqlConnection cnx = Program.GetConnection();

        public UserControlNotification()
        {
            InitializeComponent();
            notiflow();
        }

        private void UserControlNotification_Load(object sender, EventArgs e)
        {

        }
        //affichage des notifications sous forme de flowyout
        public void notiflow()
        {
            //importaion des informations de la base de données
            flowyoutaffichenotif.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select n.TicketID,MessageNotif,n.Datenotif,IsRead   from NotificationLog n Inner join Ticket t on n.TicketID=t.TicketID where  EmployeID=@EmployeID order BY Datenotif DESC", cnx);
            cmd.Parameters.AddWithValue("@EmployeID", Employe.id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable notif = new DataTable();
            adapter.Fill(notif);


            foreach (DataRow row in notif.Rows)
            {
                flowyoutmessagenotif flownotif = new flowyoutmessagenotif();

                {
                    flownotif.txtmessagenotif.Text = row["MessageNotif"].ToString();
                    DateTime dateNotif = (DateTime)row["Datenotif"];
                    flownotif.date.Text = dateNotif.ToString("dd MMM, HH:mm");
                    bool isread = (bool)row["IsRead"];
                    if (isread == false)
                    {
                        flownotif.BackColor = Color.LightSteelBlue;
                        flownotif.attention.Visible = true;
                    }


                }


                flowyoutaffichenotif.Controls.Add(flownotif);




            }

        }
        //marquer notification comme lu
        public void asread()
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Update NotificationLog set IsRead=1 from NotificationLog n inner join Ticket t on n.TicketID=t.TicketID where EmployeID=@EmployeID", cnx);
            cmd.Parameters.AddWithValue("@EmployeID", Employe.id);
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            asread();
            notiflow();
            redflaghide?.Invoke(this, EventArgs.Empty);



        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
