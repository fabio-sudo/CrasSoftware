using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class Agenda
    {
        public int codigoAgenda { get; set; }
        public Funcionario funcionario { get; set; }
        public Cliente cliente { get; set; }
        public DateTime dataAgenda { get; set; }
        public DateTime inicioAgenda { get; set; }
        public DateTime finalAgenda { get; set; }
        public string situacaoAgenda { get; set; }
        public string estatusAgenda { get; set; }//Atendido ou Agendado

    }

   public class AgendaLista : List<Agenda> { }
}
