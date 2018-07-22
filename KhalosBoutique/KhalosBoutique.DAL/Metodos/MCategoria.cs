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
    public class MCategoria : MBase, ICategoria
    {
        public void ActualizarCategoria(Categoria categoria)
        {
            db.Update(categoria);
        }

        public void AgregarCategoria(Categoria categoria)
        {
            db.Insert(categoria);
        }

        public Categoria BuscarCategoria(int idCategoria)
        {
            return db.Select<Categoria>(x => x.IdCategoria == idCategoria).FirstOrDefault();
        }

        public List<Categoria> ListarCategorias()
        {
            return db.Select<Categoria>();
        }
    }
}
