﻿using CafeOtomasyonuEntities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonuEntities.Models
{
    public class Musteriler:IEntity
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public virtual ICollection<Satislar> Satislar { get; set; }

    }
}
