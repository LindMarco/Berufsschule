using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support_Ticket_System
{
    internal class Speichern
    {
        private string dateipfad_speichern = @"C:\Users\de007467\OneDrive - FÖRCH\Desktop\Schule\2. Lehrjahr\BTS\Projekt (Support-Ticket-System)\Dateien\Tickets.txt";

        public string dateipfad()
        {
            return dateipfad_speichern;
        }
        public void ticketspeichern(Tickets ticket)
        {
            File.AppendAllText(dateipfad_speichern, ticket.ToString() + System.Environment.NewLine);
        }
    }
}
