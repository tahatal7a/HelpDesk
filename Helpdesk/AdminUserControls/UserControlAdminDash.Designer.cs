namespace Helpdesk.AdminUserControls
{
    partial class UserControlAdminDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAdminDash));
            TickResPicture = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            nombretech = new Label();
            ticketresolut = new Label();
            nombreticket = new Label();
            nombreemploye = new Label();
            ((System.ComponentModel.ISupportInitialize)TickResPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // TickResPicture
            // 
            TickResPicture.Image = (Image)resources.GetObject("TickResPicture.Image");
            TickResPicture.Location = new Point(568, 42);
            TickResPicture.Name = "TickResPicture";
            TickResPicture.Size = new Size(393, 233);
            TickResPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            TickResPicture.TabIndex = 2;
            TickResPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(100, 374);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(393, 233);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(568, 374);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(393, 233);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // nombretech
            // 
            nombretech.AutoSize = true;
            nombretech.BackColor = Color.Transparent;
            nombretech.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            nombretech.ForeColor = SystemColors.ActiveCaptionText;
            nombretech.Location = new Point(165, 64);
            nombretech.Name = "nombretech";
            nombretech.Size = new Size(113, 46);
            nombretech.TabIndex = 13;
            nombretech.Text = "label2";
            nombretech.Click += nombretech_Click;
            // 
            // ticketresolut
            // 
            ticketresolut.AutoSize = true;
            ticketresolut.BackColor = Color.Transparent;
            ticketresolut.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            ticketresolut.ForeColor = SystemColors.ButtonHighlight;
            ticketresolut.Location = new Point(169, 68);
            ticketresolut.Name = "ticketresolut";
            ticketresolut.Size = new Size(113, 46);
            ticketresolut.TabIndex = 14;
            ticketresolut.Text = "label2";
            ticketresolut.Click += ticketresolut_Click;
            // 
            // nombreticket
            // 
            nombreticket.AutoSize = true;
            nombreticket.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            nombreticket.ForeColor = SystemColors.ActiveCaptionText;
            nombreticket.Location = new Point(165, 68);
            nombreticket.Name = "nombreticket";
            nombreticket.Size = new Size(113, 46);
            nombreticket.TabIndex = 15;
            nombreticket.Text = "label2";
            nombreticket.Click += nombreticket_Click;
            // 
            // nombreemploye
            // 
            nombreemploye.AutoSize = true;
            nombreemploye.BackColor = Color.Transparent;
            nombreemploye.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            nombreemploye.ForeColor = SystemColors.ButtonFace;
            nombreemploye.Location = new Point(169, 68);
            nombreemploye.Name = "nombreemploye";
            nombreemploye.Size = new Size(113, 46);
            nombreemploye.TabIndex = 16;
            nombreemploye.Text = "label2";
            nombreemploye.Click += nombreemploye_Click;
            // 
            // UserControlAdminDash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(pictureBox2);
            Controls.Add(TickResPicture);
            Controls.Add(pictureBox3);
            Controls.Add(ticketresolut);
            Controls.Add(nombreemploye);
            Controls.Add(pictureBox1);
            Controls.Add(nombretech);
            Controls.Add(nombreticket);
            Name = "UserControlAdminDash";
            Size = new Size(1030, 672);
            Load += UserControlAdminDash_Load;
            ((System.ComponentModel.ISupportInitialize)TickResPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox TickResPicture;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label nombretech;
        private Label ticketresolut;
        private Label nombreticket;
        private Label nombreemploye;
    }
}
