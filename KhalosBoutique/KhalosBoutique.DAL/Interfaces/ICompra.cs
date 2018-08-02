using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhalosBoutique.DATA;
using KhalosBoutique.DAL.Metodos;

namespace KhalosBoutique.DAL.Interfaces
{
    public interface ICompra
    {
        List<ViewCompras> ListarProductoparaCompra();
    }
}
