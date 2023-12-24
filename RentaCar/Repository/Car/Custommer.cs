using RentaCar.Entities;
using RentaCar.Repository.DbContext;
using System;
using System.Data.SqlClient;

namespace RentaCar.Repository.Car
{
	public class Custommer : AppDbContext
    {

        public void SetCustommer(CarCustommer custommer)
        {
            string query = "INSERT INTO [dbo].[Müşteri] VALUES (@Tc,  @Ad, @Soyad,@tel, @Eposta)";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Tc", custommer.Tc);
                    command.Parameters.AddWithValue("@Tel", custommer.Tel);
                    command.Parameters.AddWithValue("@Ad", custommer.isim);
                    command.Parameters.AddWithValue("@Soyad", custommer.SoyIsim);
                    command.Parameters.AddWithValue("@Eposta", custommer.Eposta);


                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
