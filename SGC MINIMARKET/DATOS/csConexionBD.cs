using System;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
    public class csConexionBD
    {
        private readonly string cadenaConexion;

        public csConexionBD()
        {
            cadenaConexion = @"Password=123;Persist Security Info=False;User ID=sa;Initial Catalog=GC_MINIMARKET;Data Source=DESKTOP-QJOCHDP";
            //cadenaConexion = @"Server=.;Database=GC_MINIMARKET;Trusted_Connection=Yes;"; // Guizado
        }

        public SqlConnection CrearConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
