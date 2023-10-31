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
    public class KullaniciHareketleriMap:EntityTypeConfiguration<KullaniciHareketleri>
    {
        public KullaniciHareketleriMap()
        {
            this.ToTable("KullaniciHareketleri");
            this.HasKey(x => x.ID);
            this.Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Aciklama).HasColumnType("nvarchar").HasMaxLength(500);

            // Kullanicilar ve KullaniciHareketleri tabloları arasında ilişki kuruyoruz
            this.HasRequired(x => x.Kullanicilar).WithMany(x => x.KullaniciHareketleri).HasForeignKey(x => x.KullaniciID);
        }
    }
}
