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
    public partial class DepoIslemleri : Form
    {
        public DepoIslemleri()
        {
            InitializeComponent();
        }

        DepolarDal depolarDal= new DepolarDal();


        private void btnDepoEkle_Click(object sender, EventArgs e)
        {
            depolarDal.Add(new Depolar
            {
                DepoAdi = txtDepoAdi.Text,
                Adres = txtDepoAdres.Text,
                Sehir = txtDepoSehir.Text,
                Ulke = txtDepoUlke.Text,
            });
            dgwDepolar.DataSource = depolarDal.GetAll();
            MessageBox.Show("Depo Eklendi");
        }

        private void dgwpersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDepoAdi.Text = dgwDepolar.CurrentRow.Cells["DepoAdi"].Value.ToString();
            txtDepoAdres.Text=dgwDepolar.CurrentRow.Cells["Adres"].Value.ToString();
            txtDepoSehir.Text= dgwDepolar.CurrentRow.Cells["Sehir"].Value.ToString();
            txtDepoUlke.Text= dgwDepolar.CurrentRow.Cells["Ulke"].Value.ToString();
        }

        private void DepoIslemleri_Load(object sender, EventArgs e)
        {
            dgwDepolar.DataSource = depolarDal.GetAll();
        }

        private void btnDepoGuncelle_Click(object sender, EventArgs e)
        {
            depolarDal.Update(new Depolar
            {
                DepoID = Convert.ToInt32(dgwDepolar.CurrentRow.Cells[0].Value),
                DepoAdi = txtDepoAdi.Text,
                Adres = txtDepoAdres.Text,
                Sehir = txtDepoSehir.Text,
                Ulke = txtDepoUlke.Text,
            });
            dgwDepolar.DataSource = depolarDal.GetAll();
            MessageBox.Show("Depo Güncellendi");
        }

        private void btnDepoSil_Click(object sender, EventArgs e)
        {
            depolarDal.Delete(new Depolar
            {
                DepoID = Convert.ToInt32(dgwDepolar.CurrentRow.Cells[0].Value)
            });
            dgwDepolar.DataSource = depolarDal.GetAll();
            MessageBox.Show("Depo Silindi");
        }

        private void btnGeriDepolar_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
