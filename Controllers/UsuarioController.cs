using Microsoft.AspNetCore.Mvc;
using EspacioModels;
using EspacioRepository;

namespace EspacioController;

public class UsuarioController : ControllerBase
{
    private IUsuarioRepository usuarioRepository;
    private ILogger<UsuarioController> _logger;

    public UsuarioController(ILogger<UsuarioController> logger)
    {
        _logger = logger;
        usuarioRepository = new UsuarioRepository();
    }

    [HttpPost("Crear usuario")]
    public ActionResult<Usuario> Createusuario(Usuario nuevo)
    {
        usuarioRepository.CreateUsuario(nuevo);
        return Ok(nuevo);
    }

    [HttpGet("Get usuarios")]
    public ActionResult<List<Usuario>> GetAllusuarios()
    {
        List<Usuario> usuarios = usuarioRepository.GetAllUsuario();

        if (usuarios != null)
        {
            return Ok(usuarios);
        }
        else
        {
            return NotFound();
        }
    }

    [HttpGet("Get usuario id")]
    public ActionResult<Usuario> GetUsuariobyId(int idBuscado)
    {
        Usuario aux = usuarioRepository.GetUsuarioById(idBuscado);

        if (aux != null)
        {
            return Ok(aux);
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPut("Update nombre usuario")]
    public ActionResult UpdateNombreUsuario(int idBuscado, Usuario modificado)
    {
        usuarioRepository.UpdateUsuario(idBuscado, modificado);

        return Ok();
    }
}