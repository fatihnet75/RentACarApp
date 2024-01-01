using RentaCar.Repository.DbContext;
using System.Data.SqlClient;
using RentaCar.Entities;
using Microsoft.Extensions.Configuration;
using AutoMapper.Internal.Mappers;
using RentaCar.Mapping;
using System.Security.Policy;
using System.Data;


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

        public List<Cars> GetAllCarsWithCursor()
        {
            List<Cars> cars = new List<Cars>();

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_GetAllCarsWithCursor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cars car = new Cars
                            {
                                // Sütunları oku ve Cars sınıfına ekle
                                Plaka = reader["plaka"].ToString(),
                                Renk = reader["renk"].ToString(),
                                Fiyat = Convert.ToInt32(reader["fiyat"]),
                                Yil = Convert.ToDateTime(reader["yıl"])
                            };

                            cars.Add(car);
                        }
                    }
                }
            }

            return cars;
        }
    }

}
