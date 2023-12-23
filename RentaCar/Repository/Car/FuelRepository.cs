using RentaCar.Entities;
using RentaCar.Repository.DbContext;
using Microsoft.Extensions.Configuration;
using AutoMapper.Internal.Mappers;
using RentaCar.Mapping;
using RentaCar.Dtos;

namespace RentaCar.Repository.Car
{
    public class FuelRepository : AppDbContext
    {
        public IEnumerable<ModelAndBrandDto> GetCarsMaoelAndBrandByPlaka(string plaka,string fuelopt)
        {
            string query = $"SELECT model,marka FROM {fuelopt} WHERE plaka = {plaka};";
            var response = Query(query);

            return ObjectMapper.Mapper.Map<List<ModelAndBrandDto>>(response);
        }


    }
}
