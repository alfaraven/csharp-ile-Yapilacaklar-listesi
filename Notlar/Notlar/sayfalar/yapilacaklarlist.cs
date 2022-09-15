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
using Notlar.sayfalar;

namespace Notlar
{
    public partial class yapilacaklarlist : UserControl
    {

        //MySql Bağlantısı.
        //Veri Tabnını Yapılandırmak İçin 'db.cs' kısımından gerekli değişiklikleri yapabilirsiniz.
        MySqlConnection con = db.GetDBConnection();

        private string not_durum = string.Empty;
        public string user_id = String.Empty;
        public yapilacaklarlist()
        {
            InitializeComponent();
        }
        private void yapilacaklar() {
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM notlist ORDER BY not_durum ASC"))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter())
                {

                    cmd.Connection = con;
                    con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();


                    while (dr.Read())
                    {
                     
                            notlar notlar = new notlar();
                            notlar.not_baslik.Text = dr["not_baslik"].ToString();
                            notlar.not_icerik.Text = dr["not_icerik"].ToString();
                            notlar.not_oncelik = dr["not_oncelik"].ToString();
                            notlar.add_id = dr["user_id"].ToString();
                            notlar.not_id = dr["not_id"].ToString();
                            notlar.durum = dr["not_durum"].ToString();
                            notlar.you_id = user_id;

                            flowLayoutPanel1.Controls.Add(notlar);
                     
                    }

                    con.Close();

                }
            }


        }
        private void yapilacaklarlist_Load(object sender, EventArgs e)
        {
            yapilacaklar();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            yapilacaklar();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
