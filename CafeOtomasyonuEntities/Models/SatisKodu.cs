using CafeOtomasyonuEntities.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // [Key] ifadesini kullanabilmek için bu kütüphaneyi kullandık
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonuEntities.Models
{
    [Table("SatisKodu")]
    public class SatisKodu
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        [Column(TypeName ="nvarchar")]
        public string SatisTanimi { get; set; }
        public int Sayi { get; set; }
    }
}
