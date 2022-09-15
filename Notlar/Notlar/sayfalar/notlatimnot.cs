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
    public partial class notlatimnot : UserControl
    {

        //MySql Bağlantısı.
        //Veri Tabnını Yapılandırmak İçin 'db.cs' kısımından gerekli değişiklikleri yapabilirsiniz.
        MySqlConnection con = db.GetDBConnection();

        public string not_id = string.Empty;
        public string not_oncelik = string.Empty;
        public string you_id = string.Empty;
        public string add_id = string.Empty;
        public string durum = string.Empty;
        public notlatimnot()
        {
            InitializeComponent();
        }

        private void not_baslik_Click(object sender, EventArgs e)
        {

        }

        private void not_btn_yapildi_Click(object sender, EventArgs e)
        {
            notlar_mesaj.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            notlar_mesaj.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            DialogResult dialogResult = notlar_mesaj.Show("Yapıldı Olarak Kaydetmek İstermisiniz ?", "Uyarı");
            if (dialogResult == DialogResult.Yes)
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE notlarim SET not_durum=@durum WHERE not_id='" + not_id + "';", con);
                cmd.Parameters.AddWithValue("@durum", "1");
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                notlar_mesaj.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                notlar_mesaj.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                notlar_mesaj.Show("İşlem Yapıldı Olarak Kaytedildi", "Bilgi");
                guna2Transition1.ShowSync(pictur_yapıldı);
                not_btn_yapilmadi.Visible = true;

            }
            else
            {

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pictur_yapıldı.Visible = false;
            not_btn_yapilmadi.Visible = false;
            panel1.Visible = true;
            not_edit_baslik.Text = not_baslik.Text;
            not_edit_icerik.Text = not_icerik.Text;
        }

        private void not_btn_sil_Click(object sender, EventArgs e)
        {
            notlar_mesaj.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            notlar_mesaj.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            DialogResult dialogResult = notlar_mesaj.Show("Silmek istediğinizden emin misiniz?", "Uyarı");
            if (dialogResult == DialogResult.Yes)
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM notlarim WHERE not_id=@id", con);
                cmd.Parameters.AddWithValue("@id", not_id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                notlar_mesaj.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                notlar_mesaj.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                notlar_mesaj.Show("Silme İşlemi Başarılı", "Bilgi");
                guna2Transition2.HideSync(this);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void not_btn_edit_Click(object sender, EventArgs e)
        {
            notlar_mesaj.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            notlar_mesaj.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            DialogResult dialogResult = notlar_mesaj.Show("Son Değişklikleri Güncelemek İstermisiniz ?", "Uyarı");
            if (dialogResult == DialogResult.Yes)
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE notlarim SET not_baslik=@baslik,not_icerik=@icerik WHERE not_id='" + not_id + "';", con);
                cmd.Parameters.AddWithValue("@baslik", not_edit_baslik.Text);
                cmd.Parameters.AddWithValue("@icerik", not_edit_icerik.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                not_baslik.Text = not_edit_baslik.Text;
                not_icerik.Text = not_edit_icerik.Text;
                panel1.Visible = false;
                notlar_mesaj.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                notlar_mesaj.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                notlar_mesaj.Show("Son Değişklikler Güncelendi", "Bilgi");
                yapikontrol();
            }
            else if (dialogResult == DialogResult.No)
            {
                notlar_mesaj.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                notlar_mesaj.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                notlar_mesaj.Show("Son Değişklikler İptal Edildi", "İpatl");
                panel1.Visible = false;
                yapikontrol();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            yapikontrol();
        }

        private void yapikontrol()
        {
            if (durum == "1")
            {
                not_btn_yapildi.Visible = false;
                not_btn_yapilmadi.Visible = true;
                pictur_yapıldı.Visible = true;
            }
            else if (durum == "0")
            {
                pictur_yapıldı.Visible = false;
                not_btn_yapilmadi.Visible = false;
                not_btn_yapildi.Visible = true;
            }
        }
        private void notlatimnot_Load(object sender, EventArgs e)
        {
            yapikontrol();
            if (not_oncelik == "Acil")
            {
                this.BackColor = Color.Tomato;
            }
            else if (not_oncelik == "Orta")
            {
                this.BackColor = Color.Orange;
            }
            else if (not_oncelik == "Normal")
            {
                this.BackColor = Color.LightSlateGray;
            }

            if (you_id == add_id)
            {
                not_btn_yapildi.Visible = true;
                guna2Button2.Visible = true;
                not_btn_sil.Visible = true;

            }
            else
            {
                not_btn_yapildi.Visible = true;
                guna2Button2.Visible = false;
                not_btn_sil.Visible = false;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            notlar_mesaj.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            notlar_mesaj.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            DialogResult dialogResult = notlar_mesaj.Show("Yapılmadı Olarak Kaydetmek İstermisiniz ?", "Uyarı");
            if (dialogResult == DialogResult.Yes)
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE notlarim SET not_durum=@durum WHERE not_id='" + not_id + "';", con);
                cmd.Parameters.AddWithValue("@durum", "0");
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                notlar_mesaj.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                notlar_mesaj.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                notlar_mesaj.Show("İşlem Yapılmadı Olarak Kaytedildi", "Bilgi");
                guna2Transition1.HideSync(pictur_yapıldı);
                pictur_yapıldı.Visible = false;
                not_btn_yapilmadi.Visible = false;
            }
            else
            {

            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
