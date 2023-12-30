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
    public class Update : AppDbContext
    {
        public void UpdateCar(AddCArs addCars, long plaka)
        {
           using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                string updateQuery = "UPDATE Araç SET Renk = @Renk, fiyat = @Fiyat, yıl = @Yil WHERE Plaka = @Plaka";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Parametreleri ekleyerek SQL ASsorgusunu parametrize ediyoruz
                    command.Parameters.AddWithValue("@Renk", addCars.Renk); // Yeni renk değeri
                    command.Parameters.AddWithValue("@Fiyat", addCars.Fiyat); // Yeni fiyat değeri
                    command.Parameters.AddWithValue("@Yil", addCars.Yil); // Yeni yıl değeri
                    command.Parameters.AddWithValue("@Plaka", plaka); // Hangi aracın güncelleneceğini belirten plaka

                    // UPDATE sorgusunu çalıştır
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
