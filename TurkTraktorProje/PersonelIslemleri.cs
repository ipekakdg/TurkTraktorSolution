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
    public partial class PersonelIslemleri : Form
    {
        public PersonelIslemleri()
        {
            InitializeComponent();
        }

        PersonellerDal personellerDal= new PersonellerDal();
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            personellerDal.Add(new Personeller
            {
                PersonelAdi = txtPersonelAdi.Text,
                Telefon = Convert.ToInt32(txtPersonelTelefon.Text),
                Adres = txtPersonelAdres.Text,
                Sehir = txtPersonelSehir.Text,
                Ulke = txtPersonelUlke.Text,
            });
            dgwpersoneller.DataSource = personellerDal.GetAll();
            MessageBox.Show("Personel Eklendi");
        }

        private void dgwpersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelAdi.Text = dgwpersoneller.CurrentRow.Cells["PersonelAdi"].Value.ToString();
            txtPersonelTelefon.Text = dgwpersoneller.CurrentRow.Cells["Telefon"].Value.ToString();
            txtPersonelAdres.Text = dgwpersoneller.CurrentRow.Cells["Adres"].Value.ToString();
            txtPersonelSehir.Text = dgwpersoneller.CurrentRow.Cells["Sehir"].Value.ToString();
            txtPersonelUlke.Text = dgwpersoneller.CurrentRow.Cells["Ulke"].Value.ToString();
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            personellerDal.Update(new Personeller
            {
                PersonelID= Convert.ToInt32(dgwpersoneller.CurrentRow.Cells[0].Value),
                PersonelAdi = txtPersonelAdi.Text,
                Telefon = Convert.ToInt32(txtPersonelTelefon.Text),
                Adres = txtPersonelAdres.Text,
                Sehir = txtPersonelSehir.Text,
                Ulke = txtPersonelUlke.Text,
            });
            dgwpersoneller.DataSource = personellerDal.GetAll();
            MessageBox.Show("Personel Güncellendi");
        }
    

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            personellerDal.Delete(new Personeller
            {
                PersonelID = Convert.ToInt32(dgwpersoneller.CurrentRow.Cells[0].Value)
               
            });
            dgwpersoneller.DataSource = personellerDal.GetAll();
            MessageBox.Show("Personel Silindi");
        }
    

        private void PersonelIslemleri_Load(object sender, EventArgs e)
        {
            dgwpersoneller.DataSource=personellerDal.GetAll();
        }

        private void btnGeriPersoneller_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
