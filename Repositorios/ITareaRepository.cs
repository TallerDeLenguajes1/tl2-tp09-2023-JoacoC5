using EspacioModels;

namespace EspacioRepository;

public interface ITareaRepository
{
    public void CreateTarea(int idTablero, Tarea nuevo);
    public void UpdateTarea(int idBuscado, Tarea modificado);
    public Tarea GetTareaById(int idBuscado);
    public List<Tarea> GetAllTareaByUsuario(int idUsuario);
    public List<Tarea> GetAllTareabyTablero(int idTablero);
    public void SetUsuario(int idusuario, int idTarea);
    public void DeleteTarea(int idBuscado);
    //public int GetCantTareaByEstado(int estadoBuscado);
}