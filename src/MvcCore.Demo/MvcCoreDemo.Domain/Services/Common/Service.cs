using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FluentValidation.Results;
using MvcCoreDemo.Domain.Interfaces.Repository.Common;
using MvcCoreDemo.Domain.Interfaces.Service.Common;
using MvcCoreDemo.Domain.Interfaces.Validation;

namespace MvcCoreDemo.Domain.Services.Common
{
    public class Service<TEntity> : IService<TEntity>
         where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;
        private readonly ValidationResult _validationResult;

        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
            _validationResult = new ValidationResult();
        }

        protected ValidationResult ValidationResult
        {
            get { return _validationResult; }
        }

        protected IRepository<TEntity> Repository
        {
            get { return _repository; }
        }


        public TEntity Get(Guid id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<TEntity> All(bool @readonly = false)
        {
            return _repository.All(@readonly);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, bool @readonly = false)
        {
            return _repository.Find(predicate, @readonly);
        }

        public ValidationResult Add(TEntity entity)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            var selfValidationEntity = entity as ISelfValidation;
            if (selfValidationEntity != null && !selfValidationEntity.IsValid)
                return selfValidationEntity.ValidationResult;


            _repository.Add(entity);
            return _validationResult;
        }

        public ValidationResult Update(TEntity entity)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            var selfValidationEntity = entity as ISelfValidation;
            if (selfValidationEntity != null && !selfValidationEntity.IsValid)
                return selfValidationEntity.ValidationResult;

            _repository.Update(entity);
            return _validationResult;
        }

        public ValidationResult Delete(TEntity entity)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            _repository.Delete(entity);
            return _validationResult;
        }

        public ValidationResult Delete(Guid id)
        {
            TEntity entity = Get(id);
            return Delete(entity);
        }
    }
}
