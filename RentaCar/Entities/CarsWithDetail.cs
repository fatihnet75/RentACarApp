using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Entities
{
    public class CarsWithDetail : Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
