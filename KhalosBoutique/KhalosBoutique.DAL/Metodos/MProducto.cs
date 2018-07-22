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
    public class MProducto :MBase, IProducto
    {
        public void ActualizarProducto(Producto producto)
        {
            db.Update(producto);
        }

        public void comprarProducto(int idProducto, int Cantidad)
        {
            var producto = db.Select<Producto>(x => x.IdProducto == idProducto).FirstOrDefault();
            producto.Cantidad_Stock = producto.Cantidad_Stock - Cantidad;
            db.Update(producto);
        }

        public Producto BuscarProductoId(int productoId)
        {
            return db.Select<Producto>(x => x.IdProducto == productoId).FirstOrDefault();
        }

        public void EliminarProducto(int idProducto)
        {
            db.Delete<Producto>(x => x.IdProducto == idProducto);
        }

        public void InsertarProducto(Producto producto)
        {
            db.Insert(producto);
        }

        public List<Producto> ListarProductos()
        {
            return db.Select<Producto>();
        }

        public List<ViewProductos> ListarProductosView()
        {
            return db.SqlList<ViewProductos>("EXEC sp_listarProductos");
        }

        public List<ViewProductosStock> ListarProductosViewStock()
        {
            return db.SqlList<ViewProductosStock>("EXEC sp_CantidadStock");
        }

        public void devolverProducto(int idProducto, int Cantidad)
        {
            var producto = db.Select<Producto>(x => x.IdProducto == idProducto).FirstOrDefault();
            producto.Cantidad_Stock = producto.Cantidad_Stock + Cantidad;
            db.Update(producto);
        }
    }
}
