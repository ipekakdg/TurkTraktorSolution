using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkTraktorProje
{
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection _conn = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=TurkTraktor; integrated security=true;");
            string adminKullaniciAdi = txtKullaniciAdi.Text;
            string adminSifre = txtSifre.Text;

            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }

            SqlCommand command = new SqlCommand("SELECT * FROM Admin WHERE KullaniciAdi = @kullaniciadi AND Sifre = @sifre", _conn);

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@kullaniciadi", adminKullaniciAdi);
            command.Parameters.AddWithValue("@sifre", adminSifre);

            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanici adi veya sifre yanlis");
            }
            dataReader.Close();
            _conn.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

