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
    public class Playment : AppDbContext
    {

        public void SetPlayment(CarPayment Playment)
        {
            string query = "INSERT INTO [dbo].[ödeme] VALUES (@Tc,  @Tarih, @miktar)";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Tc", Playment.Tc);
                    command.Parameters.AddWithValue("@Tarih", Playment.Tarih);
                    command.Parameters.AddWithValue("@miktar", Playment.miktar);

                    command.ExecuteNonQuery();
                }
            }
        }
       




    }
}
