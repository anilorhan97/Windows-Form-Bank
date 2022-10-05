using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DATAACCESSLAYER;
using Entity;

namespace LogicLayer
{
    public class LogicGorevli
    {
        public static List<TBL_MUSTERI> MListesi()
        {
            return DALgorevli.MusteriListesi();
        }
        public static int personelEkle(BANKEntities p)
        {  //P ile kısıtlamalar yapıyoruz Ad soyad boş bırakılamaz maaş 4250 fazla olmalı vs
            if (p.AD != "" && p.SOYAD != "" )
            {
                return DALgorevli.musteriEkle(p);
            }
            else
            {  //-1 bir şey yapma değer döndürme anlamındadır 
                return -1;
            }
        }
        public static bool MSil(long per)
        {
            if (per >= 1)
            {
                return DALgorevli.musterıSil(per);
            }
            else
            {
                return false;
            }
        }
        public static bool MGuncelle(BANKEntities guncelle)
        {
            if (guncelle.AD != "" && guncelle.SOYAD != "")
            {
                return DALgorevli.musteriGuncelle();
            }
            else
            {
                return false;
            }
        }
    }
}
