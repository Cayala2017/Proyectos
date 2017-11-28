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
   public class CamaDAL
    {
        public int AgregarCama(CamaEN pAgregar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("AgregarCama", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            try
            {
                comand.Parameters.Add(new SqlParameter("@fkPlanta", pAgregar.FkPlanta));

            }
            catch (Exception) { throw; }
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public int ModificarCama(CamaEN pModificar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("ActualizarCama", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            try
            {
                comand.Parameters.Add(new SqlParameter("@IdCama", pModificar.IdCama));
                comand.Parameters.Add(new SqlParameter("@fkPlanta", pModificar.FkPlanta));

            }
            catch (Exception) { throw; }
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }
        public int EliminarCama(CamaEN pEliminar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("EliminarCama", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            try
            {
                comand.Parameters.Add(new SqlParameter("@IdCama", pEliminar.IdCama));

            }
            catch (Exception) { throw; }
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public List<CamaEN> MostrarCama()
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("MostrarCamas", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            IDataReader reader = comand.ExecuteReader();
            List<CamaEN> lista = new List<CamaEN>();
            while (reader.Read())
            {
                CamaEN propiedades = new CamaEN();
                propiedades.IdCama = reader.GetInt64(0);
                propiedades.FkPlanta = reader.GetInt64(1);

                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }

        public List<CamaEN> BuscarCamaPlanta(CamaEN pCama)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("BuscarCamas", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@fkPlanta", pCama.FkPlanta));
            IDataReader reader = comand.ExecuteReader();
            List<CamaEN> lista = new List<CamaEN>();
            while (reader.Read())
            {
                CamaEN propiedades = new CamaEN();
                propiedades.IdCama = reader.GetInt64(0);
                propiedades.FkPlanta = reader.GetInt64(1);
                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }
    }
}
