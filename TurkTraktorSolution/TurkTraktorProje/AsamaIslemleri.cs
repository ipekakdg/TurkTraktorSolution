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
    public partial class AsamaIslemleri : Form
    {
        public AsamaIslemleri()
        {
            InitializeComponent();
        }

        AsamalarDal asamalarDal=new AsamalarDal();
        MontajlarDal montajlarDal=new MontajlarDal();
        SevkiyatlarDal sevkiyatlarDal=new SevkiyatlarDal();
        BoyamalarDal boyamalarDal = new BoyamalarDal();
        ImalatlarDal imalatlarDal = new ImalatlarDal();
        MalzemeTeminiDal malzemeTeminiDal=new MalzemeTeminiDal();
        TasarimDal tasarimDal= new TasarimDal();
        TestlerDal testlerDal=new TestlerDal();
        UrunlerDal urunlerDal=new UrunlerDal();

        private void AsamaIslemleri_Load(object sender, EventArgs e)
        {
            dgwBoyamaListele.DataSource=boyamalarDal.GetAll();
            dgwImalatListele.DataSource=imalatlarDal.GetAll();
            dgwMalzemeTeminiListele.DataSource=malzemeTeminiDal.GetAll();
            dgwMontajListele.DataSource=montajlarDal.GetAll();
            dgwSevkiyatListele.DataSource = sevkiyatlarDal.GetAll();
            dgwTasarimListele.DataSource=tasarimDal.GetAll();
            dgwTestListele.DataSource=testlerDal.GetAll();


            using (var context = new TurkTraktorContext())
            {
                var products = context.Urunlers.ToList();
                var stages = context.Asamalars.ToList();
                var production=context.Imalatlars.ToList();
                var paint=context.Boyamalars.ToList();
                var test=context.Testlers.ToList();
                var material = context.MalzemeTeminis.ToList();

                cbxAsamaUrunId.DataSource = products;
                cbxAsamaUrunId.DisplayMember = "UrunAdi";
                cbxAsamaUrunId.ValueMember = "UrunID";

                cbxUretimAsamalari.DataSource = stages;
                cbxUretimAsamalari.DisplayMember = "AsamaAdi";
                cbxUretimAsamalari.ValueMember = "AsamaID";

                cbxImalatParca.DataSource = production;
                cbxImalatParca.DisplayMember = "Parcalar";
                cbxImalatParcaTuru.DataSource = production;
                cbxImalatParcaTuru.DisplayMember = "ParcaUretimi";

                cbxBoyamaTuru.DataSource = paint;
                cbxBoyamaTuru.DisplayMember = "BoyamaTuru";

                cbxTestCesidi.DataSource = test;
                cbxTestCesidi.DisplayMember = "TestCesidi";

                cbxMalzemeCesidi.DataSource = material;
                cbxMalzemeCesidi.DisplayMember = "MalzemeCesidi";
            }


        }

        private void btnTasarimEkle_Click(object sender, EventArgs e)
        {
            tasarimDal.Add(new Tasarim
            {
                Ozellikler=txtOzellik.Text,
                Boyut=Convert.ToInt32(txtBoyut.Text),
                Guc=Convert.ToInt32(txtGuc.Text),
                TeknikDetay=txtTeknikDetay.Text,
                UrunID=Convert.ToInt32(cbxAsamaUrunId.SelectedValue)
            });
            dgwTasarimListele.DataSource = tasarimDal.GetAll();
            MessageBox.Show("Tasarım Eklendi");
        }

        private void BtnImalatEkle_Click(object sender, EventArgs e)
        {

            imalatlarDal.Add(new Imalatlar
            {
                Parcalar = txtImalatParca.Text,
                ParcaUretimi=txtImalatParcaTuru.Text,
                UrunID = Convert.ToInt32(cbxAsamaUrunId.SelectedValue)
            });
            dgwImalatListele.DataSource = imalatlarDal.GetAll();
            MessageBox.Show("İmalat Eklendi");
        }

        private void btnSevkiyatEkle_Click(object sender, EventArgs e)
        {
            sevkiyatlarDal.Add(new Sevkiyatlar
            {
                AmbalajDurumu = txtAmbalaj.Text,
                SevkiyatYeri = txtSevkiyatDrumu.Text,
                UrunID = Convert.ToInt32(cbxAsamaUrunId.SelectedValue)
            });
            dgwSevkiyatListele.DataSource = sevkiyatlarDal.GetAll();
            MessageBox.Show("Sevkiyat Eklendi");
        }

        private void btnTestEkle_Click(object sender, EventArgs e)
        {
            testlerDal.Add(new Testler
            {
                TestCesidi = txtTestCesidi.Text,
                UrunID = Convert.ToInt32(cbxAsamaUrunId.SelectedValue)
            });
            dgwTestListele.DataSource = testlerDal.GetAll();
            MessageBox.Show("Test Eklendi");
        }

        private void btnBoyamaEkle_Click(object sender, EventArgs e)
        {
            boyamalarDal.Add(new Boyamalar
            {
                BoyamaTuru = txtBoyamaTuru.Text,
                UrunID = Convert.ToInt32(cbxAsamaUrunId.SelectedValue)
            });
            dgwBoyamaListele.DataSource = boyamalarDal.GetAll();
            MessageBox.Show("Boyama Eklendi");
        }

        private void btnMontajEkle_Click(object sender, EventArgs e)
        {
            montajlarDal.Add(new Montajlar {
                MontajYeri=txtMontajYeri.Text,
                UrunID = Convert.ToInt32(cbxAsamaUrunId.SelectedValue)
            });
            dgwMontajListele.DataSource = montajlarDal.GetAll();
            MessageBox.Show("Montaj Eklendi");
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            malzemeTeminiDal.Add(new MalzemeTemini
            {
                MalzemeCesidi = txtMalzemeCesidi.Text,
                UrunID = Convert.ToInt32(cbxAsamaUrunId.SelectedValue)
            });
            dgwMalzemeTeminiListele.DataSource = malzemeTeminiDal.GetAll();
            MessageBox.Show("Malzeme Temini Eklendi");
        }

        private void btnGeriDepolar_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
