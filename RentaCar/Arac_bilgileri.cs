using RentaCar.Entities;
using RentaCar.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentaCar
{
    public partial class Arac_bilgileri : Form
    {
        private readonly CarService _carService;

        public Arac_bilgileri(CarService carService)
        {
            InitializeComponent();
            _carService = carService;

            // Veritabanýndan verileri al
            // var cars = _carService.GetAllCars();
            //burasý düzelecek sadece elektirik için 
            var cars = _carService.GetAllCarsWithDetail();

            // DataGridView'i temizle
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Verileri DataGridView'e ekle
            foreach (var car in cars)
            {
                // Her bir özellik için bir sütun oluþtur
                if (dataGridView1.Columns.Count == 0)
                {
                    foreach (var property in typeof(CarsWithDetail).GetProperties())
                    {
                        dataGridView1.Columns.Add(property.Name, property.Name);
                    }
                }

                // Bir satýr ekleyin ve deðerleri sütunlara yerleþtirin
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                foreach (var property in typeof(CarsWithDetail).GetProperties())
                {
                    var value = property.GetValue(car);
                    row.Cells[property.Name].Value = value;
                }
            }
        }

        private void devamButton_Click(object sender, EventArgs e)
        {
            long plaka = Convert.ToInt64(plakaText.Text);

            // Kiracý formunu açmadan önce fiyatlarý topla
            var cars = _carService.GetAllCarsWithDetail();
            var toplamFiyatListesi = new List<int>();

            foreach (var car in cars)
            {
                toplamFiyatListesi.Add(car.Fiyat);
            }

            int toplambutce = toplamFiyatListesi.Sum();

            // Toplam bütçeyi etiket kontrolüne yazdýr
            toplambütce.Text = $"Toplam Bütçe: {toplambutce}";

            Kiraci kiraci = new Kiraci(carService: _carService, plaka: plaka);
            kiraci.Show();
        }
    }
}
