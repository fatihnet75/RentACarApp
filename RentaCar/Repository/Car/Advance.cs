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
            string query = "INSERT INTO [dbo].[Peşin] VALUES (@ino,@toplampara ,@tarih)";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ino", Advance.id);
                    command.Parameters.AddWithValue("@toplampara", Advance.ToplamPara);
                    command.Parameters.AddWithValue("@tarih", Advance.Tarih);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
