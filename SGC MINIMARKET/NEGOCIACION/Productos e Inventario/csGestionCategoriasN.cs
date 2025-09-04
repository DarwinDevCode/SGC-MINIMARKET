using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS.Productos_e_Inventario;

namespace NEGOCIACION.Productos_e_Inventario
{
    public class csGestionCategoriasN
    {
        csGestionCategorias clase_gestion_categorias = new csGestionCategorias();
        public bool InsertarCategoria(string nombre, string descripcion)
        {
            return clase_gestion_categorias.InsertarCategoria(nombre, descripcion);
        }

        public bool ActualizarCategoria(int idCategoria, string nombre, string descripcion)
        {
            return clase_gestion_categorias.ActualizarCategoria(idCategoria, nombre, descripcion);
        }

        public (DataTable, bool) ObtenerCategorias()
        {
            return clase_gestion_categorias.ObtenerCategorias();
        }
    }
}
