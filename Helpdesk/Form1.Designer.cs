namespace Helpdesk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            LoginButton = new Button();
            label2 = new Label();
            username = new Label();
            txtPass = new TextBox();
            txtUser = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 74, 173);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(username);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 591);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Black;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder;
            LoginButton.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.ForeColor = SystemColors.ControlLight;
            LoginButton.Location = new Point(37, 349);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(225, 51);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(37, 261);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Roboto Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point);
            username.ForeColor = SystemColors.ButtonFace;
            username.Location = new Point(37, 181);
            username.Name = "username";
            username.Size = new Size(68, 18);
            username.TabIndex = 4;
            username.Text = "Username";
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.ForeColor = SystemColors.Desktop;
            txtPass.Location = new Point(37, 281);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(225, 30);
            txtPass.TabIndex = 3;
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.Window;
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtUser.Location = new Point(37, 203);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(225, 30);
            txtUser.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, -64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 389);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkBlue;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(62, 51);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(313, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(664, 585);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 591);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label username;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label2;
        private PictureBox pictureBox2;
        private Button LoginButton;
    }
}