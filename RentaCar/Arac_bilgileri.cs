using RentaCar.Entities;
using RentaCar.Service;
using System.Runtime.CompilerServices;

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

            var cars = _carService.GetAllCarsWithDetail("Elektrik");

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
            string plaka = plakaText.Text.ToString();

            if(plaka is not null)
            {
                Kiraci kiraci = new Kiraci(carService: _carService,plaka: plaka);
                kiraci.Show();
            }
        }
    }
}
