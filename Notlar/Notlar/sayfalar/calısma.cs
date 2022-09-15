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

    public partial class calısma : UserControl
    {
        //MySql Bağlantısı.
        //Veri Tabnını Yapılandırmak İçin 'db.cs' kısımından gerekli değişiklikleri yapabilirsiniz.
        MySqlConnection con = db.GetDBConnection();

        public string user_id = String.Empty;
        public calısma()
        {
            InitializeComponent();
        }

        private void calısma_Load(object sender, EventArgs e)
        {

            MySqlCommand cmd = new MySqlCommand("SELECT baslangic_zamani,zaman,tarih,time FROM zaman WHERE user_id='" + user_id + "';", con);
            con.Open();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dataTable);
            guna2DataGridView3.DataSource = dataTable;

           con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
