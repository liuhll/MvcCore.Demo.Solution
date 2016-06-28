using MvcCoreDemo.Data.Context.Interfaces;

namespace MvcCoreDemo.Application.Interfaces.Common
{
    public interface ITransactionAppService<TContext>
        where TContext : IDbContext, new()
    {
        void BeginTransaction();
        void Commit();
    }
}
