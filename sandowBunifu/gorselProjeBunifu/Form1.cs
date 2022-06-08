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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (nicname_textbox.Text== "demo" && pass_textbox.Text =="sandowtrial" )
            {
                formAna frm = new formAna();
                frm.Show();
                this.Hide();
                
      

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (bunifuCustomLabel1.Visible == false)
            {
                bunifuCustomLabel1.Visible = true;
            }
            else
            {
                bunifuCustomLabel1.Visible = false;
            }


        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pass_textbox.isPassword==false)
            {
                pass_textbox.isPassword = true;
            }
            else
            {
                pass_textbox.isPassword = false;
            }
        }

        private void nicname_textbox_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nicname_textbox_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
