namespace Helpdesk.usercontroltech
{
    partial class techniciendash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(techniciendash));
            idpicture = new PictureBox();
            TickResPicture = new PictureBox();
            TIckOuvPicture = new PictureBox();
            idlabel = new Label();
            TickResLabel = new Label();
            tickOuvLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)idpicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TickResPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TIckOuvPicture).BeginInit();
            SuspendLayout();
            // 
            // idpicture
            // 
            idpicture.Image = (Image)resources.GetObject("idpicture.Image");
            idpicture.Location = new Point(52, 65);
            idpicture.Name = "idpicture";
            idpicture.Size = new Size(335, 150);
            idpicture.SizeMode = PictureBoxSizeMode.AutoSize;
            idpicture.TabIndex = 0;
            idpicture.TabStop = false;
            // 
            // TickResPicture
            // 
            TickResPicture.Image = (Image)resources.GetObject("TickResPicture.Image");
            TickResPicture.Location = new Point(415, 65);
            TickResPicture.Name = "TickResPicture";
            TickResPicture.Size = new Size(335, 150);
            TickResPicture.TabIndex = 1;
            TickResPicture.TabStop = false;
            TickResPicture.Click += pictureBox2_Click;
            // 
            // TIckOuvPicture
            // 
            TIckOuvPicture.Image = (Image)resources.GetObject("TIckOuvPicture.Image");
            TIckOuvPicture.Location = new Point(203, 254);
            TIckOuvPicture.Name = "TIckOuvPicture";
            TIckOuvPicture.Size = new Size(335, 150);
            TIckOuvPicture.TabIndex = 2;
            TIckOuvPicture.TabStop = false;
            // 
            // idlabel
            // 
            idlabel.AutoSize = true;
            idlabel.BackColor = Color.Transparent;
            idlabel.Font = new Font("Segoe UI Semibold", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            idlabel.Location = new Point(163, 55);
            idlabel.Name = "idlabel";
            idlabel.Size = new Size(102, 45);
            idlabel.TabIndex = 3;
            idlabel.Text = "label1";
            idlabel.Click += label1_Click;
            // 
            // TickResLabel
            // 
            TickResLabel.AutoSize = true;
            TickResLabel.BackColor = Color.Transparent;
            TickResLabel.Font = new Font("Segoe UI Semibold", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            TickResLabel.Location = new Point(50, 55);
            TickResLabel.Name = "TickResLabel";
            TickResLabel.Size = new Size(107, 45);
            TickResLabel.TabIndex = 4;
            TickResLabel.Text = "label2";
            TickResLabel.Click += label2_Click;
            // 
            // tickOuvLabel
            // 
            tickOuvLabel.AutoSize = true;
            tickOuvLabel.BackColor = Color.Transparent;
            tickOuvLabel.Font = new Font("Segoe UI Semibold", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            tickOuvLabel.Location = new Point(161, 55);
            tickOuvLabel.Name = "tickOuvLabel";
            tickOuvLabel.Size = new Size(107, 45);
            tickOuvLabel.TabIndex = 5;
            tickOuvLabel.Text = "label3";
            tickOuvLabel.Click += label3_Click;
            // 
            // techniciendash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(idlabel);
            Controls.Add(tickOuvLabel);
            Controls.Add(TickResLabel);
            Controls.Add(TickResPicture);
            Controls.Add(idpicture);
            Controls.Add(TIckOuvPicture);
            Name = "techniciendash";
            Size = new Size(800, 583);
            Load += techniciendash_Load;
            ((System.ComponentModel.ISupportInitialize)idpicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)TickResPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)TIckOuvPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox idpicture;
        private PictureBox TickResPicture;
        private PictureBox TIckOuvPicture;
        private Label idlabel;
        private Label TickResLabel;
        private Label tickOuvLabel;
    }
}
