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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TurkTraktorProje
{
    public partial class SatisIslemleri : Form
    {
        public SatisIslemleri()
        {
            InitializeComponent();
        }

        SatislarDal satisIslemleri = new SatislarDal();
        private void dgwSatislar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSiparisToplamTutar.Text = dgwSatislar.CurrentRow.Cells["ToplamTutar"].Value.ToString();
        }

        private void SatisIslemleri_Load(object sender, EventArgs e)
        {
            dgwSatislar.DataSource= satisIslemleri.GetAll();

            using (var context = new TurkTraktorContext())
            {
                var customers = context.Musterilers.ToList();
                var products = context.Urunlers.ToList();
                var sellers = context.Saticilars.ToList();

                cbxSatisMusteriId.DataSource = customers;
                cbxSatisMusteriId.DisplayMember = "MusteriAdi";
                cbxSatisMusteriId.ValueMember = "MusteriID";

                cbxSatisUrunId.DataSource = products;
                cbxSatisUrunId.DisplayMember = "UrunAdi";
                cbxSatisUrunId.ValueMember = "UrunID";

                cbxSatisSaticiId.DataSource = sellers;
                cbxSatisSaticiId.DisplayMember = "SaticiAdi";
                cbxSatisSaticiId.ValueMember = "SaticiID";
            }
        }

        private void btnSiparisGuncelle_Click(object sender, EventArgs e)
        {
            satisIslemleri.Update(new Satislar
            {
                SatisID = Convert.ToInt32(dgwSatislar.CurrentRow.Cells[0].Value),
                MusteriID = Convert.ToInt32(cbxSatisMusteriId.SelectedValue),
                SaticiID = Convert.ToInt32(cbxSatisSaticiId.SelectedValue),
                SatisTarihi = Convert.ToDateTime(dtpSiparisSatisTarihi.Value),
                ToplamTutar = Convert.ToInt32(txtSiparisToplamTutar.Text),
                UrunID = Convert.ToInt32(cbxSatisUrunId.SelectedValue),
            });
            dgwSatislar.DataSource = satisIslemleri.GetAll();
            MessageBox.Show("Satış Güncellendi");
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            satisIslemleri.Add(new Satislar
            {
                MusteriID = Convert.ToInt32(cbxSatisMusteriId.SelectedValue),
                UrunID = Convert.ToInt32(cbxSatisUrunId.SelectedValue),
                SaticiID = Convert.ToInt32(cbxSatisSaticiId.SelectedValue),
                SatisTarihi =Convert.ToDateTime(dtpSiparisSatisTarihi.Value),
                ToplamTutar=Convert.ToInt32(txtSiparisToplamTutar.Text),
                
            });
            dgwSatislar.DataSource = satisIslemleri.GetAll();
            MessageBox.Show("Satış Eklendi");
        }

        private void btnSiparisSil_Click(object sender, EventArgs e)
        {
            satisIslemleri.Delete(new Satislar
            {
                SatisID = Convert.ToInt32(dgwSatislar.CurrentRow.Cells[0].Value),
              
            });
            dgwSatislar.DataSource = satisIslemleri.GetAll();
            MessageBox.Show("Satış Silindi");
        }

        private void btnGeriSatislar_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
