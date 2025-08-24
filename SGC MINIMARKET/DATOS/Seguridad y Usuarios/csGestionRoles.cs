using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.Seguridad_y_Usuarios
{
    public class csGestionRoles
    {
        public bool InsertarRol(string nombre)
        {
            bool resultado = false;
            csConexionBD conexionBD = new csConexionBD();

            try
            {
                using (SqlConnection conexion = conexionBD.CrearConexion())
                using (SqlCommand comando = new SqlCommand("SP_INSERT_TB_ROL", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("@NOMBRE", SqlDbType.NVarChar, 50).Value = nombre;
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
                throw new Exception("Error al insertar el rol: " + ex.Message, ex);
            }

            return resultado;
        }

        public (DataTable, bool) ObtenerRoles()
        {
            csConexionBD conexionBD = new csConexionBD();
            DataTable tablaRoles = new DataTable();
            bool resultado = false;

            using (SqlConnection conexion = conexionBD.CrearConexion())
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("SP_SELECT_TB_ROL", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        comando.Parameters.Add(resultadoParam);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(tablaRoles);
                        }

                        resultado = Convert.ToBoolean(resultadoParam.Value);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al obtener roles: " + ex.Message, ex);
                }
            }

            return (tablaRoles, resultado);
        }

        public bool ActualizarRol(int id, string nombre)
        {
            csConexionBD conexionBD = new csConexionBD();
            bool resultado = false;

            using (SqlConnection conexion = conexionBD.CrearConexion())
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand("SP_UPDATE_TB_ROL", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@ID", id);
                        comando.Parameters.AddWithValue("@NOMBRE", nombre);

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
                    throw new Exception("Error al actualizar el rol: " + ex.Message, ex);
                }
            }

            return resultado;
        }
    }
}
