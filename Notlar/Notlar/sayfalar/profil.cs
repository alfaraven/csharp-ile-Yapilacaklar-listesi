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

    public partial class profil : UserControl
    {
        //MySql Bağlantısı.
        //Veri Tabnını Yapılandırmak İçin 'db.cs' kısımından gerekli değişiklikleri yapabilirsiniz.
        MySqlConnection con = db.GetDBConnection();


        public string user_id = String.Empty;

        public profil()
        {
            InitializeComponent();
        }
        // Şifrelemn İçin Kullanılan Bir Tür private anahtar bunu isteğe göre değiştire bilirsiniz. 
        private string SetKey()
        {

            {
                return "vfkykRmGi16LWx=v+pngNsrIWj$UxIz&B};3-y30I2zj";
            }

        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            string pswd = SSTCryptographer.Encrypt(proif_sifre.Text, proif_klancadi.Text+SetKey());
          
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE users SET kulanici_adsoyad=@adsoyad,kulanici_ad=@kln_ad,kulanici_sifre=@klnc_sifre WHERE kulanici_id='" + user_id + "';", con);
            cmd.Parameters.AddWithValue("@adsoyad", proif_adsoyad.Text);
            cmd.Parameters.AddWithValue("@kln_ad", proif_klancadi.Text);
            cmd.Parameters.AddWithValue("@klnc_sifre", pswd);
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            guna2MessageDialog1.Show("Profil Güncelendi", "Bilgi");
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        private void profil_Load(object sender, EventArgs e)
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM users  WHERE kulanici_id=@userid "))
            {
                cmd.Parameters.AddWithValue("@userid", user_id);
                using (MySqlDataAdapter sda = new MySqlDataAdapter())
                {
                   

                    cmd.Connection = con;
                    con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();


                    if (dr.Read())
                    {
                       
                        proif_adsoyad.Text = dr["kulanici_adsoyad"].ToString();
                        proif_klancadi.Text = dr["kulanici_ad"].ToString();
                        string pswdde = SSTCryptographer.Decrypt(dr["kulanici_sifre"].ToString(), proif_klancadi.Text + SetKey());
                        proif_sifre.Text = pswdde;

                    }

                    con.Close();

                }
            }

        }

     
    }
}
