using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema; // Bunu Sql'deki elemanların typelerini belirlemek için koyduk
using System.ComponentModel.DataAnnotations; // Bunuda Sql 'deki elemanlara sınırlama getirmek için kullandık
using CafeOtomasyonuEntities.Interface;

namespace CafeOtomasyonuEntities.Models
{
   public  class KullaniciHareketleri:IEntity
    {   
        public int ID { get; set; }
        public int KullaniciID { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public virtual Kullanici Kullanicilar { get; set; }

    }
}
