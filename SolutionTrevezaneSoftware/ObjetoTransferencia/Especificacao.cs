using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Especificacao
    {
        public int idEspecificacao { get; set; }
        public string descricaoEspecificacao { get; set; }

        public string encaminhamentoEspecificacao { get; set;}

    }

    public class EspecificacaoLista : List<Especificacao> { }

}

