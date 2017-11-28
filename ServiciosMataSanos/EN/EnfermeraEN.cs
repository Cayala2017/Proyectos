using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using EN;


namespace EN
{
    public class EnfermeraEN
    {
        public EnfermeraEN(string dui, string nombre, string apellido)
        {
            DUI = dui;
            Nombre = nombre;
            Apellido = apellido;
        }

        public EnfermeraEN()
        {

        }
        public string DUI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
