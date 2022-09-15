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
    public partial class detylar : Form
    {
        //MySql Bağlantısı.
        //Veri Tabnını Yapılandırmak İçin 'db.cs' kısımından gerekli değişiklikleri yapabilirsiniz.
        MySqlConnection con = db.GetDBConnection();

        public string user_id = String.Empty;
        public string baslingic = string.Empty;
        public int drm = 0;
        public detylar()
        {
            InitializeComponent();
        }

   
        private void detylar_Load(object sender, EventArgs e)
        {
            yapilacaklar_yapilmis();
            yapilacaklar_yapilmamis();
            notlar_yapilmamis();
            notlar_yapilmis();

            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - this.Width;
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            if (durum == 0)
            {
                durum = 1;
                timer_btn.Text = "Durdur";
                timer_btn.FillColor = Color.Tomato;
                timer1.Start();
              
            }
            else if (durum == 1)
            {
                durum = 0;
                timer_btn.Text = "Başlat";
                timer_btn.FillColor = Color.DodgerBlue;
                timer1.Stop();
            }
        }
        private void notlar_yapilmis()
        {
            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM notlarim WHERE not_durum=1 and 	user_id=@userid ", con))
            {
                cmd.Parameters.AddWithValue("@userid", user_id);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                nt_yap.Text = count.ToString();

            }
            con.Close();
        }
        private void notlar_yapilmamis()
        {
            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM notlarim WHERE not_durum=0 and 	user_id=@userid ", con))
            {
                cmd.Parameters.AddWithValue("@userid", user_id);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                nt_yapma.Text = count.ToString();

            }
            con.Close();
        }
        private void yapilacaklar_yapilmis()
        {
            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM notlist WHERE not_durum=1", con))
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                yp_yap.Text = count.ToString();
            }
            con.Close();
        }
        private void yapilacaklar_yapilmamis()
        {
            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM notlist WHERE not_durum=0", con))
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                yp_yapma.Text = count.ToString();
            }
            con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          
         
        }
       public int durum = 0;
       public int saat = 0, dakika = 0, saniye = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;

            }
            if (dakika == 60)
            {
                dakika = 0;
                saniye = 0;
                saat++;
            }
        
            label11.Text = String.Format("{0:D2}", saat) + ":" + String.Format("{0:D2}", dakika) + ":" + String.Format("{0:D2}", saniye);
            saniye++;
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
          
        }

        private void timer_btn_Click(object sender, EventArgs e)
        {
            if (durum == 0)
            {
                durum = 1;
                timer_btn.Text = "Durdur";
                timer_btn.FillColor = Color.Tomato;
                timer1.Start();

            }
            else if (durum == 1)
            {
                durum = 0;
                timer_btn.Text = "Başlat";
                timer_btn.FillColor = Color.DodgerBlue;
                timer1.Stop();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            DialogResult dialogResult = guna2MessageDialog1.Show("Günü Bitiremek istediğinizden emin misiniz?", "Uyarı");
            if (dialogResult == DialogResult.Yes) {  
                DateTime tarih = DateTime.Now;//bugünün tarihinin alınması
            string format = "yyyy-MM-d";//tarihe uygulanacak format.
            string format2 = "HH:mm";//tarihe uygulanacak format.
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Insert into zaman (user_id,baslangic_zamani,zaman,tarih,time)  values(@usr_id,@bslzaman,@sure,@tarih,@time)", con);
            cmd.Parameters.AddWithValue("@usr_id", user_id);
            cmd.Parameters.AddWithValue("@bslzaman",baslingic);
            cmd.Parameters.AddWithValue("@sure", label11.Text);
            cmd.Parameters.AddWithValue("@tarih", tarih.ToString(format));
            cmd.Parameters.AddWithValue("@time", tarih.ToString(format2));
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            guna2MessageDialog1.Show("İşlem Kayıtedildi", "Bilgi");
            saat = 0;
            dakika = 0;
            saniye = 0;
           
            label11.Text = "00:00:00";
            timer_btn.Text = "Başlat";
            timer_btn.FillColor = Color.DodgerBlue;
            timer1.Stop();
                Properties.Settings.Default.durum = durum = 0;
                Properties.Settings.Default.Save();
                cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

    private void detylar_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
