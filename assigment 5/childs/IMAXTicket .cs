using assigment_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.childs
{
    internal class IMAXTicket:Ticket, IPrintable
    {
        public bool Is3D { get; set; }
        public IMAXTicket(string mn, decimal price, bool is3d) : base(mn, price) {
            if (is3d)
                price += 30;
        }
        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new IMAXTicket(MovieName, Price, Is3D);
        }
    }
}
