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
   public class HistorialDAL
    {
        public int AgregarHistorial(HistorialEN pAgregar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("AgregarHistorial", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;

            comand.Parameters.Add(new SqlParameter("@FechaEntrada", pAgregar.FechaEntrada));
            comand.Parameters.Add(new SqlParameter("@FechaAlta", pAgregar.FechaAlta));
            comand.Parameters.Add(new SqlParameter("@fkNumeroSeguro", pAgregar.FkNumeroSeguro));

            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }
        public int ModificarHistorial(HistorialEN pModificar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("ModificarHistorial", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@IdHistorial", pModificar.IdHistorial));
            comand.Parameters.Add(new SqlParameter("@FechaEntrada", pModificar.FechaEntrada));
            comand.Parameters.Add(new SqlParameter("@FechaAlta", pModificar.FechaAlta));
            comand.Parameters.Add(new SqlParameter("@fkNumeroSeguro", pModificar.FkNumeroSeguro));

            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public List<HistorialEN> MostrarHistorial()
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("MostrarHistorial", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            IDataReader reader = comand.ExecuteReader();
            List<HistorialEN> lista = new List<HistorialEN>();
            while (reader.Read())
            {
                HistorialEN propiedades = new HistorialEN();
                propiedades.IdHistorial = reader.GetInt64(0);
                propiedades.FechaEntrada = reader.GetString(1);
                propiedades.FechaAlta = reader.GetString(2);
                propiedades.FkNumeroSeguro = reader.GetInt64(3);
                propiedades.DniP = reader.GetString(4);
                propiedades.NombreP = reader.GetString(5);
                propiedades.ApellidoP = reader.GetString(6);

                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }

        public List<HistorialEN> BuscarHistorial(HistorialEN pHistorial)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("BuscarHistorial", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@dni", pHistorial.DniP));
            IDataReader reader = comand.ExecuteReader();
            List<HistorialEN> lista = new List<HistorialEN>();
            while (reader.Read())
            {
                HistorialEN propiedades = new HistorialEN();
                propiedades.IdHistorial = reader.GetInt64(0);
                propiedades.FechaEntrada = reader.GetString(1);
                propiedades.FechaAlta = reader.GetString(2);
                propiedades.FkNumeroSeguro = reader.GetInt64(3);
                propiedades.DniP = reader.GetString(4);
                propiedades.NombreP = reader.GetString(5);
                propiedades.ApellidoP = reader.GetString(6);
                
                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }
        public List<HistorialEN> BuscarHistorialPorFechaEntrada(HistorialEN pHistorial)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("BuscarHistorialPorFechaEntrada", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@FechaEntrada", pHistorial.FechaEntrada));
            IDataReader reader = comand.ExecuteReader();
            List<HistorialEN> lista = new List<HistorialEN>();
            while (reader.Read())
            {
                HistorialEN propiedades = new HistorialEN();
                propiedades.IdHistorial = reader.GetInt64(0);
                propiedades.FechaEntrada = reader.GetString(1);
                propiedades.FechaAlta = reader.GetString(2);
                propiedades.FkNumeroSeguro = reader.GetInt64(3);
                propiedades.DniP = reader.GetString(4);
                propiedades.NombreP = reader.GetString(5);
                propiedades.ApellidoP = reader.GetString(6);

                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }
        public List<HistorialEN> BuscarHistorialPorFechaAlta(HistorialEN pHistorial)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("BuscarHistorialPorFechaAlta", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@FechaAlta", pHistorial.FechaAlta));
            IDataReader reader = comand.ExecuteReader();
            List<HistorialEN> lista = new List<HistorialEN>();
            while (reader.Read())
            {
                HistorialEN propiedades = new HistorialEN();
                propiedades.IdHistorial = reader.GetInt64(0);
                propiedades.FechaEntrada = reader.GetString(1);
                propiedades.FechaAlta = reader.GetString(2);
                propiedades.FkNumeroSeguro = reader.GetInt64(3);
                propiedades.DniP = reader.GetString(4);
                propiedades.NombreP = reader.GetString(5);
                propiedades.ApellidoP = reader.GetString(6);

                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }
    }
}
