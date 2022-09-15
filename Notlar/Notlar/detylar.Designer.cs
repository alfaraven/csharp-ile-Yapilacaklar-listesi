namespace Notlar
{
    partial class detylar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblisim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yp_yap = new System.Windows.Forms.Label();
            this.yp_yapma = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.nt_yapma = new System.Windows.Forms.Label();
            this.nt_yap = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Tomato;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(208, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(37, 26);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblisim
            // 
            this.lblisim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblisim.Font = new System.Drawing.Font("Segoe UI Black", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblisim.Location = new System.Drawing.Point(-1, 37);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(247, 30);
            this.lblisim.TabIndex = 1;
            this.lblisim.Text = "Ad Soyad";
            this.lblisim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblisim.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(56, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yapılacaklar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Location = new System.Drawing.Point(-8, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 5);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yapılmış:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(2, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yapılmamış:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yp_yap
            // 
            this.yp_yap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yp_yap.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold);
            this.yp_yap.Location = new System.Drawing.Point(117, 259);
            this.yp_yap.Name = "yp_yap";
            this.yp_yap.Size = new System.Drawing.Size(86, 22);
            this.yp_yap.TabIndex = 6;
            this.yp_yap.Text = "0";
            this.yp_yap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yp_yapma
            // 
            this.yp_yapma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yp_yapma.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold);
            this.yp_yapma.Location = new System.Drawing.Point(116, 296);
            this.yp_yapma.Name = "yp_yapma";
            this.yp_yapma.Size = new System.Drawing.Size(86, 22);
            this.yp_yapma.TabIndex = 7;
            this.yp_yapma.Text = "0";
            this.yp_yapma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Location = new System.Drawing.Point(-8, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 5);
            this.panel2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 14.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(56, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 33);
            this.label6.TabIndex = 8;
            this.label6.Text = "Notlarım";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nt_yapma
            // 
            this.nt_yapma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nt_yapma.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold);
            this.nt_yapma.Location = new System.Drawing.Point(116, 453);
            this.nt_yapma.Name = "nt_yapma";
            this.nt_yapma.Size = new System.Drawing.Size(86, 22);
            this.nt_yapma.TabIndex = 13;
            this.nt_yapma.Text = "0";
            this.nt_yapma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nt_yap
            // 
            this.nt_yap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nt_yap.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold);
            this.nt_yap.Location = new System.Drawing.Point(117, 416);
            this.nt_yap.Name = "nt_yap";
            this.nt_yap.Size = new System.Drawing.Size(86, 22);
            this.nt_yap.TabIndex = 12;
            this.nt_yap.Text = "0";
            this.nt_yap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(2, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Yapılmamış:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(3, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Yapılmış:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SkyBlue;
            this.label4.Location = new System.Drawing.Point(75, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Detaylar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(-8, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 30);
            this.label11.TabIndex = 18;
            this.label11.Text = "00:00:00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Location = new System.Drawing.Point(-8, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 5);
            this.panel3.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 14.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label12.Location = new System.Drawing.Point(31, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 33);
            this.label12.TabIndex = 16;
            this.label12.Text = "Çalışma Zamanı";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_btn
            // 
            this.timer_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timer_btn.BorderRadius = 5;
            this.timer_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.timer_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.timer_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.timer_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.timer_btn.FillColor = System.Drawing.Color.DodgerBlue;
            this.timer_btn.Font = new System.Drawing.Font("Segoe UI Black", 12.75F, System.Drawing.FontStyle.Bold);
            this.timer_btn.ForeColor = System.Drawing.Color.White;
            this.timer_btn.Location = new System.Drawing.Point(12, 169);
            this.timer_btn.Name = "timer_btn";
            this.timer_btn.Size = new System.Drawing.Size(107, 25);
            this.timer_btn.TabIndex = 19;
            this.timer_btn.Text = "Panel";
            this.timer_btn.Click += new System.EventHandler(this.timer_btn_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.ForestGreen;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Black", 8.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(136, 169);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(107, 25);
            this.guna2Button3.TabIndex = 20;
            this.guna2Button3.Text = "Gün Bittir";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
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
            // detylar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(248, 517);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.timer_btn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nt_yapma);
            this.Controls.Add(this.nt_yap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yp_yapma);
            this.Controls.Add(this.yp_yap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblisim);
            this.Controls.Add(this.guna2Button1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "detylar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "detylar";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.detylar_FormClosed);
            this.Load += new System.EventHandler(this.detylar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblisim;
        public System.Windows.Forms.Label nt_yapma;
        public System.Windows.Forms.Label nt_yap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label yp_yapma;
        public System.Windows.Forms.Label yp_yap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button timer_btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}