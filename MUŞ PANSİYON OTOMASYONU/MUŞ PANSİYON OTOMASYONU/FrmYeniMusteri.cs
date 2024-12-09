using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;



namespace MUŞ_PANSİYON_OTOMASYONU
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=MusPansiyon;Integrated Security=True");
        private void btnoda101_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "101";
        }

        private void btnoda102_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "102";
        }

        private void btnoda103_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "103";
        }

        private void btnoda104_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "104";
        }

        private void btnoda105_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "105";
        }

        private void btnoda106_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "106";
        }

        private void btnoda107_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "107";
        }

        private void btnoda108_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "108";
        }

        private void btnoda109_Click(object sender, EventArgs e)
        {
            TxtOdaNumarası.Text = "109";
        }

        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KIRMIZI RENKLİ BUTONLAR DOLU ODALARI GÖSTERİR");
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YEŞİL RENKLİ BUTONLAR BOŞ ODALARI GÖSTERİR");
        }

        private void DtCıkıs_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih = Convert.ToDateTime(DtGiris.Text);
            DateTime buyukTarih = Convert.ToDateTime(DtCıkıs.Text);


            TimeSpan sonuc = buyukTarih - kucukTarih;
            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 50;
            txtucret.Text=ucret.ToString(); 

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into MusteriEkle (adi, soyadi, cinsiyet, telefon, mail, tc, odano, ucret, giristarihi, cıkıstarihi) values (@adi, @soyadi, @cinsiyet, @telefon, @mail, @tc, @odano, @ucret, @giristarihi, @cıkıstarihi)", baglanti);
                komut.Parameters.AddWithValue("@adi", TxtAdi.Text);
                komut.Parameters.AddWithValue("@soyadi", TxtSoyAdi.Text);
                komut.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
                komut.Parameters.AddWithValue("@telefon", comboBox1.Text);
                komut.Parameters.AddWithValue("@mail", TxtMail.Text);
                komut.Parameters.AddWithValue("@tc", maskedTextBox2.Text);
                komut.Parameters.AddWithValue("@odano", TxtOdaNumarası.Text);
                komut.Parameters.AddWithValue("@ucret", txtucret.Text);
                komut.Parameters.AddWithValue("@giristarihi", DtGiris.Value.ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("@cıkıstarihi", DtCıkıs.Value.ToString("yyyy-MM-dd"));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri kaydı yapıldı.");
            }

            
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku1 = komut.ExecuteReader();

            while (oku1.Read())
            {
                btnoda101.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();

            }
            baglanti.Close();
            if (btnoda101.Text != "101")
            {
                btnoda101.BackColor = Color.Red;
                btnoda101.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku2 = komut.ExecuteReader();

            while (oku1.Read())
            {
                btnoda102.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();

            }
            baglanti.Close();
            if (btnoda102.Text != "102")
            {
                btnoda102.BackColor = Color.Red;
                btnoda102.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku3 = komut.ExecuteReader();

            while (oku1.Read())
            {
                btnoda101.Text = oku3["adi"].ToString() + " " + oku3["soyadi"].ToString();

            }
            baglanti.Close();
            if (btnoda103.Text != "103")
            {
                btnoda103.BackColor = Color.Red;
                btnoda103.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku4 = komut.ExecuteReader();

            while (oku1.Read())
            {
                btnoda104.Text = oku4["adi"].ToString() + " " + oku4["soyadi"].ToString();

            }
            baglanti.Close();
            if (btnoda104.Text != "104")
            {
                btnoda104.BackColor = Color.Red;
                
                btnoda104.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku5 = komut.ExecuteReader();

            while (oku1.Read())
            {
                btnoda105.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();

            }
            baglanti.Close();
            if (btnoda105.Text != "105")
            {
                btnoda105.BackColor = Color.Red;
                btnoda105.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku6 = komut.ExecuteReader();

            while (oku1.Read())
            {
                btnoda106.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();

            }
            baglanti.Close();
            if (btnoda101.Text != "106")
            {
                btnoda101.BackColor = Color.Red;
                btnoda106.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku7 = komut.ExecuteReader();

            while (oku1.Read())
            {
                btnoda107.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();

            }
            baglanti.Close();
            if (btnoda107.Text != "107")
            {
                btnoda101.BackColor = Color.Red;
                btnoda107.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku8 = komut.ExecuteReader();

            while (oku1.Read())
            {
                btnoda108.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();

            }
            baglanti.Close();
            if (btnoda108.Text != "108")
            {
                btnoda108.BackColor = Color.Red;
                btnoda108.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku9 = komut.ExecuteReader();

            while (oku1.Read())
            {
                btnoda109.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();

            }
            baglanti.Close();
            if (btnoda109.Text != "109")
            {
                btnoda109.BackColor = Color.Red;
                btnoda109.Enabled = false;

            }
        }
    }
}
//Data Source =.\SQLEXPRESS; Initial Catalog = MusPansiyon; Integrated Security = True