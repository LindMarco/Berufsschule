namespace Support_Ticket_System
{
    partial class Ticket_Bearbeiten
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
            la_ticketnummer = new Label();
            tb_ticketnummer = new TextBox();
            bu_suchen = new Button();
            pa_bearbeiten = new Panel();
            bu_fertigstellen = new Button();
            la_beschreibung = new Label();
            la_kategorie = new Label();
            la_verantwortliche_rolle = new Label();
            la_zusammenfassung = new Label();
            la_benutzer = new Label();
            tb_beschreibung = new TextBox();
            tb_kategorie = new TextBox();
            tb_verantwortliche_rolle = new TextBox();
            tb_zusammenfassung = new TextBox();
            tb_benutzer = new TextBox();
            bu_zurück2 = new Button();
            pa_bearbeiten.SuspendLayout();
            SuspendLayout();
            // 
            // bu_zurück
            // 
            bu_zurück.BackColor = SystemColors.ActiveCaption;
            bu_zurück.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_zurück.Location = new Point(41, 374);
            bu_zurück.Name = "bu_zurück";
            bu_zurück.Size = new Size(97, 43);
            bu_zurück.TabIndex = 0;
            bu_zurück.Text = "Zurück";
            bu_zurück.UseVisualStyleBackColor = false;
            bu_zurück.Click += bu_zurück_Click;
            // 
            // la_ticketnummer
            // 
            la_ticketnummer.AutoSize = true;
            la_ticketnummer.BackColor = SystemColors.ActiveCaption;
            la_ticketnummer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_ticketnummer.Location = new Point(256, 113);
            la_ticketnummer.Name = "la_ticketnummer";
            la_ticketnummer.Size = new Size(288, 21);
            la_ticketnummer.TabIndex = 1;
            la_ticketnummer.Text = "Bitte geben Sie die Ticketnummer ein.";
            // 
            // tb_ticketnummer
            // 
            tb_ticketnummer.BackColor = SystemColors.ActiveCaption;
            tb_ticketnummer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_ticketnummer.Location = new Point(265, 209);
            tb_ticketnummer.Name = "tb_ticketnummer";
            tb_ticketnummer.Size = new Size(170, 29);
            tb_ticketnummer.TabIndex = 2;
            tb_ticketnummer.TextChanged += tb_ticketnummer_TextChanged;
            // 
            // bu_suchen
            // 
            bu_suchen.BackColor = SystemColors.ActiveCaption;
            bu_suchen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_suchen.Location = new Point(474, 203);
            bu_suchen.Name = "bu_suchen";
            bu_suchen.Size = new Size(97, 43);
            bu_suchen.TabIndex = 3;
            bu_suchen.Text = "Suchen";
            bu_suchen.UseVisualStyleBackColor = false;
            bu_suchen.Click += bu_suchen_Click;
            // 
            // pa_bearbeiten
            // 
            pa_bearbeiten.Controls.Add(bu_fertigstellen);
            pa_bearbeiten.Controls.Add(la_beschreibung);
            pa_bearbeiten.Controls.Add(la_kategorie);
            pa_bearbeiten.Controls.Add(la_verantwortliche_rolle);
            pa_bearbeiten.Controls.Add(la_zusammenfassung);
            pa_bearbeiten.Controls.Add(la_benutzer);
            pa_bearbeiten.Controls.Add(tb_beschreibung);
            pa_bearbeiten.Controls.Add(tb_kategorie);
            pa_bearbeiten.Controls.Add(tb_verantwortliche_rolle);
            pa_bearbeiten.Controls.Add(tb_zusammenfassung);
            pa_bearbeiten.Controls.Add(tb_benutzer);
            pa_bearbeiten.Controls.Add(bu_zurück2);
            pa_bearbeiten.Location = new Point(2, 0);
            pa_bearbeiten.Name = "pa_bearbeiten";
            pa_bearbeiten.Size = new Size(796, 452);
            pa_bearbeiten.TabIndex = 4;
            pa_bearbeiten.Visible = false;
            // 
            // bu_fertigstellen
            // 
            bu_fertigstellen.BackColor = SystemColors.ActiveCaption;
            bu_fertigstellen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_fertigstellen.Location = new Point(650, 371);
            bu_fertigstellen.Name = "bu_fertigstellen";
            bu_fertigstellen.Size = new Size(122, 39);
            bu_fertigstellen.TabIndex = 23;
            bu_fertigstellen.Text = "Fertigstellen";
            bu_fertigstellen.UseVisualStyleBackColor = false;
            bu_fertigstellen.Click += bu_fertigstellen_Click;
            // 
            // la_beschreibung
            // 
            la_beschreibung.AutoSize = true;
            la_beschreibung.BackColor = SystemColors.ActiveCaption;
            la_beschreibung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_beschreibung.Location = new Point(35, 128);
            la_beschreibung.Name = "la_beschreibung";
            la_beschreibung.Size = new Size(110, 21);
            la_beschreibung.TabIndex = 22;
            la_beschreibung.Text = "Beschreibung";
            // 
            // la_kategorie
            // 
            la_kategorie.AutoSize = true;
            la_kategorie.BackColor = SystemColors.ActiveCaption;
            la_kategorie.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_kategorie.Location = new Point(601, 42);
            la_kategorie.Name = "la_kategorie";
            la_kategorie.Size = new Size(82, 21);
            la_kategorie.TabIndex = 21;
            la_kategorie.Text = "Kategorie";
            // 
            // la_verantwortliche_rolle
            // 
            la_verantwortliche_rolle.AutoSize = true;
            la_verantwortliche_rolle.BackColor = SystemColors.ActiveCaption;
            la_verantwortliche_rolle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_verantwortliche_rolle.Location = new Point(410, 42);
            la_verantwortliche_rolle.Name = "la_verantwortliche_rolle";
            la_verantwortliche_rolle.Size = new Size(166, 21);
            la_verantwortliche_rolle.TabIndex = 20;
            la_verantwortliche_rolle.Text = "Verantwortliche Rolle";
            // 
            // la_zusammenfassung
            // 
            la_zusammenfassung.AutoSize = true;
            la_zusammenfassung.BackColor = SystemColors.ActiveCaption;
            la_zusammenfassung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_zusammenfassung.Location = new Point(197, 42);
            la_zusammenfassung.Name = "la_zusammenfassung";
            la_zusammenfassung.Size = new Size(145, 21);
            la_zusammenfassung.TabIndex = 19;
            la_zusammenfassung.Text = "Zusammenfassung";
            // 
            // la_benutzer
            // 
            la_benutzer.AutoSize = true;
            la_benutzer.BackColor = SystemColors.ActiveCaption;
            la_benutzer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_benutzer.Location = new Point(35, 42);
            la_benutzer.Name = "la_benutzer";
            la_benutzer.Size = new Size(75, 21);
            la_benutzer.TabIndex = 18;
            la_benutzer.Text = "Benutzer";
            // 
            // tb_beschreibung
            // 
            tb_beschreibung.BackColor = SystemColors.ActiveCaption;
            tb_beschreibung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_beschreibung.Location = new Point(35, 152);
            tb_beschreibung.Multiline = true;
            tb_beschreibung.Name = "tb_beschreibung";
            tb_beschreibung.Size = new Size(737, 183);
            tb_beschreibung.TabIndex = 17;
            tb_beschreibung.TextChanged += tb_beschreibung_TextChanged;
            // 
            // tb_kategorie
            // 
            tb_kategorie.BackColor = SystemColors.ActiveCaption;
            tb_kategorie.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_kategorie.Location = new Point(601, 66);
            tb_kategorie.Name = "tb_kategorie";
            tb_kategorie.Size = new Size(111, 29);
            tb_kategorie.TabIndex = 16;
            // 
            // tb_verantwortliche_rolle
            // 
            tb_verantwortliche_rolle.BackColor = SystemColors.ActiveCaption;
            tb_verantwortliche_rolle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_verantwortliche_rolle.Location = new Point(410, 66);
            tb_verantwortliche_rolle.Name = "tb_verantwortliche_rolle";
            tb_verantwortliche_rolle.Size = new Size(173, 29);
            tb_verantwortliche_rolle.TabIndex = 15;
            // 
            // tb_zusammenfassung
            // 
            tb_zusammenfassung.BackColor = SystemColors.ActiveCaption;
            tb_zusammenfassung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_zusammenfassung.Location = new Point(197, 66);
            tb_zusammenfassung.Name = "tb_zusammenfassung";
            tb_zusammenfassung.Size = new Size(193, 29);
            tb_zusammenfassung.TabIndex = 14;
            // 
            // tb_benutzer
            // 
            tb_benutzer.BackColor = SystemColors.ActiveCaption;
            tb_benutzer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_benutzer.Location = new Point(35, 66);
            tb_benutzer.Name = "tb_benutzer";
            tb_benutzer.Size = new Size(137, 29);
            tb_benutzer.TabIndex = 13;
            // 
            // bu_zurück2
            // 
            bu_zurück2.BackColor = SystemColors.ActiveCaption;
            bu_zurück2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_zurück2.Location = new Point(35, 371);
            bu_zurück2.Name = "bu_zurück2";
            bu_zurück2.Size = new Size(122, 39);
            bu_zurück2.TabIndex = 12;
            bu_zurück2.Text = "Zurück";
            bu_zurück2.UseVisualStyleBackColor = false;
            bu_zurück2.Click += bu_zurück2_Click;
            // 
            // Ticket_Bearbeiten
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(pa_bearbeiten);
            Controls.Add(bu_suchen);
            Controls.Add(tb_ticketnummer);
            Controls.Add(la_ticketnummer);
            Controls.Add(bu_zurück);
            Name = "Ticket_Bearbeiten";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket bearbeiten";
            FormClosing += bearbeiten_FormClosing;
            pa_bearbeiten.ResumeLayout(false);
            pa_bearbeiten.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bu_zurück;
        private Label la_ticketnummer;
        private TextBox tb_ticketnummer;
        private Button bu_suchen;
        private Panel pa_bearbeiten;
        private Button bu_fertigstellen;
        private Label la_beschreibung;
        private Label la_kategorie;
        private Label la_verantwortliche_rolle;
        private Label la_zusammenfassung;
        private Label la_benutzer;
        private TextBox tb_beschreibung;
        private TextBox tb_kategorie;
        private TextBox tb_verantwortliche_rolle;
        private TextBox tb_zusammenfassung;
        private TextBox tb_benutzer;
        private Button bu_zurück2;
    }
}