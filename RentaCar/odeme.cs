using RentaCar.Entities;
using RentaCar.Repository.Car;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentaCar
{
    public partial class odeme : Form
    {
        private readonly Playment playment;
        private long plaka;
        private long tc;
        public odeme(long plaka, long tc)
        {
            if (plaka != 0 && tc != 0)  // ya da null kontrolü yapabilirsiniz
            {
                this.plaka = plaka;
                this.tc = tc;
                InitializeComponent();
                //playment.getAmount(plaka) buraya miktarı çekmen lazım yoksa güm;
                int paymentAmount = 5000;
                label2.Text = paymentAmount.ToString();  // Bu satırı kontrol edin
            }
            else
            {
                // Hata durumunda yapılacak işlemleri buraya ekleyebilirsiniz
                MessageBox.Show("Geçersiz plaka veya tc değeri.");
            }
        }


        private void krediButton_Click(object sender, EventArgs e)
        {
            
           var carplayment = new CarPayment()
            {
               miktar = Convert.ToInt32(label2.Text),
               Tarih = Convert.ToDateTime(DateTextBox1.Text),
                Tc = tc,

            };
            playment.SetPlayment(carplayment);
            kredi kredi = new kredi();
            kredi.Show();
        }

        private void pesinButton_Click(object sender, EventArgs e)
        {
            pesin pesin = new pesin(Convert.ToInt32(label2.Text));
            pesin.Show();
        }
    }
}
