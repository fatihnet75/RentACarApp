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

            // Veritaban�ndan verileri al
            // var cars = _carService.GetAllCars();
            //buras� d�zelecek sadece elektirik i�in 
            var cars = _carService.GetAllCarsWithDetail();

            // DataGridView'i temizle
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Verileri DataGridView'e ekle
            foreach (var car in cars)
            {
                // Her bir �zellik i�in bir s�tun olu�tur
                if (dataGridView1.Columns.Count == 0)
                {
                    foreach (var property in typeof(CarsWithDetail).GetProperties())
                    {
                        dataGridView1.Columns.Add(property.Name, property.Name);
                    }
                }

                // Bir sat�r ekleyin ve de�erleri s�tunlara yerle�tirin
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

            // Kirac� formunu a�madan �nce fiyatlar� topla
            var cars = _carService.GetAllCarsWithDetail();
            var toplamFiyatListesi = new List<int>();

            foreach (var car in cars)
            {
                toplamFiyatListesi.Add(car.Fiyat);
            }

            int toplambutce = toplamFiyatListesi.Sum();

            // Toplam b�t�eyi etiket kontrol�ne yazd�r
            toplamb�tce.Text = $"Toplam B�t�e: {toplambutce}";

            Kiraci kiraci = new Kiraci(carService: _carService, plaka: plaka);
            kiraci.Show();
        }
    }
}
