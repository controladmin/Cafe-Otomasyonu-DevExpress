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
    public class OdemeHareketleri:IEntity
    {
        public int ID { get; set; }
        public string SatisKodu { get; set; }
        public string OdemeTuru { get; set; }
        public decimal Odenen { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
    }
}
