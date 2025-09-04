using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.Productos_e_Inventario
{
    public class csGestionCategorias
    {
        public bool InsertarCategoria(string nombre, string descripcion)
        {
            bool resultado = false;
            csConexionBD conexionBD = new csConexionBD();

            try
            {
                using (SqlConnection conexion = conexionBD.CrearConexion())
                using (SqlCommand comando = new SqlCommand("SP_INSERT_TB_CATEGORIA", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("@NOMBRE", SqlDbType.NVarChar, 100).Value = nombre;
                    comando.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar, 200).Value = (object)descripcion ?? DBNull.Value;

                    SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    comando.Parameters.Add(salida);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(salida.Value);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar la categoría: " + ex.Message, ex);
            }

            return resultado;
        }

        public bool ActualizarCategoria(int idCategoria, string nombre, string descripcion)
        {
            bool resultado = false;
            csConexionBD conexionBD = new csConexionBD();

            try
            {
                using (SqlConnection conexion = conexionBD.CrearConexion())
                using (SqlCommand comando = new SqlCommand("SP_UPDATE_TB_CATEGORIA", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("@ID_CATEGORIA", SqlDbType.Int).Value = idCategoria;
                    comando.Parameters.Add("@NOMBRE", SqlDbType.NVarChar, 100).Value = nombre;
                    comando.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar, 200).Value = (object)descripcion ?? DBNull.Value;

                    SqlParameter salida = new SqlParameter("@Resultado", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    comando.Parameters.Add(salida);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(salida.Value);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar la categoría: " + ex.Message, ex);
            }

            return resultado;
        }

        public (DataTable, bool) ObtenerCategorias()
        {
            csConexionBD conexionBD = new csConexionBD();
            DataTable tablaCategorias = new DataTable();
            bool resultado = false;

            using (SqlConnection conexion = conexionBD.CrearConexion())
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_SELECT_TB_CATEGORIA", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        comando.Parameters.Add(resultadoParam);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(tablaCategorias);
                        }

                        resultado = Convert.ToBoolean(resultadoParam.Value);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al obtener categorías: " + ex.Message, ex);
                }
            }

            return (tablaCategorias, resultado);
        }


    }
}
