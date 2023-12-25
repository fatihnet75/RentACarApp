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
    public class Kasko : AppDbContext
    {
        public void SetKasko(CarKasko Advance)
        {
            string query = "INSERT INTO [dbo].[kasko] VALUES (@kaskono, @songecerlilik, @plaka )";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kaskon", Advance.CarKaskono);
                    command.Parameters.AddWithValue("@songecerlilik", Advance.songecerlilik);
                    command.Parameters.AddWithValue("@plaka", Advance.plaka);
                   

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
