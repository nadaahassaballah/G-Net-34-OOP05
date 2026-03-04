using assigment_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02
{
    internal abstract class Ticket : IPrintable, IBookable, ICloneable

    {
        private static int counter = 0;

        public int TicketId { get; private set; }
        public string MovieName { get; set; }
        public decimal Price { get; set; }

        protected bool isBooked;

        public bool IsBooked => isBooked;

        public decimal PriceAfterTax => Price * 1.14m;

        public Ticket(string movieName, decimal price)
        {
            TicketId = ++counter;
            MovieName = movieName;
            Price = price;
            isBooked = false;
        }

        public bool Book()
        {
            if (isBooked)
                return false;

            isBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!isBooked)
                return false;

            isBooked = false;
            return true;
        }

        public abstract void Print();

        public abstract object Clone();

    }
}
