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
    public class Roller:IEntity
    { 
        public int ID { get; set; }
        public int KullaniciID { get; set; }
        public string FormName { get; set; }
        public string KontrolName { get; set; }
        public string ControlCaption { get; set; }
    }
}
