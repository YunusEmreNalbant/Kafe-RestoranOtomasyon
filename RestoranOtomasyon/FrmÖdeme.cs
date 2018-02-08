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
    public partial class FrmÖdeme : Form
    {
        public FrmÖdeme()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string isim;

        public double a;
        public double b;
        public string yazi;
        private void FrmÖdeme_Load(object sender, EventArgs e)
        {
            textBox2.Text = isim;
            textBox112.Text = yazi;


            SqlCommand komutfiyat = new SqlCommand("Select Sum(Fiyat) From Tbl_Siparis", bgl.baglanti());
            SqlDataReader fiyatoku = komutfiyat.ExecuteReader();
            while(fiyatoku.Read())
            {
                label5.Text = fiyatoku[0].ToString();
                a = Convert.ToDouble(label5.Text);

            }

            bgl.baglanti().Close();


            SqlCommand komutoku2 = new SqlCommand("Select * From Tbl_Uyeler Where KullaniciAdi=@isim2", bgl.baglanti());
            komutoku2.Parameters.AddWithValue("@isim2", textBox2.Text);
            SqlDataReader oku2 = komutoku2.ExecuteReader();
            if (oku2.Read())
            {
                label4.Text = ((a*10)/100).ToString();

                 b = Convert.ToDouble(label4.Text);


            }

            //label5.Text= Convert.ToString(a-b);

            label5.Text = String.Format("{0:00}", a-b );

            // TODO: This line of code loads data into the 'kafeOtomasyonDataSet5.Tbl_Siparis' table. You can move, or remove it, as needed.
            this.tbl_SiparisTableAdapter.Fill(this.kafeOtomasyonDataSet5.Tbl_Siparis);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
