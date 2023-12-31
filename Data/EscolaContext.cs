using Microsoft.EntityFrameworkCore;
using ProjetoDotnet_API.Models;
using System.Diagnostics.CodeAnalysis;

namespace ProjetoDotnet_API.Data
{
    public class EscolaContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public EscolaContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("StringConexaoSQLServer"));
        }
        public DbSet<Aluno>? AlunoApi { get; set; }
        public DbSet<User>? Usuario { get; set; } //nova tabela
    }
}