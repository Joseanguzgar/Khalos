using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhalosBoutique.DATA;

namespace KhalosBoutique.DAL.Interfaces
{
    public interface ICategoria
    {
        List<Categoria> ListarCategorias();
        Categoria BuscarCategoria(int idCategoria);
        void AgregarCategoria(Categoria categoria);
        void ActualizarCategoria(Categoria categoria);
    }
}
