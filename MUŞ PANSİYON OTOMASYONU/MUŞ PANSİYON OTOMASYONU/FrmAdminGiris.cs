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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = MusPansiyon; Integrated Security = True");
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "selecet * from AdminGiris where kullanici=@kullaniciadi AND sifre=sifresi";
                SqlParameter prm1 = new SqlParameter("kullaniciadi", TxtKullanıcıAdi.Text);
                SqlParameter prm2 = new SqlParameter("sifresi", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dataTable);

                if (dataTable.Rows.Count>0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("hatalı giris");
            }

        }
    }
}
