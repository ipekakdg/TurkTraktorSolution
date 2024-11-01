using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurkTraktorProje.Context;
using TurkTraktorProje.DataAccess;
using TurkTraktorProje.Entities;

namespace TurkTraktorProje
{
    public partial class SiparisIslemleri : Form
    {
        public SiparisIslemleri()
        {
            InitializeComponent();
        }
        SiparislerDal siparislerDal = new SiparislerDal();
        SiparisDetayDal siparisDetay=new SiparisDetayDal();

        private void Siparisler_Load(object sender, EventArgs e)
        {
            dgwSiparisler.DataSource= siparislerDal.GetAll();
            dgwSiparisDetay.DataSource=siparisDetay.GetAll();

            using (var context = new TurkTraktorContext())
            {
                var customers = context.Musterilers.ToList();
              
                cbxSiparislerMusteriId.DataSource = customers;
                cbxSiparislerMusteriId.DisplayMember = "MusteriAdi";
                cbxSiparislerMusteriId.ValueMember = "MusteriID";

            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            siparislerDal.Add(new Siparisler
            {
                ToplamTutar=Convert.ToInt32(txtSiparisToplamTutar.Text),
                SiparisTarihi=Convert.ToDateTime(dtpSiparis.Value),
                MusteriID=Convert.ToInt32(cbxSiparislerMusteriId.SelectedValue),
            });
            dgwSiparisler.DataSource = siparislerDal.GetAll();
            MessageBox.Show("Sipariş Eklendi");
        }

        private void btnGeriSiparisEkle_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnSiparisDetayEkle_Click(object sender, EventArgs e)
        {
            SiparisDetayIslemleri siparisDetayIslemleri = new SiparisDetayIslemleri();
            siparisDetayIslemleri.Show();
            this.Hide();
        }

        private void btnSiparisiİptalEt_Click(object sender, EventArgs e)
        {
            txtSiparisToplamTutar.Text = "";
            cbxSiparislerMusteriId.SelectedItem = null;
            dtpSiparis.Value=DateTime.Now;
        }
    }
}
