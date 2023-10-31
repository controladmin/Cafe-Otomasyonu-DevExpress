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
    public class DalOdemeHareketleri:EntityRepositoryBase<CafeContext,OdemeHareketleri,ValidationOdemeHareketleri>
    {
    }
}
