using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using DATOS.Proveedores_y_Compras;
namespace NEGOCIACION.Proveedores_y_Compras
{
    public class csComprasProveedoresN
    {
        csComprasProveedores clase_compras_proveedores = new csComprasProveedores();
        public bool InsertarCompra(int idProveedor, DateTime fecha, decimal total)
        {
            return clase_compras_proveedores.InsertarCompra(idProveedor, fecha, total);
        }

        public (DataTable, bool) ListarCompras()
        {
            return clase_compras_proveedores.ListarCompras();
        }

        public bool ActualizarCompra(int idCompra, int idProveedor, DateTime fecha, decimal total)
        {
           return clase_compras_proveedores.ActualizarCompra(idCompra, idProveedor, fecha,total);
        }

        public (DataTable, bool) ComboboxListarProductos()
        {
            return clase_compras_proveedores.ComboboxListarProductos();
        }

        public (DataTable, bool) ComboboxListarProveedores()
        {
            return clase_compras_proveedores.ComboboxListarProveedores();
        }

        public bool InsertarDetalleCompra(int idCompra, int idProducto, int cantidad, decimal precioUnitario)
        {
            return clase_compras_proveedores.InsertarDetalleCompra(idCompra, idProducto, cantidad, precioUnitario);
        }
    }
}
