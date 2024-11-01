using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurkTraktorProje.Context;
using TurkTraktorProje.DataAccess;
using TurkTraktorProje.Entities;

namespace TurkTraktorProje
{
    public partial class SiparisDetayIslemleri : Form
    {
        public SiparisDetayIslemleri()
        {
            InitializeComponent();
        }
        SiparisDetayDal siparisDetay =new SiparisDetayDal();
        private void SiparisDetayIslemleri_Load(object sender, EventArgs e)
        {

            using (var context = new TurkTraktorContext())
            {
                var products = context.Urunlers.ToList();
                var sales= context.Siparislers.ToList();

                cbxSiparisUrunId.DataSource = products;
                cbxSiparisUrunId.DisplayMember = "UrunAdi";
                cbxSiparisUrunId.ValueMember = "UrunID";

                cbxSiparisId.DataSource = sales;
                cbxSiparisId.DisplayMember = "SiparisID";
                cbxSiparisId.ValueMember = "SiparisID";

            }
        }

        private void btnGeriSiparisDetay_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnSiparislerGeriDon_Click(object sender, EventArgs e)
        {
            SiparisIslemleri siparisIslemleri=new SiparisIslemleri();
            siparisIslemleri.Show();
            this.Hide();
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            siparisDetay.Add(new SiparisDetay
            {
                SiparisID = Convert.ToInt32(cbxSiparisId.SelectedValue),
                BirimFiyati = Convert.ToInt32(txtDetayBirimFiyati.Text),
                Miktar = Convert.ToInt32(txtDetayMiktar.Text),
                UrunID = Convert.ToInt32(cbxSiparisUrunId.SelectedValue),
            });
            MessageBox.Show("Sipariş Eklendi");
        }

        private void btnSiparisiİptalEt_Click(object sender, EventArgs e)
        {
            cbxSiparisId.SelectedItem = null;
            cbxSiparisUrunId.SelectedItem= null;
            txtDetayBirimFiyati.Text = "";
            txtDetayMiktar.Text = "";
        }
    }
}
