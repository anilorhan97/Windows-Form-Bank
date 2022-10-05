using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;

namespace DATAACCESSLAYER
{
    public class DALgorevli
    {
        public static List<TBL_MUSTERI> MusteriListesi()
        {
            List<TBL_MUSTERI> deger = new List<TBL_MUSTERI>();
            SqlCommand komut1 = new SqlCommand("Select * from TBL_MUSTERI", DAL.baglanti);
            if (komut1.Connection.State != System.Data.ConnectionState.Open) //Bağlantıya bağlı değilse süslü parantez içerisine bağlantıyı aç deriz.
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())  //Okuma devam ettiği sürece şu işlemleri yap
            {
                TBL_MUSTERI x = new TBL_MUSTERI();
                x.AD = dr["AD"].ToString();
                x.SOYAD = dr["SOYAD"].ToString();
                x.TC = dr["TC"].ToString();
                x.TELEFON = dr["TELEFON"].ToString();
                x.SEHIR = dr["SEHIR"].ToString();
                deger.Add(x);
            }
            dr.Close();
            return deger;
        }
        public static bool musterıSil(long per)
        {
            throw new NotImplementedException();
        }

        public static bool musteriGuncelle()
        {
            throw new NotImplementedException();
        }

        public static int musteriEkle(BANKEntities n)
        {
            TBL_MUSTERI ekle = new TBL_MUSTERI();
            SqlCommand komut2 = new SqlCommand("Insert into TBL_MUSTERI (AD,SOYAD,TC,TELEFON,SEHIR) values (@s1,@s2,@s3,@s4,@s5)", DAL.baglanti);
            if (komut2.Connection.State != System.Data.ConnectionState.Open) //Bağlantıya bağlı değilse süslü parantez içerisine bağlantıyı aç deriz.
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@s1", ekle.AD);
            komut2.Parameters.AddWithValue("@s2", ekle.SOYAD);
            komut2.Parameters.AddWithValue("@s3", ekle.TC);
            komut2.Parameters.AddWithValue("@s4", ekle.TELEFON);
            komut2.Parameters.AddWithValue("@s5", ekle.SEHIR);
            return komut2.ExecuteNonQuery();

        }
        public static bool musterıSil(string p)
        {
            TBL_MUSTERI sil = new TBL_MUSTERI();
            SqlCommand komut3 = new SqlCommand("Delete from TBL_MUSTERI where TC=@p1", DAL.baglanti);
            if (komut3.Connection.State != System.Data.ConnectionState.Open) //Bağlantıya bağlı değilse süslü parantez içerisine bağlantıyı aç deriz.
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() > 0; //Bool tanımlama sebebimiz bool 0 ve 1'den oluşur. 0 DAN BÜYÜK yani 1 ise bu işlemi yap anlamındadır.
        }
        public static bool musteriGuncelle(EntityLayer x)
        {
            TBL_MUSTERI guncelle = new TBL_MUSTERI();
            SqlCommand komut4 = new SqlCommand("Update TBL_MUSTERI set AD=@g1, SOYAD=@g2, TELEFON=@g3, SEHIR=@g4 where TC=@g5", DAL.baglanti);
            if (komut4.Connection.State != System.Data.ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@g1", guncelle.AD);
            komut4.Parameters.AddWithValue("@g2", guncelle.SOYAD);
            komut4.Parameters.AddWithValue("@g5", guncelle.TC);
            komut4.Parameters.AddWithValue("@g3", guncelle.TELEFON);
            komut4.Parameters.AddWithValue("@g4", guncelle.SEHIR);
            return komut4.ExecuteNonQuery() > 0;
        }


    }
}
