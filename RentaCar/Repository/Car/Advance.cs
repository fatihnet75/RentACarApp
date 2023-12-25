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
    public class Advance : AppDbContext
    {
        public void SetAdvance(CarAdvance Advance)
        {
            string query = "INSERT INTO [dbo].[Peşin] VALUES (@toplampara, @Tarih )";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kartid", Advance.ToplamPara);
                    command.Parameters.AddWithValue("@cvv", Advance.Tarih);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
