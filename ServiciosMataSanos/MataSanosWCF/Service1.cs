using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using EN;
using BL;

namespace MataSanosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        UsuarioBL _Usuario = new UsuarioBL();

        public int IniciarSesion(UsuarioEN pValidar)
        {
            return _Usuario.IniciarSesion(pValidar);
        }
        public String RegistrarUsuario(UsuarioEN pAgregar)
        {
            return _Usuario.RegistrarUsuario(pAgregar);
        }
        public String ModificarUsuario(UsuarioEN pModificar)
        {
            return _Usuario.ModificarUsuario(pModificar);
        }
        public int EliminarUsuario(UsuarioEN pEliminar)
        {
            return _Usuario.EliminarUsuario(pEliminar);
        }
        public List<UsuarioEN> MostrarUsuarios()
        {
            return _Usuario.MostrarUsuarios();
        }
        public List<UsuarioEN> BuscarUsuario(UsuarioEN pUsuario)
        {
            return _Usuario.BuscarUsuario(pUsuario);
        }

        MedicoBL _Medico = new MedicoBL();

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

        EnfermeraBL _Enfermera = new EnfermeraBL();

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

        HistorialBL _Historial = new HistorialBL();

        public int ModificarHistorial(HistorialEN pModificar)
        {
            return _Historial.ModificarHistorial(pModificar);
        }
        public int AgregarHistorial(HistorialEN pAgregar)
        {
            return _Historial.AgregarHistorial(pAgregar);
        }
        public List<HistorialEN> MostrarHistorial()
        {
            return _Historial.MostrarHistorial();
        }
        public List<HistorialEN> BuscarHistorial(HistorialEN pHistorial)
        {
            return _Historial.BuscarHistorial(pHistorial);
        }
        public List<HistorialEN> BuscarHistorialPorFechaEntrada(HistorialEN pHistorial)
        {
            return _Historial.BuscarHistorialPorFechaEntrada(pHistorial);
        }
        public List<HistorialEN> BuscarHistorialPorFechaAlta(HistorialEN pHistorial)
        {
            return _Historial.BuscarHistorialPorFechaAlta(pHistorial);
        }

        CamaBL _Cama = new CamaBL();

        public int AgregarCama(CamaEN pAgregar)
        {
            return _Cama.AgregarCama(pAgregar);
        }
        public int ModificarCama(CamaEN pModificar)
        {
            return _Cama.ModificarCama(pModificar);
        }
        public int EliminarCama(CamaEN pEliminar)
        {
            return _Cama.EliminarCama(pEliminar);
        }
        public List<CamaEN> MostrarCama()
        {
            return _Cama.MostrarCama();
        }
        public List<CamaEN> BuscarCamaPlanta(CamaEN pCama)
        {
            return _Cama.BuscarCamaPlanta(pCama);
        }

        PacienteBL _Paciente = new PacienteBL();

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

        PacienteCamaBL _CPa = new PacienteCamaBL();

        public int AgregarCamaAPaciente(PacienteCamaEN pAgregar)
        {
            return _CPa.AgregarCamaAPaciente(pAgregar);
        }
        public int ActualizarCamaAPaciente(PacienteCamaEN pModificar)
        {
            return _CPa.ActualizarCamaAPaciente(pModificar);
        }
        public int EliminarCamaAPaciente(PacienteCamaEN pEliminar)
        {
            return _CPa.EliminarCamaAPaciente(pEliminar);
        }
        public List<PacienteCamaEN> MostrarPacienteCama()
        {
            return _CPa.MostrarPacienteCama();
        }
        public List<PacienteCamaEN> BuscraCamaPacientePorFecha(PacienteCamaEN pPC)
        {
            return _CPa.BuscraCamaPacientePorFecha(pPC);
        }

        VisitaMedicaBL _Visita = new VisitaMedicaBL();

        public int AgregarVisita(VisitaMedicaEN pEliminar)
        {
            return _Visita.AgregarVisita(pEliminar);
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

        PlantaBL _Planta = new PlantaBL();

        public String AgregarPlanta(PlantaEN pAgregar)
        {
            return _Planta.AgregarPlanta(pAgregar);
        }
        public int ActualizarPlanta(PlantaEN pEliminar)
        {
            return _Planta.ActualizarPlanta(pEliminar);
        }
        public List<PlantaEN> MostraPlantas()
        {
            return _Planta.MostraPlantas();
        }
        public List<PlantaEN> BuscarPlanta(PlantaEN pPlanta)
        {
            return _Planta.BuscarPlanta(pPlanta);
        }

    }
}
