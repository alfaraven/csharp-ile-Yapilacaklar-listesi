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
    public partial class anasayfa : UserControl
    {
        //MySql Bağlantısı.
        //Veri Tabnını Yapılandırmak İçin 'db.cs' kısımından gerekli değişiklikleri yapabilirsiniz.
        MySqlConnection con = db.GetDBConnection();

        public string user_id = String.Empty;
        public anasayfa()
        {
            InitializeComponent();
        }
        private void yapilacaklar_yapilmis()
        {
            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM notlist WHERE not_durum=1", con))
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lbl_yapilmis_gorev.Text = count.ToString();

            }
            con.Close();
        }
        private void yapilacaklar_yapilmamis()
        {
            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM notlist WHERE not_durum=0", con))
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lbl_yapilmamis_gorev.Text = count.ToString();

            }
            con.Close();
        }

        private void notlar_yapilmis()
        {
            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM notlarim WHERE not_durum=1 and 	user_id=@userid ", con))
            {
                cmd.Parameters.AddWithValue("@userid", user_id);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                not_yapilmis.Text = count.ToString();

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
                not_yapilmamis.Text = count.ToString();

            }
            con.Close();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            yapilacaklar_yapilmis();
            yapilacaklar_yapilmamis();
            notlar_yapilmamis();
            notlar_yapilmis();


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }

