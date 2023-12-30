using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Entities
{
    public class CarPayment
    {
        public int id { get; set; } 
        public long Tc { get; set; }
        public int miktar { get; set; }
        public DateTime Tarih { get; set; }

    }
}
