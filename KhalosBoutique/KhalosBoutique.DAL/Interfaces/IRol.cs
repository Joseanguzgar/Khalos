using KhalosBoutique.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhalosBoutique.DAL.Interfaces
{
    public interface IRol
    {
        List<Rol> ListarRoles();

        Rol BuscarRol(int idRol);

        void InsertarRol(Rol rol);

        void ActualizarRol(Rol rol);
    }
}
