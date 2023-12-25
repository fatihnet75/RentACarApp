using RentaCar.Entities;
using RentaCar.Repository.DbContext;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Repository.Car
{
    public class NewCar : AppDbContext
    {
        public void SetCar(AddCArs car)
        {
            string query = "INSERT INTO [dbo].[Araç] VALUES (@plaka, @renk ,@fiyat,@yıl)";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@plaka", car.Plaka);
                    command.Parameters.AddWithValue("@renk", car.Renk);
                    command.Parameters.AddWithValue("@fiyat", car.Fiyat);
                    command.Parameters.AddWithValue("@yıl", car.Yil);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
