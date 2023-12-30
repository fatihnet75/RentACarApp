using RentaCar.Entities;
using RentaCar.Repository.Car;
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

    public partial class EkFiyat : Form
    {
        private readonly Sigorta sigorta = new Sigorta();
        private readonly Kasko kasko = new Kasko();
        private readonly Clheffer cheuffer = new Clheffer();
        public long plaka;
        public EkFiyat(long plaka)
        {
            this.plaka = plaka;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var carsigorta = new CarSigorta()
            {
                plaka = plaka,
                Sigortano=Convert.ToInt64(sigortaTextBox.Text),
                songecerlilik=Convert.ToDateTime(sonGecerlilikTarihsigortaTextBox1.Text),
            };
            sigorta.SetSigorta(carsigorta);

            if (kaskoKiralaButton.Checked)
            {

                var carkasko = new CarKasko()
                {
                    plaka = plaka,
                    songecerlilik = Convert.ToDateTime(sonGecerlilikTarihTextBox.Text),
                    CarKaskono = Convert.ToInt64(kaskoTextBox.Text),
                };
                kasko.SetKasko(carkasko);
            }
             if (soforKiralaButton.Checked)
            {
                var carsofor = new CarCheufeer()
                {
                    Ad = Convert.ToString(adTextBox.Text),
                    tc = Convert.ToInt64(tcTextBox.Text),
                    Soyad = Convert.ToString(soyadTextBox.Text),
                    tip=Convert.ToString(ehliyetTipiTextBox.Text),
                };
                cheuffer.Setcheffer(carsofor);
                Girir basla = new Girir();
                basla.Show();
            }
        }
    }
}
