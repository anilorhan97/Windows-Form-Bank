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
using Entity;
using DATAACCESSLAYER;
using LogicLayer;

namespace BANKA
{
    public partial class Plogin : Form
    {
        public Plogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e, List<BANKEntities> liste)
        {
          

        }

        private void Plogin_Load(object sender, EventArgs e)
        {
          
        }
        private void button1_Click(object sender, EventArgs e)
        { //LİSTELEMEYİ LINQ İLE YAPTIK
            dataGridView1.DataSource = (from x in db.TBL_MUSTERI
                                        select new
                                        {
                                            x.ID,
                                            x.AD,
                                            x.SOYAD,
                                            x.TC,
                                            x.TELEFON,
                                            x.SEHIR,
                                        }).ToList();
        }
        private void button2_Click(object sender, EventArgs e)
        { // EKLEME KISMINI n katmanlı 4. kısımdan örnek aldık
            TBL_MUSTERI ekle = new TBL_MUSTERI();
            ekle.AD = textBox2.Text;
            ekle.SOYAD = textBox3.Text;
            ekle.TC = textBox4.Text;
            ekle.TELEFON = textBox5.Text;
            ekle.SEHIR = textBox6.Text;
            db.TBL_MUSTERI.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı bir şekilde gerçekleştirildi..");

        }
        BANKEntities db = new BANKEntities();
        private void button3_Click(object sender, EventArgs e)
        {
            string sil = textBox4.Text;
            var x = db.TBL_MUSTERI.Find(sil);
            db.TBL_MUSTERI.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi gerçekleşti.");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string guncelle = textBox4.Text;
            var bul = db.TBL_MUSTERI.Find(guncelle);
            bul.AD = textBox2.Text;
            bul.SOYAD = textBox3.Text;
            bul.TELEFON = textBox5.Text;
            bul.SEHIR = textBox6.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi yapılmıştır.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            istatistik sg = new istatistik();
            sg.Show();
            this.Hide();
        }
    }
}
