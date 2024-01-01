using System;
using System.Data.SqlClient;
using RentaCar.Entities;
using RentaCar.Repository.DbContext;

namespace RentaCar.Repository.Car
{
    //Bitti
    public class RezervationRepository : AppDbContext
    {
        public void SetRezervasyon(CarRezervation rezervation)
        {
            string query = "INSERT INTO [dbo].[Rezervasyon] VALUES (@Tc, @Plaka, @FirstYil, @LastYil)";
            //string query = "EXEC sp_AddReservation @Tc, @BaslangicTarihi, @BitisTarihi, @Plaka";
            //SAKLI PROSEDUR
            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Tc", rezervation.Tc);
                    command.Parameters.AddWithValue("@Plaka", rezervation.Plaka);
                    command.Parameters.AddWithValue("@FirstYil", rezervation.FirstYil);
                    command.Parameters.AddWithValue("@LastYil", rezervation.LastYil);


                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
