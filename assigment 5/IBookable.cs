using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_5
{
    internal interface IBookable
    {
        bool Book();
        bool Cancel();
        bool IsBooked { get; }
    }
}
