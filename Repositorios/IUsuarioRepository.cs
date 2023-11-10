using EspacioModels;

namespace EspacioRepository;

public interface IUsuarioRepository
{
    public void CreateUsuario(Usuario nuevo);
    public void UpdateUsuario(int idBuscado, Usuario modificado);
    public List<Usuario> GetAllUsuario();
    public Usuario GetUsuarioById(int idBuscado);
    public void DeleteUsuario(int idBuscado);
}