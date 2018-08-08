using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhalosBoutique.DAL.Interfaces;
using KhalosBoutique.DATA;
using ServiceStack.OrmLite;

namespace KhalosBoutique.DAL.Metodos
{
    public class MUsuario : MBase, IUsuario
    {
        //LAPTOP-NPNFVF1E\SQLEXPRESS01
        public void ActualizarUsuario(Usuario usuario)
        {
            db.Update(usuario);
        }

        public Usuario BuscarUsuario(string usuario)
        {
            return db.Select<Usuario>(x => x.Cuenta == usuario).FirstOrDefault();
        }

        public Usuario BuscarUsuarioId(int usuario)
        {
            return db.Select<Usuario>(x => x.IdUsuario == usuario).FirstOrDefault();
        }

        public void EliminarUsuario(int idUsuario)
        {
            db.Delete<Usuario>(x => x.IdUsuario == idUsuario);
        }

        public void InsertarUsuario(Usuario usuario)
        {
            db.Insert(usuario);
        }

        public List<Usuario> ListarUsuarios()
        {
            return db.Select<Usuario>();
        }
    }
}
