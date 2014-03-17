using System;
using NHibernate;

namespace PSalud.DataAccess.NHibernate
{
    public interface IUnitOfWork : IDisposable
    {
        ISession Session { get; }
        void Commit();
        void Rollback();
    }
 
}
