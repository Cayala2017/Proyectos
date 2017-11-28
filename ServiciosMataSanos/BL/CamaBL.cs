using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EN;
using DAL;

namespace BL
{
   public class CamaBL
    {
        CamaDAL _cama = new CamaDAL();

        public int AgregarCama(CamaEN pAgregar)
        {
            return _cama.AgregarCama(pAgregar);
        }
        public int ModificarCama(CamaEN pModificar)
        {
            return _cama.ModificarCama(pModificar);
        }
        public int EliminarCama(CamaEN pEliminar)
        {
            return _cama.EliminarCama(pEliminar);
        }
        public List<CamaEN> MostrarCama()
        {
            return _cama.MostrarCama();
        }
        public List<CamaEN> BuscarCamaPlanta(CamaEN pCama)
        {
            return _cama.BuscarCamaPlanta(pCama);
        }
    }
}
