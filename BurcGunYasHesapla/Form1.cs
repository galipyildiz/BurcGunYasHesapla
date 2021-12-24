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
            lblYas.Text = "Yaşınız: " + YasHesapla(dogumTarihi.Year);
        }

        private string YasHesapla(int year)
        {
            return (DateTime.Now.Year - year).ToString();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
        }
    }
}
