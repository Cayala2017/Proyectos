using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EN;
using DAL;

namespace BL
{
   public class VisitaMedicaBL
    {
        VisitaMedicaDAL _Visita = new VisitaMedicaDAL();

        public int AgregarVisita(VisitaMedicaEN pAgregar)
        {
            return _Visita.AgregarVisita(pAgregar);
        }
        public int EliminarVisita(VisitaMedicaEN pEliminar)
        {
            return _Visita.EliminarVisita(pEliminar);
        }
        public List<VisitaMedicaEN> MostrarVisita()
        {
            return _Visita.MostrarVisita();
        }
        public List<VisitaMedicaEN> BuscarVisita(VisitaMedicaEN pVisita)
        {
            return _Visita.BuscarVisita(pVisita);
        }
    }
}
