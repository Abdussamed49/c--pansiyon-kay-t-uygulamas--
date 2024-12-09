using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUŞ_PANSİYON_OTOMASYONU
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr=new FrmAdminGiris();
            fr.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr=new FrmYeniMusteri();
            fr.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
             FrmMusteriler fr=new FrmMusteriler();
            fr.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MUŞ PANSİYON KAYIT UYGULAMASI /2024 -MUŞ");
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {

          timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmradyodinle fr=new frmradyodinle();
            fr.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
