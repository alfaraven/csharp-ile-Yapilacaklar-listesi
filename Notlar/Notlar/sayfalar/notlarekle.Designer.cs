namespace Notlar.sayfalar
{
    partial class notlarekle
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.yapilacak_durum = new Guna.UI2.WinForms.Guna2ComboBox();
            this.yapilacak_icerik = new Guna.UI2.WinForms.Guna2TextBox();
            this.yapilacak_baslik = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(488, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Durum";
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
            this.guna2GradientButton2.Location = new System.Drawing.Point(407, 514);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(239, 45);
            this.guna2GradientButton2.TabIndex = 67;
            this.guna2GradientButton2.Text = "Ekle";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(-2, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1086, 45);
            this.label2.TabIndex = 66;
            this.label2.Text = "Not Ekle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yapilacak_durum
            // 
            this.yapilacak_durum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yapilacak_durum.BackColor = System.Drawing.Color.Transparent;
            this.yapilacak_durum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.yapilacak_durum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yapilacak_durum.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yapilacak_durum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yapilacak_durum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.yapilacak_durum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.yapilacak_durum.ItemHeight = 30;
            this.yapilacak_durum.Items.AddRange(new object[] {
            "Acil",
            "Orta",
            "Normal"});
            this.yapilacak_durum.Location = new System.Drawing.Point(383, 452);
            this.yapilacak_durum.Name = "yapilacak_durum";
            this.yapilacak_durum.Size = new System.Drawing.Size(287, 36);
            this.yapilacak_durum.TabIndex = 65;
            // 
            // yapilacak_icerik
            // 
            this.yapilacak_icerik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yapilacak_icerik.Animated = true;
            this.yapilacak_icerik.BorderRadius = 10;
            this.yapilacak_icerik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yapilacak_icerik.DefaultText = "";
            this.yapilacak_icerik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.yapilacak_icerik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.yapilacak_icerik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yapilacak_icerik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yapilacak_icerik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yapilacak_icerik.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yapilacak_icerik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yapilacak_icerik.Location = new System.Drawing.Point(333, 241);
            this.yapilacak_icerik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yapilacak_icerik.MaxLength = 500;
            this.yapilacak_icerik.Multiline = true;
            this.yapilacak_icerik.Name = "yapilacak_icerik";
            this.yapilacak_icerik.PasswordChar = '\0';
            this.yapilacak_icerik.PlaceholderText = "İcerik";
            this.yapilacak_icerik.SelectedText = "";
            this.yapilacak_icerik.Size = new System.Drawing.Size(413, 166);
            this.yapilacak_icerik.TabIndex = 64;
            // 
            // yapilacak_baslik
            // 
            this.yapilacak_baslik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yapilacak_baslik.BorderRadius = 10;
            this.yapilacak_baslik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yapilacak_baslik.DefaultText = "";
            this.yapilacak_baslik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.yapilacak_baslik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.yapilacak_baslik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yapilacak_baslik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yapilacak_baslik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yapilacak_baslik.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.yapilacak_baslik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yapilacak_baslik.Location = new System.Drawing.Point(339, 177);
            this.yapilacak_baslik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yapilacak_baslik.Name = "yapilacak_baslik";
            this.yapilacak_baslik.PasswordChar = '\0';
            this.yapilacak_baslik.PlaceholderText = "Başlık";
            this.yapilacak_baslik.SelectedText = "";
            this.yapilacak_baslik.Size = new System.Drawing.Size(401, 50);
            this.yapilacak_baslik.TabIndex = 63;
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
            // notlarekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yapilacak_durum);
            this.Controls.Add(this.yapilacak_icerik);
            this.Controls.Add(this.yapilacak_baslik);
            this.Name = "notlarekle";
            this.Size = new System.Drawing.Size(1089, 644);
            this.Load += new System.EventHandler(this.notlarekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox yapilacak_durum;
        private Guna.UI2.WinForms.Guna2TextBox yapilacak_icerik;
        private Guna.UI2.WinForms.Guna2TextBox yapilacak_baslik;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}
