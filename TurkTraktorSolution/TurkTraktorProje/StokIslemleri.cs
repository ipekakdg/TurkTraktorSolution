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
    public partial class StokIslemleri : Form
    {
        public StokIslemleri()
        {
            InitializeComponent();
        }

        StokHareketleriDal stokHareketleri =new StokHareketleriDal();
        private void dgwStokHareketleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxHareketUrunId.Text = dgwStokHareketleri.CurrentRow.Cells["UrunID"].Value.ToString();
            cbxHareketDepoId.Text = dgwStokHareketleri.CurrentRow.Cells["DepoID"].Value.ToString();
            txtStokHareketMiktari.Text = dgwStokHareketleri.CurrentRow.Cells["Miktar"].Value.ToString();
            dtpHareketTarihi.Text = dgwStokHareketleri.CurrentRow.Cells["HareketTarihi"].Value.ToString();
        }

        private void StokIslemleri_Load(object sender, EventArgs e)
        {
            dgwStokHareketleri.DataSource = stokHareketleri.GetAll();


            using (var context = new TurkTraktorContext())
            {
                var storages = context.Depolars.ToList();
                var products = context.Urunlers.ToList();

                cbxHareketDepoId.DataSource = storages;
                cbxHareketDepoId.DisplayMember = "DepoAdi";
                cbxHareketDepoId.ValueMember = "DepoID";

                cbxHareketUrunId.DataSource = products;
                cbxHareketUrunId.DisplayMember = "UrunAdi";
                cbxHareketUrunId.ValueMember = "UrunID";

            }
        }

        private void btnHareketGuncelle_Click(object sender, EventArgs e)
        {
            stokHareketleri.Update(new StokHareketleri
            {
                HareketID = Convert.ToInt32(dgwStokHareketleri.CurrentRow.Cells[0].Value),
                UrunID = Convert.ToInt32(cbxHareketUrunId.SelectedValue),
                DepoID = Convert.ToInt32(cbxHareketDepoId.SelectedValue),
                Miktar = Convert.ToInt32(txtStokHareketMiktari.Text),
                HareketTarihi = Convert.ToDateTime(dtpHareketTarihi.Value),
            });
            dgwStokHareketleri.DataSource = stokHareketleri.GetAll();
            MessageBox.Show("Stok Hareketi Güncellendi");
        }

        private void btnHareketEkle_Click(object sender, EventArgs e)
        {
            stokHareketleri.Add(new StokHareketleri
            {
                UrunID = Convert.ToInt32(cbxHareketUrunId.SelectedValue),
                DepoID = Convert.ToInt32(cbxHareketDepoId.SelectedValue),
                Miktar = Convert.ToInt32(txtStokHareketMiktari.Text),
                HareketTarihi = Convert.ToDateTime(dtpHareketTarihi.Value),
            });
            dgwStokHareketleri.DataSource = stokHareketleri.GetAll();
            MessageBox.Show("Stok Hareketi Eklendi");
        }

        private void btnHareketSil_Click(object sender, EventArgs e)
        {
            stokHareketleri.Delete(new StokHareketleri
            {
                HareketID = Convert.ToInt32(dgwStokHareketleri.CurrentRow.Cells[0].Value),
               
            });
            dgwStokHareketleri.DataSource = stokHareketleri.GetAll();
            MessageBox.Show("Stok Hareketi Silindi");
        }

        private void btnGeriStokHareketleri_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}

