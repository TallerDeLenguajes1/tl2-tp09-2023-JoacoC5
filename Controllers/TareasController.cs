using Microsoft.AspNetCore.Mvc;
using EspacioModels;
using EspacioRepository;


namespace EspacioController;

public class TareasController : ControllerBase
{
    private ITareaRepository tareaRepository;
    private ILogger<TareasController> _logger;

    public TareasController(ILogger<TareasController> logger)
    {
        _logger = logger;
        tareaRepository = new TareaRepository();
    }

    [HttpPost("Crear tarea")]
    public ActionResult<Tarea> CreateTarea(int idTablero, Tarea nuevo)
    {
        tareaRepository.CreateTarea(idTablero, nuevo);
        return Ok(nuevo);
    }

    [HttpPut("Modificar tarea")]
    public ActionResult<Tarea> UpdateTarea(int idBuscado, Tarea modificado)
    {
        tareaRepository.UpdateTarea(idBuscado, modificado);

        return Ok(modificado);
    }

    [HttpDelete("Borrar tarea")]
    public ActionResult DeleteTarea(int idBuscado)
    {
        tareaRepository.DeleteTarea(idBuscado);

        return Ok();
    }

    /*[HttpGet("tareas en un estado")]
    public ActionResult<int> CantTareasEstado(int estado)
    {
        int cont = tareaRepository.GetCantTareaByEstado(estado);

        return Ok(cont);
    }*/
}