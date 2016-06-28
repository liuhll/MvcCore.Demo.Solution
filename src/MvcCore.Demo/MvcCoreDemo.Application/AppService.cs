using FluentValidation.Results;
using Microsoft.Practices.ServiceLocation;
using MvcCoreDemo.Application.Interfaces.Common;
using MvcCoreDemo.Data.Context.Interfaces;

namespace MvcCoreDemo.Application
{
    public class AppService<TContext> : ITransactionAppService<TContext>
        where TContext : IDbContext, new()
    {
        private IUnitOfWork<TContext> _uow;

        public AppService()
        {
            ValidationResult = new ValidationResult();
        }

        protected ValidationResult ValidationResult { get; private set; }

        public virtual void BeginTransaction()
        {
            _uow = ServiceLocator.Current.GetInstance<IUnitOfWork<TContext>>();
            _uow.BeginTransaction();
        }

        public virtual void Commit()
        {
            _uow.SaveChanges();
        }
    }

}
