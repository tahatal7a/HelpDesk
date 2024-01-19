namespace Helpdesk.AdminUserControls
{
    partial class UserControlAdminTech
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            Nom = new Label();
            btnajouter = new Button();
            btnsupprimer = new Button();
            btnmettreajour = new Button();
            btnvider = new Button();
            Usename = new Label();
            txtUsername = new TextBox();
            Passe = new Label();
            Prenom = new Label();
            txtPrenom = new TextBox();
            Telephone = new Label();
            txtTelephone = new TextBox();
            Departement = new Label();
            txtDepartement = new TextBox();
            Service = new Label();
            txtService = new TextBox();
            Specialite = new Label();
            Bureau = new Label();
            txtBureau = new TextBox();
            dataGridViewtech = new DataGridView();
            txtPass = new TextBox();
            txtspecialite = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewtech).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(119, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(196, 27);
            txtName.TabIndex = 0;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.BackColor = Color.Transparent;
            Nom.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Nom.ForeColor = Color.White;
            Nom.Location = new Point(9, 44);
            Nom.Name = "Nom";
            Nom.Size = new Size(59, 21);
            Nom.TabIndex = 1;
            Nom.Text = "Nom :";
            Nom.Click += label1_Click;
            // 
            // btnajouter
            // 
            btnajouter.BackColor = Color.SeaGreen;
            btnajouter.FlatAppearance.BorderSize = 0;
            btnajouter.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnajouter.ForeColor = Color.White;
            btnajouter.Location = new Point(36, 225);
            btnajouter.Name = "btnajouter";
            btnajouter.Size = new Size(168, 58);
            btnajouter.TabIndex = 21;
            btnajouter.Text = "Ajouter";
            btnajouter.UseVisualStyleBackColor = false;
            btnajouter.Click += btnajouter_Click;
            // 
            // btnsupprimer
            // 
            btnsupprimer.BackColor = Color.FromArgb(240, 30, 44);
            btnsupprimer.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsupprimer.ForeColor = Color.White;
            btnsupprimer.Location = new Point(240, 225);
            btnsupprimer.Name = "btnsupprimer";
            btnsupprimer.Size = new Size(168, 58);
            btnsupprimer.TabIndex = 22;
            btnsupprimer.Text = "Supprimer";
            btnsupprimer.UseVisualStyleBackColor = false;
            btnsupprimer.Click += btnsupprimer_Click;
            // 
            // btnmettreajour
            // 
            btnmettreajour.BackColor = Color.White;
            btnmettreajour.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmettreajour.ForeColor = Color.Black;
            btnmettreajour.Location = new Point(443, 225);
            btnmettreajour.Name = "btnmettreajour";
            btnmettreajour.Size = new Size(168, 58);
            btnmettreajour.TabIndex = 23;
            btnmettreajour.Text = "Mettre à jour";
            btnmettreajour.UseVisualStyleBackColor = false;
            btnmettreajour.Click += btnmettreajour_Click_1;
            // 
            // btnvider
            // 
            btnvider.BackColor = Color.Black;
            btnvider.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnvider.ForeColor = Color.OldLace;
            btnvider.Location = new Point(643, 225);
            btnvider.Name = "btnvider";
            btnvider.Size = new Size(168, 58);
            btnvider.TabIndex = 24;
            btnvider.Text = "Vider";
            btnvider.UseVisualStyleBackColor = false;
            btnvider.Click += btnvider_Click;
            // 
            // Usename
            // 
            Usename.AutoSize = true;
            Usename.BackColor = Color.Transparent;
            Usename.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Usename.ForeColor = Color.White;
            Usename.Location = new Point(340, 44);
            Usename.Name = "Usename";
            Usename.Size = new Size(110, 21);
            Usename.TabIndex = 26;
            Usename.Text = "UserName :";
            Usename.Click += label1_Click_1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(459, 38);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(196, 27);
            txtUsername.TabIndex = 25;
            // 
            // Passe
            // 
            Passe.AutoSize = true;
            Passe.BackColor = Color.Transparent;
            Passe.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Passe.ForeColor = Color.White;
            Passe.Location = new Point(673, 48);
            Passe.Name = "Passe";
            Passe.Size = new Size(136, 21);
            Passe.TabIndex = 28;
            Passe.Text = "Mot De Passe :";
            Passe.Click += label2_Click_1;
            // 
            // Prenom
            // 
            Prenom.AutoSize = true;
            Prenom.BackColor = Color.Transparent;
            Prenom.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Prenom.ForeColor = Color.White;
            Prenom.Location = new Point(0, 106);
            Prenom.Name = "Prenom";
            Prenom.Size = new Size(82, 21);
            Prenom.TabIndex = 30;
            Prenom.Text = "Prenom :";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(119, 104);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(196, 27);
            txtPrenom.TabIndex = 29;
            // 
            // Telephone
            // 
            Telephone.AutoSize = true;
            Telephone.BackColor = Color.Transparent;
            Telephone.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Telephone.ForeColor = Color.White;
            Telephone.Location = new Point(340, 106);
            Telephone.Name = "Telephone";
            Telephone.Size = new Size(113, 21);
            Telephone.TabIndex = 32;
            Telephone.Text = "Telephone :";
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(459, 104);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(196, 27);
            txtTelephone.TabIndex = 31;
            // 
            // Departement
            // 
            Departement.AutoSize = true;
            Departement.BackColor = Color.Transparent;
            Departement.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Departement.ForeColor = Color.White;
            Departement.Location = new Point(673, 110);
            Departement.Name = "Departement";
            Departement.Size = new Size(140, 21);
            Departement.TabIndex = 34;
            Departement.Text = "Departement :";
            Departement.Click += label5_Click;
            // 
            // txtDepartement
            // 
            txtDepartement.Location = new Point(831, 106);
            txtDepartement.Name = "txtDepartement";
            txtDepartement.Size = new Size(196, 27);
            txtDepartement.TabIndex = 33;
            // 
            // Service
            // 
            Service.AutoSize = true;
            Service.BackColor = Color.Transparent;
            Service.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Service.ForeColor = Color.White;
            Service.Location = new Point(673, 167);
            Service.Name = "Service";
            Service.Size = new Size(84, 21);
            Service.TabIndex = 36;
            Service.Text = "Service :";
            // 
            // txtService
            // 
            txtService.Location = new Point(831, 163);
            txtService.Name = "txtService";
            txtService.Size = new Size(196, 27);
            txtService.TabIndex = 35;
            txtService.TextChanged += textBox6_TextChanged;
            // 
            // Specialite
            // 
            Specialite.AutoSize = true;
            Specialite.BackColor = Color.Transparent;
            Specialite.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Specialite.ForeColor = Color.White;
            Specialite.Location = new Point(0, 167);
            Specialite.Name = "Specialite";
            Specialite.Size = new Size(101, 21);
            Specialite.TabIndex = 38;
            Specialite.Text = "Specialité :";
            // 
            // Bureau
            // 
            Bureau.AutoSize = true;
            Bureau.BackColor = Color.Transparent;
            Bureau.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Bureau.ForeColor = Color.White;
            Bureau.Location = new Point(340, 163);
            Bureau.Name = "Bureau";
            Bureau.Size = new Size(106, 21);
            Bureau.TabIndex = 40;
            Bureau.Text = "N° Bureau :";
            // 
            // txtBureau
            // 
            txtBureau.Location = new Point(459, 161);
            txtBureau.Name = "txtBureau";
            txtBureau.Size = new Size(196, 27);
            txtBureau.TabIndex = 39;
            // 
            // dataGridViewtech
            // 
            dataGridViewtech.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewtech.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewtech.BackgroundColor = Color.FromArgb(11, 29, 36);
            dataGridViewtech.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewtech.Location = new Point(12, 310);
            dataGridViewtech.Name = "dataGridViewtech";
            dataGridViewtech.ReadOnly = true;
            dataGridViewtech.RowHeadersVisible = false;
            dataGridViewtech.RowHeadersWidth = 51;
            dataGridViewtech.RowTemplate.Height = 29;
            dataGridViewtech.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewtech.Size = new Size(1015, 341);
            dataGridViewtech.TabIndex = 41;
            dataGridViewtech.CellContentClick += dataGridViewtech_CellContentClick;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(831, 44);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(196, 27);
            txtPass.TabIndex = 27;
            txtPass.TextChanged += textBox2_TextChanged_1;
            // 
            // txtspecialite
            // 
            txtspecialite.Location = new Point(119, 157);
            txtspecialite.Name = "txtspecialite";
            txtspecialite.Size = new Size(196, 27);
            txtspecialite.TabIndex = 42;
            txtspecialite.TextChanged += txtspecialite_TextChanged;
            // 
            // UserControlAdminTech
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 29, 36);
            Controls.Add(txtspecialite);
            Controls.Add(dataGridViewtech);
            Controls.Add(Bureau);
            Controls.Add(txtBureau);
            Controls.Add(Specialite);
            Controls.Add(Service);
            Controls.Add(txtService);
            Controls.Add(Departement);
            Controls.Add(txtDepartement);
            Controls.Add(Telephone);
            Controls.Add(txtTelephone);
            Controls.Add(Prenom);
            Controls.Add(txtPrenom);
            Controls.Add(Passe);
            Controls.Add(txtPass);
            Controls.Add(Usename);
            Controls.Add(txtUsername);
            Controls.Add(btnvider);
            Controls.Add(btnmettreajour);
            Controls.Add(btnsupprimer);
            Controls.Add(btnajouter);
            Controls.Add(Nom);
            Controls.Add(txtName);
            ForeColor = SystemColors.HotTrack;
            Name = "UserControlAdminTech";
            Size = new Size(1030, 672);
            Load += UserControlAdminTech_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewtech).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Nom;
        private Button btnajouter;
        private Button btnsupprimer;
        private Button btnmettreajour;
        private Button btnvider;
        private Label Usename;
        private Label Passe;
        private Label Prenom;
        private Label Telephone;
        private Label Departement;
        private Label Service;
        private Label Specialite;
        private Label Bureau;
        private DataGridView dataGridViewtech;
        private TextBox txtName;
        private TextBox txtUsername;
        private TextBox txtPrenom;
        private TextBox txtTelephone;
        private TextBox txtDepartement;
        private TextBox txtService;
        private TextBox txtBureau;
        private TextBox txtPass;
        private TextBox txtspecialite;
    }
}
