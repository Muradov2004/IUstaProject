using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace IUstaProject;

internal class IUstaContext : DbContext
{
    public DbSet<Expert> Experts { get; set; }
    public DbSet<Orderer> Orderers { get; set; }
    public DbSet<Category> Categories { get; set; }

    public IUstaContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=WorkerUI;Integrated Security=True;");
    }
}
