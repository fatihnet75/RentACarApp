﻿using RentaCar.Entities;
using RentaCar.Repository.Car;
using RentaCar.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar
{
    public partial class Kiraci : Form
    {
        private readonly CarService carService;
        private long plaka;
        private readonly RezervationRepository rezervation;
        private readonly Custommer custommer;
        public Kiraci(CarService carService, long plaka)
        {
            this.carService = carService;
            this.plaka = plaka;
            rezervation = new RezervationRepository();
            custommer=new Custommer();
            InitializeComponent();
        }

        private void DEVAM_Click(object sender, EventArgs e)
        {
            var carRezervation = new CarRezervation()
            {
                
                FirstYil = Convert.ToDateTime(baslangicTextBox.Text),
                LastYil = Convert.ToDateTime(bitisTextBox.Text),
                Plaka = Convert.ToInt64(plaka),
                Tc = Convert.ToInt64(tcTextBox.Text),
                
            };
            var carCustommer = new CarCustommer()
            {
                Tc = Convert.ToInt64(tcTextBox.Text),
                Tel = Convert.ToInt64(telTextBox.Text),
                isim = Convert.ToString(adTextBox.Text),
                SoyIsim = Convert.ToString(soyadTextBox.Text),
                Eposta = Convert.ToString(ePostaTextBox.Text),


            };
          
            custommer.SetCustommer(carCustommer);
            rezervation.SetRezervasyon(carRezervation);
            odeme odeme = new odeme(Convert.ToInt64(plaka), Convert.ToInt64(tcTextBox.Text));
            odeme.Show();
           
        }
       
    }
}
