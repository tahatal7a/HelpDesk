namespace Helpdesk.UserControls
{
    partial class UserControlNotification
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
            asRead = new Button();
            flowyoutaffichenotif = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // asRead
            // 
            asRead.Location = new Point(551, 19);
            asRead.Name = "asRead";
            asRead.Size = new Size(208, 35);
            asRead.TabIndex = 1;
            asRead.Text = "marquer tout comme lu ✔️";
            asRead.UseVisualStyleBackColor = true;
            asRead.Click += button1_Click;
            // 
            // flowyoutaffichenotif
            // 
            flowyoutaffichenotif.AutoSize = true;
            flowyoutaffichenotif.FlowDirection = FlowDirection.TopDown;
            flowyoutaffichenotif.Location = new Point(15, 81);
            flowyoutaffichenotif.Name = "flowyoutaffichenotif";
            flowyoutaffichenotif.Size = new Size(764, 113);
            flowyoutaffichenotif.TabIndex = 2;
            flowyoutaffichenotif.Paint += flowLayoutPanel1_Paint_1;
            // 
            // UserControlNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(flowyoutaffichenotif);
            Controls.Add(asRead);
            Name = "UserControlNotification";
            Size = new Size(800, 583);
            Load += UserControlNotification_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button asRead;
        private FlowLayoutPanel flowyoutaffichenotif;
    }
}
