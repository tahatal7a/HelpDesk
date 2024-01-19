using Helpdesk.UserControls;
using Helpdesk.usercontroltech;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk
{
    public partial class TechnicienForm : Form
    {
        // déclaration et d'initialisation de dashboard 
        techniciendash techdash = new techniciendash();
        MaficheUsControl mafiche = new MaficheUsControl();
        TechTickHis HisTick = new TechTickHis();
        Vtickets VT = new Vtickets();
        ticteccontrole tictec = new ticteccontrole();


        public TechnicienForm()
        {
            InitializeComponent();
            techdash.refreshinfo();
            mainpanel_tech.Controls.Clear();
            mainpanel_tech.Controls.Add(techdash);
            techdash.Dock = DockStyle.Fill;


            tictec.RefreshTickets();




        }

        private void techniciensButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {

        }

        private void HistoryButton_Click_1(object sender, EventArgs e)
        {

        }

        private void ticketsButton_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HistoryButton_Click_2(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {

        }

        private void TechnicienForm_Load(object sender, EventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            mainpanel_tech.Controls.Clear();
            mainpanel_tech.Controls.Add(techdash);
            techdash.Dock = DockStyle.Fill;

            //changelent de color lors du click sur button 
            dashboardButton.BackColor = Color.Black;
            ficheBtn.BackColor = ColorTranslator.FromHtml("#004AAD");
            ticketsButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            HistoryButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            buttoncontrole.BackColor = ColorTranslator.FromHtml("#004AAD");
            techdash.refreshinfo();








        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Show();

        }

        private void employeButton_Click(object sender, EventArgs e)
        {
            mainpanel_tech.Controls.Clear();
            mainpanel_tech.Controls.Add(mafiche);
            mafiche.Dock = DockStyle.Fill;

            ficheBtn.BackColor = Color.Black;
            dashboardButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            ticketsButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            HistoryButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            buttoncontrole.BackColor = ColorTranslator.FromHtml("#004AAD");

        }

        private void ticketsButton_Click_1(object sender, EventArgs e)
        {
            ticketsButton.BackColor = Color.Black;
            dashboardButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            ficheBtn.BackColor = ColorTranslator.FromHtml("#004AAD");
            HistoryButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            buttoncontrole.BackColor = ColorTranslator.FromHtml("#004AAD");


            mainpanel_tech.Controls.Clear();
            mainpanel_tech.Controls.Add(VT);
            VT.Dock = DockStyle.Fill;

        }

        private void HistoryButton_Click_3(object sender, EventArgs e)


        {
            HistoryButton.BackColor = Color.Black;
            dashboardButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            ficheBtn.BackColor = ColorTranslator.FromHtml("#004AAD");
            ticketsButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            buttoncontrole.BackColor = ColorTranslator.FromHtml("#004AAD");
            mainpanel_tech.Controls.Clear();
            mainpanel_tech.Controls.Add(HisTick);
            HisTick.Dock = DockStyle.Fill;
            HisTick.historique();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            mainpanel_tech.Controls.Clear();
            mainpanel_tech.Controls.Add(tictec);
            tictec.Dock = DockStyle.Fill;
            tictec.RefreshTickets();

            buttoncontrole.BackColor = Color.Black;
            dashboardButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            ficheBtn.BackColor = ColorTranslator.FromHtml("#004AAD");
            ticketsButton.BackColor = ColorTranslator.FromHtml("#004AAD");
            HistoryButton.BackColor = ColorTranslator.FromHtml("#004AAD");
        }
    }
}
