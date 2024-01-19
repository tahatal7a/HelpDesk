namespace Helpdesk.UserControls
{
    partial class UserControlCreateticket
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
            comboBoxCat = new ComboBox();
            label1 = new Label();
            txtDescription = new TextBox();
            label2 = new Label();
            btnSuivre = new Button();
            comboBoxP = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // comboBoxCat
            // 
            comboBoxCat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCat.FormattingEnabled = true;
            comboBoxCat.Location = new Point(198, 164);
            comboBoxCat.Name = "comboBoxCat";
            comboBoxCat.Size = new Size(295, 28);
            comboBoxCat.TabIndex = 0;
            comboBoxCat.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 164);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Catégorie";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(198, 221);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(459, 198);
            txtDescription.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 225);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // btnSuivre
            // 
            btnSuivre.Location = new Point(527, 447);
            btnSuivre.Name = "btnSuivre";
            btnSuivre.Size = new Size(130, 44);
            btnSuivre.TabIndex = 4;
            btnSuivre.Text = "Suivre";
            btnSuivre.UseVisualStyleBackColor = true;
            btnSuivre.Click += button1_Click;
            // 
            // comboBoxP
            // 
            comboBoxP.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxP.FormattingEnabled = true;
            comboBoxP.Items.AddRange(new object[] { "Haute Priorité", "Moyenne Priorité", "Basse Priorité" });
            comboBoxP.Location = new Point(198, 110);
            comboBoxP.Name = "comboBoxP";
            comboBoxP.Size = new Size(151, 28);
            comboBoxP.TabIndex = 5;
            comboBoxP.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 112);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 6;
            label3.Text = "Priorité";
            // 
            // UserControlCreateticket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(comboBoxP);
            Controls.Add(btnSuivre);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(comboBoxCat);
            Name = "UserControlCreateticket";
            Size = new Size(800, 583);
            Load += UserControlCreateticket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCat;
        private Label label1;
        private TextBox txtDescription;
        private Label label2;
        private Button btnSuivre;
        private ComboBox comboBoxP;
        private Label label3;
    }
}
