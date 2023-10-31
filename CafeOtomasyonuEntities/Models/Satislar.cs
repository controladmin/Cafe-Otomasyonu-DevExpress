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
    public class Satislar:IEntity
    {  
        public int ID { get; set; }
        public string SatisKodu { get; set; }
        public int? MusteriID { get; set; }
        public decimal Tutar { get; set; }
        public decimal IndirimTutari { get; set; }
        public decimal Odenen { get; set; }
        public decimal Kalan { get; set; }
        public string Aciklama { get; set; }
        public bool Paketmi { get; set; } = false;
        public DateTime SonIslemTarihi { get; set; }
        public virtual Musteriler Musteriler { get; set; }

    }
}
