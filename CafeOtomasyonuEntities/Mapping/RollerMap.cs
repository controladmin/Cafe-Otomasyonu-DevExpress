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
    public class RollerMap:EntityTypeConfiguration<Roller>
    {
        public RollerMap()
        {
            this.ToTable("Roller");
            this.HasKey(x => x.ID);
            this.Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.ControlCaption).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(x => x.KontrolName).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(x => x.FormName).HasColumnType("nvarchar").HasMaxLength(100);

        }
    }
}
