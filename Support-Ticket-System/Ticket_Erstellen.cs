using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Support_Ticket_System
{
    public partial class Ticket_Erstellen : Form
    {
        public Ticket_Erstellen()
        {
            InitializeComponent();
        }
        private void erstellen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket_Start form1 = new Ticket_Start();
            form1.Show();
            this.Hide();
        }

        private void bu_fertigstellen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_benutzer.Text) ||
                string.IsNullOrWhiteSpace(tb_zusammenfassung.Text) ||
                string.IsNullOrWhiteSpace(tb_verantwortliche_abteilung.Text) ||
                string.IsNullOrWhiteSpace(tb_kategorie.Text) ||
                string.IsNullOrWhiteSpace(tb_beschreibung.Text))
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = 1; //muss noch angepasst werden, dass es automatisch was vergibt
            string benutzer = tb_benutzer.Text;
            string zusammenfassung = tb_zusammenfassung.Text;
            string verantwortliche_rolle = tb_verantwortliche_abteilung.Text;
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
            tb_verantwortliche_abteilung.Text = "";
            tb_kategorie.Text = "";
            tb_beschreibung.Text = "";

            Ticket_Start form1 = new Ticket_Start();
            form1.Show();
            this.Hide();

            MessageBox.Show($"Ticket wurde erstellt, wenn Sie es bearbeiten möchten geben Sie die ID in das Feld Ticket bearbeiten ein. ID: {neuesticket.ID}", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void la_kategorie_Click(object sender, EventArgs e)
        {

        }
    }
}
