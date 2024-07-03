using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using EstagioiData.Model;

namespace EstagioiData.infraestrutura
{
    // Classe que representa o contexto de conexão com o banco de dados
    public class ConnectionContext : DbContext
    {
        // Define uma propriedade DbSet para representar a tabela no banco de dados
        public DbSet<Recruitment> Recruitments { get; set; }

        // Método usado para configurar as opções de conexão com o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql( // Passa as informações de conexão com o banco mysql
                "Server=localhost;" + // Endereço do servidor MySQL
                "Port=3306;" + // Porta de conexão do MySQL
                "Database=idata;" + // Nome do banco de dados
                "Uid=root;" + // Nome de usuário do MySQL
                "Pwd=12345;", // Senha do MySQL
                new MySqlServerVersion(new Version(8, 0, 28))); // Versão do servidor MySQL
        }
    }
}
