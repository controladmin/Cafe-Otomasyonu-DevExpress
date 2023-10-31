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
    public class UrunMap : EntityTypeConfiguration<Urun>
    {
        public UrunMap()
        {
            this.ToTable("Urun");
            this.HasKey(x => x.ID);
            this.Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.UrunKodu).HasColumnType("nvarchar").HasMaxLength(20);
            this.Property(x => x.UrunAdi).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(x => x.Aciklama).HasColumnType("nvarchar").HasMaxLength(500);
            this.Property(x => x.BirimFiyat1).HasPrecision(28, scale:2);
            this.Property(x => x.BirimFiyat2).HasPrecision(28, scale:2);
            this.Property(x => x.BirimFiyat3).HasPrecision(28, scale:2);
            this.Property(x => x.Tarih).HasColumnType("Date");
            // Menu ve Urun tablosu arasında ilişki kurduk
            this.HasRequired(x => x.Menu).WithMany(x => x.Urun).HasForeignKey(x => x.MenuID);

        }
    }
}
