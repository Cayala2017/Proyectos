using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EN;
using DAL;

namespace BL
{
   public class UsuarioBL
    {
        UsuarioDAL _Usuario = new UsuarioDAL();

        public  int IniciarSesion(UsuarioEN pValidar)
        {
            return _Usuario.IniciarSesion(pValidar);
        }
        public  String RegistrarUsuario(UsuarioEN pAgregar)
        {
            return _Usuario.RegistrarUsuario(pAgregar);
        }
        public String ModificarUsuario(UsuarioEN pModificar)
        {
            return _Usuario.ModificarUsuario(pModificar);
        }
        public int EliminarUsuario(UsuarioEN pEliminar)
        {
            return _Usuario.EliminarUsuario(pEliminar);
        }
        public  List<UsuarioEN> MostrarUsuarios()
        {
            return _Usuario.MostrarUsuarios();
        }
        public  List<UsuarioEN> BuscarUsuario(UsuarioEN pUsuario)
        {
            return _Usuario.BuscarUsuario(pUsuario);
        }
    }
}
