namespace Helpdesk
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            panel1 = new Panel();
            panel8 = new Panel();
            btnlogout = new Button();
            panel6 = new Panel();
            panel3 = new Panel();
            btntechnicien = new Button();
            panel2 = new Panel();
            btndash = new Button();
            panel4 = new Panel();
            btnemploye = new Button();
            panel5 = new Panel();
            btnticket = new Button();
            MAINpanel = new Panel();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 74, 173);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 504);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 74, 173);
            panel8.Controls.Add(btnlogout);
            panel8.Location = new Point(1, 416);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(205, 34);
            panel8.TabIndex = 9;
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
            btnlogout.Location = new Point(-67, -13);
            btnlogout.Margin = new Padding(3, 2, 3, 2);
            btnlogout.Name = "btnlogout";
            btnlogout.Padding = new Padding(0, 11, 61, 8);
            btnlogout.Size = new Size(272, 56);
            btnlogout.TabIndex = 1;
            btnlogout.Text = "Log out";
            btnlogout.TextAlign = ContentAlignment.MiddleRight;
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click_1;
            // 
            // panel6
            // 
            panel6.Location = new Point(200, 0);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(695, 453);
            panel6.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 74, 173);
            panel3.Controls.Add(btntechnicien);
            panel3.Location = new Point(0, 80);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 34);
            panel3.TabIndex = 4;
            // 
            // btntechnicien
            // 
            btntechnicien.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btntechnicien.BackColor = Color.FromArgb(0, 74, 173);
            btntechnicien.FlatAppearance.BorderSize = 0;
            btntechnicien.FlatAppearance.MouseDownBackColor = Color.Black;
            btntechnicien.FlatAppearance.MouseOverBackColor = Color.Black;
            btntechnicien.FlatStyle = FlatStyle.Flat;
            btntechnicien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btntechnicien.ForeColor = SystemColors.ControlLightLight;
            btntechnicien.Image = (Image)resources.GetObject("btntechnicien.Image");
            btntechnicien.Location = new Point(-51, -13);
            btntechnicien.Margin = new Padding(3, 2, 3, 2);
            btntechnicien.Name = "btntechnicien";
            btntechnicien.Padding = new Padding(0, 11, 76, 8);
            btntechnicien.Size = new Size(256, 56);
            btntechnicien.TabIndex = 1;
            btntechnicien.Text = "Technicien";
            btntechnicien.TextAlign = ContentAlignment.MiddleRight;
            btntechnicien.UseVisualStyleBackColor = false;
            btntechnicien.Click += btntechnicien_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 74, 173);
            panel2.Controls.Add(btndash);
            panel2.Location = new Point(0, 23);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 34);
            panel2.TabIndex = 3;
            // 
            // btndash
            // 
            btndash.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btndash.BackColor = Color.Black;
            btndash.FlatAppearance.BorderSize = 0;
            btndash.FlatAppearance.MouseDownBackColor = Color.Black;
            btndash.FlatAppearance.MouseOverBackColor = Color.Black;
            btndash.FlatStyle = FlatStyle.Flat;
            btndash.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btndash.ForeColor = SystemColors.ControlLightLight;
            btndash.Image = (Image)resources.GetObject("btndash.Image");
            btndash.Location = new Point(-67, -13);
            btndash.Margin = new Padding(3, 2, 3, 2);
            btndash.Name = "btndash";
            btndash.Padding = new Padding(0, 11, 61, 8);
            btndash.Size = new Size(272, 56);
            btndash.TabIndex = 1;
            btndash.Text = "Dashboard";
            btndash.TextAlign = ContentAlignment.MiddleRight;
            btndash.UseVisualStyleBackColor = false;
            btndash.Click += btndash_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 74, 173);
            panel4.Controls.Add(btnemploye);
            panel4.Location = new Point(1, 136);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(205, 34);
            panel4.TabIndex = 4;
            // 
            // btnemploye
            // 
            btnemploye.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnemploye.BackColor = Color.FromArgb(0, 74, 173);
            btnemploye.FlatAppearance.BorderSize = 0;
            btnemploye.FlatAppearance.MouseDownBackColor = Color.Black;
            btnemploye.FlatAppearance.MouseOverBackColor = Color.Black;
            btnemploye.FlatStyle = FlatStyle.Flat;
            btnemploye.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnemploye.ForeColor = SystemColors.ControlLightLight;
            btnemploye.Image = (Image)resources.GetObject("btnemploye.Image");
            btnemploye.Location = new Point(-51, -13);
            btnemploye.Margin = new Padding(3, 2, 3, 2);
            btnemploye.Name = "btnemploye";
            btnemploye.Padding = new Padding(0, 11, 76, 8);
            btnemploye.Size = new Size(256, 56);
            btnemploye.TabIndex = 1;
            btnemploye.Text = "Employé";
            btnemploye.TextAlign = ContentAlignment.MiddleRight;
            btnemploye.UseVisualStyleBackColor = false;
            btnemploye.Click += btnemploye_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 74, 173);
            panel5.Controls.Add(btnticket);
            panel5.Location = new Point(1, 194);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(205, 34);
            panel5.TabIndex = 5;
            // 
            // btnticket
            // 
            btnticket.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnticket.BackColor = Color.FromArgb(0, 74, 173);
            btnticket.FlatAppearance.BorderSize = 0;
            btnticket.FlatAppearance.MouseDownBackColor = Color.Black;
            btnticket.FlatAppearance.MouseOverBackColor = Color.Black;
            btnticket.FlatStyle = FlatStyle.Flat;
            btnticket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnticket.ForeColor = SystemColors.ControlLightLight;
            btnticket.Image = (Image)resources.GetObject("btnticket.Image");
            btnticket.Location = new Point(-51, -13);
            btnticket.Margin = new Padding(3, 2, 3, 2);
            btnticket.Name = "btnticket";
            btnticket.Padding = new Padding(0, 11, 76, 8);
            btnticket.Size = new Size(256, 56);
            btnticket.TabIndex = 1;
            btnticket.Text = "Tickets";
            btnticket.TextAlign = ContentAlignment.MiddleRight;
            btnticket.UseVisualStyleBackColor = false;
            btnticket.Click += btnticket_Click;
            // 
            // MAINpanel
            // 
            MAINpanel.Location = new Point(204, 0);
            MAINpanel.Margin = new Padding(3, 2, 3, 2);
            MAINpanel.Name = "MAINpanel";
            MAINpanel.Size = new Size(901, 504);
            MAINpanel.TabIndex = 6;
            MAINpanel.Paint += MAINpanel_Paint;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 506);
            Controls.Add(MAINpanel);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btndash;
        private Panel panel3;
        private Button btntechnicien;
        private Panel panel4;
        private Button btnemploye;
        private Panel panel5;
        private Button btnticket;
        private Panel panel6;
        private Panel MAINpanel;
        private Panel panel8;
        private Button btnlogout;
    }
}