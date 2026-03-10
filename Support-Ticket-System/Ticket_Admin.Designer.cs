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
            bu_zurück = new Button();
            la_Passwort = new Label();
            tb_passwort = new TextBox();
            bu_eingabe = new Button();
            pa_übersicht = new Panel();
            pa_bearbeiten = new Panel();
            lv_ticket = new ListView();
            bu_fertigstellen = new Button();
            bu_zurück3 = new Button();
            bu_zurück2 = new Button();
            tb_ticket_wählen = new TextBox();
            la_ticket_wählen = new Label();
            bu_ticket_wählen = new Button();
            lv_tickets = new ListView();
            pa_übersicht.SuspendLayout();
            pa_bearbeiten.SuspendLayout();
            SuspendLayout();
            // 
            // bu_zurück
            // 
            bu_zurück.BackColor = SystemColors.ActiveCaption;
            bu_zurück.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_zurück.Location = new Point(17, 598);
            bu_zurück.Name = "bu_zurück";
            bu_zurück.Size = new Size(97, 43);
            bu_zurück.TabIndex = 0;
            bu_zurück.Text = "Zurück";
            bu_zurück.UseVisualStyleBackColor = false;
            bu_zurück.Click += button1_Click;
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
            tb_passwort.TextChanged += tb_passwort_TextChanged;
            // 
            // bu_eingabe
            // 
            bu_eingabe.BackColor = SystemColors.ActiveCaption;
            bu_eingabe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_eingabe.Location = new Point(533, 228);
            bu_eingabe.Margin = new Padding(3, 2, 3, 2);
            bu_eingabe.Name = "bu_eingabe";
            bu_eingabe.Size = new Size(89, 31);
            bu_eingabe.TabIndex = 3;
            bu_eingabe.Text = "Eingabe";
            bu_eingabe.UseVisualStyleBackColor = false;
            bu_eingabe.Click += bu_eingabe_Click;
            // 
            // pa_übersicht
            // 
            pa_übersicht.Controls.Add(pa_bearbeiten);
            pa_übersicht.Controls.Add(bu_zurück2);
            pa_übersicht.Controls.Add(tb_ticket_wählen);
            pa_übersicht.Controls.Add(la_ticket_wählen);
            pa_übersicht.Controls.Add(bu_ticket_wählen);
            pa_übersicht.Controls.Add(lv_tickets);
            pa_übersicht.Location = new Point(1, 0);
            pa_übersicht.Margin = new Padding(3, 2, 3, 2);
            pa_übersicht.Name = "pa_übersicht";
            pa_übersicht.Size = new Size(1186, 662);
            pa_übersicht.TabIndex = 4;
            pa_übersicht.Visible = false;
            // 
            // pa_bearbeiten
            // 
            pa_bearbeiten.Controls.Add(lv_ticket);
            pa_bearbeiten.Controls.Add(bu_fertigstellen);
            pa_bearbeiten.Controls.Add(bu_zurück3);
            pa_bearbeiten.Location = new Point(0, 0);
            pa_bearbeiten.Name = "pa_bearbeiten";
            pa_bearbeiten.Size = new Size(1180, 662);
            pa_bearbeiten.TabIndex = 14;
            pa_bearbeiten.Visible = false;
            // 
            // lv_ticket
            // 
            lv_ticket.BackColor = SystemColors.Window;
            lv_ticket.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lv_ticket.Location = new Point(0, 3);
            lv_ticket.Name = "lv_ticket";
            lv_ticket.Size = new Size(1177, 73);
            lv_ticket.TabIndex = 24;
            lv_ticket.UseCompatibleStateImageBehavior = false;
            // 
            // bu_fertigstellen
            // 
            bu_fertigstellen.BackColor = SystemColors.ActiveCaption;
            bu_fertigstellen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_fertigstellen.Location = new Point(1047, 611);
            bu_fertigstellen.Name = "bu_fertigstellen";
            bu_fertigstellen.Size = new Size(122, 39);
            bu_fertigstellen.TabIndex = 23;
            bu_fertigstellen.Text = "Fertigstellen";
            bu_fertigstellen.UseVisualStyleBackColor = false;
            bu_fertigstellen.Click += bu_fertigstellen_Click;
            // 
            // bu_zurück3
            // 
            bu_zurück3.BackColor = SystemColors.ActiveCaption;
            bu_zurück3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_zurück3.Location = new Point(9, 608);
            bu_zurück3.Name = "bu_zurück3";
            bu_zurück3.Size = new Size(122, 39);
            bu_zurück3.TabIndex = 12;
            bu_zurück3.Text = "Zurück";
            bu_zurück3.UseVisualStyleBackColor = false;
            bu_zurück3.Click += bu_zurück3_Click;
            // 
            // bu_zurück2
            // 
            bu_zurück2.BackColor = SystemColors.ActiveCaption;
            bu_zurück2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_zurück2.Location = new Point(12, 614);
            bu_zurück2.Name = "bu_zurück2";
            bu_zurück2.Size = new Size(122, 39);
            bu_zurück2.TabIndex = 13;
            bu_zurück2.Text = "Zurück";
            bu_zurück2.UseVisualStyleBackColor = false;
            bu_zurück2.Click += bu_zurück2_Click;
            // 
            // tb_ticket_wählen
            // 
            tb_ticket_wählen.BackColor = SystemColors.ActiveCaption;
            tb_ticket_wählen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_ticket_wählen.Location = new Point(620, 20);
            tb_ticket_wählen.Name = "tb_ticket_wählen";
            tb_ticket_wählen.Size = new Size(100, 29);
            tb_ticket_wählen.TabIndex = 4;
            tb_ticket_wählen.TextChanged += tb_ticket_wählen_TextChanged;
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
            // bu_ticket_wählen
            // 
            bu_ticket_wählen.BackColor = SystemColors.ActiveCaption;
            bu_ticket_wählen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_ticket_wählen.Location = new Point(767, 13);
            bu_ticket_wählen.Name = "bu_ticket_wählen";
            bu_ticket_wählen.Size = new Size(93, 41);
            bu_ticket_wählen.TabIndex = 2;
            bu_ticket_wählen.Text = "Eingabe";
            bu_ticket_wählen.UseVisualStyleBackColor = false;
            bu_ticket_wählen.Click += bu_ticket_wählen_Click;
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
            lv_tickets.SelectedIndexChanged += lv_tickets_SelectedIndexChanged;
            // 
            // Ticket_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(pa_übersicht);
            Controls.Add(bu_eingabe);
            Controls.Add(tb_passwort);
            Controls.Add(la_Passwort);
            Controls.Add(bu_zurück);
            Name = "Ticket_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrator";
            FormClosing += admin_FormClosing;
            Load += Ticket_Admin_Load;
            pa_übersicht.ResumeLayout(false);
            pa_übersicht.PerformLayout();
            pa_bearbeiten.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bu_zurück;
        private Label la_Passwort;
        private TextBox tb_passwort;
        private Button bu_eingabe;
        private Panel pa_übersicht;
        private ListView lv_tickets;
        private TextBox tb_ticket_wählen;
        private Label la_ticket_wählen;
        private Button bu_ticket_wählen;
        private Button bu_zurück2;
        private Panel pa_bearbeiten;
        private Button bu_fertigstellen;
        private Button bu_zurück3;
        private ListView lv_ticket;
    }
}