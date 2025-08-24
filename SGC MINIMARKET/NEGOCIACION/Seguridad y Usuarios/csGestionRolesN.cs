using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS.Seguridad_y_Usuarios;

namespace NEGOCIACION.Seguridad_y_Usuarios
{
    public class csGestionRolesN
    {
        csGestionRoles clase_gestion_roles = new csGestionRoles();
        public bool InsertarRol(string nombre)
        {
            return clase_gestion_roles.InsertarRol(nombre);
        }

        public (DataTable, bool) ObtenerRoles()
        {
            return clase_gestion_roles.ObtenerRoles();
        }

        public bool ActualizarRol(int id, string nombre)
        {
            return clase_gestion_roles.ActualizarRol(id, nombre);
        }
    }
}
