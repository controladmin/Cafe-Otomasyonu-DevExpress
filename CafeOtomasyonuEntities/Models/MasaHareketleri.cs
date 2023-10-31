using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema; // Bunu Sql'deki elemanların typelerini belirlemek için koyduk
using System.ComponentModel.DataAnnotations; // Bunuda Sql'deki elemanlara sınırlama getirmek için kullandık
using CafeOtomasyonuEntities.Interface;

namespace CafeOtomasyonuEntities.Models
{
    public class MasaHareketleri:IEntity
    { 
        public int ID { get; set; }
        public string SatisKodu { get; set; }
        public int? MasaID { get; set; }
       // public int MenuID { get; set; }
        public int UrunID { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal IndirimTutari { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public Masa Masalar { get; set; }

        public virtual Masa Masa { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
