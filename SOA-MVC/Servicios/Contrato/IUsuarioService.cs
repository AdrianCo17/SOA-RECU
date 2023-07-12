using Microsoft.EntityFrameworkCore;
using SOA_MVC.Models;

namespace SOA_MVC.Servicios.Contrato
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuario(string correo, string clave);
        Task<Usuario> SaveUsuario(Usuario modelo);

    }
}
