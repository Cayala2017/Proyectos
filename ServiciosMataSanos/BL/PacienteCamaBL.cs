using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EN;
using DAL;

namespace BL
{
   public class PacienteCamaBL
    {
        PacienteCamaDAL _pCama = new PacienteCamaDAL();

        public int AgregarCamaAPaciente(PacienteCamaEN pAgregar)
        {
            return _pCama.AgregarCamaAPaciente(pAgregar);
        }
        public int ActualizarCamaAPaciente(PacienteCamaEN pModificar)
        {
            return _pCama.ActualizarCamaAPaciente(pModificar);
        }
        public int EliminarCamaAPaciente(PacienteCamaEN pEliminar)
        {
            return _pCama.EliminarCamaAPaciente(pEliminar);
        }
        public List<PacienteCamaEN> MostrarPacienteCama()
        {
            return _pCama.MostrarPacienteCama();
        }
        public List<PacienteCamaEN> BuscraCamaPacientePorFecha(PacienteCamaEN pPC)
        {
            return _pCama.BuscraCamaPacientePorFecha(pPC);
        }
    }
}
