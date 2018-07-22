using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace KhalosBoutique.DATA
{
    public class Categoria
    {
        [AutoIncrement]
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
    }
}
