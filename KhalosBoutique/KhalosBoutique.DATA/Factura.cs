using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhalosBoutique.DATA
{
   public class Factura
    {
        [AutoIncrement]
        public int Id_Factura { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public double PrecioTotal { get; set; }
    }
}
