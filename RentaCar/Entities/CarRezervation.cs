using System;

namespace RentaCar.Entities
{
    public class CarRezervation
    {
        public long Tc { get; set; } 
        public string Plaka { get; set; }
        public DateTime FirstYil { get; set; }
        public DateTime LastYil { get; set; }
        
    }
}
