using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support_Ticket_System
{
    internal class Tickets
    {
        public int ID;
        public string Benutzer = "";
        public string Zusammenfassung = "";
        public string Verantwortliche_abteilung = "";
        public string Kategorie = "";
        public string Beschreibung = "";
        public string Kommentar = "";

        public override string ToString()
        {
            return $"{ID};{Benutzer};{Zusammenfassung};{Verantwortliche_abteilung};{Kategorie};{Beschreibung};{Kommentar}";
        }

        public Tickets ticket_laden(int id)
        {
            Speichern ticket = new Speichern();

            foreach (string zeile in File.ReadAllLines(ticket.offene_pfad()))
            {
                string[] teile = zeile.Split(';');

                if (int.Parse(teile[0]) == id)
                {
                    return new Tickets
                    {
                        ID = Convert.ToInt16(teile[0]),
                        Benutzer = teile[1],
                        Zusammenfassung = teile[2],
                        Verantwortliche_abteilung = teile[3],
                        Kategorie = teile[4],
                        Beschreibung = teile[5]
                    };
                }
            }
            return null;
        }
        public int ticket_id()
        {
            Speichern ticket = new Speichern();

            string[] zeilen = File.ReadAllLines(ticket.dateipfad());
            if (zeilen.Length == 0)
            {
                return 1;
            }
            string letztezeile = zeilen[zeilen.Length - 1];
            string[] teile = letztezeile.Split(";");

            int letzteid = int.Parse(teile[0]);

            return letzteid + 1;
        }

        public void ticketbearbeiten(Tickets ticket)
        {
            Speichern speichern = new Speichern();
            string[] zeilen = File.ReadAllLines(speichern.offene_pfad());

            for (int i = 0; i < zeilen.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(zeilen[i])) continue;

                string[] teile = zeilen[i].Split(";");
                int aktuelleID = int.Parse(teile[0]);

                if (aktuelleID == ticket.ID)
                {
                    zeilen[i] = $"{ticket.ID};{ticket.Benutzer};{ticket.Zusammenfassung};{ticket.Verantwortliche_abteilung};{ticket.Kategorie};{ticket.Beschreibung}";
                    break;
                }
            }
            File.WriteAllLines(speichern.offene_pfad(), zeilen);
        }
        public void ticketbearbeitenalle(Tickets ticket)
        {
            Speichern speichern = new Speichern();
            string[] zeilen = File.ReadAllLines(speichern.dateipfad());

            for (int i = 0; i < zeilen.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(zeilen[i])) continue;

                string[] teile = zeilen[i].Split(";");
                int aktuelleID = int.Parse(teile[0]);

                if (aktuelleID == ticket.ID)
                {
                    zeilen[i] = $"{ticket.ID};{ticket.Benutzer};{ticket.Zusammenfassung};{ticket.Verantwortliche_abteilung};{ticket.Kategorie};{ticket.Beschreibung}";
                    break;
                }
            }
            File.WriteAllLines(speichern.dateipfad(), zeilen);
        }
        public void ticket_löschen(int id)
        {
            Speichern ticket = new Speichern();
            List<string> zeilen = File.ReadAllLines(ticket.offene_pfad()).ToList();

            foreach (string zeile in File.ReadAllLines(ticket.offene_pfad()))
            {
                string[] teile = zeile.Split(';');

                if (int.Parse(teile[0]) == id)
                {
                    zeilen.Remove(zeile);
                }
            }
            File.WriteAllLines(ticket.offene_pfad(), zeilen);
        }
    }
}
