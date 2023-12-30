
using RentaCar.Dtos;
using RentaCar.Entities;
using RentaCar.Repository;
using RentaCar.Repository.Car;

namespace RentaCar.Service
{
    public class CarService
    {
        private readonly CarRepository _carRepository;
        private readonly FuelRepository _fuelRepository;

        public CarService(CarRepository carRepository, FuelRepository fuelRepository)
        {
            _carRepository = carRepository;
            _fuelRepository = fuelRepository;
        }

        public List<Cars> GetAllCars()
        {
            var cars = _carRepository
                .GetAllCars();

            return cars;
        }
        
        public List<CarsWithDetail> GetAllCarsWithDetail()
        {
            var carsWithFuel1 = _carRepository.GetAllCarsWithFuel("Elektrik");
            var carsWithFuel2 = _carRepository.GetAllCarsWithFuel("Benzin");

            // İki listeyi birleştir
            var combinedCars = carsWithFuel1.Concat(carsWithFuel2).ToList();

            return combinedCars;
        }

        public ModelAndBrandDto GetModelAndBrandByPlaka(string plaka)
        {
            return null;
        }
    }
}
