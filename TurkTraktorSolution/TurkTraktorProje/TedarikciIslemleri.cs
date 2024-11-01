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
    public partial class TedarikciIslemleri : Form
    {
        public TedarikciIslemleri()
        {
            InitializeComponent();
        }
        TedarikcilerDal tedarikcilerDal=new TedarikcilerDal();
        private void dgwTedarikciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTedarikciAdi.Text = dgwTedarikciler.CurrentRow.Cells["TedarikciAdi"].Value.ToString();
            txtTedarikciTelefon.Text = dgwTedarikciler.CurrentRow.Cells["Telefon"].Value.ToString();
            txtTedarikciAdres.Text = dgwTedarikciler.CurrentRow.Cells["Adres"].Value.ToString();
            txtTedarikciSehir.Text = dgwTedarikciler.CurrentRow.Cells["Sehir"].Value.ToString();
            txtTedarikciUlke.Text = dgwTedarikciler.CurrentRow.Cells["Ulke"].Value.ToString();
        }

        private void btnTedarikciGuncelle_Click(object sender, EventArgs e)
        {
            tedarikcilerDal.Update(new Tedarikciler
            {
                TedarikciID = Convert.ToInt32(dgwTedarikciler.CurrentRow.Cells[0].Value),
                TedarikciAdi = txtTedarikciAdi.Text,
                Telefon = Convert.ToInt32(txtTedarikciTelefon.Text),
                Adres = txtTedarikciAdres.Text,
                Sehir = txtTedarikciSehir.Text,
                Ulke = txtTedarikciUlke.Text,
            });
            dgwTedarikciler.DataSource = tedarikcilerDal.GetAll();
            MessageBox.Show("Tedarikçi Güncellendi");
        }

        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {
            tedarikcilerDal.Add(new Tedarikciler
            {
                TedarikciAdi = txtTedarikciAdi.Text,
                Telefon = Convert.ToInt32(txtTedarikciTelefon.Text),
                Adres = txtTedarikciAdres.Text,
                Sehir = txtTedarikciSehir.Text,
                Ulke = txtTedarikciUlke.Text,
            });
            dgwTedarikciler.DataSource = tedarikcilerDal.GetAll();
            MessageBox.Show("Tedarikçi Eklendi");
        }

        private void btnTedarikciSil_Click(object sender, EventArgs e)
        {
            tedarikcilerDal.Delete(new Tedarikciler
            {
                TedarikciID = Convert.ToInt32(dgwTedarikciler.CurrentRow.Cells[0].Value),
               
            });
            dgwTedarikciler.DataSource = tedarikcilerDal.GetAll();
            MessageBox.Show("Tedarikçi Silindi");
        }

        private void TedarikciIslemleri_Load(object sender, EventArgs e)
        {
            dgwTedarikciler.DataSource = tedarikcilerDal.GetAll();
        }

        private void btnGeriTedarikciler_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
