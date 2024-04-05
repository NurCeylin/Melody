using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody
{
    internal class Payment
    {
        public int idPayment { get; set; }
        public string CardOwner { get; set; }
        public int CardNumber { get; set; }
        public int CVV { get; set; }

    }
}
