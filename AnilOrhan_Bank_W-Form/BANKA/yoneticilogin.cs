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
    public partial class yoneticilogin : Form
    {
        public yoneticilogin()
        {
            InitializeComponent();
        }
        SqlConnection ylogin = new SqlConnection("Data Source=LAPTOP-4PFPNURQ\\SQLEXPRESS;Initial Catalog=BANK;Integrated Security=True");
        private void yoneticilogin_Load(object sender, EventArgs e)
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
            ylogin.Open();
            SqlCommand login = new SqlCommand("Select * from TBL_LOGIN where KADI=@s1 and KSIFRE=@s2", ylogin);
            login.Parameters.AddWithValue("@s1", textBox3.Text);
            login.Parameters.AddWithValue("@s2", textBox1.Text);
            SqlDataReader kontrol = login.ExecuteReader();
            if (kontrol.Read() && label5.Text == textBox2.Text)
            {
                Plogin islem = new Plogin();
                islem.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız");
            }
            ylogin.Close();
        }
    }
}
