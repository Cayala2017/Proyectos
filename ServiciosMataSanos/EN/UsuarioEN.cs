using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
   public class UsuarioEN
    {
        public UsuarioEN(Int64 idUsuario, string usuario, string contrasena, string fdui)
        {
            IdUsuario = idUsuario;
            Usuario = usuario;
            Contrasena = contrasena;
            FDUI = fdui;
        }

        public UsuarioEN()
        {

        }
        public Int64 IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string FDUI { get; set; }
    }
}
