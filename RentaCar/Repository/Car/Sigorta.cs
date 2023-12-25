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
    public class Sigorta: AppDbContext
    {
        public void SetSigorta(CarSigorta Advance)
        {
            string query = "INSERT INTO [dbo].[Sigorta] VALUES (@plaka, @sigortano, @songecerlilik)";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@plaka", Advance.plaka);
                    command.Parameters.AddWithValue("@sigortano", Advance.Sigortano);
                    command.Parameters.AddWithValue("@songecerlilik", Advance.songecerlilik);
                  

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
