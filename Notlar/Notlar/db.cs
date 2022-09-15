using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notlar
{
    internal class db
    {


        public static MySqlConnection GetDBConnection()
        {

 /* Sunucu Adresi: */ string host = "localhost";
/* Sunucu Portu: */ int port = 3306;
/* VeriTabnı adı: */string database = "notlist";
/* Mysql Kullanıcı Adı: */string username = "root";
/* Mysql Şifre: */string password = "";

            return mysqldb.GetDBConnection(host, port, database, username, password);
        }


    }

 

}
