using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class VisitaMedicaEN
    {
        public VisitaMedicaEN(string fechaVisita, string horaVisita, string daignostico, Int64 fkMedico, Int64 fkPacienteCama)
        {
            FechaVisita = fechaVisita;
            HoraVisita = horaVisita;
            Daignostico = daignostico;
            FkMedico = fkMedico;
            FkPacienteCama = fkPacienteCama;
        }

        public VisitaMedicaEN()
        {

        }

        public string FechaVisita { get; set; }
        public string HoraVisita { get; set; }
        public string Daignostico { get; set; }
        public Int64 FkMedico { get; set; }
        public Int64 FkPacienteCama { get; set; }
    }
}
