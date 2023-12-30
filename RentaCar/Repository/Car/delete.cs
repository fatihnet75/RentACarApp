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
    public class delete :AppDbContext
    {
        public void DeleteCar(long plaka)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DELETE FROM Benzin WHERE Plaka = @Plaka", connection))
                {
                    command.Parameters.AddWithValue("@Plaka", plaka);
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand("DELETE FROM Elektrik WHERE Plaka = @Plaka", connection))
                {
                    command.Parameters.AddWithValue("@Plaka", plaka);
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand("DELETE FROM Sigorta WHERE Plaka = @Plaka", connection))
                {
                    command.Parameters.AddWithValue("@Plaka", plaka);
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand("DELETE FROM Soför WHERE Plaka = @Plaka", connection))
                {
                    command.Parameters.AddWithValue("@Plaka", plaka);
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand("DELETE FROM Kasko WHERE Plaka = @Plaka", connection))
                {
                    command.Parameters.AddWithValue("@Plaka", plaka);
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand("DELETE FROM Araç WHERE Plaka = @Plaka", connection))
                {
                    command.Parameters.AddWithValue("@Plaka", plaka);
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
