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
    class MasalarMap : EntityTypeConfiguration<Masa>
    {
        public MasalarMap()
        {
            this.ToTable("Masa");
            this.HasKey(x => x.ID);
            this.Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.MasaAdi).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(x => x.SatisKodu).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(x => x.Aciklama).HasColumnType("nvarchar").HasMaxLength(500);
            this.Property(x => x.EklemeTarihi).HasColumnType("Date");
            this.HasOptional(m => m.Kullanicilar).WithMany(m => m.masalar).HasForeignKey(m => m.KullaniciID);
        }
    }
}
