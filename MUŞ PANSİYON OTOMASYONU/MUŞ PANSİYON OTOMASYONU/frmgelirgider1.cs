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
    public partial class frmgelirgider1 : Form
    {
        public frmgelirgider1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = MusPansiyon; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
           baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(ucret)as toplam from MusteriEkle", baglanti); 
            SqlDataReader oku =komut.ExecuteReader();
            while (oku.Read())
            {
                lbltoplam.Text = oku["toplam"].ToString();  

            }
            baglanti.Close();

            int personel;
            personel = Convert.ToUInt16(txtpersonelsayısı);
            lblmaas.Text=(personel * 17002).ToString();

                }
    }
}
