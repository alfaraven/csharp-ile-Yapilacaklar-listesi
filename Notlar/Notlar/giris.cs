using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Notlar
{

    public partial class giris : Form
    {
        //MySql Bağlantısı.
        //Veri Tabnını Yapılandırmak İçin 'db.cs' kısımından gerekli değişiklikleri yapabilirsiniz.
        MySqlConnection con = db.GetDBConnection();


        public giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init_Data();
            /*
            var webClient = new WebClient();
            string dnsString = webClient.DownloadString("http://checkip.dyndns.org");
            dnsString = (new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")).Match(dnsString).Value;
            webClient.Dispose();
            label4.Text = "IP Adresi " + dnsString;

            string bilgisayarAdi = Dns.GetHostName();
            label3.Text = "Bilgisayar Adı: " + bilgisayarAdi;
            string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();
          */




        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        // Şifrelemn İçin Kullanılan Bir Tür private anahtar bunu isteğe göre değiştire bilirsiniz. 
        
        private string SetKey()
        {

            {
                return "vfkykRmGi16LWx=v+pngNsrIWj$UxIz&B};3-y30I2zj";
            }

        }
        private void login_button_Click(object sender, EventArgs e)
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM users where kulanici_ad=@kl "))
            {

              
                cmd.Parameters.AddWithValue("@kl", login_txt_username.Text);
                using (MySqlDataAdapter sda = new MySqlDataAdapter())
                {

                    cmd.Connection = con;
                    con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();


                    if ((dr.Read()))
                    {
                        
                      
                        string sifrelme = SSTCryptographer.Decrypt(dr["kulanici_sifre"].ToString(), SetKey());
                        if(login_text_password.Text== sifrelme)
                        {
                            panel panel = new panel();
                            yapilacaklarlist yaplicaklarliste = new yapilacaklarlist();
                            panel.user_id = dr["kulanici_id"].ToString();
                            yaplicaklarliste.user_id= dr["kulanici_id"].ToString();
                            panel.adsoyad = dr["kulanici_adsoyad"].ToString();
                            panel.Show();
                            this.Hide();
                           
                        }
                        else
                        {
                            login_message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                            login_message.Show("Kullanıcı Adı Veya Şifre Hatalı ", "Hata!");
                        }

                    }
                    else
                    {
                        login_message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                        login_message.Show("Kullanıcı Adı Veya Şifre Hatalı ", "Hata!");
                    }
                    con.Close();

                }
            }
        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                if (Properties.Settings.Default.loginceheck == true)
                {
                    login_txt_username.Text = Properties.Settings.Default.username;
                    login_text_password.Text = Properties.Settings.Default.pasword;
                    benihatirla.Checked = true;
                }
                else
                {
                    login_txt_username.Text = Properties.Settings.Default.username;
                    login_text_password.Text = Properties.Settings.Default.pasword;

                }
            }
        }
        private void Save_Data()
        {
            if (benihatirla.Checked)
            {
                Properties.Settings.Default.username = login_txt_username.Text.Trim();
                Properties.Settings.Default.pasword = login_text_password.Text.Trim();
                Properties.Settings.Default.loginceheck = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.pasword = "";
                Properties.Settings.Default.loginceheck = false;
                Properties.Settings.Default.Save();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            try
            {

          
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM users where kulanici_ad=@kl "))
            {


                cmd.Parameters.AddWithValue("@kl", login_txt_username.Text);
                using (MySqlDataAdapter sda = new MySqlDataAdapter())
                {

                    cmd.Connection = con;
                    con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();


                    if ((dr.Read()))
                    {


                        string sifrelme = SSTCryptographer.Decrypt(dr["kulanici_sifre"].ToString(), dr["kulanici_ad"].ToString() + SetKey());
                        if (login_text_password.Text == sifrelme)
                        {
                            detylar dty = new detylar();
                            panel panel = new panel();
                            yapilacaklarlist yaplicaklarliste = new yapilacaklarlist();
                            panel.user_id = dr["kulanici_id"].ToString();
                            yaplicaklarliste.user_id = dr["kulanici_id"].ToString();
                            panel.adsoyad = dr["kulanici_adsoyad"].ToString();
                            DateTime tarih = DateTime.Now;//bugünün tarihinin alınması
                            string format2 = "HH:mm";//tarihe uygulanacak format.
                            panel.baslingic = tarih.ToString(format2);
                            Save_Data();
                            panel.Show();
                            this.Hide();

                        }
                        else
                        {
                            login_message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                            login_message.Show("Kullanıcı Adı Veya Şifre Hatalı ", "Hata!");
                        }

                    }
                    else
                    {
                        login_message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                        login_message.Show("Kullanıcı Adı Veya Şifre Hatalı ", "Hata!");
                    }
                    con.Close();

                }
            }
            }
            catch
            {
                login_message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                login_message.Show("Suncu ile iletişim sağlanmadı lütfen daha sonra tekrar deneyiniz ", "Hata!");
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(kayit_txt_ad.Text=="" && kayit_txt_password.Text=="" && kayit_txt_username.Text == "")
            {
                login_message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                login_message.Show("Lütfen Boş Bırakılan Alanları Doldurun", "Hata!");
            }
            else
            {

                try
                {

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM users where kulanici_ad=@kl ");
            


                    cmd.Parameters.AddWithValue("@kl", kayit_txt_username.Text);
                MySqlDataAdapter sda = new MySqlDataAdapter();
              

                        cmd.Connection = con;
                        con.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();


                        if ((dr.Read()))
                        {

                            login_message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                            login_message.Show("Girmiş Olduğunuz Kullanıcı Adı Sistemde Mevcut\n Lütfen Başka Bir Kullanıcı Adı Giriniz. ", "Uyarı!");
                            con.Close();

                        }
                            else
                            {
                    con.Close();
                        ///burada şifreleme argoritamısını çağırıyoruz.
                        ///benzersiz olabilmesi için ben kayıt olurken kullanıcını oluşturduğu kullanıcı adı ile şifrlemeyi güçlendirdim.
                    
                string pswd = SSTCryptographer.Encrypt(kayit_txt_password.Text, kayit_txt_username.Text+SetKey());
                MySqlCommand cmdd = new MySqlCommand("Insert into users (kulanici_adsoyad,kulanici_ad,kulanici_sifre)  values(@adsoyad,@kln_ad,@klnc_sifre)", con);
                            cmdd.Parameters.AddWithValue("@adsoyad", kayit_txt_ad.Text);
                            cmdd.Parameters.AddWithValue("@kln_ad", kayit_txt_username.Text);
                            cmdd.Parameters.AddWithValue("@klnc_sifre", pswd);
                            cmdd.Connection = con;
                            con.Open();
                            login_message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                            login_message.Show("Kayıt Olundu", "Bilgi");

                cmdd.ExecuteNonQuery();
                cmdd.Dispose();
                con.Close();
                        login_txt_username.Text = kayit_txt_username.Text;
                        login_text_password.Text = kayit_txt_password.Text;
                        kayit_txt_ad.Text = "";
                            kayit_txt_username.Text = "";
                            kayit_txt_password.Text = "";
                       
                kayit_panel.Visible= false;
                giris_panel.Visible = true;
            


            }
                }
                catch
                {
                    login_message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                    login_message.Show("Suncu ile iletişim sağlanmadı lütfen daha sonra tekrar deneyiniz ", "Hata!");
                }
            }

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            kayit_panel.Visible = false;
            giris_panel.Visible = true;
         
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            kayit_panel.Visible = true;
            giris_panel.Visible = false;
          
        }
    }
}
