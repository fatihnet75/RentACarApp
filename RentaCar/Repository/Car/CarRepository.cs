using RentaCar.Repository.DbContext;
using System.Data.SqlClient;
using RentaCar.Entities;
using Microsoft.Extensions.Configuration;
using AutoMapper.Internal.Mappers;
using RentaCar.Mapping;
using System.Security.Policy;


namespace RentaCar.Repository.Car
{
    public class CarRepository : AppDbContext
    {

        public List<Cars> GetAllCars()
        {
            string query = "SELECT * FROM Araç";
            var firstCar = ObjectMapper.Mapper.Map<List<Cars>>(Query(query));
            return ObjectMapper.Mapper.Map<List<Cars>>(Query(query)) ;
        }
        //public bool CreateCars(Car car)
        //{
        //    string query = "SELECT * FROM Araç";

        //    return ObjectMapper.Mapper.Map<List<Cars>>(Query(query)); ;
        //}
        public List<CarsWithDetail> GetAllCarsWithFuel(string fuelType)
        {
            string query = $"select * from Araç as a join {fuelType} as b on a.plaka = b.plaka";
            var cars = ObjectMapper.Mapper.Map<List<CarsWithDetail>>(Query(query));

            return cars;
        }
    }

}
