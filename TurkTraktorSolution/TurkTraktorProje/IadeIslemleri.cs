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
    public partial class IadeIslemleri : Form
    {
        public IadeIslemleri()
        {
            InitializeComponent();
        }
        IadeHareketleriDal iadeHareketleri =new IadeHareketleriDal();


        private void IadeIslemleri_Load(object sender, EventArgs e)
        {
            dgwiadehareketleri.DataSource = iadeHareketleri.GetAll();
            using (var context = new TurkTraktorContext())
            {
                var customers = context.Musterilers.ToList();
                var products = context.Urunlers.ToList();
                var sales = context.Satislars.ToList();

                cbxIadeMusteriId.DataSource = customers;
                cbxIadeMusteriId.DisplayMember = "MusteriAdi";
                cbxIadeMusteriId.ValueMember = "MusteriID";

                cbxIadeUrunId.DataSource = products;
                cbxIadeUrunId.DisplayMember = "UrunAdi";
                cbxIadeUrunId.ValueMember = "UrunID";

                cbxIadeSatisId.DataSource = sales;
                cbxIadeSatisId.DisplayMember = "SatisID";
                cbxIadeSatisId.ValueMember = "SatisID";
            }
        }

        private void btnIadeOlustur_Click(object sender, EventArgs e)
        {
            iadeHareketleri.Add(new IadeHareketleri
            {
                IadeTarihi = Convert.ToDateTime(dtpIadeTarihi.Value),
                MusteriID = Convert.ToInt32(cbxIadeMusteriId.SelectedValue),
                SatisID = Convert.ToInt32(cbxIadeSatisId.SelectedValue),
                UrunID = Convert.ToInt32(cbxIadeUrunId.SelectedValue),
            });
            dgwiadehareketleri.DataSource = iadeHareketleri.GetAll();
            MessageBox.Show("İade Oluşturuldu");
        }

        private void btnStokHareketleriniGor_Click(object sender, EventArgs e)
        {
            StokIslemleri stokIslemleri = new StokIslemleri();
            stokIslemleri.Show();
            this.Hide();
        }

        private void btnIadeIptalEt_Click(object sender, EventArgs e)
        {
            cbxIadeMusteriId.SelectedItem = null;
            cbxIadeSatisId.SelectedItem = null;
            cbxIadeUrunId.SelectedItem = null;
            dtpIadeTarihi.Value=DateTime.Now;
        }

        private void btnGeriIadeHareketleri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
