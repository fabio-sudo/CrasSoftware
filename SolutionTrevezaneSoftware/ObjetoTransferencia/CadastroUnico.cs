using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class CadastroUnico
    {
        public int idCadastroUnico { get; set; }
        public string descricaoCadastroUnico { get; set; }
    }

    public class CadastroUnicoLista : List<CadastroUnico> { }
}
