using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhalosBoutique.DATA
{
    public class ViewProductos
    {
        public int Codigo { get; set; }
        public string Categoria { get; set; }
        public string Nombre { get; set; }
        public double PrecioMayor { get; set; }
        public double PrecioDetalle { get; set; }
        public double PrecioCosto { get; set; }
        public int Cantidad_en_Stock { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
    }
}
