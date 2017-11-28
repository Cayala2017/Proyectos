using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EN;
using DAL;

namespace BL
{
    public class PacienteBL
    {
        PacienteDAL _Paciente = new PacienteDAL();

        public String AgregarPaciente(PacienteEN pAgregar)
        {
            return _Paciente.AgregarPaciente(pAgregar);
        }
        public int ActualizarPaciente(PacienteEN pModificar)
        {
            return _Paciente.ActualizarPaciente(pModificar);
        }
        public List<PacienteEN> MostrarPaciente()
        {
            return _Paciente.MostrarPaciente();
        }
        public List<PacienteEN> BuscarPacientePordni(PacienteEN pPaciente)
        {
            return _Paciente.BuscarPacientePordni(pPaciente);
        }
        public List<PacienteEN> BuscarPacientePorEstado(PacienteEN pPaciente)
        {
            return _Paciente.BuscarPacientePorEstado(pPaciente);
        }
    }
}
