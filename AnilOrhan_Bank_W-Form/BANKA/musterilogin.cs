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
    public partial class musterilogin : Form
    {
        public musterilogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayit kaydol = new kayit();
            kaydol.Show();
            this.Hide();
        }
        SqlConnection mlogin = new SqlConnection("Data Source=LAPTOP-4PFPNURQ\\SQLEXPRESS;Initial Catalog=BANK;Integrated Security=True");
        private void musterilogin_Load(object sender, EventArgs e)
        {
            string[] degerler = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random rastgele = new Random(); 
            string dogrulama = ""; 
            for (int i = 0; i < 5; i++) 
            {   
                dogrulama += degerler[rastgele.Next(33)];
            }
            label5.Text = dogrulama;

           
        }
        private void button1_Click(object sender, EventArgs e)
        {
                mlogin.Open(); 
                SqlCommand login = new SqlCommand("Select TC,SIFRE from TBL_MUSTERI where TC=@s1 and SIFRE=@s2", mlogin);
                login.Parameters.AddWithValue("@s1", maskedTextBox1.Text);
                login.Parameters.AddWithValue("@s2", textBox1.Text);
                SqlDataReader kontrol = login.ExecuteReader(); 
                if (kontrol.Read() && label5.Text == textBox2.Text) 
                {   
                    islemler islem = new islemler();
                    islem.mesaj = maskedTextBox1.Text;
                    islem.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş yaptınız");
                }
                mlogin.Close();

        }

    }
}

