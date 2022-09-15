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
 
    public partial class panel : Form
    {

        //MySql Bağlantısı.
        //Veri Tabnını Yapılandırmak İçin 'db.cs' kısımından gerekli değişiklikleri yapabilirsiniz.
        MySqlConnection con = db.GetDBConnection();

        public int durum = 0;
        public int saat = 0, dakika = 0, saniye = 0;
        public string user_id=string.Empty;
        public string adsoyad = string.Empty;
        public string baslingic = string.Empty;
        private string not_durum=string.Empty;
        string yapilackalar ="",ntyapilacak="";
        public panel()
        {
            InitializeComponent();
        }

        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
  ////   panel_content.Controls.Clear();
      ////  yapılacaklar yapılacaklarlist = new yapılacaklar();
         ///panel_content.Controls.Add(yapılacaklarlist);
     
           
        }

        public void notlar_yapilmamis()
        {
            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM notlarim WHERE not_durum=0 and 	user_id=@userid ", con))
            {
                cmd.Parameters.AddWithValue("@userid", user_id);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                ntyapilacak = count.ToString();

            }
            con.Close();

            if (ntyapilacak == "0")
            {
                guna2NotificationPaint2.Visible = false;
            }
            else
            {
                guna2NotificationPaint2.Visible = true;
                guna2NotificationPaint2.Text = ntyapilacak;
            }
        }
  
        public void yapilacaklar_yapilmamis()
        {
            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM notlist WHERE not_durum=0", con))
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                yapilackalar = count.ToString();
            }
            con.Close();
            if (yapilackalar == "0")
            {
                guna2NotificationPaint1.Visible = false;

            }
            else
            {
                guna2NotificationPaint1.Visible = true;

                guna2NotificationPaint1.Text = yapilackalar;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            yapilacaklar_yapilmamis();
            notlar_yapilmamis();
            lbl_sayfa_baslik.Text = "Yapılacaklar";
            panel_content.Controls.Clear();
            yapilacaklarlist yapılacaklarlist = new yapilacaklarlist();
            yapılacaklarlist.user_id = user_id;
            yapılacaklarlist.Dock = DockStyle.Fill;
            panel_content.Controls.Add(yapılacaklarlist);
            pnlStats.Height = guna2Button2.Height;
            pnlStats.Top = guna2Button2.Top;
        }

        private void panel_Load(object sender, EventArgs e)
        {
            notlar_yapilmamis();
            yapilacaklar_yapilmamis();
           

            lbl_adsoyad.Text = adsoyad;
            lbl_sayfa_baslik.Text = "Ana Sayfa";
            panel_content.Controls.Clear();
            anasayfa anasayfa = new anasayfa();
            anasayfa.user_id = user_id;
            anasayfa.Dock = DockStyle.Fill;
            panel_content.Controls.Add(anasayfa);
            pnlStats.Height = guna2Button1.Height;
            pnlStats.Top = guna2Button1.Top;

            if (durum == 0)
            {
                durum = 0;
                timer_btn.Text = "Günü Başlat";
                timer_btn.FillColor = Color.DodgerBlue;
                timer1.Stop();
                

            }
            else if (durum == 1)
            {
                durum = 1;
                timer_btn.Text = "Durdur";
                timer_btn.FillColor = Color.Tomato;
                timer1.Start();
            }

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            lbl_sayfa_baslik.Text = "Ana Sayfa";
            panel_content.Controls.Clear();
            anasayfa anasayfa = new   anasayfa();
            anasayfa.user_id = user_id;
            anasayfa.Dock = DockStyle.Fill;
            panel_content.Controls.Add(anasayfa);
            pnlStats.Height = guna2Button1.Height;
            pnlStats.Top = guna2Button1.Top;
        }

        private void panel_left_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
           
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            notlar_yapilmamis();
            yapilacaklar_yapilmamis();
            lbl_sayfa_baslik.Text = "Notlarım";
            panel_content.Controls.Clear();
            page_notlarim notlarr = new page_notlarim();
            notlarr.user_id = user_id;
            notlarr.Dock = DockStyle.Fill;
            panel_content.Controls.Add(notlarr);
            pnlStats.Height = guna2Button4.Height;
            pnlStats.Top = guna2Button4.Top;
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            lbl_sayfa_baslik.Text = "Yapılacak Ekle";
            panel_content.Controls.Clear();
            yapilacakekle notlarr = new yapilacakekle();
            notlarr.user_id = user_id;
            notlarr.Dock = DockStyle.Fill;
            panel_content.Controls.Add(notlarr);
            pnlStats.Height = guna2Button3.Height;
            pnlStats.Top = guna2Button3.Top;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            lbl_sayfa_baslik.Text = "Notlarım Ekle";
            panel_content.Controls.Clear();
            notlarekle notlarr = new notlarekle();
            notlarr.user_id = user_id;
            notlarr.Dock = DockStyle.Fill;
            panel_content.Controls.Add(notlarr);
            pnlStats.Height = guna2Button5.Height;
            pnlStats.Top = guna2Button5.Top;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            lbl_sayfa_baslik.Text = "Profil";
            panel_content.Controls.Clear();
            profil notlarr = new profil();
            notlarr.user_id = user_id;
            notlarr.Dock = DockStyle.Fill;
            panel_content.Controls.Add(notlarr);
            pnlStats.Height = guna2Button6.Height;
            pnlStats.Top = guna2Button6.Top;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            lbl_sayfa_baslik.Text = "Hakkında";
            panel_content.Controls.Clear();
            hakinda notlarr = new hakinda();
            notlarr.Dock = DockStyle.Fill;
            panel_content.Controls.Add(notlarr);
        }

        private void panel_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                anasayfa ansf = new anasayfa();
                detylar dty= new detylar();
             
                dty.yp_yap.Text = ansf.lbl_yapilmis_gorev.Text;
                dty.yp_yapma.Text = ansf.lbl_yapilmamis_gorev.Text;
                dty.nt_yap.Text = ansf.not_yapilmis.Text;
                dty.nt_yapma.Text = ansf.not_yapilmamis.Text;

                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.Text = "Panel";
                notifyIcon1.BalloonTipTitle = "Program Çalışıyor";
                notifyIcon1.BalloonTipText = "Program sağ alt köşede konumlandı.\nTekrar açmak için çift tıklayınız";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(3);
            }
        }
       
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            this.Show();
            durum = Properties.Settings.Default.durum;
            if (durum == 0)
            {
                durum = 0;
                timer_btn.Text = "Günü Başlat";
                label2.Text = "00:00:00";
                timer_btn.FillColor = Color.DodgerBlue;
                timer1.Stop();


            }
            else if (durum == 1)
            {
                durum = 1;
                timer_btn.Text = "Durdur";
                timer_btn.FillColor = Color.Tomato;
                timer1.Start();
            }
            notifyIcon1.Visible = false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            detylar dety=new detylar();
            anasayfa ansf = new anasayfa();

            dety.lblisim.Text = lbl_adsoyad.Text;

            dety.user_id = user_id;
            dety.saat = saat;
            dety.dakika = dakika;
            dety.saniye = saniye;
            dety.baslingic = baslingic;

            if (durum == 0)
            {
                dety.durum = 1;
            }
            else if (durum == 1)
            {
                dety.durum = 0;
            }
            dety.Show();
        }

        private void dsdsToolStripMenuItem_Click(object sender, EventArgs e)
        {

   
          
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            lbl_sayfa_baslik.Text = "Çalışmalar";
            panel_content.Controls.Clear();
            calısma clsm = new calısma();
            clsm.user_id = user_id;
            clsm.Dock = DockStyle.Fill;
            panel_content.Controls.Add(clsm);
            pnlStats.Height = guna2Button6.Height;
            pnlStats.Top = guna2Button6.Top;
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            notifyIcon1.Visible = true;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
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
            detylar dyty = new detylar();
            dyty.label11.Text = String.Format("{0:D2}", saat) + ":" + String.Format("{0:D2}", dakika) + ":" + String.Format("{0:D2}", saniye);
            label2.Text = String.Format("{0:D2}", saat) + ":" + String.Format("{0:D2}", dakika) + ":" + String.Format("{0:D2}", saniye);
            saniye++;
        }
    }
}
