using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.Proveedores_y_Compras
{
    public class csComprasProveedores
    {
        public (bool, int) InsertarCompra(int idProveedor, DateTime fecha, decimal total)
        {
            csConexionBD conexionBD = new csConexionBD();
            bool resultado = false;
            int idCompra = 0;

            using (SqlConnection conexion = conexionBD.CrearConexion())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand("SP_INSERT_TB_COMPRAS", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@ID_PROVEEDOR", idProveedor);
                        comando.Parameters.AddWithValue("@FECHA", fecha);
                        comando.Parameters.AddWithValue("@TOTAL", total);

                        SqlParameter paramResultado = new SqlParameter("@Resultado", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        SqlParameter paramIdFinal = new SqlParameter("@IdFinal", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        comando.Parameters.Add(paramResultado);
                        comando.Parameters.Add(paramIdFinal);

                        comando.ExecuteNonQuery();

                        resultado = Convert.ToBoolean(paramResultado.Value);
                        idCompra = Convert.ToInt32(paramIdFinal.Value);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al insertar la compra: " + ex.Message, ex);
                }
            }

            return (resultado, idCompra);
        }

        public (DataTable, bool) ListarCompras()
        {
            csConexionBD conexionBD = new csConexionBD();
            DataTable tabla = new DataTable();
            bool resultado = false;

            using (SqlConnection conexion = conexionBD.CrearConexion())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand("SP_SELECT_TB_COMPRAS", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        comando.Parameters.Add(resultadoParam);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }

                        resultado = Convert.ToBoolean(resultadoParam.Value);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al consultar las compras: " + ex.Message, ex);
                }
            }

            return (tabla, resultado);
        }

        public bool ActualizarCompra(int idCompra, int idProveedor, DateTime fecha, decimal total)
        {
            csConexionBD conexionBD = new csConexionBD();
            bool resultado = false;

            using (SqlConnection conexion = conexionBD.CrearConexion())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand("SP_UPDATE_TB_COMPRAS", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@ID_COMPRA", idCompra);
                        comando.Parameters.AddWithValue("@ID_PROVEEDOR", idProveedor);
                        comando.Parameters.AddWithValue("@FECHA", fecha);
                        comando.Parameters.AddWithValue("@TOTAL", total);

                        SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        comando.Parameters.Add(resultadoParam);
                        comando.ExecuteNonQuery();
                        resultado = Convert.ToBoolean(resultadoParam.Value);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al actualizar la compra: " + ex.Message, ex);
                }
            }
            return resultado;
        }

        public (DataTable, bool) ComboboxListarProductos()
        {
            csConexionBD conexionBD = new csConexionBD();
            DataTable tabla = new DataTable();
            bool resultado = false;

            using (SqlConnection conexion = conexionBD.CrearConexion())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand("SP_SELECT_TB_PRODUCTOS_LISTA", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        comando.Parameters.Add(resultadoParam);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }

                        resultado = Convert.ToBoolean(resultadoParam.Value);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al consultar las compras: " + ex.Message, ex);
                }
            }

            return (tabla, resultado);
        }

        public (DataTable, bool) ComboboxListarProveedores()
        {
            csConexionBD conexionBD = new csConexionBD();
            DataTable tabla = new DataTable();
            bool resultado = false;

            using (SqlConnection conexion = conexionBD.CrearConexion())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand("SP_SELECT_TB_PROVEEDORES_LISTA", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        comando.Parameters.Add(resultadoParam);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }

                        resultado = Convert.ToBoolean(resultadoParam.Value);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al consultar las compras: " + ex.Message, ex);
                }
            }

            return (tabla, resultado);
        }

        public bool InsertarDetalleCompra(int idCompra, int idProducto, int cantidad, decimal precioUnitario)
        {
            csConexionBD conexionBD = new csConexionBD();
            bool resultado = false;

            try
            {
                using (SqlConnection conexion = conexionBD.CrearConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_INSERT_TB_DETALLE_COMPRAS", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_COMPRA", idCompra);
                        cmd.Parameters.AddWithValue("@ID_PRODUCTO", idProducto);
                        cmd.Parameters.AddWithValue("@CANTIDAD", cantidad);
                        cmd.Parameters.AddWithValue("@PRECIO_UNITARIO", precioUnitario);

                        SqlParameter paramResultado = new SqlParameter("@Resultado", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(paramResultado);
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        resultado = Convert.ToBoolean(paramResultado.Value);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar detalle de compra: " + ex.Message);
            }

            return resultado;
        }


    }
}
