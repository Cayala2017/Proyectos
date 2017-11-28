using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
   public class MedicoEN
    {
        
        public MedicoEN(Int64 idMedico, byte[] imagen, string nombre, string apellido, string especialidad, string nombreUsuario, string contrasena, Int64 fkPlanta)
        {
            IdMedico = idMedico;
            Imagen = imagen;
            Nombre = nombre;
            Apellido = apellido;
            Especialidad = especialidad;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            FkPlanta = fkPlanta;
        }

        public MedicoEN()
        {

        }

        public Int64 IdMedico { get; set; }
        public byte[] Imagen { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public Int64 FkPlanta { get; set; }
    }
}
