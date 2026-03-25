namespace Support_Ticket_System
{
    partial class Ticket_Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket_Start));
            bu_administrator = new Button();
            bu_bearbeiten = new Button();
            bu_erstellen = new Button();
            la_ueberschrift = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            la_willkommen = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bu_administrator
            // 
            bu_administrator.BackColor = Color.FromArgb(26, 39, 64);
            bu_administrator.FlatAppearance.BorderSize = 0;
            bu_administrator.FlatStyle = FlatStyle.Flat;
            bu_administrator.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_administrator.ForeColor = SystemColors.ControlLightLight;
            bu_administrator.Location = new Point(720, 20);
            bu_administrator.Name = "bu_administrator";
            bu_administrator.Size = new Size(152, 41);
            bu_administrator.TabIndex = 7;
            bu_administrator.Text = "Administrator";
            bu_administrator.UseVisualStyleBackColor = false;
            bu_administrator.Click += bu_administrator_Click;
            // 
            // bu_bearbeiten
            // 
            bu_bearbeiten.FlatAppearance.BorderColor = Color.FromArgb(26, 39, 64);
            bu_bearbeiten.FlatAppearance.BorderSize = 2;
            bu_bearbeiten.FlatStyle = FlatStyle.Flat;
            bu_bearbeiten.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_bearbeiten.ForeColor = Color.FromArgb(26, 39, 64);
            bu_bearbeiten.Location = new Point(231, 362);
            bu_bearbeiten.Name = "bu_bearbeiten";
            bu_bearbeiten.Size = new Size(152, 41);
            bu_bearbeiten.TabIndex = 6;
            bu_bearbeiten.Text = "Ticket bearbeiten";
            bu_bearbeiten.UseVisualStyleBackColor = false;
            bu_bearbeiten.Click += bu_bearbeiten_Click;
            // 
            // bu_erstellen
            // 
            bu_erstellen.BackColor = Color.FromArgb(26, 39, 64);
            bu_erstellen.FlatAppearance.BorderSize = 0;
            bu_erstellen.FlatStyle = FlatStyle.Flat;
            bu_erstellen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_erstellen.ForeColor = SystemColors.ControlLightLight;
            bu_erstellen.Location = new Point(46, 362);
            bu_erstellen.Name = "bu_erstellen";
            bu_erstellen.Size = new Size(152, 41);
            bu_erstellen.TabIndex = 5;
            bu_erstellen.Text = "Ticket erstellen";
            bu_erstellen.UseVisualStyleBackColor = false;
            bu_erstellen.Click += bu_erstellen_Click;
            // 
            // la_ueberschrift
            // 
            la_ueberschrift.AutoSize = true;
            la_ueberschrift.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_ueberschrift.ForeColor = SystemColors.ControlLightLight;
            la_ueberschrift.Location = new Point(82, 23);
            la_ueberschrift.Name = "la_ueberschrift";
            la_ueberschrift.Size = new Size(251, 32);
            la_ueberschrift.TabIndex = 4;
            la_ueberschrift.Text = "Support-Ticketsystem";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 39, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(bu_administrator);
            panel1.Controls.Add(la_ueberschrift);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 82);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.ImageLocation = "..\\..\\..\\Bilder\\logo.png";
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // la_willkommen
            // 
            la_willkommen.AutoSize = true;
            la_willkommen.FlatStyle = FlatStyle.Flat;
            la_willkommen.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_willkommen.ForeColor = Color.FromArgb(26, 39, 64);
            la_willkommen.ImageAlign = ContentAlignment.MiddleLeft;
            la_willkommen.Location = new Point(46, 158);
            la_willkommen.Name = "la_willkommen";
            la_willkommen.Size = new Size(272, 54);
            la_willkommen.TabIndex = 9;
            la_willkommen.Text = "Willkommen,";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(26, 39, 64);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(51, 221);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 10;
            label1.Text = "was ist Ihr Anliegen?";
            // 
            // Ticket_Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(884, 511);
            Controls.Add(label1);
            Controls.Add(la_willkommen);
            Controls.Add(panel1);
            Controls.Add(bu_bearbeiten);
            Controls.Add(bu_erstellen);
            Name = "Ticket_Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Startseite ";
            FormClosing += start_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bu_administrator;
        private Button bu_bearbeiten;
        private Button bu_erstellen;
        private Label la_ueberschrift;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label la_willkommen;
        private Label label1;
    }
}
