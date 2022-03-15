using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKatmaliMimari
{
    public class BussinessLogicLayer
    {
        DataAccessLayer dal;

        public BussinessLogicLayer()
        {
            dal = new DataAccessLayer();
        }


        public int Kaydet(Musteri musteri)
        {
            if (!string.IsNullOrEmpty(musteri.Ad) && !string.IsNullOrEmpty(musteri.Soyad))
            {
                return dal.MusteriKaydet(musteri);
            }
            else
                return -1;//eksik parametre
        }
    }
}
