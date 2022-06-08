
namespace gorselProjeBunifu
{
    partial class yeni_sporcu
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
            this.ad_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.soyad_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cinsiyet_dropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.dogum_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.meslek_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.kan_dropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.uyelik_dropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.kimlik_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.email_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cepno_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.adres_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sms_checkbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.email_checkbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.sms_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.email_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.arama_checkbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.arama_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.izinler_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.kaydet_buton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.temizle_buton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // ad_txt
            // 
            this.ad_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ad_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ad_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ad_txt.HintForeColor = System.Drawing.Color.Gray;
            this.ad_txt.HintText = "Ad ";
            this.ad_txt.isPassword = false;
            this.ad_txt.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.ad_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.ad_txt.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.ad_txt.LineThickness = 2;
            this.ad_txt.Location = new System.Drawing.Point(53, 137);
            this.ad_txt.Margin = new System.Windows.Forms.Padding(4);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(236, 31);
            this.ad_txt.TabIndex = 1;
            this.ad_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ad_txt.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // soyad_txt
            // 
            this.soyad_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soyad_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.soyad_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.soyad_txt.HintForeColor = System.Drawing.Color.Gray;
            this.soyad_txt.HintText = "Soyad";
            this.soyad_txt.isPassword = false;
            this.soyad_txt.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.soyad_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.soyad_txt.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.soyad_txt.LineThickness = 2;
            this.soyad_txt.Location = new System.Drawing.Point(53, 192);
            this.soyad_txt.Margin = new System.Windows.Forms.Padding(4);
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.Size = new System.Drawing.Size(236, 31);
            this.soyad_txt.TabIndex = 2;
            this.soyad_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.soyad_txt.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // cinsiyet_dropdown
            // 
            this.cinsiyet_dropdown.BackColor = System.Drawing.Color.Transparent;
            this.cinsiyet_dropdown.BorderRadius = 5;
            this.cinsiyet_dropdown.DisabledColor = System.Drawing.Color.Gray;
            this.cinsiyet_dropdown.ForeColor = System.Drawing.Color.White;
            this.cinsiyet_dropdown.Items = new string[] {
        "Cinsiyet Seçiniz",
        "Erkek",
        "Kadın"};
            this.cinsiyet_dropdown.Location = new System.Drawing.Point(52, 250);
            this.cinsiyet_dropdown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cinsiyet_dropdown.Name = "cinsiyet_dropdown";
            this.cinsiyet_dropdown.NomalColor = System.Drawing.SystemColors.Highlight;
            this.cinsiyet_dropdown.onHoverColor = System.Drawing.SystemColors.HotTrack;
            this.cinsiyet_dropdown.selectedIndex = 0;
            this.cinsiyet_dropdown.Size = new System.Drawing.Size(236, 31);
            this.cinsiyet_dropdown.TabIndex = 3;
            this.cinsiyet_dropdown.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // dogum_date
            // 
            this.dogum_date.AccessibleName = "";
            this.dogum_date.BackColor = System.Drawing.SystemColors.Highlight;
            this.dogum_date.BorderRadius = 5;
            this.dogum_date.ForeColor = System.Drawing.Color.White;
            this.dogum_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dogum_date.FormatCustom = null;
            this.dogum_date.Location = new System.Drawing.Point(53, 303);
            this.dogum_date.Name = "dogum_date";
            this.dogum_date.Size = new System.Drawing.Size(236, 31);
            this.dogum_date.TabIndex = 5;
            this.dogum_date.Value = new System.DateTime(2022, 5, 22, 0, 0, 0, 0);
            this.dogum_date.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // meslek_txt
            // 
            this.meslek_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.meslek_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.meslek_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.meslek_txt.HintForeColor = System.Drawing.Color.Gray;
            this.meslek_txt.HintText = "Meslek";
            this.meslek_txt.isPassword = false;
            this.meslek_txt.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.meslek_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.meslek_txt.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.meslek_txt.LineThickness = 2;
            this.meslek_txt.Location = new System.Drawing.Point(53, 352);
            this.meslek_txt.Margin = new System.Windows.Forms.Padding(4);
            this.meslek_txt.Name = "meslek_txt";
            this.meslek_txt.Size = new System.Drawing.Size(236, 31);
            this.meslek_txt.TabIndex = 6;
            this.meslek_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.meslek_txt.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged);
            // 
            // kan_dropdown
            // 
            this.kan_dropdown.BackColor = System.Drawing.Color.Transparent;
            this.kan_dropdown.BorderRadius = 5;
            this.kan_dropdown.DisabledColor = System.Drawing.Color.Gray;
            this.kan_dropdown.ForeColor = System.Drawing.Color.White;
            this.kan_dropdown.Items = new string[] {
        "Kan Grubu Seçiniz",
        "0 Rh+",
        "0 Rh-",
        "A Rh+",
        "A Rh-",
        "B Rh+",
        "B Rh-",
        "AB Rh+",
        "AB Rh-"};
            this.kan_dropdown.Location = new System.Drawing.Point(53, 411);
            this.kan_dropdown.Name = "kan_dropdown";
            this.kan_dropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.kan_dropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kan_dropdown.selectedIndex = 0;
            this.kan_dropdown.Size = new System.Drawing.Size(236, 31);
            this.kan_dropdown.TabIndex = 7;
            this.kan_dropdown.onItemSelected += new System.EventHandler(this.bunifuDropdown2_onItemSelected);
            // 
            // uyelik_dropdown
            // 
            this.uyelik_dropdown.BackColor = System.Drawing.Color.Transparent;
            this.uyelik_dropdown.BorderRadius = 5;
            this.uyelik_dropdown.DisabledColor = System.Drawing.Color.Gray;
            this.uyelik_dropdown.ForeColor = System.Drawing.Color.White;
            this.uyelik_dropdown.Items = new string[] {
        "Üyelik Tipi Seçiniz",
        "1 Ay",
        "3 Ay",
        "6 Ay ",
        "12 Ay"};
            this.uyelik_dropdown.Location = new System.Drawing.Point(372, 361);
            this.uyelik_dropdown.Name = "uyelik_dropdown";
            this.uyelik_dropdown.NomalColor = System.Drawing.SystemColors.Highlight;
            this.uyelik_dropdown.onHoverColor = System.Drawing.SystemColors.HotTrack;
            this.uyelik_dropdown.selectedIndex = 0;
            this.uyelik_dropdown.Size = new System.Drawing.Size(236, 31);
            this.uyelik_dropdown.TabIndex = 8;
            this.uyelik_dropdown.onItemSelected += new System.EventHandler(this.bunifuDropdown3_onItemSelected);
            // 
            // kimlik_txt
            // 
            this.kimlik_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kimlik_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.kimlik_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kimlik_txt.HintForeColor = System.Drawing.Color.Gray;
            this.kimlik_txt.HintText = "Kimlik No*";
            this.kimlik_txt.isPassword = false;
            this.kimlik_txt.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.kimlik_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.kimlik_txt.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.kimlik_txt.LineThickness = 2;
            this.kimlik_txt.Location = new System.Drawing.Point(53, 93);
            this.kimlik_txt.Margin = new System.Windows.Forms.Padding(4);
            this.kimlik_txt.Name = "kimlik_txt";
            this.kimlik_txt.Size = new System.Drawing.Size(236, 31);
            this.kimlik_txt.TabIndex = 9;
            this.kimlik_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kimlik_txt.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Boxed Regular", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(51, 23);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(213, 30);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "Yeni Sporcu Girişi";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(52, 56);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(208, 11);
            this.bunifuSeparator1.TabIndex = 11;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // email_txt
            // 
            this.email_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email_txt.HintForeColor = System.Drawing.Color.Gray;
            this.email_txt.HintText = "E-Posta";
            this.email_txt.isPassword = false;
            this.email_txt.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.email_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.email_txt.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.email_txt.LineThickness = 2;
            this.email_txt.Location = new System.Drawing.Point(372, 93);
            this.email_txt.Margin = new System.Windows.Forms.Padding(4);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(236, 31);
            this.email_txt.TabIndex = 12;
            this.email_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email_txt.OnValueChanged += new System.EventHandler(this.email_txt_OnValueChanged);
            // 
            // cepno_txt
            // 
            this.cepno_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cepno_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cepno_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cepno_txt.HintForeColor = System.Drawing.Color.Gray;
            this.cepno_txt.HintText = "Cep Telefonu";
            this.cepno_txt.isPassword = false;
            this.cepno_txt.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.cepno_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.cepno_txt.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.cepno_txt.LineThickness = 2;
            this.cepno_txt.Location = new System.Drawing.Point(372, 137);
            this.cepno_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cepno_txt.Name = "cepno_txt";
            this.cepno_txt.Size = new System.Drawing.Size(236, 31);
            this.cepno_txt.TabIndex = 13;
            this.cepno_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cepno_txt.OnValueChanged += new System.EventHandler(this.cepno_txt_OnValueChanged);
            // 
            // adres_txt
            // 
            this.adres_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adres_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.adres_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adres_txt.HintForeColor = System.Drawing.Color.Gray;
            this.adres_txt.HintText = "Adres";
            this.adres_txt.isPassword = false;
            this.adres_txt.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.adres_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.adres_txt.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.adres_txt.LineThickness = 2;
            this.adres_txt.Location = new System.Drawing.Point(373, 192);
            this.adres_txt.Margin = new System.Windows.Forms.Padding(4);
            this.adres_txt.Name = "adres_txt";
            this.adres_txt.Size = new System.Drawing.Size(236, 31);
            this.adres_txt.TabIndex = 14;
            this.adres_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adres_txt.OnValueChanged += new System.EventHandler(this.adres_txt_OnValueChanged);
            // 
            // sms_checkbox
            // 
            this.sms_checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sms_checkbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sms_checkbox.Checked = false;
            this.sms_checkbox.CheckedOnColor = System.Drawing.SystemColors.Highlight;
            this.sms_checkbox.ForeColor = System.Drawing.Color.White;
            this.sms_checkbox.Location = new System.Drawing.Point(375, 282);
            this.sms_checkbox.Name = "sms_checkbox";
            this.sms_checkbox.Size = new System.Drawing.Size(20, 20);
            this.sms_checkbox.TabIndex = 15;
            this.sms_checkbox.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // email_checkbox
            // 
            this.email_checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.email_checkbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.email_checkbox.Checked = false;
            this.email_checkbox.CheckedOnColor = System.Drawing.SystemColors.Highlight;
            this.email_checkbox.ForeColor = System.Drawing.Color.White;
            this.email_checkbox.Location = new System.Drawing.Point(375, 325);
            this.email_checkbox.Name = "email_checkbox";
            this.email_checkbox.Size = new System.Drawing.Size(20, 20);
            this.email_checkbox.TabIndex = 16;
            this.email_checkbox.OnChange += new System.EventHandler(this.bunifuCheckbox2_OnChange);
            // 
            // sms_label
            // 
            this.sms_label.AutoSize = true;
            this.sms_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sms_label.Location = new System.Drawing.Point(408, 284);
            this.sms_label.Name = "sms_label";
            this.sms_label.Size = new System.Drawing.Size(32, 17);
            this.sms_label.TabIndex = 17;
            this.sms_label.Text = "Sms";
            this.sms_label.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email_label.Location = new System.Drawing.Point(408, 327);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(55, 17);
            this.email_label.TabIndex = 18;
            this.email_label.Text = "E-Posta";
            this.email_label.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // arama_checkbox
            // 
            this.arama_checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.arama_checkbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.arama_checkbox.Checked = false;
            this.arama_checkbox.CheckedOnColor = System.Drawing.SystemColors.Highlight;
            this.arama_checkbox.ForeColor = System.Drawing.Color.White;
            this.arama_checkbox.Location = new System.Drawing.Point(506, 282);
            this.arama_checkbox.Name = "arama_checkbox";
            this.arama_checkbox.Size = new System.Drawing.Size(20, 20);
            this.arama_checkbox.TabIndex = 19;
            this.arama_checkbox.OnChange += new System.EventHandler(this.bunifuCheckbox3_OnChange);
            // 
            // arama_label
            // 
            this.arama_label.AutoSize = true;
            this.arama_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama_label.Location = new System.Drawing.Point(532, 284);
            this.arama_label.Name = "arama_label";
            this.arama_label.Size = new System.Drawing.Size(52, 17);
            this.arama_label.TabIndex = 20;
            this.arama_label.Text = "Arama";
            this.arama_label.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // izinler_label
            // 
            this.izinler_label.AutoSize = true;
            this.izinler_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.izinler_label.Location = new System.Drawing.Point(371, 244);
            this.izinler_label.Name = "izinler_label";
            this.izinler_label.Size = new System.Drawing.Size(43, 17);
            this.izinler_label.TabIndex = 21;
            this.izinler_label.Text = "İzinler";
            this.izinler_label.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(372, 257);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(40, 11);
            this.bunifuSeparator2.TabIndex = 22;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            this.bunifuSeparator2.Load += new System.EventHandler(this.bunifuSeparator2_Load);
            // 
            // kaydet_buton
            // 
            this.kaydet_buton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.kaydet_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.kaydet_buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kaydet_buton.BorderRadius = 5;
            this.kaydet_buton.ButtonText = "Kaydet";
            this.kaydet_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaydet_buton.DisabledColor = System.Drawing.Color.Gray;
            this.kaydet_buton.Iconcolor = System.Drawing.Color.Transparent;
            this.kaydet_buton.Iconimage = null;
            this.kaydet_buton.Iconimage_right = null;
            this.kaydet_buton.Iconimage_right_Selected = null;
            this.kaydet_buton.Iconimage_Selected = null;
            this.kaydet_buton.IconMarginLeft = 0;
            this.kaydet_buton.IconMarginRight = 0;
            this.kaydet_buton.IconRightVisible = true;
            this.kaydet_buton.IconRightZoom = 0D;
            this.kaydet_buton.IconVisible = true;
            this.kaydet_buton.IconZoom = 90D;
            this.kaydet_buton.IsTab = false;
            this.kaydet_buton.Location = new System.Drawing.Point(494, 411);
            this.kaydet_buton.Name = "kaydet_buton";
            this.kaydet_buton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.kaydet_buton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.kaydet_buton.OnHoverTextColor = System.Drawing.Color.White;
            this.kaydet_buton.selected = false;
            this.kaydet_buton.Size = new System.Drawing.Size(115, 31);
            this.kaydet_buton.TabIndex = 23;
            this.kaydet_buton.Text = "Kaydet";
            this.kaydet_buton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kaydet_buton.Textcolor = System.Drawing.Color.White;
            this.kaydet_buton.TextFont = new System.Drawing.Font("Cocogoose", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet_buton.Click += new System.EventHandler(this.kaydet_buton_Click);
            // 
            // temizle_buton
            // 
            this.temizle_buton.Activecolor = System.Drawing.Color.Black;
            this.temizle_buton.BackColor = System.Drawing.Color.Gray;
            this.temizle_buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.temizle_buton.BorderRadius = 5;
            this.temizle_buton.ButtonText = "temizle";
            this.temizle_buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temizle_buton.DisabledColor = System.Drawing.Color.Gray;
            this.temizle_buton.Iconcolor = System.Drawing.Color.Transparent;
            this.temizle_buton.Iconimage = null;
            this.temizle_buton.Iconimage_right = null;
            this.temizle_buton.Iconimage_right_Selected = null;
            this.temizle_buton.Iconimage_Selected = null;
            this.temizle_buton.IconMarginLeft = 0;
            this.temizle_buton.IconMarginRight = 0;
            this.temizle_buton.IconRightVisible = true;
            this.temizle_buton.IconRightZoom = 0D;
            this.temizle_buton.IconVisible = true;
            this.temizle_buton.IconZoom = 90D;
            this.temizle_buton.IsTab = false;
            this.temizle_buton.Location = new System.Drawing.Point(375, 411);
            this.temizle_buton.Name = "temizle_buton";
            this.temizle_buton.Normalcolor = System.Drawing.Color.Gray;
            this.temizle_buton.OnHovercolor = System.Drawing.Color.Black;
            this.temizle_buton.OnHoverTextColor = System.Drawing.Color.White;
            this.temizle_buton.selected = false;
            this.temizle_buton.Size = new System.Drawing.Size(115, 31);
            this.temizle_buton.TabIndex = 24;
            this.temizle_buton.Text = "temizle";
            this.temizle_buton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.temizle_buton.Textcolor = System.Drawing.Color.White;
            this.temizle_buton.TextFont = new System.Drawing.Font("Cocogoose", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.HintText = "Boy";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuMaterialTextbox1.LineThickness = 2;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(372, 37);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(110, 31);
            this.bunifuMaterialTextbox1.TabIndex = 25;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.HintText = "Kilo";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuMaterialTextbox2.LineThickness = 2;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(498, 37);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(110, 31);
            this.bunifuMaterialTextbox2.TabIndex = 26;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // yeni_sporcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 476);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.temizle_buton);
            this.Controls.Add(this.kaydet_buton);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.izinler_label);
            this.Controls.Add(this.arama_label);
            this.Controls.Add(this.arama_checkbox);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.sms_label);
            this.Controls.Add(this.email_checkbox);
            this.Controls.Add(this.sms_checkbox);
            this.Controls.Add(this.adres_txt);
            this.Controls.Add(this.cepno_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.kimlik_txt);
            this.Controls.Add(this.uyelik_dropdown);
            this.Controls.Add(this.kan_dropdown);
            this.Controls.Add(this.meslek_txt);
            this.Controls.Add(this.dogum_date);
            this.Controls.Add(this.cinsiyet_dropdown);
            this.Controls.Add(this.soyad_txt);
            this.Controls.Add(this.ad_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yeni_sporcu";
            this.Text = "yeni_sporcu";
            this.Load += new System.EventHandler(this.yeni_sporcu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel sms_label;
        private Bunifu.Framework.UI.BunifuCustomLabel email_label;
        private Bunifu.Framework.UI.BunifuCustomLabel arama_label;
        private Bunifu.Framework.UI.BunifuCustomLabel izinler_label;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox ad_txt;
        public Bunifu.Framework.UI.BunifuMaterialTextbox soyad_txt;
        public Bunifu.Framework.UI.BunifuDropdown cinsiyet_dropdown;
        public Bunifu.Framework.UI.BunifuDatepicker dogum_date;
        public Bunifu.Framework.UI.BunifuMaterialTextbox meslek_txt;
        public Bunifu.Framework.UI.BunifuDropdown kan_dropdown;
        public Bunifu.Framework.UI.BunifuDropdown uyelik_dropdown;
        public Bunifu.Framework.UI.BunifuMaterialTextbox kimlik_txt;
        public Bunifu.Framework.UI.BunifuMaterialTextbox email_txt;
        public Bunifu.Framework.UI.BunifuMaterialTextbox cepno_txt;
        public Bunifu.Framework.UI.BunifuMaterialTextbox adres_txt;
        public Bunifu.Framework.UI.BunifuCheckbox sms_checkbox;
        public Bunifu.Framework.UI.BunifuCheckbox email_checkbox;
        public Bunifu.Framework.UI.BunifuCheckbox arama_checkbox;
        public Bunifu.Framework.UI.BunifuFlatButton kaydet_buton;
        public Bunifu.Framework.UI.BunifuFlatButton temizle_buton;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
    }
}