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
    public class DalMasalar:EntityRepositoryBase<CafeContext,Masa,ValidationMasalar>
    {
        public object MasalariListele(CafeContext context)
        {
            var model = (from masa in context.Masalar join Kullanici k  in context.Kullanicilar on masa.KullaniciID
                         equals k.ID into kullanici from kullanicimasa in kullanici.DefaultIfEmpty()
                         select new
                         {
                             masa.ID,
                             masa.Aciklama,
                             masa.Durum,
                             masa.EklemeTarihi,
                             masa.SonIslemTarihi,
                             masa.Reservemi,
                             masa.Islem,
                             masa.MasaAdi,
                             Kullanici=kullanicimasa.KullaniciAdi

                         }).ToList();
            return model;
        }
    }
}
