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
   public class MedicoDAL
    {
        public int Validar(MedicoEN _pUsuario)
        {
            int resultado;

            using (IDbConnection conn = ConexionDatos.conexion())
            {
                conn.Open();
                SqlCommand comand = new SqlCommand("Validar", conn as SqlConnection);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add(new SqlParameter("@nombreUsuario", _pUsuario.NombreUsuario));
                comand.Parameters.Add(new SqlParameter("@contrasena",_pUsuario.Contrasena));
                IDataReader _reader = comand.ExecuteReader();

                if (_reader.Read() != false)
                {
                    resultado = 1;
                }
                else
                {
                    resultado = 0;
                }
                conn.Close();
            }
            return resultado;
        }

        public static string Cifrar(string pPalabra)
        {
            string caracteres = string.Empty;

            for (int i = 0; i < pPalabra.Length; i++)
            {
                string letra = pPalabra.Substring(i, 1);
                int codigo = Convert.ToChar(letra);
                int Codigocifrado = codigo + 3;
                char Caractecifrado = Convert.ToChar(Codigocifrado);
                caracteres = caracteres + Caractecifrado;
            }
            return caracteres;
        }
        BD M = new BD();
        public String AgregarMedico(MedicoEN pAgregar)
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@imagen", pAgregar.Imagen));
                lst.Add(new Parametros("@nombre", pAgregar.Nombre));
                lst.Add(new Parametros("@apellido", pAgregar.Apellido));
                lst.Add(new Parametros("@especialidad", pAgregar.Especialidad));
                lst.Add(new Parametros("@nombreUsuario", pAgregar.NombreUsuario));
                lst.Add(new Parametros("@contrasena", pAgregar.Contrasena));
                lst.Add(new Parametros("@fkPlanta", pAgregar.FkPlanta));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("AgregarMedico", ref lst);
                return Mensaje = lst[7].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public int AgregarMedico(MedicoEN pAgregar)
        //{
        //    IDbConnection conn = ConexionDatos.conexion();
        //    conn.Open();
        //    SqlCommand comand = new SqlCommand("AgregarMedico", conn as SqlConnection);
        //    comand.CommandType = CommandType.StoredProcedure;

        //    comand.Parameters.Add(new SqlParameter("@Imagen", pAgregar.Imagen));
        //    comand.Parameters.Add(new SqlParameter("@nombre", pAgregar.Nombre));
        //    comand.Parameters.Add(new SqlParameter("@apellido", pAgregar.Apellido));
        //    comand.Parameters.Add(new SqlParameter("@especialidad", pAgregar.Especialidad));
        //    comand.Parameters.Add(new SqlParameter("@nombreUsuario", pAgregar.NombreUsuario));
        //    comand.Parameters.Add(new SqlParameter("@contrasena", Cifrar(pAgregar.Contrasena)));
        //    comand.Parameters.Add(new SqlParameter("@fkPlanta", pAgregar.FkPlanta));
        //    int resultado = comand.ExecuteNonQuery();
        //    conn.Close();
        //    return resultado;
        //}

        public int ActualizarMedico(MedicoEN pModificar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("ActualizarMedico", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;

            comand.Parameters.Add(new SqlParameter("@IdMedico", pModificar.IdMedico));
            comand.Parameters.Add(new SqlParameter("@Imagen", pModificar.Imagen));
            comand.Parameters.Add(new SqlParameter("@nombre", pModificar.Nombre));
            comand.Parameters.Add(new SqlParameter("@apellido", pModificar.Apellido));
            comand.Parameters.Add(new SqlParameter("@especialidad", pModificar.Especialidad));
            comand.Parameters.Add(new SqlParameter("@nombreUsuario", pModificar.NombreUsuario));
            comand.Parameters.Add(new SqlParameter("@contrasena", Cifrar(pModificar.Contrasena)));
            comand.Parameters.Add(new SqlParameter("@fkPlanta", pModificar.FkPlanta));
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public int EliminarMedico(MedicoEN pEliminar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("EliminarMedico", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;

            comand.Parameters.Add(new SqlParameter("@IdMedico", pEliminar.IdMedico));
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public List<MedicoEN> MostrarMedico()
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("MostrarMedico", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            IDataReader reader = comand.ExecuteReader();
            List<MedicoEN> lista = new List<MedicoEN>();
            while (reader.Read())
            {
                MedicoEN propiedades = new MedicoEN();
                propiedades.IdMedico = reader.GetInt64(0);
                propiedades.Imagen = (byte[])reader[1];
                propiedades.Nombre = reader.GetString(2);
                propiedades.Apellido = reader.GetString(3);
                propiedades.Especialidad = reader.GetString(4);
                propiedades.NombreUsuario = reader.GetString(5);
                propiedades.Contrasena = reader.GetString(6);
                propiedades.FkPlanta = reader.GetInt64(7);

                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }

        public List<MedicoEN> BuscarMedicoEspecialidad(MedicoEN pMedicoEN)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("BuscarMedicoEspecialidad", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@especialidad", pMedicoEN.Especialidad));
            IDataReader reader = comand.ExecuteReader();
            List<MedicoEN> lista = new List<MedicoEN>();
            while (reader.Read())
            {
                MedicoEN propiedades = new MedicoEN();
                propiedades.IdMedico = reader.GetInt64(0);
                propiedades.Imagen = (byte[])reader[1];
                propiedades.Nombre = reader.GetString(2);
                propiedades.Apellido = reader.GetString(3);
                propiedades.Especialidad = reader.GetString(4);
                propiedades.NombreUsuario = reader.GetString(5);
                propiedades.Contrasena = reader.GetString(6);
                propiedades.FkPlanta = reader.GetInt64(7);
           
                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }
        public List<MedicoEN> BuscarMedicoApellido(MedicoEN pMedicoEN)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("BuscarMedicoApellido", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@apellido", pMedicoEN.Apellido));
            IDataReader reader = comand.ExecuteReader();
            List<MedicoEN> lista = new List<MedicoEN>();
            while (reader.Read())
            {
                MedicoEN propiedades = new MedicoEN();
                propiedades.IdMedico = reader.GetInt64(0);
                propiedades.Imagen = (byte[])reader[1];
                propiedades.Nombre = reader.GetString(2);
                propiedades.Apellido = reader.GetString(3);
                propiedades.Especialidad = reader.GetString(4);
                propiedades.NombreUsuario = reader.GetString(5);
                propiedades.Contrasena = reader.GetString(6);
                propiedades.FkPlanta = reader.GetInt64(7);

                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }
        public List<MedicoEN> ObtenerImagen(MedicoEN pMedicoEN)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("ObtenerImagen", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@nombreUsuario", pMedicoEN.NombreUsuario));
            IDataReader reader = comand.ExecuteReader();
            List<MedicoEN> lista = new List<MedicoEN>();
            while (reader.Read())
            {
                MedicoEN propiedades = new MedicoEN();
                propiedades.IdMedico = reader.GetInt64(0);
                propiedades.Imagen = (byte[])reader[1];
                propiedades.Nombre = reader.GetString(2);
                propiedades.Apellido = reader.GetString(3);
                propiedades.Especialidad = reader.GetString(4);
                propiedades.NombreUsuario = reader.GetString(5);
                propiedades.Contrasena = reader.GetString(6);
                propiedades.FkPlanta = reader.GetInt64(7);

                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }
    }
}
