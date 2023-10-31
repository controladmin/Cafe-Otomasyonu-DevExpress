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
    public class DalKullanicilar:EntityRepositoryBase<CafeContext,Kullanici,ValidationKullanicilar>
    {
        public object KullanicilariListele(CafeContext context)
        {
            var Liste = (from k in context.Kullanicilar
                         select new
                         {
                             k.ID,
                             k.AdSoyad,
                             k.Telefon,
                             k.Email,
                             k.Gorevi,
                             k.Adres,
                             k.Aciklama,
                             k.KullaniciAdi,
                             k.KayitTarihi,
                             k.Aktifmi
                         }).ToList();
            return Liste;
        }
    }
}
