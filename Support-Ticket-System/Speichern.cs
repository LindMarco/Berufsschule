using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support_Ticket_System
{
    internal class Speichern
    {
        private string dateipfad_speichern = "..\\..\\..\\Dateien\\Tickets.txt";
        private string dateipfad_geschlossen = "..\\..\\..\\Dateien\\Geschlossene Tickets.txt";
        private string dateipfad_offen = "..\\..\\..\\Dateien\\Offene Tickets.txt";
        public string dateipfad()
        {
            return dateipfad_speichern;
        }
        public void ticketspeichern(Tickets ticket)
        {
            File.AppendAllText(dateipfad_speichern, ticket.ToString() + System.Environment.NewLine);
        }

        public string geschlossen_pfad()
        {
            return dateipfad_geschlossen;
        }

        public void ticketschließen(Tickets ticket)
        {
            File.AppendAllText(dateipfad_geschlossen, ticket.ToString() + System.Environment.NewLine);
        }

        public string offene_pfad()
        {
            return dateipfad_offen;
        }
        public void ticketoffen(Tickets ticket)
        {
            File.AppendAllText(dateipfad_offen, ticket.ToString() + System.Environment.NewLine);
        }
    }
}
