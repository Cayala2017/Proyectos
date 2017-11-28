using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EN;
using DAL;

namespace BL
{
   public class HistorialBL
    {
        HistorialDAL _historial = new HistorialDAL();

        public int ModificarHistorial(HistorialEN pModificar)
        {
            return _historial.ModificarHistorial(pModificar);
        }
        public int AgregarHistorial(HistorialEN pAgregar)
        {
            return _historial.AgregarHistorial(pAgregar);
        }
        public List<HistorialEN> MostrarHistorial()
        {
            return _historial.MostrarHistorial();
        }
        public List<HistorialEN> BuscarHistorial(HistorialEN pHistorial)
        {
            return _historial.BuscarHistorial(pHistorial);
        }
        public List<HistorialEN> BuscarHistorialPorFechaEntrada(HistorialEN pHistorial)
        {
            return _historial.BuscarHistorialPorFechaEntrada(pHistorial);
        }
        public List<HistorialEN> BuscarHistorialPorFechaAlta(HistorialEN pHistorial)
        {
            return _historial.BuscarHistorialPorFechaAlta(pHistorial);
        }
    }
}
