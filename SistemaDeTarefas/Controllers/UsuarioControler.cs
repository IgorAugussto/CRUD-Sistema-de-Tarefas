using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioControler : ControllerBase
    {
        //Funcionalidade - Buscar os usuarios
        [HttpGet]
        public ActionResult<List<UsuarioControler>> BuscarTodosUsuarios()
        {
            return Ok();
        }
    }
}
