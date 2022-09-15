namespace Notlar
{
    partial class profil
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
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.proif_adsoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.proif_klancadi = new Guna.UI2.WinForms.Guna2TextBox();
            this.proif_sifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.AnimatedGIF = true;
            this.guna2GradientButton2.BorderRadius = 10;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.SlateBlue;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(375, 276);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(239, 45);
            this.guna2GradientButton2.TabIndex = 67;
            this.guna2GradientButton2.Text = "Güncele";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(-25, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1086, 45);
            this.label2.TabIndex = 66;
            this.label2.Text = "Profil Ayarları";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proif_adsoyad
            // 
            this.proif_adsoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proif_adsoyad.BorderRadius = 10;
            this.proif_adsoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.proif_adsoyad.DefaultText = "";
            this.proif_adsoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.proif_adsoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.proif_adsoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.proif_adsoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.proif_adsoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.proif_adsoyad.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.proif_adsoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.proif_adsoyad.Location = new System.Drawing.Point(228, 206);
            this.proif_adsoyad.Name = "proif_adsoyad";
            this.proif_adsoyad.PasswordChar = '\0';
            this.proif_adsoyad.PlaceholderText = "Ad Soyad";
            this.proif_adsoyad.SelectedText = "";
            this.proif_adsoyad.Size = new System.Drawing.Size(258, 36);
            this.proif_adsoyad.TabIndex = 63;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // proif_klancadi
            // 
            this.proif_klancadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proif_klancadi.BorderRadius = 10;
            this.proif_klancadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.proif_klancadi.DefaultText = "";
            this.proif_klancadi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.proif_klancadi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.proif_klancadi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.proif_klancadi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.proif_klancadi.Enabled = false;
            this.proif_klancadi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.proif_klancadi.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.proif_klancadi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.proif_klancadi.Location = new System.Drawing.Point(375, 135);
            this.proif_klancadi.Name = "proif_klancadi";
            this.proif_klancadi.PasswordChar = '\0';
            this.proif_klancadi.PlaceholderText = "Kullanıcı Adı";
            this.proif_klancadi.SelectedText = "";
            this.proif_klancadi.Size = new System.Drawing.Size(258, 36);
            this.proif_klancadi.TabIndex = 69;
            // 
            // proif_sifre
            // 
            this.proif_sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proif_sifre.BorderRadius = 10;
            this.proif_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.proif_sifre.DefaultText = "";
            this.proif_sifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.proif_sifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.proif_sifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.proif_sifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.proif_sifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.proif_sifre.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.proif_sifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.proif_sifre.Location = new System.Drawing.Point(510, 206);
            this.proif_sifre.Name = "proif_sifre";
            this.proif_sifre.PasswordChar = '●';
            this.proif_sifre.PlaceholderText = "Şifre";
            this.proif_sifre.SelectedText = "";
            this.proif_sifre.Size = new System.Drawing.Size(258, 36);
            this.proif_sifre.TabIndex = 70;
            this.proif_sifre.UseSystemPasswordChar = true;
            // 
            // profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.proif_sifre);
            this.Controls.Add(this.proif_klancadi);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proif_adsoyad);
            this.Name = "profil";
            this.Size = new System.Drawing.Size(1036, 504);
            this.Load += new System.EventHandler(this.profil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox proif_adsoyad;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2TextBox proif_klancadi;
        private Guna.UI2.WinForms.Guna2TextBox proif_sifre;
    }
}
