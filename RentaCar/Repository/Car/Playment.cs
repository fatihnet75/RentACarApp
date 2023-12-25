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
            string query = "INSERT INTO [dbo].[ödeme] VALUES (@Tc, @miktar ,@Tarih)";

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


        public int GetAmountAsync(string plaka)
        {
            string query = "SELECT fiyat FROM [dbo].[araç] WHERE plaka=@plaka";

            using (SqlConnection connection = GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@plaka", plaka);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Okuma işlemi başarılı olduysa miktar değerini al
                            int miktar = reader.GetInt32(reader.GetOrdinal("fiyat"));
                            return miktar;
                        }
                    }
                }
            }

            // Okuma işlemi başarısız olduysa veya miktar bulunamadıysa -1 veya başka bir değer döndürebilirsiniz.
            return -1;
        }



    }
}
