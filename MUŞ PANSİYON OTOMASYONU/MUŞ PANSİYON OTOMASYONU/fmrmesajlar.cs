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
    public partial class fmrmesajlar : Form
    {
        public fmrmesajlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = MusPansiyon; Integrated Security = True");

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void verilerigoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from mesajlar", baglanti);
            SqlDataReader oku =komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku.ToString(); 
                ekle.Text = oku["adsoyad"].ToString();
                ekle.Text = oku["mesajlar"].ToString();
                listView1.Items.Add(ekle); 
            }
            baglanti.Close();   
        }
        private void fmrmesajlar_Load(object sender, EventArgs e)
        {

        }

        private void btnkaydet3_Click(object sender, EventArgs e)
        {
            verilerigoster();        }
    }
}
