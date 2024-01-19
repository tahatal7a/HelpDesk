using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk.usercontroltech
{
    public partial class MaficheUsControl : UserControl
    {
        public MaficheUsControl()
        {
            InitializeComponent();
            IDlabel.Text = Classtech.ID.ToString();

            DEPlabel.Text = Classtech.Departement.ToString();
            NAMElabel.Text = Classtech.Nom.ToString();
            prenomlabel.Text = Classtech.Prenom.ToString();
            SERVlabrl.Text = Classtech.Service.ToString();
            SPEClabel.Text = Classtech.Specialité.ToString();
            BURlabel.Text = Classtech.Nbureau.ToString();
            TELElabel.Text = Classtech.Ntel.ToString();



        }
        private void MaficheUsControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void IDlabel_Click(object sender, EventArgs e)
        {

        }

        private void NAMElabel_Click(object sender, EventArgs e)
        {

        }
    }

}



