using KhalosBoutique.DAL.Interfaces;
using KhalosBoutique.DATA;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhalosBoutique.DAL.Metodos
{
    public class MRol : MBase, IRol
    {
        public void ActualizarRol(Rol rol)
        {
            db.Update(rol);
        }

        public Rol BuscarRol(int idRol)
        {
            return db.Select<Rol>(x => x.IdRol == idRol).FirstOrDefault();
        }

        public void InsertarRol(Rol rol)
        {
            db.Insert(rol);
        }

        public List<Rol> ListarRoles()
        {
            return db.Select<Rol>();
        }
    }
}
