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
   public class MasaHareketleriMap:EntityTypeConfiguration<MasaHareketleri>
    {
        public MasaHareketleriMap()
        {
            this.ToTable("MasaHareketleri");
            this.HasKey(x => x.ID);
            this.Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.SatisKodu).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(x => x.Aciklama).HasColumnType("nvarchar").HasMaxLength(500);

            // Masalar ve MasaHareketleri tablosu arasında ilişki kurduk
            this.HasOptional(x => x.Masa).WithMany(x => x.MasaHareketleri).HasForeignKey(x => x.MasaID);
            this.HasRequired(x => x.Urun).WithMany(x => x.MasaHareketleri).HasForeignKey(x => x.UrunID);
        }
    }
}
