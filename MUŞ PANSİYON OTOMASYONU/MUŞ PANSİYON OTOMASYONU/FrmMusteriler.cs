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
using System.Xml.Linq;

namespace MUŞ_PANSİYON_OTOMASYONU
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = MusPansiyon; Integrated Security = True");

        private void verilergoster()
        {
            listView1.Items.Clear();    
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle =new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["adi"].ToString());
                ekle.SubItems.Add(oku["soyadi"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["odano"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());
                ekle.SubItems.Add(oku["giristarihi"].ToString());
                ekle.SubItems.Add(oku["cıkıstarihi"].ToString());
          listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }


        private void BtnVerileriGoster_Click(object sender, EventArgs e)
        {
            verilergoster();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
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
            MessageBox.Show("Müşteri kaydı Güncellendi .");
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyAdi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            maskedTextBox2.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNumarası.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtGiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtCıkıs.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNumarası.Text=="101")
            {
                
            }
            baglanti.Open();
            SqlCommand sql10 = new SqlCommand("delete from oda101 where adi =("+TxtAdi.Text+")",baglanti);


            if (TxtOdaNumarası.Text == "102")
            {

            }
            baglanti.Open();
            SqlCommand sql = new SqlCommand("delete from oda102 where adi =(" + TxtAdi.Text + ")", baglanti);


            if (TxtOdaNumarası.Text == "103")
            {

            }
            baglanti.Open();
            SqlCommand sql2 = new SqlCommand("delete from oda103 where adi =(" + TxtAdi.Text + ")", baglanti);


            if (TxtOdaNumarası.Text == "104")
            {

            }
            baglanti.Open();
            SqlCommand sql1 = new SqlCommand("delete from oda104 where adi =(" + TxtAdi.Text + ")", baglanti);


            if (TxtOdaNumarası.Text == "105")
            {

            }
            baglanti.Open();
            SqlCommand sql4 = new SqlCommand("delete from oda105 where adi =(" + TxtAdi.Text + ")", baglanti);

            if (TxtOdaNumarası.Text == "106")
            {

            }
            baglanti.Open();
            SqlCommand sql5 = new SqlCommand("delete from oda101 where adi =(" + TxtAdi.Text + ")", baglanti);


            if (TxtOdaNumarası.Text == "106")
            {

            }
            baglanti.Open();
            SqlCommand sql6 = new SqlCommand("delete from oda107 where adi =(" + TxtAdi.Text + ")", baglanti);


            if (TxtOdaNumarası.Text == "107")
            {

            }
            baglanti.Open();
            SqlCommand sql7 = new SqlCommand("delete from oda101 where adi =(" + TxtAdi.Text + ")", baglanti);


            if (TxtOdaNumarası.Text == "108")
            {

            }
            baglanti.Open();
            SqlCommand sql8 = new SqlCommand("delete from oda108 where adi =(" + TxtAdi.Text + ")", baglanti);

            if (TxtOdaNumarası.Text == "109")
            {

            }
            baglanti.Open();
            SqlCommand sql9 = new SqlCommand("delete from oda109 where adi =(" + TxtAdi.Text + ")", baglanti);






        }




        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyAdi.Clear();
            comboBox1.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Text = "";
            maskedTextBox2.Clear();
            TxtOdaNumarası.Clear();
            txtucret.Clear();
            DtGiris.Text = "";
            DtCıkıs.Text = "";

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%"+textBox1.Text+ "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["adi"].ToString());
                ekle.SubItems.Add(oku["soyadi"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["odano"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());
                ekle.SubItems.Add(oku["giristarihi"].ToString());
                ekle.SubItems.Add(oku["cıkıstarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
//Data Source =.\SQLEXPRESS; Initial Catalog = MusPansiyon; Integrated Security = True