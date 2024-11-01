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
    public partial class SaticiIslemleri : Form
    {
        public SaticiIslemleri()
        {
            InitializeComponent();
        }

        SaticilarDal saticilarDal = new SaticilarDal();

        private void SaticiIslemleri_Load(object sender, EventArgs e)
        {
            dgwSaticilar.DataSource= saticilarDal.GetAll();
        }

        private void btnSaticiGuncelle_Click(object sender, EventArgs e)
        {
            saticilarDal.Update(new Saticilar
            {
                SaticiID = Convert.ToInt32(dgwSaticilar.CurrentRow.Cells[0].Value),
                SaticiAdi = txtSaticiAdi.Text,
                Sehir = txtSaticiSehir.Text,
                Adres = txtSaticiAdres.Text,
                Ulke = txtSaticiUlke.Text,
                Telefon = Convert.ToInt32(txtSaticiTelefon.Text),
            });
            dgwSaticilar.DataSource = saticilarDal.GetAll();
            MessageBox.Show("Satici Güncellendi");
        }

        private void btnSaticiEkle_Click(object sender, EventArgs e)
        {
            saticilarDal.Add(new Saticilar
            {
                SaticiAdi = txtSaticiAdi.Text,
                Sehir = txtSaticiSehir.Text,
                Adres = txtSaticiAdres.Text,
                Ulke = txtSaticiUlke.Text,
                Telefon = Convert.ToInt32(txtSaticiTelefon.Text),
            });
            dgwSaticilar.DataSource = saticilarDal.GetAll();
            MessageBox.Show("Satici Eklendi");
        }

        private void dgwSaticilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtSaticiAdi.Text = dgwSaticilar.CurrentRow.Cells["SaticiAdi"].Value.ToString();
            txtSaticiSehir.Text = dgwSaticilar.CurrentRow.Cells["Sehir"].Value.ToString();
            txtSaticiAdres.Text = dgwSaticilar.CurrentRow.Cells["Adres"].Value.ToString();
            txtSaticiUlke.Text = dgwSaticilar.CurrentRow.Cells["Ulke"].Value.ToString();
            txtSaticiTelefon.Text = dgwSaticilar.CurrentRow.Cells["Telefon"].Value.ToString();
        }

        private void btnGeriSaticilar_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
