using Microsoft.EntityFrameworkCore;
using PointStore.Domain.Entity;

namespace PointStore.Repository.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }
        public DbSet<Produto> Produtos {get; set;}
    }
}
