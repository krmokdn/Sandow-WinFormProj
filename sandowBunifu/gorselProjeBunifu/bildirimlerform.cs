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
    public partial class bildirimlerform : Form
    {
        public bildirimlerform()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            basarılı basarılı = new basarılı();
            basarılı.Show();  // form2 göster diyoruz
            this.Hide();   // bu yani form1 gizle diyoruz
        }
    }
}
