using Helpdesk.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk
{
    public partial class MainForm : Form

    {

        UserControlDashboard dashboard = new UserControlDashboard();
        UserControlEmploye employe;
        UserControlTechniciens techniciens = new UserControlTechniciens();
        UserControlCreateticket cre = new UserControlCreateticket();
        UserControlTicketHis his = new UserControlTicketHis();
        UserControlNotification ntf = new UserControlNotification();
        Form1 login = new Form1();

        public MainForm()
        {
            InitializeComponent();
            //intialisation du form par dashbord(Control)
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
            cre.TicketCreated += updatedatarefresh;
            dashboard.NotificationUpdated += affichered;
            ntf.redflaghide += hideit;


        }

        private void updatedatarefresh(object sender, EventArgs e)
        {
            his.Displaydata();
            ticket.ticketfun();
            dashboard.refreshntciket();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //changelent de color lors du click sur button 
            dashboardButton.BackColor = Color.Black;
            NotificationButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            employeButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            ticketsButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            HistoryButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            techniciensButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            //changer le panel vers dashbord(control)
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(dashboard);
            dashboard.notification();
            dashboard.Dock = DockStyle.Fill;
            attentionred.BackColor = ColorTranslator.FromHtml("#004AAD");

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            techniciensButton.BackColor = Color.Black;
            dashboardButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            employeButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            ticketsButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            HistoryButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            NotificationButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(techniciens);
            dashboard.Dock = DockStyle.Fill;
            attentionred.BackColor = ColorTranslator.FromHtml("#004AAD");

        }

        private void employeButton_Click(object sender, EventArgs e)
        {
            employeButton.BackColor = Color.Black;
            dashboardButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            techniciensButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            ticketsButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            HistoryButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            NotificationButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            employe = new UserControlEmploye();
            //changement de panel vers employee(Control)
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(employe);
            dashboard.Dock = DockStyle.Fill;
            attentionred.BackColor = ColorTranslator.FromHtml("#004AAD");

        }

        private void ticketsButton_Click(object sender, EventArgs e)
        {
            ticketsButton.BackColor = Color.Black;
            dashboardButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            techniciensButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            HistoryButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            NotificationButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            employeButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            attentionred.BackColor = ColorTranslator.FromHtml("#004AAD");
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(cre);
            dashboard.Dock = DockStyle.Fill;
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            HistoryButton.BackColor = Color.Black;
            dashboardButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            employeButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            techniciensButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            NotificationButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            ticketsButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(his);
            dashboard.Dock = DockStyle.Fill;
            attentionred.BackColor = ColorTranslator.FromHtml("#004AAD");

        }

        private void NotificationButton_Click(object sender, EventArgs e)
        {
            NotificationButton.BackColor = Color.Black;
            dashboardButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            ticketsButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            employeButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            techniciensButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            HistoryButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(ntf);
            ntf.notiflow();
            attentionred.BackColor = Color.Black;
        }
        private void affichered(object sender, EventArgs e)
        {
            attentionred.Visible = true;
        }
        private void hideit(object sender, EventArgs e)
        {
            attentionred.Visible = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
