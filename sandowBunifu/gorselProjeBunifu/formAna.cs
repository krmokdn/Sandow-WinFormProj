using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselProjeBunifu
{
    public partial class formAna : Form
    {
        public formAna()
        {
            InitializeComponent();
        }

        private void FormGetir(Form frm) //panel içine form yerleştirme methodu 
        {
            anaPanel.Controls.Clear(); // formlar üst üste gelmesin diye paneli ilkte temizledik
            frm.MdiParent = this; // form içinde form açmak için
            frm.FormBorderStyle = FormBorderStyle.None; //borderları kaldırdık
            anaPanel.Controls.Add(frm); //panele form değişkenini ekledik
            frm.Show(); // son olarak formu göster dedik
            //
            // getirireceğimiz form panelin içine tam oturması için formu açarken panelle aynı boyutta açıyoruz.
            // panel boyutu: 673*476
        }


        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void yeni_sporcu_buton_Click(object sender, EventArgs e)
        {
            yeni_sporcu ekle = new yeni_sporcu();
            FormGetir(ekle);
        }

        private void b2b_magaza_buton_Click(object sender, EventArgs e)
        {
            b2b_magaza magaza = new b2b_magaza();
            FormGetir(magaza);
        }

        private void stok_kontrol_buton_Click(object sender, EventArgs e)
        {
            stok_kontrol kontol = new stok_kontrol();
            FormGetir(kontol);
        }

        private void tum_sporcular_buton_Click(object sender, EventArgs e)
        {
            tum_sporcular hepsi = new tum_sporcular();
            FormGetir(hepsi);
        }

        private void cık_buton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formAna_Load(object sender, EventArgs e)
        {
            anaDashboard dashboard = new anaDashboard();
            FormGetir(dashboard);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            anaDashboard dashboard = new anaDashboard();
            FormGetir(dashboard);
        }

        private void program_ekle_buton_Click(object sender, EventArgs e)
        {
            program_ekle program = new program_ekle();
            FormGetir(program);
        }
    }
}
