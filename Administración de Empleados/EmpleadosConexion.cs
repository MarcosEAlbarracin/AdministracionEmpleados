using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Administración_de_Empleados
{
    class EmpleadosConexion
    {
        public List<Empleados> ListarEmpleados()
        {
            List<Empleados> lista = new List<Empleados>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            conexion.ConnectionString = "data source=ALBARRACIN-PC; initial catalog=EMPLEADOS_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from Empleados";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Empleados aux = new Empleados();
                aux.Id = lector.GetInt32(0);
                aux.NombreCompleto = lector.GetString(1);
                aux.DNI = lector.GetString(2);
                aux.Edad = lector.GetInt32(3);
                aux.Casado = lector.GetBoolean(4);
                aux.Salario = lector.GetDecimal(5);

                lista.Add(aux);
            }

            conexion.Close();

            return lista;
        }

        public List<Empleados> ListarEmpleados(string nombre)
        {
            List<Empleados> lista = new List<Empleados>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source=ALBARRACIN-PC; initial catalog=EMPLEADOS_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from Empleados where NombreCompleto like '" + nombre + "%'";
                comando.Connection = conexion;
                conexion.Open();

                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Empleados aux = new Empleados();
                    aux.Id = lector.GetInt32(0);
                    aux.NombreCompleto = lector.GetString(1);
                    aux.DNI = lector.GetString(2);
                    aux.Edad = lector.GetInt32(3);
                    aux.Casado = lector.GetBoolean(4);
                    aux.Salario = lector.GetDecimal(5);

                    lista.Add(aux);
                }
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        internal void modificar(Empleados empleado)
        {
            SqlConnection conexion = new SqlConnection("data source=ALBARRACIN-PC; initial catalog=EMPLEADOS_DB; integrated security=sspi");
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            try
            {
                comando.CommandText = "Update Empleados Set NombreCompleto=@nombre, DNI=@dni, Edad=@edad, Casado=@casado, Salario=@salario Where Id=@id"; //modificar el string con los campos correctamente
                comando.Parameters.AddWithValue("@nombre", empleado.NombreCompleto);
                comando.Parameters.AddWithValue("@dni", empleado.DNI);
                comando.Parameters.AddWithValue("@edad", empleado.Edad);
                comando.Parameters.AddWithValue("@casado", empleado.Casado);
                comando.Parameters.AddWithValue("@salario", empleado.Salario);
                comando.Parameters.AddWithValue("@id", empleado.Id);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal void eliminar(int id)
        {
            SqlConnection conexion = new SqlConnection("data source=ALBARRACIN-PC; initial catalog=EMPLEADOS_DB; integrated security=sspi");
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            try
            {
                comando.CommandText = "Delete From Empleados Where Id=@id";
                comando.Parameters.AddWithValue("@id", id);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Empleados empleadonuevo)
        {
            SqlConnection conexion = new SqlConnection("data source=ALBARRACIN-PC; initial catalog=EMPLEADOS_DB; integrated security=sspi");
            SqlCommand comando = new SqlCommand();

            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = "insert into Empleados values ('" + empleadonuevo.NombreCompleto + "', " + empleadonuevo.DNI + ", '"+empleadonuevo.Edad.ToString()+"', '"+empleadonuevo.Casado+"','"+empleadonuevo.Salario.ToString()+"')";
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

    }
}
