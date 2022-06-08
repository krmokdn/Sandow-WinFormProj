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
    public partial class b2b_magaza : Form
    {

        public b2b_magaza()
        {
            InitializeComponent();
        }
        int sayı = 0;
        int para = 879;
        int hesap;
        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void satınal_buton_Click(object sender, EventArgs e)
        {
            satınal_form satınal = new satınal_form();
            satınal.Show();
        }
      
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            hardlineprotein_adet.Text = sayı++.ToString();
            hesap = para * sayı;
            hardlineprotein_fiyat.Text = hesap.ToString();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            hardlineprotein_adet.Text = sayı--.ToString();
            hesap = para * sayı;
            hardlineprotein_fiyat.Text = hesap.ToString();
        }
    }
}
