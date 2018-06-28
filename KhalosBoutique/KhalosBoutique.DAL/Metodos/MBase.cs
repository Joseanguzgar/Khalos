using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhalosBoutique.DAL.Metodos
{
    public class MBase
    {
        public OrmLiteConnectionFactory conexion;
        public IDbConnection db;

        public MBase()
        {
            conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            db = conexion.Open();
        }
    }
}
