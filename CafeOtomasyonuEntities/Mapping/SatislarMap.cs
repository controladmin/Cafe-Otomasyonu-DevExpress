using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration; // Buraya ekledik EntityTypeConfiguration kullanabilmek için
using CafeOtomasyonuEntities.Models; // Burada Menu sınıfını kullanabilmek için ekledik
using System.ComponentModel.DataAnnotations.Schema; // Configuration özelliklerini kullanabilmek için bunu ekledik

namespace CafeOtomasyonuEntities.Mapping
{
    public class SatislarMap:EntityTypeConfiguration<Satislar>
    {
        public SatislarMap()
        {
            this.ToTable("Satislar");
            this.HasKey(x => x.ID);
            this.Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.SatisKodu).HasColumnType("nvarchar").HasMaxLength(30);
            this.Property(x => x.Aciklama).HasColumnType("nvarchar").HasMaxLength(500);
            this.HasOptional(s => s.Musteriler).WithMany(s => s.Satislar).HasForeignKey(s => s.MusteriID);
        }
    }
}
