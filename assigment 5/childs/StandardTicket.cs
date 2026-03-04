using assigment_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.childs
{
    internal class StandardTicket : Ticket,IPrintable
    {
        public int SeatNumber { get; set; }

        public StandardTicket(string mn, decimal price, int seatNumber):base(mn, price) 
        {
            SeatNumber = seatNumber;
        }

        public override void Print()
        {
            Console.WriteLine(
                       $"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");
        }
        public override object Clone()
        {
            return new StandardTicket(MovieName, Price, SeatNumber);
        }

    }
}
