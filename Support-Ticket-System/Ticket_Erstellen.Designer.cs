namespace Support_Ticket_System
{
    partial class Ticket_Erstellen
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
            tb_benutzer = new TextBox();
            tb_zusammenfassung = new TextBox();
            tb_verantwortliche_abteilung = new TextBox();
            tb_kategorie = new TextBox();
            tb_beschreibung = new TextBox();
            la_benutzer = new Label();
            la_zusammenfassung = new Label();
            la_verantwortliche_abteilung = new Label();
            la_kategorie = new Label();
            la_beschreibung = new Label();
            bu_fertigstellen = new Button();
            SuspendLayout();
            // 
            // bu_zurück
            // 
            bu_zurück.BackColor = SystemColors.ActiveCaption;
            bu_zurück.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_zurück.Location = new Point(12, 460);
            bu_zurück.Name = "bu_zurück";
            bu_zurück.Size = new Size(122, 39);
            bu_zurück.TabIndex = 0;
            bu_zurück.Text = "Zurück";
            bu_zurück.UseVisualStyleBackColor = false;
            bu_zurück.Click += button1_Click;
            // 
            // tb_benutzer
            // 
            tb_benutzer.BackColor = SystemColors.ActiveCaption;
            tb_benutzer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_benutzer.Location = new Point(32, 94);
            tb_benutzer.Name = "tb_benutzer";
            tb_benutzer.Size = new Size(137, 29);
            tb_benutzer.TabIndex = 1;
            // 
            // tb_zusammenfassung
            // 
            tb_zusammenfassung.BackColor = SystemColors.ActiveCaption;
            tb_zusammenfassung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_zusammenfassung.Location = new Point(185, 94);
            tb_zusammenfassung.Name = "tb_zusammenfassung";
            tb_zusammenfassung.Size = new Size(193, 29);
            tb_zusammenfassung.TabIndex = 2;
            // 
            // tb_verantwortliche_abteilung
            // 
            tb_verantwortliche_abteilung.BackColor = SystemColors.ActiveCaption;
            tb_verantwortliche_abteilung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_verantwortliche_abteilung.Location = new Point(407, 94);
            tb_verantwortliche_abteilung.Name = "tb_verantwortliche_abteilung";
            tb_verantwortliche_abteilung.Size = new Size(218, 29);
            tb_verantwortliche_abteilung.TabIndex = 3;
            // 
            // tb_kategorie
            // 
            tb_kategorie.BackColor = SystemColors.ActiveCaption;
            tb_kategorie.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_kategorie.Location = new Point(662, 94);
            tb_kategorie.Name = "tb_kategorie";
            tb_kategorie.Size = new Size(111, 29);
            tb_kategorie.TabIndex = 4;
            // 
            // tb_beschreibung
            // 
            tb_beschreibung.BackColor = SystemColors.ActiveCaption;
            tb_beschreibung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_beschreibung.Location = new Point(32, 201);
            tb_beschreibung.Multiline = true;
            tb_beschreibung.Name = "tb_beschreibung";
            tb_beschreibung.Size = new Size(762, 194);
            tb_beschreibung.TabIndex = 5;
            // 
            // la_benutzer
            // 
            la_benutzer.AutoSize = true;
            la_benutzer.BackColor = SystemColors.ActiveCaption;
            la_benutzer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_benutzer.Location = new Point(32, 70);
            la_benutzer.Name = "la_benutzer";
            la_benutzer.Size = new Size(75, 21);
            la_benutzer.TabIndex = 6;
            la_benutzer.Text = "Benutzer";
            // 
            // la_zusammenfassung
            // 
            la_zusammenfassung.AutoSize = true;
            la_zusammenfassung.BackColor = SystemColors.ActiveCaption;
            la_zusammenfassung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_zusammenfassung.Location = new Point(185, 70);
            la_zusammenfassung.Name = "la_zusammenfassung";
            la_zusammenfassung.Size = new Size(145, 21);
            la_zusammenfassung.TabIndex = 7;
            la_zusammenfassung.Text = "Zusammenfassung";
            // 
            // la_verantwortliche_abteilung
            // 
            la_verantwortliche_abteilung.AutoSize = true;
            la_verantwortliche_abteilung.BackColor = SystemColors.ActiveCaption;
            la_verantwortliche_abteilung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_verantwortliche_abteilung.Location = new Point(407, 70);
            la_verantwortliche_abteilung.Name = "la_verantwortliche_abteilung";
            la_verantwortliche_abteilung.Size = new Size(201, 21);
            la_verantwortliche_abteilung.TabIndex = 8;
            la_verantwortliche_abteilung.Text = "Verantwortliche Abteilung";
            // 
            // la_kategorie
            // 
            la_kategorie.AutoSize = true;
            la_kategorie.BackColor = SystemColors.ActiveCaption;
            la_kategorie.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_kategorie.Location = new Point(662, 70);
            la_kategorie.Name = "la_kategorie";
            la_kategorie.Size = new Size(82, 21);
            la_kategorie.TabIndex = 9;
            la_kategorie.Text = "Kategorie";
            // 
            // la_beschreibung
            // 
            la_beschreibung.AutoSize = true;
            la_beschreibung.BackColor = SystemColors.ActiveCaption;
            la_beschreibung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            la_beschreibung.Location = new Point(32, 177);
            la_beschreibung.Name = "la_beschreibung";
            la_beschreibung.Size = new Size(110, 21);
            la_beschreibung.TabIndex = 10;
            la_beschreibung.Text = "Beschreibung";
            // 
            // bu_fertigstellen
            // 
            bu_fertigstellen.BackColor = SystemColors.ActiveCaption;
            bu_fertigstellen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bu_fertigstellen.Location = new Point(750, 460);
            bu_fertigstellen.Name = "bu_fertigstellen";
            bu_fertigstellen.Size = new Size(122, 39);
            bu_fertigstellen.TabIndex = 11;
            bu_fertigstellen.Text = "Fertigstellen";
            bu_fertigstellen.UseVisualStyleBackColor = false;
            bu_fertigstellen.Click += bu_fertigstellen_Click;
            // 
            // Ticket_Erstellen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(bu_fertigstellen);
            Controls.Add(la_beschreibung);
            Controls.Add(la_kategorie);
            Controls.Add(la_verantwortliche_abteilung);
            Controls.Add(la_zusammenfassung);
            Controls.Add(la_benutzer);
            Controls.Add(tb_beschreibung);
            Controls.Add(tb_kategorie);
            Controls.Add(tb_verantwortliche_abteilung);
            Controls.Add(tb_zusammenfassung);
            Controls.Add(tb_benutzer);
            Controls.Add(bu_zurück);
            Name = "Ticket_Erstellen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket erstellen";
            FormClosing += erstellen_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bu_zurück;
        private TextBox tb_benutzer;
        private TextBox tb_zusammenfassung;
        private TextBox tb_verantwortliche_abteilung;
        private TextBox tb_kategorie;
        private TextBox tb_beschreibung;
        private Label la_benutzer;
        private Label la_zusammenfassung;
        private Label la_verantwortliche_abteilung;
        private Label la_kategorie;
        private Label la_beschreibung;
        private Button bu_fertigstellen;
    }
}