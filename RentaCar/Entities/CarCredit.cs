using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Entities
{
    public class CarCredit
    {
        public long KartId { get; set; }
        public int Cvv { get; set; }
        public string KartName { get; set; }
    }
}
