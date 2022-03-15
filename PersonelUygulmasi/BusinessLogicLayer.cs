using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulmasi
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal;

        public BusinessLogicLayer()
        {
            dal = new DataAccessLayer();
        }



        public int SistemGirisKontrol(string kullaniciAdi,string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                return dal.SistemGirisKontrol(new SistemKullanici { 
                    KullaniciAdi=kullaniciAdi,
                    Sifre=sifre
                });
            }
            else
                return -100; //loglamam kuralları olabilir --eksik bilgi
        }


        public int PersonelEkle(Guid personelId,string isim,string soyisim,string emailAdress,string telefon)
        {
            if (personelId != Guid.Empty && !string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim))
            {
                Personel p = new Personel();
                p.PersonelId = personelId;
                p.Isim = isim;
                p.Soyisim = soyisim;
                p.EmailAddres = emailAdress;
                p.Telefon = telefon;

                return dal.Personel_Ekle(p);
            }
            else
                return -100;
        }


        public List<Personel> PersonelTumListe()
        {
            List<Personel> personeller = new List<Personel>();

            try
            {
                SqlDataReader reader = dal.PersonelTumListe();
                while (reader.Read())
                {
                    personeller.Add(new Personel
                    {
                        PersonelId = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        Isim=reader.IsDBNull(1)?string.Empty:reader.GetString(1),
                        Soyisim=reader.IsDBNull(2)?string.Empty:reader.GetString(2),
                        EmailAddres=reader.IsDBNull(3)?string.Empty:reader.GetString(3),
                        Telefon=reader.IsDBNull(4)?string.Empty:reader.GetString(4)

                    }) ;
                }

                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dal.BaglantiAyarlar();
            }

            return personeller;
        }


        public Personel PersonelGetir(Guid id)
        {
            Personel personel = new Personel();
            SqlDataReader reader;

            try
            {
                reader = dal.PersonelGetir(id);

                while (reader.Read())
                {
                    personel.PersonelId = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                    personel.Isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    personel.Soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    personel.EmailAddres = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    personel.Telefon = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                }

                reader.Close();
            }
            catch (Exception)
            {

                //log
            }
            finally
            {
                dal.BaglantiAyarlar();
            }

            return personel;
        }


        public int PersonelGuncelle(Guid personelId,string isim,string soyisim,string emailAdres,string telefonNumarasi)
        {
            Personel personel = new Personel
            {
                PersonelId=personelId,
                Isim=isim,
                Soyisim=soyisim,
                EmailAddres=emailAdres,
                Telefon=telefonNumarasi
            };


            return dal.PersonelGuncelle(personel);
        }


        public int PersonelSil(Guid id)
        {
            return dal.PersonelSil(id);
        }
    }
}
