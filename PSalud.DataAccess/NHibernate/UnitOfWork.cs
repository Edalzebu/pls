using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using NHibernate;

namespace PSalud.DataAccess.NHibernate
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISessionFactory _sessionFactory;
        private readonly ITransaction _transaction;
        private List<string> buffer = new List<string>();
        
        public ISession Session { get; private set; }

        public UnitOfWork(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
            Session = _sessionFactory.OpenSession();
            Session.FlushMode = FlushMode.Auto;
            _transaction = Session.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public void Dispose()
        {
            Session.Close();
        }

        public void Commit()
        {
            if (!_transaction.IsActive)
            {
                throw new InvalidOperationException("No active transation");
            }
            _transaction.Commit();
        }

        public void Rollback()
        {
            if (_transaction.IsActive)
            {
                _transaction.Rollback();
            }
        }

        public void Log(string entry)
        {
            buffer.Add(entry);
        }

        public string RenderLog()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string entry in buffer)
                sb.Append(string.Format("<div>{0}</div>", entry));
             
            return sb.ToString();
        }
    }
}
