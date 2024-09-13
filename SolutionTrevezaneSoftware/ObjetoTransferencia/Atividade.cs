using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Atividade
    {    
        public int idAtividade { get; set; }
        public string descricaoAtividade { get; set; }

        public bool selecionado { get; set; }
    }

    public class AtividadeLista : List<Atividade> { }
}
