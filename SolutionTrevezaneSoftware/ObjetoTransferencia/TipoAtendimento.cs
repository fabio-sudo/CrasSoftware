using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TipoAtendimento
    {

        public int idTipo { get; set; }
        public string descricaoTipo { get; set; }

    }

    public class TipoLista : List<TipoAtendimento> { }
}
