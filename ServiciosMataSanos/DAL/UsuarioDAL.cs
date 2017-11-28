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
   public class UsuarioDAL
    {
        BD M = new BD();

        public String RegistrarUsuario(UsuarioEN pAgregar)
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@usuario", pAgregar.Usuario));
                lst.Add(new Parametros("@contrasena", Cifrar(pAgregar.Contrasena)));
                lst.Add(new Parametros("@FDUI", pAgregar.FDUI));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("RegistrarUsuario", ref lst);
                return Mensaje = lst[3].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public int RegistrarUsuario(UsuarioEN pAgregar)
        //{
        //    IDbConnection conn = ConexionDatos.conexion();
        //    conn.Open();
        //    SqlCommand comand = new SqlCommand("RegistrarUsuario", conn as SqlConnection);
        //    comand.CommandType = CommandType.StoredProcedure;
        //    try
        //    {
        //        comand.Parameters.Add(new SqlParameter("@Usuario", pAgregar.Usuario));
        //        comand.Parameters.Add(new SqlParameter("@Contrasena", pAgregar.Contrasena));
        //        comand.Parameters.Add(new SqlParameter("@FkdEnfermera", pAgregar.FkdEnfermera));

        //    }
        //    catch (Exception) { throw; }
        //    int resultado = comand.ExecuteNonQuery();
        //    conn.Close();
        //    return resultado;
        //}
        public String ModificarUsuario(UsuarioEN pModificar)
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@usuario", pModificar.Usuario));
                lst.Add(new Parametros("@contrasena", Cifrar(pModificar.Contrasena)));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("ModificarUsuario", ref lst);
                return Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public int ModificarUsuario(UsuarioEN pModificar)
        //{
        //    IDbConnection conn = ConexionDatos.conexion();
        //    conn.Open();
        //    SqlCommand comand = new SqlCommand("ModificarUsuario", conn as SqlConnection);
        //    comand.CommandType = CommandType.StoredProcedure;
        //    try
        //    {
        //        comand.Parameters.Add(new SqlParameter("@IdUsuario", pModificar.IdUsuario));
        //        comand.Parameters.Add(new SqlParameter("@Usuario", pModificar.Usuario));
        //        comand.Parameters.Add(new SqlParameter("@Contrasena", pModificar.Contrasena));
        //        comand.Parameters.Add(new SqlParameter("@FkdEnfermera", pModificar.FkdEnfermera));

        //    }
        //    catch (Exception) { throw; }
        //    int resultado = comand.ExecuteNonQuery();
        //    conn.Close();
        //    return resultado;
        //}
        public  int IniciarSesion(UsuarioEN _pUsuario)
        {
            int resultado;

            using (IDbConnection conn = ConexionDatos.conexion())
            {
                conn.Open();
                SqlCommand comand = new SqlCommand("IniciarSesion", conn as SqlConnection);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add(new SqlParameter("@usuario", _pUsuario.Usuario));
                comand.Parameters.Add(new SqlParameter("@contrasena", Cifrar(_pUsuario.Contrasena)));
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

        public  int EliminarUsuario(UsuarioEN pEliminar)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("EliminarUsuario", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            try
            {
                comand.Parameters.Add(new SqlParameter("@IdUsuario", pEliminar.IdUsuario));

            }
            catch (Exception) { throw; }
            int resultado = comand.ExecuteNonQuery();
            conn.Close();
            return resultado;
        }

        public  List<UsuarioEN> MostrarUsuarios()
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("MostrarUsuarios", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            IDataReader reader = comand.ExecuteReader();
            List<UsuarioEN> lista = new List<UsuarioEN>();
            while (reader.Read())
            {

                UsuarioEN propiedades = new UsuarioEN();
                propiedades.IdUsuario = reader.GetInt64(0);
                propiedades.Usuario = reader.GetString(1);
                propiedades.Contrasena = reader.GetString(2);
                propiedades.FDUI = reader.GetString(3);

                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }

        public  List<UsuarioEN> BuscarUsuario(UsuarioEN pUsuario)
        {
            IDbConnection conn = ConexionDatos.conexion();
            conn.Open();
            SqlCommand comand = new SqlCommand("BuscarUsuario", conn as SqlConnection);
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Add(new SqlParameter("@IdUsuario", pUsuario.IdUsuario));
            IDataReader reader = comand.ExecuteReader();
            List<UsuarioEN> lista = new List<UsuarioEN>();
            while (reader.Read())
            {
                UsuarioEN propiedades = new UsuarioEN();
                propiedades.IdUsuario = reader.GetInt64(0);
                propiedades.Usuario = reader.GetString(1);
                propiedades.Contrasena = reader.GetString(2);
                propiedades.FDUI = reader.GetString(3);
                lista.Add(propiedades);
            }
            conn.Close();
            return lista;
        }
    }
}
