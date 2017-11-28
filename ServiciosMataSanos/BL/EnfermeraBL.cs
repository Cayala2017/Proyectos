using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EN;
using DAL;

namespace BL
{
   public class EnfermeraBL
    {
        EnfermeraDAL _Enfermera = new EnfermeraDAL();

        public String ReguistraEnfermero(EnfermeraEN pAgregar)
        {
            return _Enfermera.ReguistraEnfermero(pAgregar);
        }
        public int EliminarEnfermeras(EnfermeraEN pEliminar)
        {
            return _Enfermera.EliminarEnfermeras(pEliminar);
        }
        public int ModificarEnfermeras(EnfermeraEN pModificar)
        {
            return _Enfermera.ModificarEnfermeras(pModificar);
        }
        public List<EnfermeraEN> MostrarEnfermeras()
        {
            return _Enfermera.MostrarEnfermeras();
        }
        public List<EnfermeraEN> BuscarEnfermera(EnfermeraEN pEnfermera)
        {
            return _Enfermera.BuscarEnfermera(pEnfermera);
        }
    }
}
