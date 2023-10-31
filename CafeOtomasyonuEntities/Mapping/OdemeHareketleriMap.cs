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
    public class OdemeHareketleriMap:EntityTypeConfiguration<OdemeHareketleri>
    {
        public OdemeHareketleriMap()
        {
            this.ToTable("OdemeHareketleri");
            this.HasKey(x => x.ID);
            this.Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.SatisKodu).HasColumnType("nvarchar").HasMaxLength(25);
            this.Property(x => x.OdemeTuru).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(x => x.Aciklama).HasColumnType("nvarchar").HasMaxLength(500);

        }
    }
}
