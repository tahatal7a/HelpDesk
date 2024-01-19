namespace Helpdesk.AdminUserControls
{
    partial class UserControlAdminTickets
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
            Categorie = new Label();
            label1 = new Label();
            txtemploye = new TextBox();
            label2 = new Label();
            txtstatut = new ComboBox();
            label3 = new Label();
            txtdescription = new TextBox();
            txtpriorite = new ComboBox();
            label4 = new Label();
            txtouvert = new DateTimePicker();
            DateOuvert = new Label();
            DateClotur = new Label();
            txtcloture = new DateTimePicker();
            btnvider = new Button();
            btnmettreajour = new Button();
            btnsupprimer = new Button();
            btnajouter = new Button();
            datagridviewticket = new DataGridView();
            txtcategorie = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)datagridviewticket).BeginInit();
            SuspendLayout();
            // 
            // Categorie
            // 
            Categorie.AutoSize = true;
            Categorie.BackColor = Color.Transparent;
            Categorie.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Categorie.ForeColor = Color.White;
            Categorie.Location = new Point(12, 46);
            Categorie.Name = "Categorie";
            Categorie.Size = new Size(127, 21);
            Categorie.TabIndex = 46;
            Categorie.Text = "Categorie Id :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(373, 45);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 48;
            label1.Text = " Employe Id :";
            // 
            // txtemploye
            // 
            txtemploye.Location = new Point(500, 40);
            txtemploye.Name = "txtemploye";
            txtemploye.Size = new Size(209, 27);
            txtemploye.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(743, 45);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 50;
            label2.Text = " Statut :";
            // 
            // txtstatut
            // 
            txtstatut.DropDownStyle = ComboBoxStyle.DropDownList;
            txtstatut.FormattingEnabled = true;
            txtstatut.Items.AddRange(new object[] { "ouvert", "en cours", "fermé", "résolu" });
            txtstatut.Location = new Point(828, 46);
            txtstatut.Name = "txtstatut";
            txtstatut.Size = new Size(196, 28);
            txtstatut.TabIndex = 51;
            txtstatut.SelectedIndexChanged += comboBoxCategorie_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 53;
            label3.Text = "Description :";
            // 
            // txtdescription
            // 
            txtdescription.Location = new Point(166, 77);
            txtdescription.Multiline = true;
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(529, 80);
            txtdescription.TabIndex = 54;
            txtdescription.TextChanged += textBox2_TextChanged;
            // 
            // txtpriorite
            // 
            txtpriorite.DropDownStyle = ComboBoxStyle.DropDownList;
            txtpriorite.FormattingEnabled = true;
            txtpriorite.Items.AddRange(new object[] { "Haute Priorité", "Moyenne Priorité", "Basse Priorité" });
            txtpriorite.Location = new Point(828, 102);
            txtpriorite.Name = "txtpriorite";
            txtpriorite.Size = new Size(196, 28);
            txtpriorite.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(747, 106);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 55;
            label4.Text = "Priorité :";
            // 
            // txtouvert
            // 
            txtouvert.CustomFormat = " ";
            txtouvert.Format = DateTimePickerFormat.Custom;
            txtouvert.Location = new Point(166, 182);
            txtouvert.Name = "txtouvert";
            txtouvert.Size = new Size(201, 27);
            txtouvert.TabIndex = 57;
            txtouvert.ValueChanged += DateOuverture_ValueChanged;
            txtouvert.KeyDown += DateOuverture_KeyDown;
            // 
            // DateOuvert
            // 
            DateOuvert.AutoSize = true;
            DateOuvert.BackColor = Color.Transparent;
            DateOuvert.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DateOuvert.ForeColor = Color.White;
            DateOuvert.Location = new Point(12, 182);
            DateOuvert.Name = "DateOuvert";
            DateOuvert.Size = new Size(148, 21);
            DateOuvert.TabIndex = 58;
            DateOuvert.Text = "DateOuverture :";
            // 
            // DateClotur
            // 
            DateClotur.AutoSize = true;
            DateClotur.BackColor = Color.Transparent;
            DateClotur.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DateClotur.ForeColor = Color.White;
            DateClotur.Location = new Point(419, 182);
            DateClotur.Name = "DateClotur";
            DateClotur.Size = new Size(124, 21);
            DateClotur.TabIndex = 59;
            DateClotur.Text = "DateCloture :";
            // 
            // txtcloture
            // 
            txtcloture.CustomFormat = " ";
            txtcloture.Format = DateTimePickerFormat.Custom;
            txtcloture.Location = new Point(555, 182);
            txtcloture.Name = "txtcloture";
            txtcloture.Size = new Size(208, 27);
            txtcloture.TabIndex = 60;
            txtcloture.ValueChanged += DateCloture_ValueChanged;
            txtcloture.KeyDown += DateCloture_KeyDown;
            // 
            // btnvider
            // 
            btnvider.BackColor = Color.Black;
            btnvider.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnvider.ForeColor = Color.OldLace;
            btnvider.Location = new Point(700, 246);
            btnvider.Name = "btnvider";
            btnvider.Size = new Size(168, 58);
            btnvider.TabIndex = 64;
            btnvider.Text = "Vider";
            btnvider.UseVisualStyleBackColor = false;
            btnvider.Click += btnvider_Click;
            // 
            // btnmettreajour
            // 
            btnmettreajour.BackColor = Color.White;
            btnmettreajour.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmettreajour.ForeColor = Color.Black;
            btnmettreajour.Location = new Point(500, 246);
            btnmettreajour.Name = "btnmettreajour";
            btnmettreajour.Size = new Size(168, 58);
            btnmettreajour.TabIndex = 63;
            btnmettreajour.Text = "Mettre à jour";
            btnmettreajour.UseVisualStyleBackColor = false;
            btnmettreajour.Click += btnmettreajour_Click;
            // 
            // btnsupprimer
            // 
            btnsupprimer.BackColor = Color.FromArgb(240, 30, 44);
            btnsupprimer.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsupprimer.ForeColor = Color.White;
            btnsupprimer.Location = new Point(297, 246);
            btnsupprimer.Name = "btnsupprimer";
            btnsupprimer.Size = new Size(168, 58);
            btnsupprimer.TabIndex = 62;
            btnsupprimer.Text = "Supprimer";
            btnsupprimer.UseVisualStyleBackColor = false;
            btnsupprimer.Click += btnsupprimer_Click;
            // 
            // btnajouter
            // 
            btnajouter.BackColor = Color.SeaGreen;
            btnajouter.FlatAppearance.BorderSize = 0;
            btnajouter.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnajouter.ForeColor = Color.White;
            btnajouter.Location = new Point(93, 246);
            btnajouter.Name = "btnajouter";
            btnajouter.Size = new Size(168, 58);
            btnajouter.TabIndex = 61;
            btnajouter.Text = "Ajouter";
            btnajouter.UseVisualStyleBackColor = false;
            btnajouter.Click += btnajouter_Click;
            // 
            // datagridviewticket
            // 
            datagridviewticket.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridviewticket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridviewticket.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagridviewticket.BackgroundColor = Color.FromArgb(41, 75, 93);
            datagridviewticket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewticket.Location = new Point(3, 310);
            datagridviewticket.Name = "datagridviewticket";
            datagridviewticket.ReadOnly = true;
            datagridviewticket.RowHeadersVisible = false;
            datagridviewticket.RowHeadersWidth = 51;
            datagridviewticket.RowTemplate.Height = 29;
            datagridviewticket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridviewticket.Size = new Size(1021, 344);
            datagridviewticket.TabIndex = 65;
            datagridviewticket.CellContentClick += datagridviewticket_CellContentClick;
            // 
            // txtcategorie
            // 
            txtcategorie.FormattingEnabled = true;
            txtcategorie.Items.AddRange(new object[] { "1", "2" });
            txtcategorie.Location = new Point(166, 40);
            txtcategorie.Name = "txtcategorie";
            txtcategorie.Size = new Size(201, 28);
            txtcategorie.TabIndex = 67;
            // 
            // UserControlAdminTickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 75, 93);
            Controls.Add(txtcategorie);
            Controls.Add(datagridviewticket);
            Controls.Add(btnvider);
            Controls.Add(btnmettreajour);
            Controls.Add(btnsupprimer);
            Controls.Add(btnajouter);
            Controls.Add(txtcloture);
            Controls.Add(DateClotur);
            Controls.Add(DateOuvert);
            Controls.Add(txtouvert);
            Controls.Add(txtpriorite);
            Controls.Add(label4);
            Controls.Add(txtdescription);
            Controls.Add(label3);
            Controls.Add(txtstatut);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtemploye);
            Controls.Add(Categorie);
            Name = "UserControlAdminTickets";
            Size = new Size(1030, 672);
            Load += UserControlAdminTickets_Load;
            ((System.ComponentModel.ISupportInitialize)datagridviewticket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private static TextBox txtName;
        private Label Categorie;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label DateOuvert;
        private Label DateClotur;
        private static DataGridView dataGridView1;
        private static TextBox txtEmploye;
        private Button btnvider;
        private Button btnmettreajour;
        private DataGridView datagridviewticket;
        private TextBox txtemploye;
        private ComboBox txtstatut;
        private TextBox txtdescription;
        private ComboBox txtpriorite;
        private DateTimePicker txtouvert;
        private DateTimePicker txtcloture;
        private Button btnajouter;
        private Button btnsupprimer;
        private ComboBox txtcategorie;
    }
}
