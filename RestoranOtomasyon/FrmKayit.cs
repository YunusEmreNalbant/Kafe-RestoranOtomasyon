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
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        Random rastgele = new Random();
        private void FrmKayit_Load(object sender, EventArgs e)
        {
            string karakter1;
            string[] dizi1 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z", "Q", "X", "W" };
            int sembol1 = rastgele.Next(0, dizi1.Length);
            karakter1 = (dizi1[sembol1]);
            //  label5.Text = karakter1.ToString();

            string karakter2;
            string[] dizi2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            int sembol2 = rastgele.Next(0, dizi2.Length);
            karakter2 = (dizi2[sembol2]);


            string karakter3;
            string[] dizi3 = { "!", "#", "+", "-", "*", "/", "&", "<", ">", "=", "?" };
            int sembol3 = rastgele.Next(0, dizi3.Length);
            karakter3 = (dizi3[sembol3]);


            string karakter4;
            string[] dizi4 = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z", "x", "w", "q" };
            int sembol4 = rastgele.Next(0, dizi4.Length);
            karakter4 = (dizi4[sembol4]);
            label7.Text = karakter1 + karakter2 + karakter3 + karakter4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtKayitAd.Text == string.Empty || TxtKayitNick.Text == string.Empty || TxtKayitSifre.Text == string.Empty || TxtKayitSoyAd.Text == string.Empty || TxtKod.Text == string.Empty || TxtKod.Text != label7.Text)
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz ve doğru bir şekilde doldurunuz !");
            }

            else
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Uyeler (Ad,Soyad,KullaniciAdi,Sifre,Telefon) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtKayitAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtKayitSoyAd.Text);
                komut.Parameters.AddWithValue("@p3", TxtKayitNick.Text);
                komut.Parameters.AddWithValue("@p4", TxtKayitSifre.Text);
                komut.Parameters.AddWithValue("@p5", MskKayitTelefon.Text);
                komut.ExecuteNonQuery();

                bgl.baglanti().Close();
                
                MessageBox.Show("Kayıt Başarıyla Gerçekleşti !");
         }
        }
    }
}
    
 