namespace Notlar
{
    partial class giris
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.giris_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.benihatirla = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.login_text_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.login_message = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kayit_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label5 = new System.Windows.Forms.Label();
            this.kayit_txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.kayit_txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.kayit_txt_ad = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.giris_panel.SuspendLayout();
            this.kayit_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // giris_panel
            // 
            this.giris_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.giris_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.giris_panel.Controls.Add(this.guna2GradientButton2);
            this.giris_panel.Controls.Add(this.label3);
            this.giris_panel.Controls.Add(this.benihatirla);
            this.giris_panel.Controls.Add(this.login_text_password);
            this.giris_panel.Controls.Add(this.login_txt_username);
            this.giris_panel.Controls.Add(this.login_button);
            this.giris_panel.Controls.Add(this.label1);
            this.giris_panel.Location = new System.Drawing.Point(0, 38);
            this.giris_panel.Name = "giris_panel";
            this.giris_panel.Size = new System.Drawing.Size(667, 333);
            this.giris_panel.TabIndex = 4;
            this.giris_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(313, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Beni Hatırla";
            // 
            // benihatirla
            // 
            this.benihatirla.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.benihatirla.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.benihatirla.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.benihatirla.CheckedState.InnerColor = System.Drawing.Color.White;
            this.benihatirla.Location = new System.Drawing.Point(256, 186);
            this.benihatirla.Name = "benihatirla";
            this.benihatirla.Size = new System.Drawing.Size(53, 23);
            this.benihatirla.TabIndex = 23;
            this.benihatirla.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.benihatirla.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.benihatirla.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.benihatirla.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // login_text_password
            // 
            this.login_text_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_text_password.Animated = true;
            this.login_text_password.AutoRoundedCorners = true;
            this.login_text_password.BorderRadius = 16;
            this.login_text_password.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.login_text_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_text_password.DefaultText = "";
            this.login_text_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_text_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_text_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_text_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_text_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_text_password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_text_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_text_password.IconLeft = ((System.Drawing.Image)(resources.GetObject("login_text_password.IconLeft")));
            this.login_text_password.Location = new System.Drawing.Point(347, 144);
            this.login_text_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_text_password.MaxLength = 25;
            this.login_text_password.Name = "login_text_password";
            this.login_text_password.Padding = new System.Windows.Forms.Padding(20);
            this.login_text_password.PasswordChar = '●';
            this.login_text_password.PlaceholderText = "Şifre";
            this.login_text_password.SelectedText = "";
            this.login_text_password.Size = new System.Drawing.Size(240, 34);
            this.login_text_password.TabIndex = 22;
            this.login_text_password.UseSystemPasswordChar = true;
            // 
            // login_txt_username
            // 
            this.login_txt_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_txt_username.Animated = true;
            this.login_txt_username.AutoRoundedCorners = true;
            this.login_txt_username.BorderRadius = 16;
            this.login_txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_txt_username.DefaultText = "";
            this.login_txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_txt_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.login_txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_txt_username.IconLeft = ((System.Drawing.Image)(resources.GetObject("login_txt_username.IconLeft")));
            this.login_txt_username.Location = new System.Drawing.Point(80, 144);
            this.login_txt_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_txt_username.MaxLength = 20;
            this.login_txt_username.Name = "login_txt_username";
            this.login_txt_username.Padding = new System.Windows.Forms.Padding(20);
            this.login_txt_username.PasswordChar = '\0';
            this.login_txt_username.PlaceholderText = "Kullanıcı Adı";
            this.login_txt_username.SelectedText = "";
            this.login_txt_username.Size = new System.Drawing.Size(240, 34);
            this.login_txt_username.TabIndex = 21;
            // 
            // login_button
            // 
            this.login_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_button.Animated = true;
            this.login_button.AutoRoundedCorners = true;
            this.login_button.BackColor = System.Drawing.Color.Transparent;
            this.login_button.BorderRadius = 23;
            this.login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_button.FillColor2 = System.Drawing.Color.SlateBlue;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(164, 224);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(353, 48);
            this.login_button.TabIndex = 20;
            this.login_button.Text = " Giriş";
            this.login_button.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(256, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giriş Yap";
            // 
            // login_message
            // 
            this.login_message.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.login_message.Caption = null;
            this.login_message.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.login_message.Parent = this;
            this.login_message.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.login_message.Text = null;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Tomato;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(620, 5);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(42, 27);
            this.guna2ControlBox1.TabIndex = 5;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BorderRadius = 5;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(572, 5);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(42, 27);
            this.guna2ControlBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giriş";
            // 
            // kayit_panel
            // 
            this.kayit_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kayit_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.kayit_panel.Controls.Add(this.guna2PictureBox2);
            this.kayit_panel.Controls.Add(this.kayit_txt_ad);
            this.kayit_panel.Controls.Add(this.kayit_txt_username);
            this.kayit_panel.Controls.Add(this.kayit_txt_password);
            this.kayit_panel.Controls.Add(this.guna2GradientButton1);
            this.kayit_panel.Controls.Add(this.label5);
            this.kayit_panel.Location = new System.Drawing.Point(0, 32);
            this.kayit_panel.Name = "kayit_panel";
            this.kayit_panel.Size = new System.Drawing.Size(667, 339);
            this.kayit_panel.TabIndex = 25;
            this.kayit_panel.Visible = false;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 23;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.SlateBlue;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(161, 253);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(353, 48);
            this.guna2GradientButton1.TabIndex = 20;
            this.guna2GradientButton1.Text = "Kayıt";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(267, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 45);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kayıt Ol";
            // 
            // kayit_txt_password
            // 
            this.kayit_txt_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kayit_txt_password.Animated = true;
            this.kayit_txt_password.AutoRoundedCorners = true;
            this.kayit_txt_password.BorderRadius = 16;
            this.kayit_txt_password.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.kayit_txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kayit_txt_password.DefaultText = "";
            this.kayit_txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kayit_txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kayit_txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kayit_txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kayit_txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kayit_txt_password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit_txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kayit_txt_password.IconLeft = ((System.Drawing.Image)(resources.GetObject("kayit_txt_password.IconLeft")));
            this.kayit_txt_password.Location = new System.Drawing.Point(344, 187);
            this.kayit_txt_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kayit_txt_password.MaxLength = 40;
            this.kayit_txt_password.Name = "kayit_txt_password";
            this.kayit_txt_password.Padding = new System.Windows.Forms.Padding(20);
            this.kayit_txt_password.PasswordChar = '●';
            this.kayit_txt_password.PlaceholderText = "Şifre";
            this.kayit_txt_password.SelectedText = "";
            this.kayit_txt_password.Size = new System.Drawing.Size(240, 34);
            this.kayit_txt_password.TabIndex = 46;
            this.kayit_txt_password.UseSystemPasswordChar = true;
            // 
            // kayit_txt_username
            // 
            this.kayit_txt_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kayit_txt_username.Animated = true;
            this.kayit_txt_username.AutoRoundedCorners = true;
            this.kayit_txt_username.BorderRadius = 16;
            this.kayit_txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kayit_txt_username.DefaultText = "";
            this.kayit_txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kayit_txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kayit_txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kayit_txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kayit_txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kayit_txt_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.kayit_txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kayit_txt_username.IconLeft = ((System.Drawing.Image)(resources.GetObject("kayit_txt_username.IconLeft")));
            this.kayit_txt_username.Location = new System.Drawing.Point(83, 187);
            this.kayit_txt_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kayit_txt_username.MaxLength = 40;
            this.kayit_txt_username.Name = "kayit_txt_username";
            this.kayit_txt_username.Padding = new System.Windows.Forms.Padding(20);
            this.kayit_txt_username.PasswordChar = '\0';
            this.kayit_txt_username.PlaceholderText = "Kullanıcı Adı";
            this.kayit_txt_username.SelectedText = "";
            this.kayit_txt_username.Size = new System.Drawing.Size(240, 34);
            this.kayit_txt_username.TabIndex = 45;
            // 
            // kayit_txt_ad
            // 
            this.kayit_txt_ad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kayit_txt_ad.Animated = true;
            this.kayit_txt_ad.BorderRadius = 16;
            this.kayit_txt_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kayit_txt_ad.DefaultText = "";
            this.kayit_txt_ad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kayit_txt_ad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kayit_txt_ad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kayit_txt_ad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kayit_txt_ad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kayit_txt_ad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit_txt_ad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kayit_txt_ad.IconLeft = ((System.Drawing.Image)(resources.GetObject("kayit_txt_ad.IconLeft")));
            this.kayit_txt_ad.Location = new System.Drawing.Point(224, 121);
            this.kayit_txt_ad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kayit_txt_ad.MaxLength = 49;
            this.kayit_txt_ad.Name = "kayit_txt_ad";
            this.kayit_txt_ad.PasswordChar = '\0';
            this.kayit_txt_ad.PlaceholderText = "Ad Soyad";
            this.kayit_txt_ad.SelectedText = "";
            this.kayit_txt_ad.Size = new System.Drawing.Size(240, 37);
            this.kayit_txt_ad.TabIndex = 44;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(2, 14);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(47, 47);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 45;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.AutoRoundedCorners = true;
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderRadius = 14;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.SlateBlue;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(271, 279);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(153, 30);
            this.guna2GradientButton2.TabIndex = 26;
            this.guna2GradientButton2.Text = "Kayıt Ol";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(667, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kayit_panel);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.giris_panel);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.giris_panel.ResumeLayout(false);
            this.giris_panel.PerformLayout();
            this.kayit_panel.ResumeLayout(false);
            this.kayit_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel giris_panel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox login_text_password;
        public Guna.UI2.WinForms.Guna2TextBox login_txt_username;
        private Guna.UI2.WinForms.Guna2GradientButton login_button;
        private Guna.UI2.WinForms.Guna2ToggleSwitch benihatirla;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2MessageDialog login_message;
        private Guna.UI2.WinForms.Guna2Panel kayit_panel;
        private Guna.UI2.WinForms.Guna2TextBox kayit_txt_ad;
        public Guna.UI2.WinForms.Guna2TextBox kayit_txt_username;
        public Guna.UI2.WinForms.Guna2TextBox kayit_txt_password;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
    }
}

