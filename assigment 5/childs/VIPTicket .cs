using assigment_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.childs
{
    internal class VIPTicket: Ticket , IPrintable
    {
        public  bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; }= 50;
        public VIPTicket(string mn, decimal price, bool _LoungeAccess) : base(mn, price)
        {
            LoungeAccess = _LoungeAccess;

        }
        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new VIPTicket(MovieName, Price, LoungeAccess);
        }
    }
}
