using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;
using SistemaDeTarefas.Model;
using SistemaDeTarefas.Repositorio.Interfaces;

namespace SistemaDeTarefas.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaTarefasDbContext _dbContext;
        public UsuarioRepositorio(SistemaTarefasDbContext sistemaTarefasDbContext)
        {
            _dbContext= sistemaTarefasDbContext;
        }
        
        //Esse método vai retornar "x" onde x é o id do usuario que vai retornar o id que vindo como parametro
        public async Task<UsuarioModel> BuscarPorID(int id)
        {
            //Nesse caso como assincrono (que não é em tempo real), eu preciso aguardar a requisição ser feita
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            //Pegar todo mundo da tabela usuario
            return await _dbContext.Usuarios.ToListAsync();
        }
        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            _dbContext.Add(usuario);

            //Isso confirma a ação acima, salvando o usuario na base de dados
            _dbContext.SaveChanges();

            return usuario;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorID(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario para o ID: {id} não foi encontrado no baco de dados");
            }

            usuarioPorId.Name = usuario.Name;
            usuarioPorId.Email = usuario.Email;

            _dbContext.Update(usuarioPorId);
            _dbContext.SaveChanges();

            return usuarioPorId;
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
