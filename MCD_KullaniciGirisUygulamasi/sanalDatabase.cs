using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KullaniciGirisUygulamasi
{
    public class sanalDatabase
    {
        public static List<kullanici> KullaniciTablo = new List<kullanici>();

        static sanalDatabase()
        {
            KullaniciTablo.Add(new kullanici()
            {
                id = 1,
                isim = "Faik",
                soyisim = "Turan",
                kullaniciAdi =  "faik.turan",
                sifre = "1",
                aciklama = "Faik Turan Kullanıcı profil bilgisi"
            });
            KullaniciTablo.Add(new kullanici()
            {
                id = 2,
                isim = "Arif",
                soyisim = "Turan",
                kullaniciAdi = "arif.turan",
                sifre = "2",
                aciklama = "Arif Turan Kullanıcı profil bilgisi"
            });
        }
    }
}
