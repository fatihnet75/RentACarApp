using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar
{
    public partial class SplashForm : Form
    {
        private int remainingSeconds = 3; // Geri sayım için kalan süre

        public SplashForm()
        {
            InitializeComponent();
        }

        private async void SplashForm_Load(object sender, EventArgs e)
        {
            await PerformLoadingAsync();

            Girir girirForm = new Girir();
            girirForm.Show();

            // 3 saniyelik geri sayımı başlat
            await StartCountdown();
        }

        private async Task PerformLoadingAsync()
        {
            // Simüle edilmiş bir yükleme süresi
            await Task.Delay(300); // 0.3 saniye
        }

        private async Task StartCountdown()
        {
            while (remainingSeconds > 0)
            {
                label1.Text = $"Kalan Süre: {remainingSeconds} saniye";
                await Task.Delay(1000); // 1 saniye beklet
                remainingSeconds--;
            }

            // Geri sayım tamamlandıktan sonra SplashForm'u kapat
            Close();
        }

        private void SplashForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Eğer bu olay tetiklenirse, diğer formu açabilir veya başka işlemler yapabilirsiniz.
        }
    }
}
