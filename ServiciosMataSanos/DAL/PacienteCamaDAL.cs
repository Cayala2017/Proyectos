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
   public class PacienteCamaDAL
    {
        public int ActualizarCamaAPaciente(PacienteCamaEN pModificar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("ActualizarCamaAPaciente", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            try
            {
                comand.Parameters.Add(new SqlParameter("@IdPacienteCama", pModificar.IdPacienteCama));
                comand.Parameters.Add(new SqlParameter("@FechaAsignada", pModificar.FechaAsignada));
                comand.Parameters.Add(new SqlParameter("@fkCama", pModificar.FkCama));
                comand.Parameters.Add(new SqlParameter("@fkHistoria", pModificar.FkHistoria));

            }
            catch (Exception) { throw; }
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }
        public int AgregarCamaAPaciente(PacienteCamaEN pAgregar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("AgregarCamaAPaciente", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            try
            {
                comand.Parameters.Add(new SqlParameter("@FechaAsignada", pAgregar.FechaAsignada));
                comand.Parameters.Add(new SqlParameter("@fkCama", pAgregar.FkCama));
                comand.Parameters.Add(new SqlParameter("@fkHistoria", pAgregar.FkHistoria));
            }
            catch (Exception) { throw; }
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public int EliminarCamaAPaciente(PacienteCamaEN pEliminar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("EliminarCamaAPaciente", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            try
            {
                comand.Parameters.Add(new SqlParameter("@IdPacienteCama", pEliminar.IdPacienteCama));

            }
            catch (Exception) { throw; }
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public List<PacienteCamaEN> MostrarPacienteCama()
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("MostrarPacienteCama", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            IDataReader reader = comand.ExecuteReader();
            List<PacienteCamaEN> lista = new List<PacienteCamaEN>();
            while (reader.Read())
            {

                PacienteCamaEN propiedades = new PacienteCamaEN();
                propiedades.IdPacienteCama = reader.GetInt64(0);
                propiedades.FechaAsignada = reader.GetString(1);
                propiedades.FkCama = reader.GetInt64(2);
                propiedades.FkHistoria = reader.GetInt64(3);
                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }

        public List<PacienteCamaEN> BuscraCamaPacientePorFecha(PacienteCamaEN pPC)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("BuscraCamaPacientePorFecha", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@fechaAsignacion", pPC.FechaAsignada));
            IDataReader reader = comand.ExecuteReader();
            List<PacienteCamaEN> lista = new List<PacienteCamaEN>();
            while (reader.Read())
            {
                PacienteCamaEN propiedades = new PacienteCamaEN();
                propiedades.IdPacienteCama = reader.GetInt64(0);
                propiedades.FechaAsignada = reader.GetString(1);
                propiedades.FkCama = reader.GetInt64(2);
                propiedades.FkHistoria = reader.GetInt64(3);
                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }
    }
}
