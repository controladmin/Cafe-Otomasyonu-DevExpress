using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyonuEntities.Models;
using CafeOtomasyonuEntities.Repository;
using CafeOtomasyonuEntities.Validations;

namespace CafeOtomasyonuEntities.DAL
{
    public class DalKullaniciHareketleri:EntityRepositoryBase<CafeContext,KullaniciHareketleri,ValidationKullaniciHareketleri>
    {
        //public static int Kullaniciid { get; set; }
        public void KullaniciHareketleriEkle(CafeContext context,KullaniciHareketleri hareket,string aciklama)
        {
            DalKullaniciHareketleri hareketdal = new DalKullaniciHareketleri();
            hareket.Tarih = DateTime.Now;
            hareket.Aciklama = aciklama;
            if(hareketdal.AddOrUpdate(context,hareket))
            {
                hareketdal.Save(context);
            }
        }
    }
}
