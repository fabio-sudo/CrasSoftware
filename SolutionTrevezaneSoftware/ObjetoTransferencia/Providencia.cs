using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Providencia
    {
        public int idProvidencia { get; set; }
        public string descricaoProvidencia { get; set; }

        public bool selecionado { get; set; }

    }

    public class ProvidenciaLista : List<Providencia> { }
}
