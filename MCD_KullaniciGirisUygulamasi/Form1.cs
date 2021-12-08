using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_KullaniciGirisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            kullanici bulunanKullanici = sanalDatabase.KullaniciTablo.Find(i => i.kullaniciAdi == kullaniAdi && i.sifre == sifre);

            //kullaniAdi = "admin" && sifre = "123"
            if (bulunanKullanici != null)
            {
                anaForm _anaForm = new anaForm(bulunanKullanici);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
