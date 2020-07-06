using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32.SafeHandles;

namespace EntidadeBaseDeDatos_Provincia
{
    /// <summary>
    /// Esta clase se comunicara con la BD Provincia en SQL Server
    /// </summary>
    public class AccesoDatos_Provincia
    {
        #region Atributos

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        #endregion

        #region Constructores
        /// <summary>
        /// 
        /// </summary>
        public AccesoDatos_Provincia()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.conexionProvincia);
        }

        /// <summary>
        /// 
        /// </summary>
        public AccesoDatos_Provincia(string cadenaConexion)
        {
            this.conexion = new SqlConnection(cadenaConexion);
        }
        #endregion

        #region PruebaConexion
        public bool ProbarConexion()
        {
            bool sePudo = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception)
            {
                sePudo = false;
            }
            finally
            {
                if(this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close(); 
                }
            }
            return sePudo;
        }

        #endregion

        #region Consultas de Seleccion
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Provincia> ObtenerListaProvincias()
        {
            List<Provincia> provincias = new List<Provincia>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text; //admite un enumerado, el text le dice al comando que el contenido del commandType es una instruccion
                                                               //TableDirect espera un nombre de una tabla
                                                               //StoreProcedure espera el nombre de un procedimiento almacenado. Instruccion de SQL guardado en una base de datos
                this.comando.CommandText = "SELECT * FROM DatosProvincia"; //depende del commandType
                this.comando.Connection = this.conexion; //si el connection no esta establecido y la conexion no esta abierta, falla

                this.conexion.Open();

                this.lector = comando.ExecuteReader();//si es consulta de seleccion, uso el executeReader() -> retorna un SQLDataReader con el contenido de las filas afectadas x la seleccion
                
                while(lector.Read())//-> este metodo desplaza al siguiente registro! retorna true mientras haya elementos, sino devuelve false
                {
                    Provincia unaProvincia = new Provincia();

                    unaProvincia.id = lector.GetInt32(0);
                    unaProvincia.nombre_provincia = lector.GetString(1);
                    unaProvincia.cantidad_habitantes = lector.GetInt32(2);

                    provincias.Add(unaProvincia);
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return provincias;
        }

        #endregion

        #region Inserciones
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Agregar(Provincia p)
        {
            bool sePudo = false;

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.Parameters.AddWithValue("@nombre_provincia", p.nombre_provincia);
                this.comando.Parameters.AddWithValue("@cantidad_habitantes", p.cantidad_habitantes);
                //this.comando.CommandText = "INSERT INTO DatosProvincia (nombre_provincia, cantidad_habitantes) VALUES ('"+p.nombre_provincia+"',"+p.cantidad_habitantes+")";
                this.comando.CommandText = "INSERT INTO DatosProvincia(nombre_provincia, cantidad_habitantes) VALUES(@nombre_provincia, @cantidad_habitantes)";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int resultadoInsercion = comando.ExecuteNonQuery();

                if(resultadoInsercion != 0)
                {
                    sePudo = true;
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return sePudo;
        }
        public bool AgregarProvinciaABase(Provincia p)
        {
            return this.Agregar(p);
        }
        #endregion

        #region Modificaciones
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ModificarProvincia(Provincia p)
        {
            bool seModifico = false;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@id", p.id);
                this.comando.Parameters.AddWithValue("@nombre_provincia", p.nombre_provincia);
                this.comando.Parameters.AddWithValue("@cantidad_habitantes", p.cantidad_habitantes);

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "UPDATE DatosProvincia SET nombre_provincia = @nombre_provincia, cantidad_habitantes = @cantidad_habitantes WHERE id = @id";

                this.comando.Connection = this.conexion;
                this.conexion.Open();

                int resultadoModificacion = this.comando.ExecuteNonQuery();

                if(resultadoModificacion != 0)
                {
                    seModifico = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return seModifico;
        }



        #endregion

        #region Eliminar
        public bool EliminarProvincia(int id)
        {
            bool seElimino = false;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@id", id);

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "DELETE FROM DatosProvincia WHERE id = @id";

                this.comando.Connection = this.conexion;
                this.conexion.Open();

                int resultadoEliminacion = this.comando.ExecuteNonQuery();
                
                if(resultadoEliminacion != 0)
                {
                    seElimino = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return seElimino;
        }


        #endregion

        public DataTable ObtenerDataTableProvincias()
        {
            DataTable tabla = new DataTable("Provincias");

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM DatosProvincia";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                tabla.Load(lector);

                lector.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return tabla;
        }

    }
}
