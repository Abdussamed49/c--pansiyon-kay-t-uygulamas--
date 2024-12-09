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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MUŞ_PANSİYON_OTOMASYONU
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = MusPansiyon; Integrated Security = True");


        private void btnoda101_Click(object sender, EventArgs e)
        {
            btnoda101.Text = "";
            baglanti.Open();
         

            SqlCommand komut = new SqlCommand("insert into oda101  (adi, soyadi, cinsiyet, telefon, mail, tc, odano, ucret, giristarihi, cıkıstarihi) values (@adi, @soyadi, @cinsiyet, @telefon, @mail, @tc, @odano, @ucret, @giristarihi, @cıkıstarihi)", baglanti);
            komut.Parameters.AddWithValue("@adi", TxtAdi.Text);
            komut.Parameters.AddWithValue("@soyadi", TxtSoyadi.Text);   
            komut.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            komut.Parameters.AddWithValue("@telefon", comboBox1.Text);
            
         

            baglanti.Close();
            MessageBox.Show("Müşteri kaydı Güncellendi .");
        }
   
        }
}
    

