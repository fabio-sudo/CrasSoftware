using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class SituacaoIdentificada
    {
        public int idSituacaoIdentificada { get; set; }
        public string descricaoSituacaoIdentificada { get; set; }
    }

    public class SituacaoIdentificadaLista : List<SituacaoIdentificada> { }
}
