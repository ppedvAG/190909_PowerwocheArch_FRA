using System;
using System.Data.Entity;
using Widerstandsmessung.Domain;

namespace Widerstandsmessung.Data.EF
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Server=(localdb)\\MSSQLLocalDB;Database=Widerstandsmessung;Trusted_Connection=true;AttachDbFilename=C:\\temp\\Widerstand.mdf")
        {
        }

        public DbSet<SOLLWiderstand> SOLLWiderstand { get; set; }
        public DbSet<ISTWiderstand> ISTWiderstand { get; set; }
    }
}
