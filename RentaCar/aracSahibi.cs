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
    public partial class aracSahibi : Form
    {
        private readonly Employe employe = new Employe();
        private readonly Person person = new Person();
        private readonly Official official = new Official();
        private readonly Responsible responsible = new Responsible();
        public long plaka;
        public aracSahibi(long plaka)
        {
            InitializeComponent();
            this.plaka = plaka;
        }

        private void devamButton_Click(object sender, EventArgs e)
        {
            var carResponsible = new CarResponsible()
            {
                plaka = plaka,
                AdSoyad = Convert.ToString(adSoyadTextBox.Text),
            };
            var carPerson = new CarPerson() { 
            tc=Convert.ToInt64(tcTextBox.Text),
            Plaka= plaka,
            
            };


           

            person.Setperson(carPerson);
            responsible.SetREsponsible(carResponsible);

            if (SirketArabası.Checked)
            {

                var caroficcial = new CarOficcial()
                {
                    Rütbe = Convert.ToString(meslekTextBox.Text),
                    pzisyon = Convert.ToString(telPozisyonTextBox.Text),
                    tc = Convert.ToInt64(tcTextBox.Text),
                };
                official.SetOficcial(caroficcial);
            }
            else if (KendiArabam.Checked)
            {
                var caremployee = new CarEmployee()
                {
                    Telefon = Convert.ToInt64(telPozisyonTextBox.Text),
                    tc = Convert.ToInt64(tcTextBox.Text),
                    Rutbe = Convert.ToString(meslekTextBox.Text),
                };
                employe.SetEmployee(caremployee);
            }
            EkFiyat ekFiyat = new EkFiyat(plaka);
            ekFiyat.Show();
        }
    }
}
