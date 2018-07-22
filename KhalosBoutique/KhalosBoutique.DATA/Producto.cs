using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace KhalosBoutique.DATA
{
    public class Producto
    {
        [AutoIncrement]
        public int IdProducto { get; set; }

        public int IdCategoria { get; set; }

        public string Nombre { get; set; }

        public int Cantidad_Stock { get; set; }

        public string Descripcion { get; set; }

        public string Talla { get; set; }

        public double PrecioMayor { get; set; }

        public double PrecioDetalle { get; set; }

        public double PrecioCosto { get; set; }

        public string Color { get; set; }
    }
}
