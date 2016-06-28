using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentValidation.Results;

namespace MvcCoreDemo.Domain.Interfaces.Service.Common
{
    public interface IService<TEntity>
    where TEntity : class
    {
        TEntity Get(Guid id);
        IEnumerable<TEntity> All(bool @readonly = false);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, bool @readonly = false);
        ValidationResult Add(TEntity department);
        ValidationResult Update(TEntity department);
        ValidationResult Delete(TEntity entity);
        ValidationResult Delete(Guid id);
    }
}
