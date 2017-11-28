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
   public class PlantaDAL
    {

        BD M = new BD();
        public String AgregarPlanta(PlantaEN pAgregar)
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@nombre", pAgregar.Nombre));
                lst.Add(new Parametros("@numeroCamas", pAgregar.NumeroCamas));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("AgregarPlanta", ref lst);
                return Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public int AgregarPlanta(PlantaEN pAgregar)
        //{
        //    IDbConnection conn = ConexionDatos.conexion();
        //    conn.Open();
        //    SqlCommand comand = new SqlCommand("AgregarPlanta", conn as SqlConnection);
        //    comand.CommandType = CommandType.StoredProcedure;
        //    try
        //    {
        //        comand.Parameters.Add(new SqlParameter("@nombre", pAgregar.Nombre));
        //        comand.Parameters.Add(new SqlParameter("@numeroCamas", pAgregar.NumeroCamas));
        //    }
        //    catch (Exception) { throw; }
        //    int resultado = comand.ExecuteNonQuery();
        //    conn.Close();
        //    return resultado;
        //}

        public int ActualizarPlanta(PlantaEN pModificar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("ActualizarPlanta", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            try
            {
                comand.Parameters.Add(new SqlParameter("@IdPlanta", pModificar.IdPlanta));
                comand.Parameters.Add(new SqlParameter("@nombre", pModificar.Nombre));
                comand.Parameters.Add(new SqlParameter("@numeroCamas", pModificar.NumeroCamas));
            }
            catch (Exception) { throw; }
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }


        public List<PlantaEN> MostraPlantas()
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("MostraPlantas", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            IDataReader reader = comand.ExecuteReader();
            List<PlantaEN> lista = new List<PlantaEN>();
            while (reader.Read())
            {

                PlantaEN propiedades = new PlantaEN();
                propiedades.IdPlanta = reader.GetInt64(0);
                propiedades.Nombre = reader.GetString(1);
                propiedades.NumeroCamas = reader.GetInt32(2);
                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }

        public List<PlantaEN> BuscarPlanta(PlantaEN pPlanta)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("BuscarPlanta", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@nombre", pPlanta.Nombre));
            IDataReader reader = comand.ExecuteReader();
            List<PlantaEN> lista = new List<PlantaEN>();
            while (reader.Read())
            {
                PlantaEN propiedades = new PlantaEN();
                propiedades.IdPlanta = reader.GetInt64(0);
                propiedades.Nombre = reader.GetString(1);
                propiedades.NumeroCamas = reader.GetInt32(2);
                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }
    }
}
