using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
   public class HistorialEN
    {
        public HistorialEN(Int64 idHistorial, string fechaEntrada, string fechaAlta, Int64 fkNumeroSeguro, string nombreP, string apellidoP, string dniP)
        {
            IdHistorial = idHistorial;
            FechaEntrada = fechaEntrada;
            FechaAlta = fechaAlta;
            FkNumeroSeguro = fkNumeroSeguro;
            NombreP = nombreP;
            ApellidoP = apellidoP;
            DniP = dniP;
        }
        public HistorialEN()
        {

        }

        public Int64 IdHistorial { get; set; }
        public string FechaEntrada { get; set; }
        public string FechaAlta { get; set; }
        public Int64 FkNumeroSeguro { get; set; }

        public string NombreP { get; set; }
        public string ApellidoP { get; set; }
        public string DniP { get; set; }
    }
}
