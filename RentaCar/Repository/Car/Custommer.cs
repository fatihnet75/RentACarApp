using RentaCar.Entities;
using RentaCar.Repository.DbContext;
using System;
using System.Data.SqlClient;

namespace RentaCar.Repository.Car
{
	public class Custommer : AppDbContext
    {

        public void SetCustommer(Custommer custommer)
        {
            string query = "INSERT INTO [dbo].[Müşteri] VALUES (@Tc, @tel, @Ad, @Soyad, @Eposta)";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    


                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
