using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyonuEntities.Models;
using System.Data.Entity.ModelConfiguration; // EntityTypeConfiguration kullanabilmek için bu kütüphaneyi ekledik
using System.ComponentModel.DataAnnotations.Schema; // DatabaseGeneratedOption bu ifadeyi kullanabilmek için bu kütüphaneyi kullandık

namespace CafeOtomasyonuEntities.Mapping
{
   public class MusterilerMap:EntityTypeConfiguration<Musteriler>
    {
        public MusterilerMap()
        {
            this.ToTable("Musteriler");
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.AdSoyad).HasColumnType("nvarchar").HasMaxLength(150);
            this.Property(p => p.Telefon).HasColumnType("nvarchar").HasMaxLength(25);
            this.Property(p => p.Adres).HasColumnType("nvarchar").HasMaxLength(500);
            this.Property(p => p.Email).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(p => p.Aciklama).HasColumnType("nvarchar").HasMaxLength(750);
        }        
    }
}
