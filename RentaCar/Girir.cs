using RentaCar.Repository;
using RentaCar.Repository.Car;
using RentaCar.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar
{
    public partial class Girir : Form
    {
        public Girir()
        {
            InitializeComponent();
        }

        // Ana form yüklenme olayı
        private void Girir_Load(object sender, EventArgs e)
        {
            // Splash ekranını göster
            SplashForm splashForm = new SplashForm();
            splashForm.Show();

            // Ana formu geçici olarak gizle
            this.Hide();

            // Ana formu bir gecikme sonrasında göstermek için metodunu çağır
            splashForm.ShowMainForm();

            // Ana formu tekrar göster
            this.Show();
        }

        // Araç ekle butonu tıklama olayı
        private void button1_Click(object sender, EventArgs e)
        {
            aracOzellik aracOzellik = new aracOzellik();
            aracOzellik.Show();
        }

        // Araç kirala butonu tıklama olayı
        private void button4_Click(object sender, EventArgs e)
        {
            // CarRepository sınıfından bir örnek oluştur
            CarRepository carRepository = new CarRepository();
            FuelRepository fuelRepository = new FuelRepository();

            try
            {
                // CarRepository örneğini CarService kurucusuna geçir
                CarService carService = new CarService(carRepository, fuelRepository);

                // Şimdi, carService örneğini Arac_bilgileri kurucusuna geçirebilirsin
                Arac_bilgileri aracBilgileriForm = new Arac_bilgileri(carService);

                // Oluşturulan formu göster
                aracBilgileriForm.Show();

                // İhtiyaca bağlı olarak, mevcut formu kapat
                // this.Close();
            }
            catch (Exception ex)
            {
                // Form oluşturulurken oluşabilecek herhangi bir istisnayı ele al
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Araç sil butonu tıklama olayı
        private void button2_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.Show();
        }

        // Araç güncelle butonu tıklama olayı
        private void button3_Click(object sender, EventArgs e)
        {
            update Update = new update();
            Update.Show();
        }
    }
}
