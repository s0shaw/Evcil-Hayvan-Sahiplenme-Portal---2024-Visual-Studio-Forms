namespace PetAdoptionForm
{
    partial class Form1
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.lgn_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbtn_admin = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbtn_adoptee = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbtn_adopter = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.lgn_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_login = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.SystemColors.MenuHighlight;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // lgn_username
            // 
            this.lgn_username.Animated = true;
            this.lgn_username.AutoRoundedCorners = true;
            this.lgn_username.BorderRadius = 23;
            this.lgn_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lgn_username.DefaultText = "";
            this.lgn_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lgn_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lgn_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lgn_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lgn_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lgn_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lgn_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lgn_username.Location = new System.Drawing.Point(340, 386);
            this.lgn_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lgn_username.Name = "lgn_username";
            this.lgn_username.PasswordChar = '\0';
            this.lgn_username.PlaceholderText = "Kullanici Adi";
            this.lgn_username.SelectedText = "";
            this.lgn_username.Size = new System.Drawing.Size(229, 48);
            this.lgn_username.TabIndex = 5;
            // 
            // rbtn_admin
            // 
            this.rbtn_admin.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_admin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_admin.CheckedState.BorderThickness = 0;
            this.rbtn_admin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_admin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtn_admin.Location = new System.Drawing.Point(215, 310);
            this.rbtn_admin.Name = "rbtn_admin";
            this.rbtn_admin.Size = new System.Drawing.Size(20, 20);
            this.rbtn_admin.TabIndex = 6;
            this.rbtn_admin.Text = "Admin";
            this.rbtn_admin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_admin.UncheckedState.BorderThickness = 2;
            this.rbtn_admin.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_admin.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtn_admin.CheckedChanged += new System.EventHandler(this.rbtn_admin_CheckedChanged);
            // 
            // rbtn_adoptee
            // 
            this.rbtn_adoptee.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_adoptee.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_adoptee.CheckedState.BorderThickness = 0;
            this.rbtn_adoptee.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_adoptee.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtn_adoptee.Location = new System.Drawing.Point(440, 310);
            this.rbtn_adoptee.Name = "rbtn_adoptee";
            this.rbtn_adoptee.Size = new System.Drawing.Size(20, 20);
            this.rbtn_adoptee.TabIndex = 7;
            this.rbtn_adoptee.Text = "Admin";
            this.rbtn_adoptee.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_adoptee.UncheckedState.BorderThickness = 2;
            this.rbtn_adoptee.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_adoptee.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtn_adoptee.CheckedChanged += new System.EventHandler(this.rbtn_adoptee_CheckedChanged);
            // 
            // rbtn_adopter
            // 
            this.rbtn_adopter.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_adopter.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_adopter.CheckedState.BorderThickness = 0;
            this.rbtn_adopter.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_adopter.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtn_adopter.Location = new System.Drawing.Point(682, 310);
            this.rbtn_adopter.Name = "rbtn_adopter";
            this.rbtn_adopter.Size = new System.Drawing.Size(20, 20);
            this.rbtn_adopter.TabIndex = 8;
            this.rbtn_adopter.Text = "Admin";
            this.rbtn_adopter.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_adopter.UncheckedState.BorderThickness = 2;
            this.rbtn_adopter.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_adopter.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtn_adopter.CheckedChanged += new System.EventHandler(this.rbtn_adopter_CheckedChanged);
            // 
            // lgn_password
            // 
            this.lgn_password.Animated = true;
            this.lgn_password.AutoRoundedCorners = true;
            this.lgn_password.BorderRadius = 23;
            this.lgn_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lgn_password.DefaultText = "";
            this.lgn_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lgn_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lgn_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lgn_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lgn_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lgn_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lgn_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lgn_password.Location = new System.Drawing.Point(340, 456);
            this.lgn_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lgn_password.Name = "lgn_password";
            this.lgn_password.PasswordChar = '\0';
            this.lgn_password.PlaceholderText = "Sifre";
            this.lgn_password.SelectedText = "";
            this.lgn_password.Size = new System.Drawing.Size(229, 48);
            this.lgn_password.TabIndex = 9;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(49, 53);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverDarkMode;
            this.kryptonLabel1.Size = new System.Drawing.Size(714, 72);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 10;
            this.kryptonLabel1.Values.Text = "Evcil Hayvan Sahiplendirme Portalı";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(198, 336);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(56, 24);
            this.kryptonLabel2.TabIndex = 11;
            this.kryptonLabel2.Values.Text = "Admin";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(408, 336);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(87, 24);
            this.kryptonLabel3.TabIndex = 12;
            this.kryptonLabel3.Values.Text = "Sahiplenen";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(644, 336);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(105, 24);
            this.kryptonLabel4.TabIndex = 13;
            this.kryptonLabel4.Values.Text = "Sahiplendiren";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Admin dışındaki kullanıcılar sadece kullanıcı adı girerek giriş yapacaktır. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Şifre";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::PetAdoptionForm.Properties.Resources.icons8_exit;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(801, 449);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(91, 85);
            this.guna2ImageButton1.TabIndex = 17;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.HoverState.Image = global::PetAdoptionForm.Properties.Resources.pawprint;
            this.btn_login.HoverState.ImageSize = new System.Drawing.Size(128, 128);
            this.btn_login.Image = global::PetAdoptionForm.Properties.Resources.pawprint;
            this.btn_login.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_login.ImageRotate = 0F;
            this.btn_login.ImageSize = new System.Drawing.Size(128, 128);
            this.btn_login.IndicateFocus = true;
            this.btn_login.Location = new System.Drawing.Point(340, 131);
            this.btn_login.Name = "btn_login";
            this.btn_login.PressedState.Image = global::PetAdoptionForm.Properties.Resources.pawprint;
            this.btn_login.PressedState.ImageSize = new System.Drawing.Size(100, 100);
            this.btn_login.Size = new System.Drawing.Size(229, 179);
            this.btn_login.TabIndex = 4;
            this.btn_login.UseTransparentBackground = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(825, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Çıkış";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 578);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.lgn_password);
            this.Controls.Add(this.rbtn_adopter);
            this.Controls.Add(this.rbtn_adoptee);
            this.Controls.Add(this.rbtn_admin);
            this.Controls.Add(this.lgn_username);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_login;
        private Guna.UI2.WinForms.Guna2TextBox lgn_username;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbtn_admin;
        private Guna.UI2.WinForms.Guna2TextBox lgn_password;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbtn_adopter;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbtn_adoptee;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

