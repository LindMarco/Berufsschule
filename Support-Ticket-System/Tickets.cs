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
        public string Benutzer;
        public string Zusammenfassung;
        public string Verantwortliche_abteilung;
        public string Kategori;
        public string Beschreibung;

        public override string ToString()
        {
            return $"{ID};{Benutzer};{Zusammenfassung};{Verantwortliche_abteilung};{Kategori};{Beschreibung}";
        }

        public Tickets ticket_laden(int id)
        {
            Speichern ticket = new Speichern();

            foreach (string zeile in File.ReadAllLines(ticket.dateipfad()))
            {
                string[] teile = zeile.Split(';');

                if (int.Parse(teile[0]) == id)
                {
                    return new Tickets
                    {
                        Benutzer = teile[1],
                        Zusammenfassung = teile[2],
                        Verantwortliche_abteilung = teile[3],
                        Kategori = teile[4],
                        Beschreibung = teile[5]
                    };
                }
            }
            return null;
        }

    }
}
