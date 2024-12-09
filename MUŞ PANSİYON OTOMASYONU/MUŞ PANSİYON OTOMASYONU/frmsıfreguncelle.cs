using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MUŞ_PANSİYON_OTOMASYONU
{
    public partial class frmsıfreguncelle : Form
    {
        public frmsıfreguncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = MusPansiyon; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into admingirisset kullanici ='" + txtkullanıcıadı.Text + "',SİFRE='" + txtsıfre.Text + "", baglanti);
            komut.Parameters.AddWithValue("@adi", txtkullanıcıadı.Text);
            komut.Parameters.AddWithValue("@soyadi", txtsıfre.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();
            
        }
    }
}
