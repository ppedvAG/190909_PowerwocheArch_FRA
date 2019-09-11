using ppedv.MajoDDD.Domain;
using ppedv.MajoDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ppedv.MajoDDD.Data.Access
{
    public class AccessUnitOfWork : IUnitOfWork
    {
        public AccessUnitOfWork()
        {
            con = new OleDbConnection(@"Provider=Microsoft.JET.OLEDB.4.0;Data Source=./MajoDDD.mdb;Persist Security Info = False; ");
            con.Open();
        }
        private OleDbConnection con;

        public IBookRepository BookRepository => new AccessBookRepository(con);

        public IBookStoreRepository BookStoreRepository => throw new NotImplementedException();

        public IUniversalRepository<T> GetRepository<T>() where T : Entity
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
