using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NKatmaliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BussinessLogicLayer bll = new BussinessLogicLayer();

            int sonuc= bll.Kaydet(new Musteri {
                MusteriId=Convert.ToInt32(txtId.Text),
                Ad=txtAd.Text,
                Soyad=txtSoyad.Text
            });

            if (sonuc > 0)
                MessageBox.Show("Başarıyla Kaydedildi.");
            else
                MessageBox.Show("Kaydederken bir hata oluştu.");
        }
    }
}
