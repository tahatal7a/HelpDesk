namespace Helpdesk.usercontroltech
{
    partial class MaficheUsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaficheUsControl));
            pictureBox1 = new PictureBox();
            DEPlabel = new Label();
            SERVlabrl = new Label();
            SPEClabel = new Label();
            BURlabel = new Label();
            TELElabel = new Label();
            NAMElabel = new Label();
            IDlabel = new Label();
            prenomlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(648, 412);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // DEPlabel
            // 
            DEPlabel.AutoSize = true;
            DEPlabel.Location = new Point(306, 247);
            DEPlabel.Name = "DEPlabel";
            DEPlabel.Size = new Size(38, 15);
            DEPlabel.TabIndex = 1;
            DEPlabel.Text = "label1";
            // 
            // SERVlabrl
            // 
            SERVlabrl.AutoSize = true;
            SERVlabrl.BackColor = SystemColors.Control;
            SERVlabrl.ForeColor = SystemColors.ControlText;
            SERVlabrl.Location = new Point(263, 279);
            SERVlabrl.Name = "SERVlabrl";
            SERVlabrl.Size = new Size(38, 15);
            SERVlabrl.TabIndex = 2;
            SERVlabrl.Text = "label2";
            // 
            // SPEClabel
            // 
            SPEClabel.AutoSize = true;
            SPEClabel.Location = new Point(278, 310);
            SPEClabel.Name = "SPEClabel";
            SPEClabel.Size = new Size(38, 15);
            SPEClabel.TabIndex = 3;
            SPEClabel.Text = "label3";
            // 
            // BURlabel
            // 
            BURlabel.AutoSize = true;
            BURlabel.Location = new Point(289, 338);
            BURlabel.Name = "BURlabel";
            BURlabel.Size = new Size(38, 15);
            BURlabel.TabIndex = 4;
            BURlabel.Text = "label4";
            // 
            // TELElabel
            // 
            TELElabel.AutoSize = true;
            TELElabel.Location = new Point(263, 368);
            TELElabel.Name = "TELElabel";
            TELElabel.Size = new Size(38, 15);
            TELElabel.TabIndex = 5;
            TELElabel.Text = "label5";
            // 
            // NAMElabel
            // 
            NAMElabel.AutoSize = true;
            NAMElabel.BackColor = Color.FromArgb(26, 44, 68);
            NAMElabel.Font = new Font("Calisto MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            NAMElabel.ForeColor = Color.White;
            NAMElabel.Location = new Point(336, 196);
            NAMElabel.Name = "NAMElabel";
            NAMElabel.Size = new Size(85, 31);
            NAMElabel.TabIndex = 6;
            NAMElabel.Text = "label6";
            NAMElabel.Click += NAMElabel_Click;
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.BackColor = Color.FromArgb(26, 44, 68);
            IDlabel.Font = new Font("Calisto MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            IDlabel.ForeColor = Color.White;
            IDlabel.Location = new Point(129, 58);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(85, 31);
            IDlabel.TabIndex = 7;
            IDlabel.Text = "label7";
            IDlabel.Click += IDlabel_Click;
            // 
            // prenomlabel
            // 
            prenomlabel.AutoSize = true;
            prenomlabel.BackColor = Color.FromArgb(26, 44, 68);
            prenomlabel.Font = new Font("Calisto MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            prenomlabel.ForeColor = Color.White;
            prenomlabel.Location = new Point(256, 196);
            prenomlabel.Name = "prenomlabel";
            prenomlabel.Size = new Size(85, 31);
            prenomlabel.TabIndex = 10;
            prenomlabel.Text = "label8";
            // 
            // MaficheUsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(prenomlabel);
            Controls.Add(IDlabel);
            Controls.Add(NAMElabel);
            Controls.Add(TELElabel);
            Controls.Add(BURlabel);
            Controls.Add(SPEClabel);
            Controls.Add(SERVlabrl);
            Controls.Add(DEPlabel);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MaficheUsControl";
            Size = new Size(700, 437);
            Load += MaficheUsControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label DEPlabel;
        private Label SERVlabrl;
        private Label SPEClabel;
        private Label BURlabel;
        private Label TELElabel;
        private Label NAMElabel;
        private Label IDlabel;
        private Label prenomlabel;
    }
}
