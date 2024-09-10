using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class SituacaoFamiliar
    {
        public int idSituacaoFamiliar { get; set; }
        public string descricaoSituacaoFamiliar { get; set; }
    }

    public class SituacaoFamilizarLista : List<SituacaoFamiliar> { }
}
