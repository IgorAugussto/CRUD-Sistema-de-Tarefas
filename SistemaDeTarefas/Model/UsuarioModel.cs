namespace SistemaDeTarefas.Model
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        // "?" significa que a variavel pode ser nula
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
