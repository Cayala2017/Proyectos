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
    public class EnfermeraDAL
    {
        BD M = new BD();
        public String ReguistraEnfermero(EnfermeraEN pAgregar)
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@DUI", pAgregar.DUI));
                lst.Add(new Parametros("@nombre", pAgregar.Nombre));
                lst.Add(new Parametros("@apellido", pAgregar.Apellido));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("ReguistraEnfermero", ref lst);
                return Mensaje = lst[3].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public int ReguistraEnfermero(EnfermeraEN pAgregar)
        //{
        //    IDbConnection conn = ConexionDatos.conexion();
        //    conn.Open();
        //    SqlCommand comand = new SqlCommand("ReguistraEnfermero", conn as SqlConnection);
        //    comand.CommandType = CommandType.StoredProcedure;
        //    try
        //    {
        //        comand.Parameters.Add(new SqlParameter("@nombre", pAgregar.Nombre));
        //        comand.Parameters.Add(new SqlParameter("@apellido", pAgregar.Apellido));
        //    }
        //    catch (Exception) { throw; }
        //    int resultado = comand.ExecuteNonQuery();
        //    conn.Close();
        //    return resultado;
        //}

        public int ModificarEnfermeras(EnfermeraEN pModificar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("ModificarEnfermeras", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            try
            {
                comand.Parameters.Add(new SqlParameter("@DUI", pModificar.DUI));
                comand.Parameters.Add(new SqlParameter("@nombre", pModificar.Nombre));
                comand.Parameters.Add(new SqlParameter("@apellido", pModificar.Apellido));
            }
            catch (Exception) { throw; }
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public int EliminarEnfermeras(EnfermeraEN pEliminar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("EliminarEnfermeras", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            try
            {
                comand.Parameters.Add(new SqlParameter("@DUI", pEliminar.DUI));
            }
            catch (Exception) { throw; }
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public List<EnfermeraEN> MostrarEnfermeras()
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("MostrarEnfermeras", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            IDataReader reader = comand.ExecuteReader();
            List<EnfermeraEN> lista = new List<EnfermeraEN>();
            while (reader.Read())
            {

                EnfermeraEN propiedades = new EnfermeraEN();
                propiedades.DUI = reader.GetString(0);
                propiedades.Nombre = reader.GetString(1);
                propiedades.Apellido = reader.GetString(2);
                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }

        public List<EnfermeraEN> BuscarEnfermera(EnfermeraEN pEnfermera)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("BuscarEnfermera", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@DUI", pEnfermera.DUI));
            IDataReader reader = comand.ExecuteReader();
            List<EnfermeraEN> lista = new List<EnfermeraEN>();
            while (reader.Read())
            {
                EnfermeraEN propiedades = new EnfermeraEN();
                propiedades.DUI = reader.GetString(0);
                propiedades.Nombre = reader.GetString(1);
                propiedades.Apellido = reader.GetString(2);
                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }
    }
}
