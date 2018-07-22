using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhalosBoutique.DATA
{
    public class ViewProductosStock
    {
        public int Codigo { get; set; }
        public string Categoria { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Disponible { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Talla { get; set; }
    }
}
