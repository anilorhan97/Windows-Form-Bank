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
    public partial class istatistik : Form
    {
        public istatistik()
        {
            InitializeComponent();
        }
        SqlConnection hmm = new SqlConnection("Data Source=LAPTOP-4PFPNURQ\\SQLEXPRESS;Initial Catalog=BANK;Integrated Security=True");
        BANKEntities ista = new BANKEntities();
        private void istatistik_Load(object sender, EventArgs e)
        {
            label2.Text = ista.TBL_MUSTERI.Count().ToString();
            label3.Text = ista.TBL_BAKIYE.Sum(y => y.BAKIYE).ToString();
            label5.Text = ista.TBL_BAKIYE.Average(x => x.BAKIYE).ToString();

         /*   hmm.Open();
            SqlCommand sehirler = new SqlCommand("SELECT SEHIR FROM TBL_MUSTERI ", hmm);
            SqlDataReader dr = sehirler.ExecuteReader(); 
            while (dr.Read()) 
            {
                chart1.Series["ŞEHİRLER"].Points.AddXY(dr[0], dr[1]);

            }
            hmm.Close();*/

        }
    }
}
