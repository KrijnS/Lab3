using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Ticket
    {
        UIInfo info;
        string date;
        int ticketID;

        public Ticket(UIInfo info, string date, int ticketID)
        {
            this.info = info;
            this.date = date;
            this.ticketID = ticketID;
        }
        
        public Ticket generateTicket(UIInfo info)
        {
            Date d = new Date();
            string date = d.getDate();
            TicketID tID = new TicketID();
            int id = tID.generateID();

            Ticket ticket = new Ticket(info, date, id);
            writeTicketToFile(ticket);

            return ticket;
        }

        public void writeTicketToFile(Ticket ticket)
        {         
            string ticketToFile = ticket.ticketID + " From " + info.From + " to " + info.To + " Class " + info.Class + " On " + ticket.date;
            File.AppendAllText("Tickets.txt", ticketToFile + Environment.NewLine);
        }

    }
}
