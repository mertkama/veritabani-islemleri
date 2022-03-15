using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaglantiBilgisi
{
    public partial class Form1 : Form
    {
        DataAccessLayer dal;
        public Form1()
        {
            InitializeComponent();
            dal = new DataAccessLayer("", "", "", "");
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            dal = new DataAccessLayer(txtDataSource.Text, txtCatalog.Text, txtKAdi.Text, txtSifre.Text);

            dal.BaglantiDurumYonetimi();

            lblSonuc.Text = dal.BaglantiDurumBilgisi().ToString();
        }
    }
}
