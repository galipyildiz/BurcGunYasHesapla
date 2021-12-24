using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurcGunYasHesapla
{
    public partial class Form1 : Form
    {
        DateTime dogumTarihi;
        public Form1()
        {
            InitializeComponent();
            Hesapla();
        }

        private void Hesapla()
        {
            dogumTarihi = dtpDogumTarihi.Value;
            lblYas.Text = "Yaşınız: " + YasHesapla(dogumTarihi);
            lblGun.Text = "Yaşadığınız Gün: " + GunHesapla(dogumTarihi);
            lblBurc.Text = "Burcunuz: " + BurcHesapla(dogumTarihi.Month, dogumTarihi.Day);
        }

        private string BurcHesapla(int month, int day)
        {
            string burc = "";
            if ((month == 1 && day >= 21) || (month == 2 && day <= 19))//Kova => Ocak 21 - 19 Şubat
            {
                burc = "Kova";
            }
            else if ((month == 2 && day >= 20) || (month == 3 && day <= 20))//Balık => 20 Şubat - 20 Mart
            {
                burc = "Balık";
            }
            else if ((month == 3 && day >= 21) || (month == 4 && day <= 20))//Koç => 21 Mart - 20 Nisan
            {
                burc = "Koç";
            }
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))//Boğa => 21 Nisan - 21 Mayıs
            {
                burc = "Boğa";
            }
            else if ((month == 5 && day >= 22) || (month == 6 && day <= 21))//İkizler => 22 Mayıs - 21 Haziran
            {
                burc = "İkizler";
            }
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 23))//Yengeç => 22 Haziran - 23 Temmuz
            {
                burc = "Yengeç";
            }
            else if ((month == 7 && day >= 24) || (month == 8 && day <= 23))//Aslan => 24 Temmuz - 23 Ağustos
            {
                burc = "Aslan";
            }
            else if ((month == 8 && day >= 24) || (month == 9 && day <= 22))//Başak => 24 Ağustos - 22 Eylül
            {
                burc = "Başak";
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 23))//Terazi => 23 Eylül - 23 Ekim
            {
                burc = "Terazi";
            }
            else if ((month == 10 && day >= 24) || (month == 11 && day <= 22))//Akrep => 24 Ekim - 22 Kasım
            {
                burc = "Akrep";
            }
            else if ((month == 11 && day >= 23) || (month == 12 && day <= 21))//Yay => 23 Kasım - 21 Aralık
            {
                burc = "Yay";
            }
            else//Oğlak => 22 Aralık - 20 Ocak
            {
                burc = "Oğlak";
            }
            return burc;
        }

        private string GunHesapla(DateTime dogumTarihi)
        {
            TimeSpan gecenSure = DateTime.Now - dogumTarihi;
            int toplamGun = (int)gecenSure.TotalDays;
            return toplamGun.ToString();
        }

        private string YasHesapla(DateTime dogumTarihi)
        {
            TimeSpan gecenSure = DateTime.Now - dogumTarihi;
            int yas = (int)gecenSure.TotalDays / 365;
            return yas.ToString();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
        }
    }
}
