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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string kullaniciadim;
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kafeOtomasyonDataSet6.Tbl_Siparis' table. You can move, or remove it, as needed.
            this.tbl_SiparisTableAdapter4.Fill(this.kafeOtomasyonDataSet6.Tbl_Siparis);
            textBox2.Text = kullaniciadim;

            

             //TODO: This line of code loads data into the 'kafeOtomasyonDataSet4.Tbl_Siparis' table. You can move, or remove it, as needed.
            this.tbl_SiparisTableAdapter3.Fill(this.kafeOtomasyonDataSet4.Tbl_Siparis);
            // TODO: This line of code loads data into the 'kafeOtomasyonDataSet3.Tbl_Siparis' table. You can move, or remove it, as needed.
            this.tbl_SiparisTableAdapter2.Fill(this.kafeOtomasyonDataSet3.Tbl_Siparis);
            dataGridView1.Visible = false;
            label14.Visible = false;
            
            textBox1.Visible = false;
            label5.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            dataGridView2.Visible = false;
            // TODO: This line of code loads data into the 'kafeOtomasyonDataSet2.Tbl_Siparis' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'kafeOtomasyonDataSet1.Tbl_Siparis' table. You can move, or remove it, as needed.
            
            
            // TODO: This line of code loads data into the 'kafeOtomasyonDataSet.Tbl_Menu' table. You can move, or remove it, as needed.
            this.tbl_MenuTableAdapter.Fill(this.kafeOtomasyonDataSet.Tbl_Menu);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            DataTable veritablo = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select [Ürün Adı], Fiyat from Tbl_Menu Where durum=1", bgl.baglanti());
            adapter.Fill(veritablo);
            dataGridView1.DataSource = veritablo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            
/*
            SqlCommand komut11 = new SqlCommand("insert into Tbl_Siparis (MasaNo) values (@a)", bgl.baglanti());
            komut11.Parameters.AddWithValue("@a", label16.Text);
            komut11.ExecuteNonQuery();
            bgl.baglanti().Close();

    */



            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Siparis", bgl.baglanti());
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label14.Visible = true;
         
            textBox1.Visible = true;
            label5.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            dataGridView2.Visible = true;

            SqlCommand komut = new SqlCommand("insert into Tbl_Siparis (Ürün, Fiyat) values (@p1,@p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",dataGridView1.CurrentRow.Cells[0].Value.ToString());
            komut.Parameters.AddWithValue("@p2",dataGridView1.CurrentRow.Cells[1].Value.ToString());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            DataTable veritablo2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter("select Ürün, Fiyat from Tbl_Siparis ", bgl.baglanti());
            adapter2.Fill(veritablo2);
            dataGridView2.DataSource = veritablo2;

           

            // dataGridView2.Rows[0].Cells[0].Value = label1.Text;
            //dataGridView2.Rows[0].Cells[1].Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //dataGridView2.Rows[0].Cells[3].Value = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //dataGridView2.Rows[0].Cells[2].Value = textBox1.Text;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into Tbl_Siparis ([Not]) values (@notekle)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@notekle", textBox1.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            DataTable veritablo = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select [Ürün Adı], Fiyat from Tbl_Menu Where durum=2", bgl.baglanti());
            adapter.Fill(veritablo);
            dataGridView1.DataSource = veritablo;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            DataTable veritablo = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select [Ürün Adı], Fiyat from Tbl_Menu Where durum=3", bgl.baglanti());
            adapter.Fill(veritablo);
            dataGridView1.DataSource = veritablo;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            DataTable veritablo = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select [Ürün Adı], Fiyat from Tbl_Menu Where durum=4", bgl.baglanti());
            adapter.Fill(veritablo);
            dataGridView1.DataSource = veritablo;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            DataTable veritablo = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select [Ürün Adı], Fiyat from Tbl_Menu Where durum=5", bgl.baglanti());
            adapter.Fill(veritablo);
            dataGridView1.DataSource = veritablo;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Siparis", bgl.baglanti());
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            dataGridView2.DataSource = null;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FrmÖdeme forumac = new FrmÖdeme();
            forumac.yazi = textBox1.Text;
            forumac.isim = textBox2.Text;
            forumac.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;

            SqlCommand komutsil2 = new SqlCommand("Delete From Tbl_Siparis", bgl.baglanti());
            komutsil2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            SqlCommand komutsil3 = new SqlCommand("Delete From Tbl_Siparis", bgl.baglanti());
            komutsil3.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            SqlCommand komutsil4 = new SqlCommand("Delete From Tbl_Siparis", bgl.baglanti());
            komutsil4.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            SqlCommand komutsil5 = new SqlCommand("Delete From Tbl_Siparis", bgl.baglanti());
            komutsil5.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            SqlCommand komutsil6 = new SqlCommand("Delete From Tbl_Siparis", bgl.baglanti());
            komutsil6.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            SqlCommand komutsil7 = new SqlCommand("Delete From Tbl_Siparis", bgl.baglanti());
            komutsil7.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            SqlCommand komutsil8 = new SqlCommand("Delete From Tbl_Siparis", bgl.baglanti());
            komutsil8.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            SqlCommand komutsil9 = new SqlCommand("Delete From Tbl_Siparis", bgl.baglanti());
            komutsil9.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            SqlCommand komutsil10 = new SqlCommand("Delete From Tbl_Siparis", bgl.baglanti());
            komutsil10.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            SqlCommand komutsil11 = new SqlCommand("Delete From Tbl_Siparis", bgl.baglanti());
            komutsil11.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;

            SqlCommand komutsil12 = new SqlCommand("Delete From Tbl_Siparis", bgl.baglanti());
            komutsil12.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
