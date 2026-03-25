namespace Support_Ticket_System
{
    partial class Ticket_Admin
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
            bu_zurück_start = new Button();
            la_Passwort = new Label();
            tb_passwort = new TextBox();
            pa_übersicht = new Panel();
            pa_bearbeiten = new Panel();
            label1 = new Label();
            tb_kommentar = new TextBox();
            lv_ticket = new ListView();
            bu_fertig = new Button();
            bu_zurück_eingabe = new Button();
            bu_zurück_PW = new Button();
            tb_ticket_wählen = new TextBox();
            la_ticket_wählen = new Label();
            bu_ticket_nehmen = new Button();
            lv_tickets = new ListView();
            bu_PW = new Button();
            pa_übersicht.SuspendLayout();
            pa_bearbeiten.SuspendLayout();
            SuspendLayout();
            // 
            // bu_zurück_start
            // 
            bu_zurück_start.BackColor = SystemColors.ActiveCaption;
            bu_zurück_start.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_zurück_start.Location = new Point(17, 598);
            bu_zurück_start.Name = "bu_zurück_start";
            bu_zurück_start.Size = new Size(97, 43);
            bu_zurück_start.TabIndex = 0;
            bu_zurück_start.Text = "Zurück";
            bu_zurück_start.UseVisualStyleBackColor = false;
            bu_zurück_start.Click += bu_zurück_start_Click;
            // 
            // la_Passwort
            // 
            la_Passwort.AutoSize = true;
            la_Passwort.BackColor = SystemColors.ActiveCaption;
            la_Passwort.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_Passwort.Location = new Point(407, 102);
            la_Passwort.Name = "la_Passwort";
            la_Passwort.Size = new Size(330, 21);
            la_Passwort.TabIndex = 1;
            la_Passwort.Text = "Geben Sie das Administrator Passwort ein.";
            // 
            // tb_passwort
            // 
            tb_passwort.BackColor = SystemColors.ActiveCaption;
            tb_passwort.ForeColor = SystemColors.ActiveCaption;
            tb_passwort.Location = new Point(516, 170);
            tb_passwort.Margin = new Padding(3, 2, 3, 2);
            tb_passwort.Name = "tb_passwort";
            tb_passwort.Size = new Size(121, 23);
            tb_passwort.TabIndex = 2;
            // 
            // pa_übersicht
            // 
            pa_übersicht.Controls.Add(pa_bearbeiten);
            pa_übersicht.Controls.Add(bu_zurück_PW);
            pa_übersicht.Controls.Add(tb_ticket_wählen);
            pa_übersicht.Controls.Add(la_ticket_wählen);
            pa_übersicht.Controls.Add(bu_ticket_nehmen);
            pa_übersicht.Controls.Add(lv_tickets);
            pa_übersicht.Dock = DockStyle.Fill;
            pa_übersicht.Location = new Point(0, 0);
            pa_übersicht.Margin = new Padding(3, 2, 3, 2);
            pa_übersicht.Name = "pa_übersicht";
            pa_übersicht.Size = new Size(1184, 661);
            pa_übersicht.TabIndex = 4;
            pa_übersicht.Visible = false;
            // 
            // pa_bearbeiten
            // 
            pa_bearbeiten.Controls.Add(label1);
            pa_bearbeiten.Controls.Add(tb_kommentar);
            pa_bearbeiten.Controls.Add(lv_ticket);
            pa_bearbeiten.Controls.Add(bu_fertig);
            pa_bearbeiten.Controls.Add(bu_zurück_eingabe);
            pa_bearbeiten.Dock = DockStyle.Fill;
            pa_bearbeiten.Location = new Point(0, 0);
            pa_bearbeiten.Name = "pa_bearbeiten";
            pa_bearbeiten.Size = new Size(1184, 661);
            pa_bearbeiten.TabIndex = 14;
            pa_bearbeiten.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 192);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 26;
            label1.Text = "Kommentar";
            // 
            // tb_kommentar
            // 
            tb_kommentar.BackColor = SystemColors.ActiveCaption;
            tb_kommentar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_kommentar.Location = new Point(26, 216);
            tb_kommentar.Multiline = true;
            tb_kommentar.Name = "tb_kommentar";
            tb_kommentar.Size = new Size(537, 176);
            tb_kommentar.TabIndex = 25;
            // 
            // lv_ticket
            // 
            lv_ticket.BackColor = SystemColors.Window;
            lv_ticket.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lv_ticket.Location = new Point(0, 3);
            lv_ticket.Name = "lv_ticket";
            lv_ticket.Size = new Size(1177, 86);
            lv_ticket.TabIndex = 24;
            lv_ticket.UseCompatibleStateImageBehavior = false;
            // 
            // bu_fertig
            // 
            bu_fertig.BackColor = SystemColors.ActiveCaption;
            bu_fertig.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_fertig.Location = new Point(1047, 611);
            bu_fertig.Name = "bu_fertig";
            bu_fertig.Size = new Size(122, 39);
            bu_fertig.TabIndex = 23;
            bu_fertig.Text = "Fertigstellen";
            bu_fertig.UseVisualStyleBackColor = false;
            bu_fertig.Click += bu_fertig_Click;
            // 
            // bu_zurück_eingabe
            // 
            bu_zurück_eingabe.BackColor = SystemColors.ActiveCaption;
            bu_zurück_eingabe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_zurück_eingabe.Location = new Point(11, 614);
            bu_zurück_eingabe.Name = "bu_zurück_eingabe";
            bu_zurück_eingabe.Size = new Size(122, 39);
            bu_zurück_eingabe.TabIndex = 12;
            bu_zurück_eingabe.Text = "Zurück";
            bu_zurück_eingabe.UseVisualStyleBackColor = false;
            bu_zurück_eingabe.Click += bu_zurück_eingabe_Click;
            // 
            // bu_zurück_PW
            // 
            bu_zurück_PW.BackColor = SystemColors.ActiveCaption;
            bu_zurück_PW.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_zurück_PW.Location = new Point(12, 614);
            bu_zurück_PW.Name = "bu_zurück_PW";
            bu_zurück_PW.Size = new Size(122, 39);
            bu_zurück_PW.TabIndex = 13;
            bu_zurück_PW.Text = "Zurück";
            bu_zurück_PW.UseVisualStyleBackColor = false;
            bu_zurück_PW.Click += bu_zurück_PW_Click;
            // 
            // tb_ticket_wählen
            // 
            tb_ticket_wählen.BackColor = SystemColors.ActiveCaption;
            tb_ticket_wählen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_ticket_wählen.Location = new Point(536, 25);
            tb_ticket_wählen.Name = "tb_ticket_wählen";
            tb_ticket_wählen.Size = new Size(100, 29);
            tb_ticket_wählen.TabIndex = 4;
            // 
            // la_ticket_wählen
            // 
            la_ticket_wählen.AutoSize = true;
            la_ticket_wählen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_ticket_wählen.Location = new Point(159, 28);
            la_ticket_wählen.Name = "la_ticket_wählen";
            la_ticket_wählen.Size = new Size(355, 21);
            la_ticket_wählen.TabIndex = 3;
            la_ticket_wählen.Text = "Ticket ID eingeben um das Ticket zu bearbeiten";
            // 
            // bu_ticket_nehmen
            // 
            bu_ticket_nehmen.BackColor = SystemColors.ActiveCaption;
            bu_ticket_nehmen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_ticket_nehmen.Location = new Point(656, 18);
            bu_ticket_nehmen.Name = "bu_ticket_nehmen";
            bu_ticket_nehmen.Size = new Size(93, 41);
            bu_ticket_nehmen.TabIndex = 2;
            bu_ticket_nehmen.Text = "Eingabe";
            bu_ticket_nehmen.UseVisualStyleBackColor = false;
            bu_ticket_nehmen.Click += bu_ticket_nehmen_Click;
            // 
            // lv_tickets
            // 
            lv_tickets.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lv_tickets.Location = new Point(3, 81);
            lv_tickets.Margin = new Padding(3, 2, 3, 2);
            lv_tickets.Name = "lv_tickets";
            lv_tickets.Size = new Size(1168, 528);
            lv_tickets.TabIndex = 1;
            lv_tickets.UseCompatibleStateImageBehavior = false;
            // 
            // bu_PW
            // 
            bu_PW.Location = new Point(536, 211);
            bu_PW.Name = "bu_PW";
            bu_PW.Size = new Size(92, 30);
            bu_PW.TabIndex = 5;
            bu_PW.Text = "Eingabe";
            bu_PW.UseVisualStyleBackColor = true;
            bu_PW.Click += bu_PW_Click;
            // 
            // Ticket_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(pa_übersicht);
            Controls.Add(bu_PW);
            Controls.Add(tb_passwort);
            Controls.Add(la_Passwort);
            Controls.Add(bu_zurück_start);
            Name = "Ticket_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrator";
            pa_übersicht.ResumeLayout(false);
            pa_übersicht.PerformLayout();
            pa_bearbeiten.ResumeLayout(false);
            pa_bearbeiten.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bu_zurück_start;
        private Label la_Passwort;
        private TextBox tb_passwort;
        private Panel pa_übersicht;
        private ListView lv_tickets;
        private TextBox tb_ticket_wählen;
        private Label la_ticket_wählen;
        private Button bu_ticket_nehmen;
        private Button bu_zurück_PW;
        private Panel pa_bearbeiten;
        private Button bu_fertig;
        private Button bu_zurück_eingabe;
        private ListView lv_ticket;
        private TextBox tb_kommentar;
        private Label label1;
        private Button bu_PW;
    }
}