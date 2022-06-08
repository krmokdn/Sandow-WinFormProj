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
    public partial class satınal_form : Form
    {
        public satınal_form()
        {
            InitializeComponent();
        }

        private void email_txt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            siparisiniz_alındı_label.Visible = true;
            green_tick.Visible = true;
            this.Hide();
        }
    }
}
