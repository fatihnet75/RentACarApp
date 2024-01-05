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

            // SplashForm'u ba�lat�n
            SplashForm splashForm = new SplashForm();
            splashForm.Show();

            // Ana formun y�klenmesini beklemek i�in bir gecikme ekleyin
            Application.DoEvents();
            Thread.Sleep(3000);  // 3 saniye bekleyin (Sim�lasyon amac�yla)

            // SplashForm'u kapat�n
            splashForm.Close();

            // Ana formu ba�lat�n
            Application.Run(new Girir());
        }
    }
}
