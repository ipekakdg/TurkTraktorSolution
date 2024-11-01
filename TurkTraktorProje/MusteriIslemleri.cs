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
    public partial class MusteriIslemleri : Form
    {
        public MusteriIslemleri()
        {
            InitializeComponent();
        }

        MusterilerDal musterilerDal = new MusterilerDal();
        private void dgwMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMusteriAdi.Text = dgwMusteriler.CurrentRow.Cells["MusteriAdi"].Value.ToString();
            txtMusteriAdres.Text = dgwMusteriler.CurrentRow.Cells["Adres"].Value.ToString();
            txtMusteriSehir.Text = dgwMusteriler.CurrentRow.Cells["Sehir"].Value.ToString();
            txtMusteriUlke.Text = dgwMusteriler.CurrentRow.Cells["Ulke"].Value.ToString();
            txtMusteriTelefon.Text = dgwMusteriler.CurrentRow.Cells["Telefon"].Value.ToString();
        }

        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
            dgwMusteriler.DataSource= musterilerDal.GetAll();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            musterilerDal.Update(new Musteriler
            {
                MusteriID = Convert.ToInt32(dgwMusteriler.CurrentRow.Cells[0].Value),
                MusteriAdi = txtMusteriAdi.Text,
                Adres = txtMusteriAdres.Text,
                Sehir = txtMusteriSehir.Text,
                Ulke = txtMusteriUlke.Text,
                Telefon = Convert.ToInt32(txtMusteriTelefon.Text),
            });
            dgwMusteriler.DataSource = musterilerDal.GetAll();
            MessageBox.Show("Müşteri Güncellendi");
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            musterilerDal.Add(new Musteriler
            {
                MusteriAdi = txtMusteriAdi.Text,
                Adres = txtMusteriAdres.Text,
                Sehir = txtMusteriSehir.Text,
                Ulke = txtMusteriUlke.Text,
                Telefon = Convert.ToInt32(txtMusteriTelefon.Text),
            });
            dgwMusteriler.DataSource = musterilerDal.GetAll();
            MessageBox.Show("Müşteri Eklendi");
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            musterilerDal.Delete(new Musteriler
            {
                MusteriID = Convert.ToInt32(dgwMusteriler.CurrentRow.Cells[0].Value),
              
            });
            dgwMusteriler.DataSource = musterilerDal.GetAll();
            MessageBox.Show("Müşteri Silindi");
        }

        private void btnGeriMusteriler_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
