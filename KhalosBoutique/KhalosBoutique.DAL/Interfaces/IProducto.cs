using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhalosBoutique.DATA;

namespace KhalosBoutique.DAL.Interfaces
{
    public interface IProducto
    {
        List<ViewProductos> ListarProductosView();
        List<ViewProductosStock> ListarProductosViewStock();
        List<Producto> ListarProductos();
        void InsertarProducto(Producto producto);
        void ActualizarProducto(Producto producto);
        void EliminarProducto(int idProducto);
        Producto BuscarProductoId(int productoId);
        void comprarProducto(int idProducto, int Cantidad);
        void devolverProducto(int idProducto, int Cantidad);
    }
}
