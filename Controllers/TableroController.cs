using Microsoft.AspNetCore.Mvc;
using EspacioModels;
using EspacioRepository;


namespace EspacioController;

public class TableroController : ControllerBase
{
    private ITableroRepository tableroRepository;
    private ILogger<TableroController> _logger;

    public TableroController(ILogger<TableroController> logger)
    {
        _logger = logger;
        tableroRepository = new TableroRepository();
    }

    [HttpPost("Crear tablero")]
    public ActionResult<Tablero> CreateTablero(Tablero nuevo)
    {
        tableroRepository.CreateTablero(nuevo);
        return Ok(nuevo);
    }

    [HttpGet("Get tableros")]
    public ActionResult<List<Tablero>> GetAllTablero()
    {
        List<Tablero> tableros = tableroRepository.GetAllTablero();

        if (tableros != null)
        {
            return Ok(tableros);
        }
        else
        {
            return NotFound();
        }
    }
}