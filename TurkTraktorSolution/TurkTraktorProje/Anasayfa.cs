using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkTraktorProje
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnKategorIslemleri_Click(object sender, EventArgs e)
        {
            KategoriIslemleri kategoriler= new KategoriIslemleri();
            kategoriler.Show();
            this.Hide();
        }

        private void btnSatisIslemleri_Click(object sender, EventArgs e)
        {
            SatisIslemleri satislar= new SatisIslemleri();
            satislar.Show();
            this.Hide();
        }

        private void btnStokHareketleri_Click(object sender, EventArgs e)
        {
            StokIslemleri stokHareketleri= new StokIslemleri();
            stokHareketleri.Show();
            this.Hide();
        }

        private void btnIadeHareketleri_Click(object sender, EventArgs e)
        {
            IadeIslemleri ıadeHareketleri = new IadeIslemleri();
            ıadeHareketleri.Show();
            this.Hide();
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            UrunIslemleri urunler= new UrunIslemleri();
            urunler.Show();
            this.Hide();
        }

        private void btnSaticiIslemleri_Click(object sender, EventArgs e)
        {
            SaticiIslemleri saticilar = new SaticiIslemleri();
            saticilar.Show();
            this.Hide();
        }

        private void btnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            PersonelIslemleri personeller = new PersonelIslemleri();
            personeller.Show();
            this.Hide();
        }

        private void btnMusteriIslemleri_Click(object sender, EventArgs e)
        {
            MusteriIslemleri musteriler = new MusteriIslemleri();
            musteriler.Show();
            this.Hide();
        }

        private void btnDepoIslemleri_Click(object sender, EventArgs e)
        {
            DepoIslemleri depolar = new DepoIslemleri();
            depolar.Show();
            this.Hide();
        }

        private void btnTedarikciIslemleri_Click(object sender, EventArgs e)
        {
            TedarikciIslemleri tedarikciler = new TedarikciIslemleri();
            tedarikciler.Show();
            this.Hide();
        }

        private void btnSiparisİslemleri_Click(object sender, EventArgs e)
        {
            SiparisIslemleri siparisler=new SiparisIslemleri();
            siparisler.Show();
            this.Hide();
        }

        private void btnSiparisDetaylari_Click(object sender, EventArgs e)
        {
            SiparisDetayIslemleri siparisDetaylari = new SiparisDetayIslemleri();
            siparisDetaylari.Show();
            this.Hide();
        }

        private void btnUrunAsamaDetaylari_Click(object sender, EventArgs e)
        {
            AsamaIslemleri asamaIslemleri = new AsamaIslemleri();
            asamaIslemleri.Show();
            this.Hide();

        }
    }
}
