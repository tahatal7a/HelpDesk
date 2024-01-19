namespace Helpdesk
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            panel3 = new Panel();
            employeButton = new Button();
            panel8 = new Panel();
            btnlogout = new Button();
            panel7 = new Panel();
            attentionred = new PictureBox();
            NotificationButton = new Button();
            panel6 = new Panel();
            HistoryButton = new Button();
            panel2 = new Panel();
            dashboardButton = new Button();
            panel5 = new Panel();
            ticketsButton = new Button();
            panel4 = new Panel();
            techniciensButton = new Button();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attentionred).BeginInit();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(0, 74, 173);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 604);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 74, 173);
            panel3.Controls.Add(employeButton);
            panel3.Location = new Point(-4, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 45);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // employeButton
            // 
            employeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            employeButton.BackColor = Color.FromArgb(0, 74, 173);
            employeButton.FlatAppearance.BorderSize = 0;
            employeButton.FlatAppearance.MouseDownBackColor = Color.Black;
            employeButton.FlatAppearance.MouseOverBackColor = Color.Black;
            employeButton.FlatStyle = FlatStyle.Flat;
            employeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            employeButton.ForeColor = SystemColors.ControlLightLight;
            employeButton.Image = (Image)resources.GetObject("employeButton.Image");
            employeButton.Location = new Point(-57, -15);
            employeButton.Name = "employeButton";
            employeButton.Padding = new Padding(0, 15, 87, 11);
            employeButton.Size = new Size(295, 70);
            employeButton.TabIndex = 1;
            employeButton.Text = "                          Profil";
            employeButton.UseVisualStyleBackColor = false;
            employeButton.Click += employeButton_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 74, 173);
            panel8.Controls.Add(btnlogout);
            panel8.Location = new Point(-1, 544);
            panel8.Name = "panel8";
            panel8.Size = new Size(234, 45);
            panel8.TabIndex = 8;
            // 
            // btnlogout
            // 
            btnlogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnlogout.BackColor = Color.FromArgb(0, 74, 173);
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatAppearance.MouseDownBackColor = Color.Black;
            btnlogout.FlatAppearance.MouseOverBackColor = Color.Black;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogout.ForeColor = SystemColors.ControlLightLight;
            btnlogout.Image = (Image)resources.GetObject("btnlogout.Image");
            btnlogout.Location = new Point(-77, -17);
            btnlogout.Name = "btnlogout";
            btnlogout.Padding = new Padding(0, 15, 70, 11);
            btnlogout.Size = new Size(311, 75);
            btnlogout.TabIndex = 1;
            btnlogout.Text = "Log out";
            btnlogout.TextAlign = ContentAlignment.MiddleRight;
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 74, 173);
            panel7.Controls.Add(attentionred);
            panel7.Controls.Add(NotificationButton);
            panel7.Location = new Point(0, 343);
            panel7.Name = "panel7";
            panel7.Size = new Size(234, 45);
            panel7.TabIndex = 7;
            // 
            // attentionred
            // 
            attentionred.Image = (Image)resources.GetObject("attentionred.Image");
            attentionred.Location = new Point(162, 7);
            attentionred.Name = "attentionred";
            attentionred.Size = new Size(47, 31);
            attentionred.SizeMode = PictureBoxSizeMode.Zoom;
            attentionred.TabIndex = 0;
            attentionred.TabStop = false;
            attentionred.Visible = false;
            // 
            // NotificationButton
            // 
            NotificationButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NotificationButton.BackColor = Color.FromArgb(0, 74, 173);
            NotificationButton.FlatAppearance.BorderSize = 0;
            NotificationButton.FlatAppearance.MouseDownBackColor = Color.Black;
            NotificationButton.FlatAppearance.MouseOverBackColor = Color.Black;
            NotificationButton.FlatStyle = FlatStyle.Flat;
            NotificationButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NotificationButton.ForeColor = SystemColors.ControlLightLight;
            NotificationButton.Image = (Image)resources.GetObject("NotificationButton.Image");
            NotificationButton.Location = new Point(-77, -17);
            NotificationButton.Name = "NotificationButton";
            NotificationButton.Padding = new Padding(0, 15, 70, 11);
            NotificationButton.Size = new Size(311, 75);
            NotificationButton.TabIndex = 1;
            NotificationButton.Text = "Notification";
            NotificationButton.TextAlign = ContentAlignment.MiddleRight;
            NotificationButton.UseVisualStyleBackColor = false;
            NotificationButton.Click += NotificationButton_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 74, 173);
            panel6.Controls.Add(HistoryButton);
            panel6.Location = new Point(0, 280);
            panel6.Name = "panel6";
            panel6.Size = new Size(234, 45);
            panel6.TabIndex = 6;
            // 
            // HistoryButton
            // 
            HistoryButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            HistoryButton.BackColor = Color.FromArgb(0, 74, 173);
            HistoryButton.FlatAppearance.BorderSize = 0;
            HistoryButton.FlatAppearance.MouseDownBackColor = Color.Black;
            HistoryButton.FlatAppearance.MouseOverBackColor = Color.Black;
            HistoryButton.FlatStyle = FlatStyle.Flat;
            HistoryButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HistoryButton.ForeColor = SystemColors.ControlLightLight;
            HistoryButton.Image = (Image)resources.GetObject("HistoryButton.Image");
            HistoryButton.Location = new Point(-111, -17);
            HistoryButton.Name = "HistoryButton";
            HistoryButton.Padding = new Padding(0, 15, 70, 11);
            HistoryButton.Size = new Size(384, 75);
            HistoryButton.TabIndex = 1;
            HistoryButton.Text = "Historique tickets";
            HistoryButton.TextAlign = ContentAlignment.MiddleRight;
            HistoryButton.UseVisualStyleBackColor = false;
            HistoryButton.Click += HistoryButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 74, 173);
            panel2.Controls.Add(dashboardButton);
            panel2.Location = new Point(0, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 45);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint_1;
            // 
            // dashboardButton
            // 
            dashboardButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dashboardButton.BackColor = Color.Black;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatAppearance.MouseDownBackColor = Color.Black;
            dashboardButton.FlatAppearance.MouseOverBackColor = Color.Black;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dashboardButton.ForeColor = SystemColors.ControlLightLight;
            dashboardButton.Image = (Image)resources.GetObject("dashboardButton.Image");
            dashboardButton.Location = new Point(-77, -17);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(0, 15, 70, 11);
            dashboardButton.Size = new Size(311, 75);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "Dashboard";
            dashboardButton.TextAlign = ContentAlignment.MiddleRight;
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += button1_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 74, 173);
            panel5.Controls.Add(ticketsButton);
            panel5.Location = new Point(0, 217);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 45);
            panel5.TabIndex = 5;
            // 
            // ticketsButton
            // 
            ticketsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ticketsButton.BackColor = Color.FromArgb(0, 74, 173);
            ticketsButton.FlatAppearance.BorderSize = 0;
            ticketsButton.FlatAppearance.MouseDownBackColor = Color.Black;
            ticketsButton.FlatAppearance.MouseOverBackColor = Color.Black;
            ticketsButton.FlatStyle = FlatStyle.Flat;
            ticketsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ticketsButton.ForeColor = SystemColors.ControlLightLight;
            ticketsButton.Image = (Image)resources.GetObject("ticketsButton.Image");
            ticketsButton.Location = new Point(-103, -17);
            ticketsButton.Name = "ticketsButton";
            ticketsButton.Padding = new Padding(0, 15, 70, 11);
            ticketsButton.Size = new Size(365, 75);
            ticketsButton.TabIndex = 1;
            ticketsButton.Text = "Création tickets";
            ticketsButton.TextAlign = ContentAlignment.MiddleRight;
            ticketsButton.UseVisualStyleBackColor = false;
            ticketsButton.Click += ticketsButton_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 74, 173);
            panel4.Controls.Add(techniciensButton);
            panel4.Location = new Point(0, 155);
            panel4.Name = "panel4";
            panel4.Size = new Size(234, 45);
            panel4.TabIndex = 4;
            // 
            // techniciensButton
            // 
            techniciensButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            techniciensButton.BackColor = Color.FromArgb(0, 74, 173);
            techniciensButton.FlatAppearance.BorderSize = 0;
            techniciensButton.FlatAppearance.MouseDownBackColor = Color.Black;
            techniciensButton.FlatAppearance.MouseOverBackColor = Color.Black;
            techniciensButton.FlatStyle = FlatStyle.Flat;
            techniciensButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            techniciensButton.ForeColor = SystemColors.ControlLightLight;
            techniciensButton.Image = (Image)resources.GetObject("techniciensButton.Image");
            techniciensButton.Location = new Point(-77, -17);
            techniciensButton.Name = "techniciensButton";
            techniciensButton.Padding = new Padding(0, 15, 70, 11);
            techniciensButton.Size = new Size(311, 75);
            techniciensButton.TabIndex = 1;
            techniciensButton.Text = "Techniciens";
            techniciensButton.TextAlign = ContentAlignment.MiddleRight;
            techniciensButton.UseVisualStyleBackColor = false;
            techniciensButton.Click += button3_Click;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Location = new Point(232, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(789, 600);
            mainPanel.TabIndex = 1;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 601);
            Controls.Add(panel1);
            Controls.Add(mainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Helpdesk";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)attentionred).EndInit();
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button dashboardButton;
        private Panel panel3;
        private Button employeButton;
        private Panel panel4;
        private Button techniciensButton;
        private Panel panel5;
        private Button ticketsButton;
        private Panel panel6;
        private Button HistoryButton;
        private Panel panel7;
        private Button NotificationButton;
        private Panel mainPanel;
        private Panel panel8;
        private Button btnlogout;
        private PictureBox attentionred;
    }
}