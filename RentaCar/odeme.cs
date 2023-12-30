using RentaCar.Entities;
using RentaCar.Repository.Car;

namespace RentaCar
{
    public partial class odeme : Form
    {
        private readonly Playment playment = new Playment();
        private long plaka;
        private long tc;
        public odeme(long plaka, long tc)
        {
            if (plaka != 0 && tc != 0)  // ya da null kontrolü yapabilirsiniz
            {
                this.plaka = plaka;
                this.tc = tc;
                InitializeComponent();
                var paymentAmount = playment.GetAmountAsync(plaka.ToString());
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
                id = Convert.ToInt32(idmaskedTextBox1.Text),
               miktar = Convert.ToInt32(label2.Text),
               Tarih = Convert.ToDateTime(DateTextBox1.Text),
                Tc = tc

            };
            playment.SetPlayment(carplayment);
            kredi kredi = new kredi( Convert.ToInt32(idmaskedTextBox1.Text));
            kredi.Show();
        }

        private void pesinButton_Click(object sender, EventArgs e)
        {

            var carplayment = new CarPayment()
            {
                id = Convert.ToInt32(idmaskedTextBox1.Text),
                miktar = Convert.ToInt32(label2.Text),
                Tarih = Convert.ToDateTime(DateTextBox1.Text),
                Tc = tc,

            };
            playment.SetPlayment(carplayment);
            pesin pesin = new pesin(Convert.ToInt32(label2.Text), Convert.ToInt32(idmaskedTextBox1.Text));
            pesin.Show();
        }
    }
}
