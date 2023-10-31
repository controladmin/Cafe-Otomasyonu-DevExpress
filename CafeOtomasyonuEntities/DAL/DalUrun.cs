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
   public class DalUrun:EntityRepositoryBase<CafeContext,Urun,ValidationUrun>
    {
        public object UrunListele(CafeContext context)
        {
            var Liste = (from u in context.Urun
                         select new
                         {
                             u.ID,
                             u.MenuID,
                             Menu=u.Menu.MenuAdi,
                             u.UrunKodu,
                             u.UrunAdi,
                             u.BirimFiyat1,
                             u.BirimFiyat2,
                             u.BirimFiyat3,
                             u.Aciklama,
                             u.Resim,
                             u.Tarih
                         }).ToList();
            return Liste;
        }
    }
}
