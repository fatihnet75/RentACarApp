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
    public class Clheffer : AppDbContext
    {
        public void Setcheffer(CarCheufeer Advance)
        {
            string query = "INSERT INTO [dbo].[Soför] VALUES (@tc, @Ad, @Soyad, @ehliyettipi )";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tc", Advance.tc);
                    command.Parameters.AddWithValue("@ad", Advance.Ad);
                    command.Parameters.AddWithValue("@Soyad", Advance.Soyad);
                    command.Parameters.AddWithValue("@ehliyettipi", Advance.tip);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
