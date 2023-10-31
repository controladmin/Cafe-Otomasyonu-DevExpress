using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;  // Bunu Sql'deki elemanların typelerini belirlemek için koyduk
using System.ComponentModel.DataAnnotations;  // Bunuda Sql 'deki elemanlara sınırlama getirmek için kullandık
using CafeOtomasyonuEntities.Interface;

namespace CafeOtomasyonuEntities.Models
{
    public class Kullanici:IEntity
    {   
        public int ID { get; set; }  
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }  
        public string Email { get; set; }     
        public string Gorevi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string HatirlatmaSorusu { get; set; }
        public string Cevap { get; set; }
        public string Aciklama { get; set; }
        public DateTime KayitTarihi { get; set; }
        public bool Aktifmi { get; set; }
        public virtual ICollection<KullaniciHareketleri> KullaniciHareketleri { get; set; }
        public virtual ICollection<Masa> masalar { get; set; }
    }
}
