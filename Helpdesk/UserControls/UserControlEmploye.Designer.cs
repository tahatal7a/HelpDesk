namespace Helpdesk.UserControls
{
    partial class UserControlEmploye
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlEmploye));
            Id_card = new PictureBox();
            Nom = new Label();
            Prnm = new Label();
            Departement = new Label();
            sevice = new Label();
            netage = new Label();
            nbureau = new Label();
            ntel = new Label();
            ((System.ComponentModel.ISupportInitialize)Id_card).BeginInit();
            SuspendLayout();
            // 
            // Id_card
            // 
            Id_card.Image = (Image)resources.GetObject("Id_card.Image");
            Id_card.Location = new Point(129, 75);
            Id_card.Name = "Id_card";
            Id_card.Size = new Size(509, 449);
            Id_card.SizeMode = PictureBoxSizeMode.CenterImage;
            Id_card.TabIndex = 0;
            Id_card.TabStop = false;
            Id_card.Click += Id_card_Click;
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.BackColor = Color.FromArgb(21, 101, 192);
            Nom.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Nom.ForeColor = SystemColors.Control;
            Nom.Location = new Point(118, 74);
            Nom.Name = "Nom";
            Nom.Size = new Size(96, 46);
            Nom.TabIndex = 1;
            Nom.Text = "Nom";
            Nom.Click += label1_Click;
            // 
            // Prnm
            // 
            Prnm.AutoSize = true;
            Prnm.BackColor = Color.FromArgb(21, 101, 192);
            Prnm.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Prnm.ForeColor = SystemColors.Control;
            Prnm.Location = new Point(118, 120);
            Prnm.Name = "Prnm";
            Prnm.Size = new Size(141, 46);
            Prnm.TabIndex = 2;
            Prnm.Text = "Prénom";
            Prnm.Click += label2_Click;
            // 
            // Departement
            // 
            Departement.AutoSize = true;
            Departement.BackColor = Color.FromArgb(21, 101, 192);
            Departement.Font = new Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Departement.ForeColor = SystemColors.Control;
            Departement.Location = new Point(320, 285);
            Departement.Name = "Departement";
            Departement.Size = new Size(49, 20);
            Departement.TabIndex = 3;
            Departement.Text = "label1";
            // 
            // sevice
            // 
            sevice.AutoSize = true;
            sevice.BackColor = Color.FromArgb(21, 101, 192);
            sevice.Font = new Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            sevice.ForeColor = SystemColors.Control;
            sevice.Location = new Point(267, 331);
            sevice.Name = "sevice";
            sevice.Size = new Size(49, 20);
            sevice.TabIndex = 4;
            sevice.Text = "label2";
            sevice.Click += sevice_Click;
            // 
            // netage
            // 
            netage.AutoSize = true;
            netage.BackColor = Color.FromArgb(21, 101, 192);
            netage.Font = new Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            netage.ForeColor = SystemColors.Control;
            netage.Location = new Point(288, 375);
            netage.Name = "netage";
            netage.Size = new Size(49, 20);
            netage.TabIndex = 5;
            netage.Text = "label3";
            netage.Click += netage_Click;
            // 
            // nbureau
            // 
            nbureau.AutoSize = true;
            nbureau.BackColor = Color.FromArgb(21, 101, 192);
            nbureau.Font = new Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nbureau.ForeColor = SystemColors.Control;
            nbureau.Location = new Point(294, 415);
            nbureau.Name = "nbureau";
            nbureau.Size = new Size(49, 20);
            nbureau.TabIndex = 6;
            nbureau.Text = "label4";
            // 
            // ntel
            // 
            ntel.AutoSize = true;
            ntel.BackColor = Color.FromArgb(21, 101, 192);
            ntel.Font = new Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ntel.ForeColor = SystemColors.Control;
            ntel.Location = new Point(267, 459);
            ntel.Name = "ntel";
            ntel.Size = new Size(49, 20);
            ntel.TabIndex = 7;
            ntel.Text = "label5";
            ntel.Click += ntel_Click;
            // 
            // UserControlEmploye
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 240, 242);
            Controls.Add(ntel);
            Controls.Add(nbureau);
            Controls.Add(netage);
            Controls.Add(sevice);
            Controls.Add(Departement);
            Controls.Add(Prnm);
            Controls.Add(Nom);
            Controls.Add(Id_card);
            Name = "UserControlEmploye";
            Size = new Size(800, 583);
            Load += UserControlEmploye_Load;
            ((System.ComponentModel.ISupportInitialize)Id_card).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Id_card;
        private Label Nom;
        private Label Prnm;
        private Label Departement;
        private Label sevice;
        private Label netage;
        private Label nbureau;
        private Label ntel;
    }
}
