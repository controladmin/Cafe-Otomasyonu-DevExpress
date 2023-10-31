using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // Contex yapısını kullanailmek için bunu ekledik
using CafeOtomasyonuEntities.Interface; // Interface'i kullanabilmek için buraya ekledik
using System.Linq.Expressions; // Expressions özelliğini kullanabilmek için bunu ekledik
using System.Data.Entity.Migrations; // Interfaceten gelen metotları kullanabilmek için bunu ekledik
using FluentValidation;
using CafeOtomasyonuEntities.Tools;

namespace CafeOtomasyonuEntities.Repository
{
    public class EntityRepositoryBase<TContext, TEntity, TValidator> : IEntityRepository<TContext, TEntity>
        where TContext : DbContext, new()
        where TEntity : class, IEntity, new()
        where TValidator : IValidator, new()
    {
        public bool AddOrUpdate(TContext context, TEntity entity)
        {
            TValidator validator = new TValidator();
            bool ValidationResult = ValidatorTools.Validates(validator,entity);
            if (ValidationResult)
            {
                context.Set<TEntity>().AddOrUpdate(entity);
            }
            return ValidationResult;
        }

        public void Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            context.Set<TEntity>().Remove(context.Set<TEntity>().FirstOrDefault(filter));
           // context.Set<TEntity>().RemoveRange(context.Set<TEntity>().Where(filter)); // RemoveRange kullanırsak where kullanırız
        }

        public List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().FirstOrDefault(filter);
        }

        public void Save(TContext context)
        {
            context.SaveChanges();
        }
    }
}
