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
    public partial class UrunIslemleri : Form
    {
        public UrunIslemleri()
        {
            InitializeComponent();
        }

        UrunlerDal urunlerDal = new UrunlerDal();
        private void btnUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text= dgwUrunler.CurrentRow.Cells["UrunAdi"].Value.ToString();
            txtUrunSatisFiyati.Text= dgwUrunler.CurrentRow.Cells["SatisFiyati"].Value.ToString();
            txtUrunStokMiktari.Text = dgwUrunler.CurrentRow.Cells["StokMiktari"].Value.ToString();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            urunlerDal.Update(new Urunler
            {
                UrunID = Convert.ToInt32(dgwUrunler.CurrentRow.Cells[0].Value),
                UrunAdi = txtUrunAdi.Text,
                KategoriID = Convert.ToInt32(cbxUrunlerKategoriId.SelectedValue),
                TedarikciID = Convert.ToInt32(cbxUrunlerTedarikciId.SelectedValue),
                StokMiktari = Convert.ToInt32(txtUrunStokMiktari.Text),
                SatisFiyati = Convert.ToInt32(txtUrunSatisFiyati.Text),
            });

            dgwUrunler.DataSource = urunlerDal.GetAll();
            MessageBox.Show(" Ürün Güncellendi");
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            urunlerDal.Add(new Urunler
            {
                UrunAdi = txtUrunAdi.Text,
                KategoriID = Convert.ToInt32(cbxUrunlerKategoriId.SelectedValue),
                TedarikciID=Convert.ToInt32(cbxUrunlerTedarikciId.SelectedValue),
                StokMiktari = Convert.ToInt32(txtUrunStokMiktari.Text),
                SatisFiyati = Convert.ToInt32(txtUrunSatisFiyati.Text),
            }) ;
            
            dgwUrunler.DataSource = urunlerDal.GetAll();
            MessageBox.Show(" Ürün Eklendi");
        }
  

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            urunlerDal.Delete(new Urunler
            {
                UrunID = Convert.ToInt32(dgwUrunler.CurrentRow.Cells[0].Value),
            });
            dgwUrunler.DataSource = urunlerDal.GetAll();
            MessageBox.Show(" Ürün Silindi");
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            dgwUrunler.DataSource= urunlerDal.GetAll();

            using (var context = new TurkTraktorContext())
            {
                var categories = context.Kategorilers.ToList();
                var suppliers = context.Tedarikcilers.ToList();


                cbxUrunlerKategoriId.DataSource = categories;
                cbxUrunlerKategoriId.DisplayMember = "KategoriAdi";
                cbxUrunlerKategoriId.ValueMember = "KategoriID";

                cbxUrunlerTedarikciId.DataSource = suppliers;
                cbxUrunlerTedarikciId.DisplayMember = "TedarikciAdi";
                cbxUrunlerTedarikciId.ValueMember = "TedarikciID";

            }
        }

        private void btnGeriUrunler_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }


    }

}