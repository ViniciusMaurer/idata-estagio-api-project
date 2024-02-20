using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using EstagioiData.Model;

namespace EstagioiData.infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Recruitment> Recruitments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql( //passa as informações de conexão com o banco mysql
                "Server=localhost;" +
                "Port=3306;" +
                "Database=idata;" +
                "Uid=root;" +
                "Pwd=Vini@0709;",
                new MySqlServerVersion(new Version(8, 0, 28)));
        }
    }
}