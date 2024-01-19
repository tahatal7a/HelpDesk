namespace Helpdesk.usercontroltech
{
    partial class Vtickets
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
            flowLayoutTicket = new FlowLayoutPanel();
            tichinv = new Label();
            SuspendLayout();
            // 
            // flowLayoutTicket
            // 
            flowLayoutTicket.AutoSize = true;
            flowLayoutTicket.FlowDirection = FlowDirection.TopDown;
            flowLayoutTicket.Location = new Point(29, 17);
            flowLayoutTicket.Name = "flowLayoutTicket";
            flowLayoutTicket.Size = new Size(740, 215);
            flowLayoutTicket.TabIndex = 0;
            flowLayoutTicket.Paint += flowLayoutPanel1_Paint;
            // 
            // tichinv
            // 
            tichinv.AutoSize = true;
            tichinv.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            tichinv.Location = new Point(174, 275);
            tichinv.Name = "tichinv";
            tichinv.Size = new Size(430, 46);
            tichinv.TabIndex = 1;
            tichinv.Text = "Aucun Ticket est disponible";
            tichinv.Visible = false;
            tichinv.Click += label1_Click;
            // 
            // Vtickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(tichinv);
            Controls.Add(flowLayoutTicket);
            Name = "Vtickets";
            Size = new Size(800, 583);
            Load += Vtickets_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutTicket;
        public static Label tichinv;
    }
}
