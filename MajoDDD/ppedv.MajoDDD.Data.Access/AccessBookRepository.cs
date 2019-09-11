using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using ppedv.MajoDDD.Domain;
using ppedv.MajoDDD.Domain.Interfaces;

namespace ppedv.MajoDDD.Data.Access
{
    internal class AccessBookRepository : IBookRepository
    {
        public AccessBookRepository(OleDbConnection con)
        {
            this.con = con;
        }
        private OleDbConnection con;

        public void Add(Book item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Book item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            List<Book> output = new List<Book>();
            OleDbCommand DbCommand = con.CreateCommand();
            DbCommand.CommandText = "SELECT * FROM Books";
            OleDbDataReader DbReader = DbCommand.ExecuteReader();
            while (DbReader.Read())
            {
                Book temp = new Book();
                temp.ID = Convert.ToInt32(DbReader.GetValue(0));
                temp.Title = DbReader.GetString(1);
                temp.Author = DbReader.GetString(2);
                temp.Pages = Convert.ToInt32(DbReader.GetValue(3));
                temp.Price = Convert.ToDecimal(DbReader.GetValue(4));

                output.Add(temp);
            }
            return output;
        }

        public Book GetBookWithHighestPrice()
        {
            throw new System.NotImplementedException();
        }

        public Book GetByID(int ID)
        {
            throw new System.NotImplementedException();
        }

        public int GetTotalAmountOfBooksInCirculation(Book b)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Book> Query()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Book item)
        {
            throw new System.NotImplementedException();
        }
    }
}