using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EspacioModels;

public class Usuario
{
    private int id;
    private string nombreDeUsuario;

    public int Id { get => id; set => id = value; }
    public string NombreDeUsuario { get => nombreDeUsuario; set => nombreDeUsuario = value; }
}