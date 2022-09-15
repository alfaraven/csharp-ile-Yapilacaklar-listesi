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
    public partial class yapilacakekle : UserControl
    {

        //MySql Bağlantısı.
        //Veri Tabnını Yapılandırmak İçin 'db.cs' kısımından gerekli değişiklikleri yapabilirsiniz.
        MySqlConnection con = db.GetDBConnection();

        public string user_id = String.Empty;
        public yapilacakekle()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if(yapilacak_baslik.Text=="" || yapilacak_icerik.Text=="" || yapilacak_durum.SelectedIndex == -1)
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Lütfen Boş Alanları Doldurun", "Hata");
            }
            else
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Insert into notlist (user_id,not_baslik,not_icerik,not_oncelik,not_durum)  values(@usr_id,@baslik,@icerik,@oncelik,@durum)", con);
                cmd.Parameters.AddWithValue("@usr_id", user_id);
                cmd.Parameters.AddWithValue("@baslik", yapilacak_baslik.Text);
                cmd.Parameters.AddWithValue("@icerik", yapilacak_icerik.Text);
                cmd.Parameters.AddWithValue("@oncelik", yapilacak_durum.Text);
                cmd.Parameters.AddWithValue("@durum", "0");
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog1.Show("Ekleme İşlemi Başarılı", "Bilgi");
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                yapilacak_baslik.Text = "";
                yapilacak_icerik.Text = "";
                yapilacak_durum.SelectedIndex = -1;
            }
           
        }

        private void yapilacakekle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
