using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // Context kullanabilmek için bunu ekledik
using System.Linq.Expressions; // Expression Function kullanabilmek için bunu ekledik

namespace CafeOtomasyonuEntities.Interface
{
    public interface IEntityRepository<TContext,TEntity>
        where TContext:DbContext,new()
        where TEntity:class,IEntity,new() // şart Koydum Where ile
    {
        bool AddOrUpdate(TContext context, TEntity entity);
        void Delete(TContext context,Expression<Func<TEntity,bool>>filter);
        void Save(TContext context);

        List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null);  // getAll diye metot oluşturduk filtre başlangıçta boş null geçtik liste için
        TEntity GetByFilter(TContext context,Expression<Func<TEntity,bool>>filter); // GetByFilter diye metot oluşturduk tek kayıt için
    }
}
