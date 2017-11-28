using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
   public class PacienteCamaEN
    {
        public PacienteCamaEN(Int64 idPacienteCama, string fechaAsignada, Int64 fkCama, Int64 fkHistoria)
        {
            IdPacienteCama = idPacienteCama;
            FechaAsignada = fechaAsignada;
            FkCama = fkCama;
            FkHistoria = fkHistoria;
        }

        public PacienteCamaEN()
        {

        }
        public Int64 IdPacienteCama { get; set; }
        public string FechaAsignada { get; set; }
        public Int64 FkCama { get; set; }
        public Int64 FkHistoria { get; set; }
    }
}
