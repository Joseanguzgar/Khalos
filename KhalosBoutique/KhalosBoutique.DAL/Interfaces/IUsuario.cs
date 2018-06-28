using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhalosBoutique.DATA;

namespace KhalosBoutique.DAL.Interfaces
{
    public interface IUsuario
    {
        List<Usuario> ListarUsuarios();

        Usuario BuscarUsuario(String usuario);

        Usuario BuscarUsuarioId(int usuario);

        void InsertarUsuario(Usuario usuario);

        void ActualizarUsuario(Usuario usuario);

        void EliminarUsuario(int idUsuario);
    }
}
