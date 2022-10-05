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

namespace BANKA
{
    public partial class islemler : Form
    {
        public islemler()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-4PFPNURQ\\SQLEXPRESS;Initial Catalog=BANK;Integrated Security=True");
        BANKEntities of = new BANKEntities();
        public string mesaj;

        void listele()
        {
            SqlCommand goster = new SqlCommand("Select BAKIYE FROM TBL_BAKIYE WHERE MUSTERIID=@P1", baglanti);

            goster.Parameters.AddWithValue("@P1", label1.Text);
            SqlDataAdapter da = new SqlDataAdapter(goster);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void islemler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANKDataSet.TBL_BAKIYE' table. You can move, or remove it, as needed.
            label1.Text = mesaj;
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void btn_bakiye_Click(object sender, EventArgs e)
        {
            this.tBL_BAKIYETableAdapter.Fill(this.bANKDataSet.TBL_BAKIYE);
            baglanti.Open();
            SqlCommand goster = new SqlCommand("Select BAKIYE FROM TBL_BAKIYE WHERE MUSTERIID=@P1", baglanti);

            goster.Parameters.AddWithValue("@P1", label1.Text);
            SqlDataAdapter da = new SqlDataAdapter(goster);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            listele();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_parayatirma_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            btn_yatir.Visible = true;
        }

        private void btn_yatir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand yatir = new SqlCommand("update TBL_BAKIYE SET BAKIYE+=@E1 WHERE MUSTERIID=@P1", baglanti);
            yatir.Parameters.AddWithValue("@P1", label1.Text);
            yatir.Parameters.AddWithValue("@E1", Convert.ToInt32(textBox1.Text));
            yatir.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Para yatırma işleminiz başarılı bir şekilde gerçekleşmiştir..");
            listele();
            textBox1.Visible = false;
            btn_yatir.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) //PARA ÇEKME BUTONU
        {
            baglanti.Open();
            SqlCommand cek = new SqlCommand("update TBL_BAKIYE SET BAKIYE-=@E1 WHERE MUSTERIID=@P1", baglanti);
            cek.Parameters.AddWithValue("@P1", label1.Text);
            cek.Parameters.AddWithValue("@E1", Convert.ToInt32(textBox2.Text));
            cek.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Para çekme işleminiz başarılı bir şekilde gerçekleşmiştir..");
            listele();
            textBox2.Visible = false;
            button1.Visible = false;
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand gonder = new SqlCommand("update TBL_BAKIYE SET BAKIYE += @G1 WHERE MUSTERIID=@P1",baglanti);
            gonder.Parameters.AddWithValue("@P1",textBox3.Text);
            gonder.Parameters.AddWithValue("@G1", Convert.ToInt32(textBox4.Text));

            SqlCommand cektir = new SqlCommand("update TBL_BAKIYE SET BAKIYE -= @G2 WHERE MUSTERIID=@P2", baglanti);
            cektir.Parameters.AddWithValue("@P2", label1.Text);
            cektir.Parameters.AddWithValue("@G2", Convert.ToInt32(textBox4.Text));
            gonder.ExecuteNonQuery();
            cektir.ExecuteNonQuery();
            MessageBox.Show("Para gönderme işleminiz başarılı bir şekilde gerçekleşti..");
            listele();
            btn_gonder.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
        }

        private void btn_paracekme_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            button1.Visible = true;
        }

        private void btn_paragonderme_Click(object sender, EventArgs e)
        {
            btn_gonder.Visible=true;
            label3.Visible=true;
            label4.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }
    }
}
