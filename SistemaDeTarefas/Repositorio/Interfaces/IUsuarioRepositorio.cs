using SistemaDeTarefas.Model;

namespace SistemaDeTarefas.Repositorio.Interfaces
{
    //Aqui vão ficar alguns contratos de usuario, como adicionar usuario ou excluir usuario
    //Todas a palavras que estão dentro do "<>" significa que vai retornar aquilo que está lá dentro
    public interface IUsuarioRepositorio
    {
        //Nesse tem "List" pois vai retornar a lista de todos os usuarios
        Task<List<UsuarioModel>> BuscarTodosUsuarios();

        //Nesse caso por exemplo não tem lista por que está buscando somente por id
        Task<UsuarioModel> BuscarPorID(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}
