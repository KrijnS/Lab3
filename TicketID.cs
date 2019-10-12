using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class TicketID
    {
        //Ticket IDs are currently a keyvaluepair with the date, the chance that this minimal implementation makes a not unique pair is small to none
        public int generateID()
        {
            Random rand = new Random();
            int id = rand.Next(100000000);
            return id;
        }
    }
}
