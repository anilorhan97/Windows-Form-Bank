using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DATAACCESSLAYER
{
    public class DAL
    {
        //Bağlantıyı burada yaptık. Kısıtlama vs DALgorevli.cs 'de yapılacaktır.
        public static SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-4PFPNURQ\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");

    }
}
