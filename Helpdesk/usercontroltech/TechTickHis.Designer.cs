namespace Helpdesk.usercontroltech
{
    partial class TechTickHis
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
            HistoriqueGridView = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)HistoriqueGridView).BeginInit();
            SuspendLayout();
            // 
            // HistoriqueGridView
            // 
            HistoriqueGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HistoriqueGridView.BackgroundColor = SystemColors.Control;
            HistoriqueGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoriqueGridView.Location = new Point(0, 85);
            HistoriqueGridView.Name = "HistoriqueGridView";
            HistoriqueGridView.ReadOnly = true;
            HistoriqueGridView.RowHeadersWidth = 51;
            HistoriqueGridView.RowTemplate.Height = 29;
            HistoriqueGridView.Size = new Size(800, 498);
            HistoriqueGridView.TabIndex = 0;
            HistoriqueGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(185, 10);
            label1.Name = "label1";
            label1.Size = new Size(395, 54);
            label1.TabIndex = 1;
            label1.Text = "Historique de ticket";
            // 
            // TechTickHis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(HistoriqueGridView);
            Name = "TechTickHis";
            Size = new Size(800, 583);
            Load += TechTickHis_Load;
            ((System.ComponentModel.ISupportInitialize)HistoriqueGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView HistoriqueGridView;
        private Label label1;
    }
}
