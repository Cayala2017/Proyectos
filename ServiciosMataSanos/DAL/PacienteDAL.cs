using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using EN;

namespace DAL
{
    public class PacienteDAL
    {

        BD M = new BD();
        public String AgregarPaciente(PacienteEN pAgregar)
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@dni", pAgregar.Dni));
                lst.Add(new Parametros("@nombre", pAgregar.Nombre));
                lst.Add(new Parametros("@apellido", pAgregar.Apellido));
                lst.Add(new Parametros("@fechaNacimiento", pAgregar.FechaNacimiento));
                lst.Add(new Parametros("@estado", pAgregar.Estado));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("AgregarPaciente", ref lst);
                return Mensaje = lst[5].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public int AgregarPaciente(PacienteEN pModificar)
        //{
        //    IDbConnection conn = ConexionDatos.conexion();
        //    conn.Open();
        //    SqlCommand comand = new SqlCommand("AgregarPaciente", conn as SqlConnection);
        //    comand.CommandType = CommandType.StoredProcedure;
            
        //    comand.Parameters.Add(new SqlParameter("@dni", pModificar.Dni));
        //    comand.Parameters.Add(new SqlParameter("@nombre", pModificar.Nombre));
        //    comand.Parameters.Add(new SqlParameter("@apellido", pModificar.Apellido));
        //    comand.Parameters.Add(new SqlParameter("@fechaNacimiento", pModificar.FechaNacimiento));
        //    comand.Parameters.Add(new SqlParameter("@estado", pModificar.Estado));

        //    int resultado = comand.ExecuteNonQuery();
        //    conn.Close();
        //    return resultado;
        //}
        public int ActualizarPaciente(PacienteEN pModificar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("ActualizarPaciente", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;

            comand.Parameters.Add(new SqlParameter("@IdNumeroSeguro", pModificar.IdNumeroSeguro));
            comand.Parameters.Add(new SqlParameter("@dni", pModificar.Dni));
            comand.Parameters.Add(new SqlParameter("@nombre", pModificar.Nombre));
            comand.Parameters.Add(new SqlParameter("@apellido", pModificar.Apellido));
            comand.Parameters.Add(new SqlParameter("@fechaNacimiento", pModificar.FechaNacimiento));
            comand.Parameters.Add(new SqlParameter("@estado", pModificar.Estado));
            
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public List<PacienteEN> MostrarPaciente()
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("MostrarPaciente", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            IDataReader reader = comand.ExecuteReader();
            List<PacienteEN> lista = new List<PacienteEN>();
            while (reader.Read())
            {

                PacienteEN propiedades = new PacienteEN();
                propiedades.IdNumeroSeguro = reader.GetInt64(0);
                propiedades.Dni = reader.GetString(1);
                propiedades.Nombre = reader.GetString(2);
                propiedades.Apellido = reader.GetString(3);
                propiedades.FechaNacimiento = reader.GetString(4);
                propiedades.Estado = reader.GetString(5);
                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }

        public List<PacienteEN> BuscarPacientePordni(PacienteEN pPaciente)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("BuscarPacientePordni", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@dni", pPaciente.Dni));
            IDataReader reader = comand.ExecuteReader();
            List<PacienteEN> lista = new List<PacienteEN>();
            while (reader.Read())
            {
                PacienteEN propiedades = new PacienteEN();
                propiedades.IdNumeroSeguro = reader.GetInt64(0);
                propiedades.Dni = reader.GetString(1);
                propiedades.Nombre = reader.GetString(2);
                propiedades.Apellido = reader.GetString(3);
                propiedades.FechaNacimiento = reader.GetString(4);
                propiedades.Estado = reader.GetString(5);

                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }
        public List<PacienteEN> BuscarPacientePorEstado(PacienteEN pPaciente)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("BuscarPacientePorEstado", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@dni", pPaciente.Dni));
            IDataReader reader = comand.ExecuteReader();
            List<PacienteEN> lista = new List<PacienteEN>();
            while (reader.Read())
            {
                PacienteEN propiedades = new PacienteEN();
                propiedades.IdNumeroSeguro = reader.GetInt64(0);
                propiedades.Dni = reader.GetString(1);
                propiedades.Nombre = reader.GetString(2);
                propiedades.Apellido = reader.GetString(3);
                propiedades.FechaNacimiento = reader.GetString(4);
                propiedades.Estado = reader.GetString(5);

                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }
        
    }
}
