﻿using ppedv.MajoDDD.Domain;
using System;
using System.Data.Entity;

namespace ppedv.MajoDDD.Data.EF
{
    public class EFContext : DbContext
    {
        // Teilnehmerrechner
        // public EFContext() : base("Server=.;Database=MajoDDD;Trusted_Connection=true;")
        public EFContext() : base("Server=(localdb)\\MSSQLLocalDB;Database=MajoDDD;Trusted_Connection=true;AttachDbFilename=C:\\temp\\MajoDDD.mdf")
        { }

        public DbSet<Book> Book { get; set; }
        public DbSet<BookStore> BookStore { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
    }
}
