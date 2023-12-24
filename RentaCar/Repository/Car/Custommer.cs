using RentaCar.Repository.DbContext;
using System;

namespace RentaCar.Repository.Car
{
	public class Custommer : AppDbContext
    {
        public void SetRezervasyon(String tc, string plaka, String isim, String Soyisim, String eposta)
        {
            string query = $"INSERT INTO [dbo].[Rezervasyon] VALUES ('{tc}','{plaka}','{isim}','{Soyisim}','{eposta}')";
            var response = Query(query);
        }
    }
}
