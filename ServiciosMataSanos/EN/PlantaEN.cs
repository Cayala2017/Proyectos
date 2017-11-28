using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
   public class PlantaEN
    {
        public PlantaEN(Int64 idPlanta, string nombre, int numeroCamas)
        {
            IdPlanta = idPlanta;
            Nombre = nombre;
            NumeroCamas = numeroCamas;
        }

        public PlantaEN()
        {

        }
        public Int64 IdPlanta { get; set; }
        public string Nombre { get; set; }
        public int NumeroCamas { get; set; }
    }
}
