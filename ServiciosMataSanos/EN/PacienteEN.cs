using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class PacienteEN
    {
        public PacienteEN(Int64 idNumeroSeguro, string dni, string nombre, string apellido, string fechaNacimiento, string estado)
        {
            IdNumeroSeguro = idNumeroSeguro;
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Estado = estado;
        }

       public PacienteEN()
        {

        }
        public Int64 IdNumeroSeguro { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string Estado { get; set; }
    }
}
