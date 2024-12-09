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
using System.Data.Sql;
using System.Data.SqlClient;

namespace MUŞ_PANSİYON_OTOMASYONU
{
    public partial class frmstoklar : Form
    {
        public frmstoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = MusPansiyon; Integrated Security = True");

        private void veriler()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from stoklar", baglanti);
            SqlDataReader oku =komut.ExecuteReader();
            while (oku.Read())
            {
                
            }
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {



            ListView ekle =new ListView();
            ekle.Columns.Add("gida");
            ekle.Columns.Add("içeçek");
            ekle.Columns.Add("atıştırmalıklar");

        }

        private void veriler2()
        {
            
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from faturalar", baglanti);
            SqlDataReader oku2=komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListView ekle =new ListView();
                ekle.TabIndex = oku2["elektrik"].ToString().Length;
                ekle.TabIndex = oku2["su"].ToString().Length;
                ekle.TabIndex = oku2["internet"].ToString().Length;
            }

            baglanti.Close();
        }

        private void frmstoklar_Load(object sender, EventArgs e)
        {
            veriler();
        }
    }
    
}
