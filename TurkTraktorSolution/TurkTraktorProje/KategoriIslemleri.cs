using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurkTraktorProje.DataAccess;
using TurkTraktorProje.Entities;

namespace TurkTraktorProje
{
    public partial class KategoriIslemleri : Form
    {
        public KategoriIslemleri()
        {
            InitializeComponent();
        }

        KategorilerDal kategorilerDal = new KategorilerDal();
        private void dgwKategoriIslemleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriAdiEkle.Text = dgwKategoriIslemleri.CurrentRow.Cells["KategoriAdi"].Value.ToString();
        }

        private void KategoriIslemleri_Load(object sender, EventArgs e)
        {
            dgwKategoriIslemleri.DataSource = kategorilerDal.GetAll();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            kategorilerDal.Add(new Kategoriler
            {
                KategoriAdi = txtKategoriAdiEkle.Text,
            });
            dgwKategoriIslemleri.DataSource = kategorilerDal.GetAll();
            MessageBox.Show("Kategori Eklendi");
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            kategorilerDal.Update(new Kategoriler
            {
                KategoriID = Convert.ToInt32(dgwKategoriIslemleri.CurrentRow.Cells[0].Value),
                KategoriAdi = txtKategoriAdiEkle.Text,
            });
            dgwKategoriIslemleri.DataSource = kategorilerDal.GetAll();
            MessageBox.Show("Kategori Güncellendi");
        }


        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            kategorilerDal.Delete(new Kategoriler
            {
                KategoriID = Convert.ToInt32(dgwKategoriIslemleri.CurrentRow.Cells[0].Value),
               
            });
            dgwKategoriIslemleri.DataSource = kategorilerDal.GetAll();
            MessageBox.Show("Kategori Silindi");
        }

        private void btnGeriKategoriler_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
