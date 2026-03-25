using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Support_Ticket_System
{
    public partial class Ticket_Admin : Form
    {
        public Ticket_Admin()
        {
            InitializeComponent();

            lv_tickets.View = View.Details;
            lv_tickets.GridLines = true;
            lv_tickets.Items.Clear();


            lv_tickets.Columns.Add("ID", 30);
            lv_tickets.Columns.Add("Benutzer", 130);
            lv_tickets.Columns.Add("Zusammenfassung", 220);
            lv_tickets.Columns.Add("Verantwortliche Abteilung", 210);
            lv_tickets.Columns.Add("Kategorie", 90);
            lv_tickets.Columns.Add("Beschreibung", 5000);

            Speichern ticket = new Speichern();

            string[] zeilen = File.ReadAllLines(ticket.offene_pfad());
            foreach (string zeile in zeilen)
            {
                string[] teile = zeile.Split(';');
                if (teile.Length >= 6)
                {
                    ListViewItem item = new ListViewItem(teile[0]);
                    item.SubItems.Add(teile[1]);
                    item.SubItems.Add(teile[2]);
                    item.SubItems.Add(teile[3]);
                    item.SubItems.Add(teile[4]);
                    item.SubItems.Add(teile[5]);
                    lv_tickets.Items.Add(item);
                }
            }
        }
        private void admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void bu_PW_Click(object sender, EventArgs e)
        {
            string pw = "1";
            if (string.IsNullOrWhiteSpace(tb_passwort.Text))
            {
                MessageBox.Show("Bitte Passwort eingeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pw == tb_passwort.Text)
            {
                pa_übersicht.Visible = true;
            }
            else
            {
                MessageBox.Show("Passwort falsch", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void bu_zurück_eingabe_Click(object sender, EventArgs e)
        {
            pa_bearbeiten.Visible = false;
            tb_ticket_wählen.Text = "";
        }

        private void bu_zurück_PW_Click(object sender, EventArgs e)
        {
            pa_übersicht.Visible = false;
            tb_passwort.Text = "";
        }

        private void bu_zurück_start_Click(object sender, EventArgs e)
        {
            Ticket_Start form1 = new Ticket_Start();
            form1.Show();
            this.Hide();
        }

        private void bu_ticket_nehmen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_ticket_wählen.Text))
            {
                MessageBox.Show("Bitte eine Ticketnummer eingeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int gesuchteID = int.Parse(tb_ticket_wählen.Text);
            Tickets ticket = new Tickets().ticket_laden(gesuchteID);

            if (ticket == null)
            {
                MessageBox.Show("Ticket nicht gefunden");
                return;
            }

            pa_bearbeiten.Visible = true;

            lv_ticket.View = View.Details;
            lv_ticket.GridLines = true;
            lv_ticket.Items.Clear();

            lv_ticket.Columns.Add("Benutzer", 140);
            lv_ticket.Columns.Add("Zusammenfassung", 250);
            lv_ticket.Columns.Add("Verantwortliche Abteilung", 210);
            lv_ticket.Columns.Add("Kategorie", 90);
            lv_ticket.Columns.Add("Beschreibung", 5000);

            ListViewItem item = new ListViewItem(ticket.Benutzer);
            item.SubItems.Add(ticket.Zusammenfassung);
            item.SubItems.Add(ticket.Verantwortliche_abteilung);
            item.SubItems.Add(ticket.Kategorie);
            item.SubItems.Add(ticket.Beschreibung);
            lv_ticket.Items.Add(item);
        }

        private void bu_fertig_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_kommentar.Text))
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int gesuchteID = Convert.ToInt32(tb_ticket_wählen.Text);
            string kommentar = tb_kommentar.Text;

            Tickets ticket = new Tickets().ticket_laden(gesuchteID);

            ticket.Kommentar = kommentar;


            Speichern speicher = new Speichern();
            speicher.ticketschließen(ticket);

            ticket.ticket_löschen(gesuchteID);

            pa_bearbeiten.Visible = false;
            tb_ticket_wählen.Text = "";
            tb_kommentar.Text = "";
            lv_tickets.Items.Clear();

            Speichern ticket1 = new Speichern();

            string[] zeilen = File.ReadAllLines(ticket1.offene_pfad());
            foreach (string zeile in zeilen)
            {
                string[] teile = zeile.Split(';');
                if (teile.Length >= 6)
                {
                    ListViewItem item = new ListViewItem(teile[0]);
                    item.SubItems.Add(teile[1]);
                    item.SubItems.Add(teile[2]);
                    item.SubItems.Add(teile[3]);
                    item.SubItems.Add(teile[4]);
                    item.SubItems.Add(teile[5]);
                    lv_tickets.Items.Add(item);
                }
            }

            MessageBox.Show($"Ticket mit der ID: {gesuchteID} wurde Erfolgreich Geschlossen", "Geschlossen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}