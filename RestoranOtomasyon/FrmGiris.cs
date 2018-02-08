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
namespace RestoranOtomasyon
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
     
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            FrmAnaSayfa frm1 = new FrmAnaSayfa();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            SqlCommand komut = new SqlCommand("Select * From Tbl_Uyeler Where KullaniciAdi=@p1 and Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtKullaniciSifre.Text);
           

            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {

                FrmAnaSayfa frm1 = new FrmAnaSayfa();
                frm1.kullaniciadim = TxtKullaniciAd.Text;
                frm1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı E-posta veya Şifre !");
            }

           




        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKayit frm2 = new FrmKayit();
            frm2.Show();
            

        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            pictureBox1.Visible = true;

        }
    }
}
