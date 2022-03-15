using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulmasi
{
    public class Personel
    {
        public Guid PersonelId { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string EmailAddres { get; set; }
        public string Telefon { get; set; }


        public override string ToString()
        {
            return $"{Isim} {Soyisim}";
        }


    }
}
