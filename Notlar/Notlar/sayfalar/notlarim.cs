using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace Notlar.sayfalar
{
    public partial class page_notlarim : UserControl
    {

        //MySql Bağlantısı.
        //Veri Tabnını Yapılandırmak İçin 'db.cs' kısımından gerekli değişiklikleri yapabilirsiniz.
        MySqlConnection con = db.GetDBConnection();

        private string not_durum = string.Empty;
        public string user_id = String.Empty;
        public page_notlarim()
        {
            InitializeComponent();
        }
        private void notlar()
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM notlarim ORDER BY not_durum ASC"))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter())
                {

                    cmd.Connection = con;
                    con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();


                    while (dr.Read())
                    {
                        string usertidd = dr["user_id"].ToString();
                     
                        if (user_id == usertidd)
                        {
                            
                                notlatimnot notlar = new notlatimnot();
                            notlar.not_baslik.Text = dr["not_baslik"].ToString();
                            notlar.not_icerik.Text = dr["not_icerik"].ToString();
                            notlar.not_oncelik = dr["not_oncelik"].ToString();
                            notlar.add_id = dr["user_id"].ToString();
                            notlar.not_id = dr["not_id"].ToString();
                                notlar.durum = dr["not_durum"].ToString();
                            notlar.you_id = user_id;

                            flowLayoutPanel1.Controls.Add(notlar);
                      
                        }
                    }

                    con.Close();

                }
            }


        }
        private void notlarim_Load(object sender, EventArgs e)
        {
            notlar();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            notlar();
        }
    }
}
