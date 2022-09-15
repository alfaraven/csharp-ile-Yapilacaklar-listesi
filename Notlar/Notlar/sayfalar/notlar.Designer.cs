namespace Notlar
{
    partial class notlar
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notlar));
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            this.not_baslik = new System.Windows.Forms.Label();
            this.not_btn_yapildi = new Guna.UI2.WinForms.Guna2Button();
            this.not_icerik = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.not_btn_sil = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.not_edit_icerik = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.not_edit_baslik = new Guna.UI2.WinForms.Guna2TextBox();
            this.not_btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.notlar_mesaj = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.pictur_yapıldı = new Guna.UI2.WinForms.Guna2PictureBox();
            this.not_btn_yapilmadi = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Transition2 = new Guna.UI2.WinForms.Guna2Transition();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictur_yapıldı)).BeginInit();
            this.SuspendLayout();
            // 
            // not_baslik
            // 
            this.guna2Transition1.SetDecoration(this.not_baslik, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.not_baslik, Guna.UI2.AnimatorNS.DecorationType.None);
            this.not_baslik.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.not_baslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.not_baslik.Location = new System.Drawing.Point(3, 20);
            this.not_baslik.Name = "not_baslik";
            this.not_baslik.Size = new System.Drawing.Size(537, 53);
            this.not_baslik.TabIndex = 0;
            this.not_baslik.Text = "Başlık";
            this.not_baslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // not_btn_yapildi
            // 
            this.not_btn_yapildi.BorderRadius = 10;
            this.guna2Transition2.SetDecoration(this.not_btn_yapildi, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.not_btn_yapildi, Guna.UI2.AnimatorNS.DecorationType.None);
            this.not_btn_yapildi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.not_btn_yapildi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.not_btn_yapildi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.not_btn_yapildi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.not_btn_yapildi.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.not_btn_yapildi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.not_btn_yapildi.ForeColor = System.Drawing.Color.White;
            this.not_btn_yapildi.Location = new System.Drawing.Point(428, 208);
            this.not_btn_yapildi.Name = "not_btn_yapildi";
            this.not_btn_yapildi.Size = new System.Drawing.Size(106, 26);
            this.not_btn_yapildi.TabIndex = 1;
            this.not_btn_yapildi.Text = "Yapıldı Yap";
            this.not_btn_yapildi.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // not_icerik
            // 
            this.guna2Transition1.SetDecoration(this.not_icerik, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.not_icerik, Guna.UI2.AnimatorNS.DecorationType.None);
            this.not_icerik.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.not_icerik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.not_icerik.Location = new System.Drawing.Point(3, 53);
            this.not_icerik.Name = "not_icerik";
            this.not_icerik.Size = new System.Drawing.Size(531, 152);
            this.not_icerik.TabIndex = 2;
            this.not_icerik.Text = resources.GetString("not_icerik.Text");
            this.not_icerik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.not_icerik.Click += new System.EventHandler(this.not_icerik_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 20;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Transition2.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Black;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(338, 208);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(79, 26);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "Düzenle";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // not_btn_sil
            // 
            this.not_btn_sil.BorderRadius = 10;
            this.guna2Transition2.SetDecoration(this.not_btn_sil, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.not_btn_sil, Guna.UI2.AnimatorNS.DecorationType.None);
            this.not_btn_sil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.not_btn_sil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.not_btn_sil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.not_btn_sil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.not_btn_sil.FillColor = System.Drawing.Color.Tomato;
            this.not_btn_sil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.not_btn_sil.ForeColor = System.Drawing.Color.White;
            this.not_btn_sil.Location = new System.Drawing.Point(249, 208);
            this.not_btn_sil.Name = "not_btn_sil";
            this.not_btn_sil.Size = new System.Drawing.Size(79, 26);
            this.not_btn_sil.TabIndex = 4;
            this.not_btn_sil.Text = "Sil";
            this.not_btn_sil.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.not_edit_icerik);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.not_edit_baslik);
            this.panel1.Controls.Add(this.not_btn_edit);
            this.guna2Transition2.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 239);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // not_edit_icerik
            // 
            this.not_edit_icerik.Animated = true;
            this.not_edit_icerik.AutoScroll = true;
            this.not_edit_icerik.BorderRadius = 10;
            this.not_edit_icerik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.not_edit_icerik, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.not_edit_icerik, Guna.UI2.AnimatorNS.DecorationType.None);
            this.not_edit_icerik.DefaultText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam elit tortor, facilis" +
    "is sed sapien sed, ultric";
            this.not_edit_icerik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.not_edit_icerik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.not_edit_icerik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.not_edit_icerik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.not_edit_icerik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.not_edit_icerik.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.not_edit_icerik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.not_edit_icerik.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.not_edit_icerik.Location = new System.Drawing.Point(61, 53);
            this.not_edit_icerik.Margin = new System.Windows.Forms.Padding(4);
            this.not_edit_icerik.Multiline = true;
            this.not_edit_icerik.Name = "not_edit_icerik";
            this.not_edit_icerik.PasswordChar = '\0';
            this.not_edit_icerik.PlaceholderText = "İçerik";
            this.not_edit_icerik.SelectedText = "";
            this.not_edit_icerik.Size = new System.Drawing.Size(430, 146);
            this.not_edit_icerik.TabIndex = 8;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 10;
            this.guna2Transition2.SetDecoration(this.guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Tomato;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(358, 206);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(80, 26);
            this.guna2Button3.TabIndex = 7;
            this.guna2Button3.Text = "Vazgeç";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click_1);
            // 
            // not_edit_baslik
            // 
            this.not_edit_baslik.BackColor = System.Drawing.Color.Transparent;
            this.not_edit_baslik.BorderRadius = 10;
            this.not_edit_baslik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition2.SetDecoration(this.not_edit_baslik, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.not_edit_baslik, Guna.UI2.AnimatorNS.DecorationType.None);
            this.not_edit_baslik.DefaultText = "";
            this.not_edit_baslik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.not_edit_baslik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.not_edit_baslik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.not_edit_baslik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.not_edit_baslik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.not_edit_baslik.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.not_edit_baslik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.not_edit_baslik.Location = new System.Drawing.Point(125, 10);
            this.not_edit_baslik.Name = "not_edit_baslik";
            this.not_edit_baslik.PasswordChar = '\0';
            this.not_edit_baslik.PlaceholderText = "Başlık";
            this.not_edit_baslik.SelectedText = "";
            this.not_edit_baslik.Size = new System.Drawing.Size(291, 36);
            this.not_edit_baslik.TabIndex = 5;
            // 
            // not_btn_edit
            // 
            this.not_btn_edit.BorderRadius = 10;
            this.guna2Transition2.SetDecoration(this.not_btn_edit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.not_btn_edit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.not_btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.not_btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.not_btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.not_btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.not_btn_edit.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.not_btn_edit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.not_btn_edit.ForeColor = System.Drawing.Color.White;
            this.not_btn_edit.Location = new System.Drawing.Point(447, 206);
            this.not_btn_edit.Name = "not_btn_edit";
            this.not_btn_edit.Size = new System.Drawing.Size(80, 26);
            this.not_btn_edit.TabIndex = 4;
            this.not_btn_edit.Text = "Güncele";
            this.not_btn_edit.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // notlar_mesaj
            // 
            this.notlar_mesaj.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.notlar_mesaj.Caption = "";
            this.notlar_mesaj.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.notlar_mesaj.Parent = null;
            this.notlar_mesaj.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.notlar_mesaj.Text = null;
            // 
            // pictur_yapıldı
            // 
            this.pictur_yapıldı.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.pictur_yapıldı, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.pictur_yapıldı, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictur_yapıldı.Image = ((System.Drawing.Image)(resources.GetObject("pictur_yapıldı.Image")));
            this.pictur_yapıldı.ImageRotate = 0F;
            this.pictur_yapıldı.Location = new System.Drawing.Point(199, 67);
            this.pictur_yapıldı.Name = "pictur_yapıldı";
            this.pictur_yapıldı.Size = new System.Drawing.Size(127, 123);
            this.pictur_yapıldı.TabIndex = 13;
            this.pictur_yapıldı.TabStop = false;
            this.pictur_yapıldı.UseTransparentBackground = true;
            this.pictur_yapıldı.Visible = false;
            // 
            // not_btn_yapilmadi
            // 
            this.not_btn_yapilmadi.BorderRadius = 10;
            this.guna2Transition2.SetDecoration(this.not_btn_yapilmadi, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.not_btn_yapilmadi, Guna.UI2.AnimatorNS.DecorationType.None);
            this.not_btn_yapilmadi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.not_btn_yapilmadi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.not_btn_yapilmadi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.not_btn_yapilmadi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.not_btn_yapilmadi.FillColor = System.Drawing.Color.DodgerBlue;
            this.not_btn_yapilmadi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.not_btn_yapilmadi.ForeColor = System.Drawing.Color.White;
            this.not_btn_yapilmadi.Location = new System.Drawing.Point(423, 208);
            this.not_btn_yapilmadi.Name = "not_btn_yapilmadi";
            this.not_btn_yapilmadi.Size = new System.Drawing.Size(116, 26);
            this.not_btn_yapilmadi.TabIndex = 14;
            this.not_btn_yapilmadi.Text = "Yapılmadı Yap";
            this.not_btn_yapilmadi.Visible = false;
            this.not_btn_yapilmadi.Click += new System.EventHandler(this.not_btn_yapilmadi_Click);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Particles;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // guna2Transition2
            // 
            this.guna2Transition2.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.guna2Transition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.guna2Transition2.DefaultAnimation = animation2;
            // 
            // notlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.not_btn_yapilmadi);
            this.Controls.Add(this.pictur_yapıldı);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.not_btn_sil);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.not_icerik);
            this.Controls.Add(this.not_btn_yapildi);
            this.Controls.Add(this.not_baslik);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(13, 13, 13, 30);
            this.Name = "notlar";
            this.Size = new System.Drawing.Size(544, 241);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictur_yapıldı)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label not_baslik;
        public System.Windows.Forms.Label not_icerik;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox not_edit_baslik;
        private Guna.UI2.WinForms.Guna2Button not_btn_edit;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2MessageDialog notlar_mesaj;
        public Guna.UI2.WinForms.Guna2Button not_btn_yapildi;
        public Guna.UI2.WinForms.Guna2Button guna2Button2;
        public Guna.UI2.WinForms.Guna2Button not_btn_sil;
        private Guna.UI2.WinForms.Guna2PictureBox pictur_yapıldı;
        public Guna.UI2.WinForms.Guna2Button not_btn_yapilmadi;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition2;
        private Guna.UI2.WinForms.Guna2TextBox not_edit_icerik;
    }
}
