namespace Helpdesk.UserControls
{
    partial class flowyoutmessagenotif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flowyoutmessagenotif));
            panel1 = new Panel();
            txtmessagenotif = new Label();
            date = new Label();
            attention = new PictureBox();
            panelnotif = new Panel();
            ((System.ComponentModel.ISupportInitialize)attention).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 10);
            panel1.TabIndex = 0;
            // 
            // txtmessagenotif
            // 
            txtmessagenotif.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtmessagenotif.AutoSize = true;
            txtmessagenotif.Location = new Point(26, 28);
            txtmessagenotif.Name = "txtmessagenotif";
            txtmessagenotif.Size = new Size(50, 20);
            txtmessagenotif.TabIndex = 0;
            txtmessagenotif.Text = "label1";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date.Location = new Point(601, 64);
            date.Name = "date";
            date.Size = new Size(39, 20);
            date.TabIndex = 1;
            date.Text = "date";
            // 
            // attention
            // 
            attention.Image = (Image)resources.GetObject("attention.Image");
            attention.Location = new Point(678, 18);
            attention.Name = "attention";
            attention.Size = new Size(35, 30);
            attention.SizeMode = PictureBoxSizeMode.Zoom;
            attention.TabIndex = 2;
            attention.TabStop = false;
            attention.UseWaitCursor = true;
            attention.Visible = false;
            // 
            // panelnotif
            // 
            panelnotif.BackColor = SystemColors.ActiveCaption;
            panelnotif.Location = new Point(3, 74);
            panelnotif.Name = "panelnotif";
            panelnotif.Size = new Size(725, 10);
            panelnotif.TabIndex = 3;
            // 
            // flowyoutmessagenotif
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtmessagenotif);
            Controls.Add(attention);
            Controls.Add(date);
            Controls.Add(panelnotif);
            Name = "flowyoutmessagenotif";
            Size = new Size(728, 86);
            ((System.ComponentModel.ISupportInitialize)attention).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Label txtmessagenotif;
        public Label date;
        public PictureBox attention;
        private Panel panelnotif;
    }
}
