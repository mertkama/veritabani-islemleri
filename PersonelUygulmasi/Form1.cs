using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelUygulmasi
{
    public partial class Form1 : Form
    {

        BusinessLogicLayer bll;
        
        public Form1()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int girisSayisi = bll.SistemGirisKontrol(txtKAdi.Text, txtSifre.Text);

            if (girisSayisi > 0)
            {
                //MessageBox.Show("Giriş Başarılı");
                AnaForm form = new AnaForm();

                form.Show();
            }
            else if (girisSayisi == -100)
            {
                MessageBox.Show("Eksik giriş tekrar kontrol ediniz.");
            }
            else
                MessageBox.Show("Hata oluştu. Tekrar deneyiniz");
        }
    }
}
