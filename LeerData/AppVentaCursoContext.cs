using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    public class AppVentaCursosContext : DbContext
    {
            private const string connectionString = @"Data Source =LAPTOP-T9F8OT26;Initial Catalog=CursosOnline;Integrated Security=True";

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }

            public DbSet<Curso> Curso{get;set;}
            public DbSet<Precio> Precio{get;set;}
    }

}