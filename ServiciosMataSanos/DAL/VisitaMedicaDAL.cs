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
   public class VisitaMedicaDAL
    {
        public int AgregarVisita(VisitaMedicaEN pAgregar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("AgregarVisita", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            try
            {
                comand.Parameters.Add(new SqlParameter("@fechaVisita", pAgregar.FechaVisita));
                comand.Parameters.Add(new SqlParameter("@horaVisita", pAgregar.HoraVisita));
                comand.Parameters.Add(new SqlParameter("@Daignostico", pAgregar.Daignostico));
                comand.Parameters.Add(new SqlParameter("@fkMedico", pAgregar.FkMedico));
                comand.Parameters.Add(new SqlParameter("@fkPacienteCama", pAgregar.FkPacienteCama));


            }
            catch (Exception) { throw; }
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public int EliminarVisita(VisitaMedicaEN pEliminar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("EliminarVisita", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            try
            {
                comand.Parameters.Add(new SqlParameter("@fkPacienteCama", pEliminar.FkPacienteCama));
            }
            catch (Exception) { throw; }
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public List<VisitaMedicaEN> MostrarVisita()
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("MostrarVisita", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            IDataReader reader = comand.ExecuteReader();
            List<VisitaMedicaEN> lista = new List<VisitaMedicaEN>();
            while (reader.Read())
            {

                VisitaMedicaEN propiedades = new VisitaMedicaEN();
                propiedades.FechaVisita = reader.GetString(0);
                propiedades.HoraVisita = reader.GetString(1);
                propiedades.Daignostico = reader.GetString(2);
                propiedades.FkMedico = reader.GetInt64(3);
                propiedades.FkPacienteCama = reader.GetInt64(4);

                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }

        public List<VisitaMedicaEN> BuscarVisita(VisitaMedicaEN pVisita)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("BuscarVisita", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@fkPacienteCama", pVisita.FkPacienteCama));
            IDataReader reader = comand.ExecuteReader();
            List<VisitaMedicaEN> lista = new List<VisitaMedicaEN>();
            while (reader.Read())
            {
                VisitaMedicaEN propiedades = new VisitaMedicaEN();
                propiedades.FechaVisita = reader.GetString(0);
                propiedades.HoraVisita = reader.GetString(1);
                propiedades.Daignostico = reader.GetString(2);
                propiedades.FkMedico = reader.GetInt64(3);
                propiedades.FkPacienteCama = reader.GetInt64(4);
                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }
    }
}
