
namespace gorselProjeBunifu
{
    partial class tum_sporcular
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.kimlik_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyet = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dogum_tarihi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.meslek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kan_grubu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.boy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sms_izin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.arama_izin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mail_izin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uyelik_tipi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kimlik_no,
            this.Ad,
            this.soyad,
            this.cinsiyet,
            this.dogum_tarihi,
            this.meslek,
            this.kan_grubu,
            this.boy,
            this.kilo,
            this.email,
            this.cep_no,
            this.adres,
            this.sms_izin,
            this.arama_izin,
            this.mail_izin,
            this.uyelik_tipi});
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(673, 476);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // kimlik_no
            // 
            this.kimlik_no.HeaderText = "Kimlik No";
            this.kimlik_no.Name = "kimlik_no";
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            // 
            // soyad
            // 
            this.soyad.HeaderText = "Soyad";
            this.soyad.Name = "soyad";
            // 
            // cinsiyet
            // 
            this.cinsiyet.HeaderText = "Cinsiyet";
            this.cinsiyet.Name = "cinsiyet";
            // 
            // dogum_tarihi
            // 
            this.dogum_tarihi.HeaderText = "Doğum Tarihi";
            this.dogum_tarihi.Name = "dogum_tarihi";
            // 
            // meslek
            // 
            this.meslek.HeaderText = "Meslek";
            this.meslek.Name = "meslek";
            // 
            // kan_grubu
            // 
            this.kan_grubu.HeaderText = "Kan Grubu";
            this.kan_grubu.Name = "kan_grubu";
            // 
            // boy
            // 
            this.boy.HeaderText = "Boy";
            this.boy.Name = "boy";
            // 
            // kilo
            // 
            this.kilo.HeaderText = "Kilo";
            this.kilo.Name = "kilo";
            // 
            // email
            // 
            this.email.HeaderText = "E-Posta";
            this.email.Name = "email";
            // 
            // cep_no
            // 
            this.cep_no.HeaderText = "Cep Telefonu";
            this.cep_no.Name = "cep_no";
            // 
            // adres
            // 
            this.adres.HeaderText = "Adres";
            this.adres.Name = "adres";
            // 
            // sms_izin
            // 
            this.sms_izin.HeaderText = "Sms İzni";
            this.sms_izin.Name = "sms_izin";
            // 
            // arama_izin
            // 
            this.arama_izin.HeaderText = "Arama İzni";
            this.arama_izin.Name = "arama_izin";
            // 
            // mail_izin
            // 
            this.mail_izin.HeaderText = "E-Posta İzni";
            this.mail_izin.Name = "mail_izin";
            // 
            // uyelik_tipi
            // 
            this.uyelik_tipi.HeaderText = "Üyelik Tipi";
            this.uyelik_tipi.Name = "uyelik_tipi";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tum_sporcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 476);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tum_sporcular";
            this.Text = "tum_sporcular";
            this.Load += new System.EventHandler(this.tum_sporcular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn kimlik_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewComboBoxColumn cinsiyet;
        private System.Windows.Forms.DataGridViewComboBoxColumn dogum_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn meslek;
        private System.Windows.Forms.DataGridViewComboBoxColumn kan_grubu;
        private System.Windows.Forms.DataGridViewTextBoxColumn boy;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sms_izin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn arama_izin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mail_izin;
        private System.Windows.Forms.DataGridViewComboBoxColumn uyelik_tipi;
        public Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Timer timer1;
    }
}