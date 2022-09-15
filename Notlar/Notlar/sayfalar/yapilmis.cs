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

namespace Notlar
{
    public partial class yapilmis : UserControl
    {

        //MySql Bağlantısı.
        //Veri Tabnını Yapılandırmak İçin 'db.cs' kısımından gerekli değişiklikleri yapabilirsiniz.
        MySqlConnection con = db.GetDBConnection();

        private string not_durum = string.Empty;
        public string user_id = String.Empty;

        public yapilmis()
        {
            InitializeComponent();
        }
        public void yaplilmis()
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM notlist "))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter())
                {

                    cmd.Connection = con;
                    con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();


                    while (dr.Read())
                    {
                        not_durum = dr["not_durum"].ToString();
                        if (not_durum == "1")
                        {
                            notlar notlar = new notlar();
                            notlar.not_baslik.Text = dr["not_baslik"].ToString();
                            notlar.not_icerik.Text = dr["not_icerik"].ToString();
                            notlar.not_oncelik = dr["not_oncelik"].ToString();
                            notlar.add_id = dr["user_id"].ToString();
                            notlar.not_id = dr["not_id"].ToString();
                            notlar.you_id = user_id;

                            flowLayoutPanel1.Controls.Add(notlar);
                            notlar.not_btn_yapildi.Visible = false;
                            notlar.guna2Button2.Visible = false;
                            notlar.not_btn_sil.Location = new Point(448, 208);
                        }



                    }

                    con.Close();

                }
            }
        }
        private void yapilmis_Load(object sender, EventArgs e)
        {
            yaplilmis();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            yaplilmis();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
