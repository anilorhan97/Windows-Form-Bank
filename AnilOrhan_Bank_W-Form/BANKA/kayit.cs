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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        SqlConnection kaydol = new SqlConnection("Data Source=LAPTOP-4PFPNURQ\\SQLEXPRESS;Initial Catalog=BANK;Integrated Security=True");
        BANKEntities sehirler = new BANKEntities();
        private void kayit_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in sehirler.SEHIR  
                               select new
                               {
                                   x.plaka,
                                   x.sehirad,
                               }).ToList();
            comboBox1.ValueMember = "plaka";  
            comboBox1.DisplayMember = "sehirad";
            comboBox1.DataSource = kategoriler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBL_BAKIYE t = new TBL_BAKIYE();
            TBL_MUSTERI ekle = new TBL_MUSTERI();
            ekle.AD = textBox1.Text;
            ekle.SOYAD = textBox2.Text;
            t.MUSTERIID = Convert.ToInt64(maskedTextBox1.Text).ToString();
            ekle.TC = Convert.ToInt64(maskedTextBox1.Text).ToString();
            ekle.TELEFON = Convert.ToInt64(maskedTextBox2.Text).ToString();
            ekle.SEHIR = comboBox1.SelectedValue.ToString();
            ekle.SIFRE = textBox3.Text;
            sehirler.TBL_MUSTERI.Add(ekle);
            sehirler.TBL_BAKIYE.Add(t);
            sehirler.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı bir şekilde gerçekleştirildi..");
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musterilogin go = new musterilogin();
            go.Show();
            this.Hide();
        }
    }
}
