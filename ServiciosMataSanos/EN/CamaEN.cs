using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
   public class CamaEN
    {
        public CamaEN(Int64 idCama, Int64 fkPlanta)
        {
            IdCama = idCama;
            FkPlanta = fkPlanta;
        }

        public CamaEN()
        {

        }
        public Int64 IdCama { get; set; }
        public Int64 FkPlanta { get; set; }
    }
}
