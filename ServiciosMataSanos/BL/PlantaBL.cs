using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EN;
using DAL;

namespace BL
{
   public class PlantaBL
    {
        PlantaDAL _planta = new PlantaDAL();

        public String AgregarPlanta(PlantaEN pAgregar)
        {
            return _planta.AgregarPlanta(pAgregar);
        }
        public int ActualizarPlanta(PlantaEN pEliminar)
        {
            return _planta.ActualizarPlanta(pEliminar);
        }
        public List<PlantaEN> MostraPlantas()
        {
            return _planta.MostraPlantas();
        }
        public List<PlantaEN> BuscarPlanta(PlantaEN pPlanta)
        {
            return _planta.BuscarPlanta(pPlanta);
        }
    }
}
