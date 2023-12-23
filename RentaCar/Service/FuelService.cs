using RentaCar.Repository.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentaCar.Entities;

namespace RentaCar.Service
{
    
    public class FuelService
    {
        private readonly FuelRepository _fuelRepository;

        public FuelService(FuelRepository fuelRepository)
        {
            _fuelRepository = fuelRepository;
        }

    
    }
    

}
