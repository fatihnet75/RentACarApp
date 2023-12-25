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
    public class Responsible : AppDbContext
    {

        public void SetREsponsible(CarResponsible responsible)
        {
            string query = "INSERT INTO [dbo].[sorumlu] VALUES (@plaka,@adsoyad)";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@plaka", responsible.plaka);
                    command.Parameters.AddWithValue("@adsoyad", responsible.AdSoyad);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
