using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace QxdCtidApiSer.EntityFramework.Repositories
{
    public abstract class QxdCtidApiSerRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<QxdCtidApiSerDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected QxdCtidApiSerRepositoryBase(IDbContextProvider<QxdCtidApiSerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class QxdCtidApiSerRepositoryBase<TEntity> : QxdCtidApiSerRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected QxdCtidApiSerRepositoryBase(IDbContextProvider<QxdCtidApiSerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
