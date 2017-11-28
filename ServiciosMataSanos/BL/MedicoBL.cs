using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;
using DAL;

namespace BL
{
   public class MedicoBL
    {
        MedicoDAL _Medico = new MedicoDAL();

        public int Validar(MedicoEN pValidar)
        {
            return _Medico.Validar(pValidar);
        }
        public String AgregarMedico(MedicoEN pAgregar)
        {
            return _Medico.AgregarMedico(pAgregar);
        }
        public int ActualizarMedico(MedicoEN pModificar)
        {
            return _Medico.ActualizarMedico(pModificar);
        }
        public int EliminarMedico(MedicoEN pEliminar)
        {
            return _Medico.EliminarMedico(pEliminar);
        }
        public List<MedicoEN> MostrarMedico()
        {
            return _Medico.MostrarMedico();
        }
        public List<MedicoEN> BuscarMedicoApellido(MedicoEN pMedicoEN)
        {
            return _Medico.BuscarMedicoApellido(pMedicoEN);
        }
        public List<MedicoEN> BuscarMedicoEspecialidad(MedicoEN pMedicoEN)
        {
            return _Medico.BuscarMedicoEspecialidad(pMedicoEN);
        }
        public List<MedicoEN> ObtenerImagen(MedicoEN pMedicoEN)
        {
            return _Medico.ObtenerImagen(pMedicoEN);
        }
    }
}
