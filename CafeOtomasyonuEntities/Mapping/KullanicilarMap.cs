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
   public class KullanicilarMap:EntityTypeConfiguration<Kullanici>
    {
        public KullanicilarMap()
        {
            this.ToTable("Kullanici");
            this.HasKey(x => x.ID);
            this.Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.AdSoyad).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(x => x.Adres).HasColumnType("nvarchar").HasMaxLength(500);
            this.Property(x => x.Telefon).HasColumnType("nvarchar").HasMaxLength(15);
            this.Property(x => x.Email).HasColumnType("nvarchar").HasMaxLength(30);
            this.Property(x => x.Gorevi).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(x => x.KullaniciAdi).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(x => x.Sifre).HasColumnType("nvarchar").HasMaxLength(20);
            this.Property(x => x.HatirlatmaSorusu).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(x => x.Cevap).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(x => x.Aciklama).HasColumnType("nvarchar").HasMaxLength(500);

        }
    }
}
