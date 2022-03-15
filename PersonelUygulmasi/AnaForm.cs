using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelUygulmasi
{
    public partial class AnaForm : Form
    {
        BusinessLogicLayer bll;

        public AnaForm()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int etkilenenKayit = bll.PersonelEkle(Guid.NewGuid(), txtIsim.Text, txtSoyisim.Text, txtEmail.Text, txtTelefon.Text);

            if (etkilenenKayit > 0)
            {
                MessageBox.Show("Kayıt Eklendi");
                PersonelDoldur();
            }                
            else if (etkilenenKayit == -100)
                MessageBox.Show("Eksik bilgi");
            else
                MessageBox.Show("Kaydedilirken bir hata oluştu.");
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            PersonelDoldur();
        }


        private void PersonelDoldur()
        {
            List<Personel> personelListesi = bll.PersonelTumListe();

            lbPersonel.DataSource = personelListesi;
        }

        private void lbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = (ListBox)sender;

            Personel listPersonel = (Personel)list.SelectedItem;

            Personel dbPersonel = bll.PersonelGetir(listPersonel.PersonelId);

            if (dbPersonel != null)
            {
                txtEmailSD.Text = dbPersonel.EmailAddres;
                txtIsimSD.Text = dbPersonel.Isim;
                txtSoyisimSD.Text = dbPersonel.Soyisim;
                txtTelefonSD.Text = dbPersonel.Telefon;                
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Guid personelId = ((Personel)lbPersonel.SelectedItem).PersonelId;

            int kayitSayisi = bll.PersonelGuncelle(personelId, txtIsimSD.Text, txtSoyisimSD.Text, txtEmailSD.Text, txtTelefonSD.Text);

            if (kayitSayisi > 0)
            {
                MessageBox.Show("Kayıt Güncellendi");
                PersonelDoldur();
            }
            else
                MessageBox.Show("Güncelleme sırasında bir hata oluştu.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Kaydı Silmek istediğinize emin misiniz ?","Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (cevap == DialogResult.OK)
            {
                Personel personel = (Personel)lbPersonel.SelectedItem;
                int etkilenenKayitSayisi = bll.PersonelSil(personel.PersonelId);

                if (etkilenenKayitSayisi > 0)
                {
                    MessageBox.Show("Kayıt silindi");
                    PersonelDoldur();
                }
            }
            else
            {
                MessageBox.Show("İşlem kullanıcı tarafından iptal edildi");
            }
        }

        private void btnTestKayitEkle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                bll.PersonelEkle(Guid.NewGuid(), FakeData.NameData.GetFirstName(), FakeData.NameData.GetSurname(), FakeData.NetworkData.GetEmail(), FakeData.PhoneNumberData.GetPhoneNumber());
            }

            PersonelDoldur();

        }

        private void btnJsonAl_Click(object sender, EventArgs e)
        {
            List<Personel> list = new List<Personel>();


            list = bll.PersonelTumListe();
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(list);

            File.WriteAllText(@"C:\Json\Personel.json", json);
        }

        private void btnJsonYukle_Click(object sender, EventArgs e)
        {
            string jsonData = File.ReadAllText(@"C:\Json\Personel.json");
            List<Personel> liste = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Personel>>(jsonData);

            for (int i = 0; i < liste.Count; i++)
            {
                int etkilenenKayit= bll.PersonelEkle(liste[i].PersonelId, liste[i].Isim, liste[i].Soyisim, liste[i].EmailAddres, liste[i].Telefon);

                if (etkilenenKayit <= 0)
                    MessageBox.Show("Kayıt eklenemedi");
            }
        }
    }
}
