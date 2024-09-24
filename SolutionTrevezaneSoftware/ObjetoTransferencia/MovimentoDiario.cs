using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class MovimentoDiario
    {

        // Primary Key
        public int IdMovimentoDiario { get; set; }

        // Columns
        public DateTime? Data { get; set; }
        public string Prontuario { get; set; }
        public string Nome { get; set; }
        public int? QuantidadeCriancas { get; set; }
        public int? QuantidadeAdolescentes { get; set; }
        public int? QuantidadeIdosos { get; set; }
        public bool? VisitaDomiciliar { get; set; }
        public string Observacoes { get; set; }

        //Realizações
        public bool? Encaminhamento { get; set; }
        public bool? BeneficioConcedido { get; set; }
        public bool? InscritoPaif { get; set; }
        public bool? AcompanhamentoIndividual { get; set; }


        //RMA
        public bool? IncluidoCad { get; set; }
        public bool? AtualizacaoCad { get; set; }
        public bool? Bpc { get; set; }
        public bool? EncaminhadoCreas { get; set; }
        public bool? AuxilioNatalidade { get; set; }
        public bool? AuxilioFuneral { get; set; }
        public bool? BeneficioEventual { get; set; }


        //Relacionamento com bases
        public Cliente idCliente { get; set; }//Chave estrangeira optativa
        public CadastroUnico idCad { get; set; }//Chave estrangeira optativa
        public Funcionario idFuncionario { get; set; }//Chave estrangeira optativa

        //Listas
        public TipoLista tipoAtendimentos { get; set; } = new TipoLista();
        public ProvidenciaLista providencias { get; set; } = new ProvidenciaLista();
        public SituacaoIdentificadaLista situacaoIdentificadas { get; set; } = new SituacaoIdentificadaLista();
        public BeneficioGovernoLista beneficioGovernos { get; set; } = new BeneficioGovernoLista();
        public CadastroUnicoLista cadastroUnicos { get; set; } = new CadastroUnicoLista();
        public SituacaoFamilizarLista situacaoFamiliars { get; set; } = new SituacaoFamilizarLista();
        public AtividadeLista atividadeLista { get; set; } = new AtividadeLista();
        public EspecificacaoLista especificacaoLista { get; set;} = new EspecificacaoLista();
    }


    public class MovimentoDiarioLista : List<MovimentoDiario> { }
}
