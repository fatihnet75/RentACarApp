// Program.cs

using System;
using System.Threading;
using System.Windows.Forms;

namespace RentaCar
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // SplashForm'u baþlatýn
            SplashForm splashForm = new SplashForm();
            splashForm.Show();

            // Ana formun yüklenmesini beklemek için bir gecikme ekleyin
            Application.DoEvents();
            Thread.Sleep(3000);  // 3 saniye bekleyin (Simülasyon amacýyla)

            // SplashForm'u kapatýn
            splashForm.Close();

            // Ana formu baþlatýn
            Application.Run(new Girir());
        }
    }
}
