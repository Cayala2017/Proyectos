using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EN;

namespace MataSanosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int IniciarSesion(UsuarioEN pValidar);
        [OperationContract]
        String RegistrarUsuario(UsuarioEN pAgregar);
        [OperationContract]
        String ModificarUsuario(UsuarioEN pModificar);
        [OperationContract]
        int EliminarUsuario(UsuarioEN pEliminar);
        [OperationContract]
        List<UsuarioEN> MostrarUsuarios();
        [OperationContract]
        List<UsuarioEN> BuscarUsuario(UsuarioEN pUsuario);
        [OperationContract]
        int Validar(MedicoEN pValidar);
        [OperationContract]
        String AgregarMedico(MedicoEN pAgregar);
        [OperationContract]
        int ActualizarMedico(MedicoEN pModificar);
        [OperationContract]
        int EliminarMedico(MedicoEN pEliminar);
        [OperationContract]
        List<MedicoEN> MostrarMedico();
        [OperationContract]
        List<MedicoEN> BuscarMedicoApellido(MedicoEN pMedicoEN);
        [OperationContract]
        List<MedicoEN> BuscarMedicoEspecialidad(MedicoEN pMedicoEN);
        [OperationContract]
        List<MedicoEN> ObtenerImagen(MedicoEN pMedicoEN);
        [OperationContract]
        String ReguistraEnfermero(EnfermeraEN pAgregar);
        [OperationContract]
        int EliminarEnfermeras(EnfermeraEN pEliminar);
        [OperationContract]
        int ModificarEnfermeras(EnfermeraEN pModificar);
        [OperationContract]
        List<EnfermeraEN> MostrarEnfermeras();
        [OperationContract]
        List<EnfermeraEN> BuscarEnfermera(EnfermeraEN pEnfermera);
        [OperationContract]
        int ModificarHistorial(HistorialEN pModificar);
        [OperationContract]
        int AgregarHistorial(HistorialEN pAgregar);
        [OperationContract]
        List<HistorialEN> MostrarHistorial();
        [OperationContract]
        List<HistorialEN> BuscarHistorial(HistorialEN pHistorial);
        [OperationContract]
        List<HistorialEN> BuscarHistorialPorFechaEntrada(HistorialEN pHistorial);
        [OperationContract]
        List<HistorialEN> BuscarHistorialPorFechaAlta(HistorialEN pHistorial);
        [OperationContract]
        int AgregarCama(CamaEN pAgregar);
        [OperationContract]
        int ModificarCama(CamaEN pModificar);
        [OperationContract]
        int EliminarCama(CamaEN pEliminar);
        [OperationContract]
        List<CamaEN> MostrarCama();
        [OperationContract]
        List<CamaEN> BuscarCamaPlanta(CamaEN pCama);
        [OperationContract]
        String AgregarPaciente(PacienteEN pAgregar);
        [OperationContract]
        int ActualizarPaciente(PacienteEN pModificar);
        [OperationContract]
        List<PacienteEN> MostrarPaciente();
        [OperationContract]
        List<PacienteEN> BuscarPacientePordni(PacienteEN pPaciente);
        [OperationContract]
        List<PacienteEN> BuscarPacientePorEstado(PacienteEN pPaciente);
        [OperationContract]
        int AgregarCamaAPaciente(PacienteCamaEN pAgregar);
        [OperationContract]
        int ActualizarCamaAPaciente(PacienteCamaEN pModificar);
        [OperationContract]
        int EliminarCamaAPaciente(PacienteCamaEN pEliminar);
        [OperationContract]
        List<PacienteCamaEN> MostrarPacienteCama();
        [OperationContract]
        List<PacienteCamaEN> BuscraCamaPacientePorFecha(PacienteCamaEN pPC);
        [OperationContract]
        int AgregarVisita(VisitaMedicaEN pEliminar);
        [OperationContract]
        int EliminarVisita(VisitaMedicaEN pEliminar);
        [OperationContract]
        List<VisitaMedicaEN> MostrarVisita();
        [OperationContract]
        List<VisitaMedicaEN> BuscarVisita(VisitaMedicaEN pVisita);
        [OperationContract]
        String AgregarPlanta(PlantaEN pAgregar);
        [OperationContract]
        int ActualizarPlanta(PlantaEN pEliminar);
        [OperationContract]
        List<PlantaEN> MostraPlantas();
        [OperationContract]
        List<PlantaEN> BuscarPlanta(PlantaEN pPlanta);
    }
}
