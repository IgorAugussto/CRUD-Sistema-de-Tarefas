using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Model;

namespace SistemaDeTarefas.Data

    //Configuração das tabelas do banco de dados
{
    public class SistemaTarefasDbContext : DbContext
    {
        public SistemaTarefasDbContext(DbContextOptions<SistemaTarefasDbContext> options)
            : base(options)
        {
        }

        //Essa tabela "UsuarioModel" representa a tabela usuario dentro do banco de dados
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
