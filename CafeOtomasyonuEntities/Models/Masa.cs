﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema; // Bunu Sql'deki elemanların typelerini belirlemek için koyduk
using System.ComponentModel.DataAnnotations; // Bunuda Sql'deki elemanlara sınırlama getirmek için kullandık
using CafeOtomasyonuEntities.Interface;

namespace CafeOtomasyonuEntities.Models
{
    public class Masa:IEntity
    {
        public int ID { get; set; }   
        public string MasaAdi { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
        public bool Reservemi { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public DateTime SonIslemTarihi { get; set; }
        public string Islem { get; set; }
        public string SatisKodu { get; set; }
        // public Nullable<int> KullaniciID { get; set; }
        public int? KullaniciID { get; set; }

        public virtual ICollection<MasaHareketleri> MasaHareketleri { get; set; }
        public virtual Kullanici Kullanicilar { get; set; }
    }
}
