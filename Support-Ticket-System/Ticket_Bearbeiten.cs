using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Support_Ticket_System
{
    public partial class Ticket_Bearbeiten : Form
    {
        public Ticket_Bearbeiten()
        {
            InitializeComponent();
        }
        private void bearbeiten_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bu_zurück_Click(object sender, EventArgs e)
        {
            Ticket_Start form1 = new Ticket_Start();
            form1.Show();
            this.Hide();
        }

        private void tb_ticketnummer_TextChanged(object sender, EventArgs e)
        {

        }

        private void bu_suchen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_ticketnummer.Text))
            {
                MessageBox.Show("Bitte eine Ticketnummer eingeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int gesuchteID = int.Parse(tb_ticketnummer.Text);
            Tickets ticket = new Tickets().ticket_laden(gesuchteID);

            if (ticket == null)
            {
                MessageBox.Show("Ticket nicht gefunden");
                return;
            }

            tb_benutzer.Text = ticket.Benutzer;
            tb_zusammenfassung.Text = ticket.Zusammenfassung;
            tb_verantwortliche_rolle.Text = ticket.Verantwortliche_abteilung;
            tb_kategorie.Text = ticket.Kategori;
            tb_beschreibung.Text = ticket.Beschreibung;

            pa_bearbeiten.Visible = true;
        }

        private void bu_fertigstellen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_benutzer.Text) ||
                string.IsNullOrWhiteSpace(tb_zusammenfassung.Text) ||
                string.IsNullOrWhiteSpace(tb_verantwortliche_rolle.Text) ||
                string.IsNullOrWhiteSpace(tb_kategorie.Text) ||
                string.IsNullOrWhiteSpace(tb_beschreibung.Text))
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int gesuchteID = int.Parse(tb_ticketnummer.Text);
            int id = gesuchteID;
            string benutzer = tb_benutzer.Text;
            string zusammenfassung = tb_zusammenfassung.Text;
            string verantwortliche_rolle = tb_verantwortliche_rolle.Text;
            string kategorie = tb_kategorie.Text;
            string beschreibung = tb_beschreibung.Text;

            Tickets neuesticket = new Tickets
            {
                ID = id,
                Benutzer = benutzer,
                Zusammenfassung = zusammenfassung,
                Verantwortliche_abteilung = verantwortliche_rolle,
                Kategori = kategorie,
                Beschreibung = beschreibung
            };

            Speichern speicher = new Speichern();
            speicher.ticketspeichern(neuesticket);

            tb_benutzer.Text = "";
            tb_zusammenfassung.Text = "";
            tb_verantwortliche_rolle.Text = "";
            tb_kategorie.Text = "";
            tb_beschreibung.Text = "";

            Ticket_Start form1 = new Ticket_Start();
            form1.Show();
            this.Hide();

            MessageBox.Show($"Ticket wurde bearbeitet, wenn Sie es bearbeiten möchten geben Sie die ID in das Feld Ticket bearbeiten ein. ID: {neuesticket.ID}", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
            //muss hier noch so sein, dass nicht ein Neues Ticket erstellt wird sondern in der Datei geändert wird
        }

        private void bu_zurück2_Click(object sender, EventArgs e)
        {
            pa_bearbeiten.Visible = false;
            tb_ticketnummer.Text = "";
        }

        private void tb_beschreibung_TextChanged(object sender, EventArgs e)
        {

        }
    }
}