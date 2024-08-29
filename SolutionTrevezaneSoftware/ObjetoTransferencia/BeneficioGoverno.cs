using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class BeneficioGoverno
    {
        public int idBeneficioGoverno { get; set; }
        public string descricaoBeneficioGoverno { get; set; }
    }

    public class BeneficioGovernoLista : List<BeneficioGoverno> { }
}
