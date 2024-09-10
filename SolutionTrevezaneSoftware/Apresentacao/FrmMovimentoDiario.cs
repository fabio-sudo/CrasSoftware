using Negocio;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMovimentoDiario : Form
    {
        //Funcionario
        string strFuncionario;
        Funcionario funcionarioLogado;
        Funcionario objFuncionario = new Funcionario();

        //--------------------Grides
        NegTipoAtendimento nTipo = new NegTipoAtendimento();
        public TipoLista tipoLista;
        public TipoAtendimento tipoSelecionado;

        NegProvidencia nProvidencia = new NegProvidencia();
        public ProvidenciaLista providenciaLista;
        public Providencia providencia;

        NegSituacaoIdentificada nSituacaoIdentificada = new NegSituacaoIdentificada();
        public SituacaoIdentificadaLista situacaoLista;
        public SituacaoIdentificada situacao;

        NegBeneficioGoverno nBeneficio = new NegBeneficioGoverno();
        public BeneficioGovernoLista beneficioLista;
        public BeneficioGoverno beneficio;

        NegCadastroUnico nCadastroUnico = new NegCadastroUnico();
        public CadastroUnicoLista cadastroUnicoLista;
        public CadastroUnico cadastroUnico;

        NegSituacaoFamiliar nSituacaoFamiliar = new NegSituacaoFamiliar();
        public SituacaoFamilizarLista situacaoFamiliarLista;
        public SituacaoFamiliar situacaoFamiliar;

        NegEspecificacao nEspecificacao = new NegEspecificacao();
        public EspecificacaoLista especificacaoLista;
        public Especificacao especificacao;

        NegAtividade nAtividade = new NegAtividade();
        public AtividadeLista atividadeLista;
        public Atividade atividade;

        public FrmMovimentoDiario([Optional] string nomeFuncionario)
        {
            InitializeComponent();

            if (nomeFuncionario != String.Empty)
            {
                strFuncionario = nomeFuncionario;
            }
        }

        //----------------------------------------------------------Construtor
        private void metodoConstrutor()
        {

            funcionarioLogado = FrmMenuPrincipal.userLogado;
            if (funcionarioLogado.nomeFuncionario == "Josi" || funcionarioLogado.nomeFuncionario == "JOSI")
            { return; }
            else
            {
                objFuncionario = funcionarioLogado;
                tbBuscarFuncionario.Text = objFuncionario.nomeFuncionario;


            }

        }



        //--------------------------------------------------------Preencher Grid
        //atualiza os valores no Data Grid Tipo
        private void AtualizarDataGridTipo()
        {

            this.dgvSelecionarTipo.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.tipoLista.Count > 0)
            {
                this.dgvSelecionarTipo.Rows.Add(this.tipoLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (TipoAtendimento tipo in this.tipoLista)
            {
                this.dgvSelecionarTipo[1, indice].Value = tipo.idTipo;
                this.dgvSelecionarTipo[2, indice].Value = tipo.descricaoTipo;

                indice++;
            }

            dgvSelecionarTipo.Update();

        }

        //atualiza os valores no Data Grid Providencia
        private void AtualizarDataGridProvidencia()
        {

            this.dgvProvidencia.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.providenciaLista.Count > 0)
            {
                this.dgvProvidencia.Rows.Add(this.providenciaLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Providencia prov in this.providenciaLista)
            {
                this.dgvProvidencia[1, indice].Value = prov.idProvidencia;
                this.dgvProvidencia[2, indice].Value = prov.descricaoProvidencia;

                indice++;
            }

            dgvProvidencia.Update();

        }

        //atualiza os valores no Data Grid Situação Identificada
        private void AtualizarDataGridSituacaoIdentificada()
        {

            this.dgvSituacaoIdentificada.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.situacaoLista.Count > 0)
            {
                this.dgvSituacaoIdentificada.Rows.Add(this.situacaoLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (SituacaoIdentificada sit in this.situacaoLista)
            {
                this.dgvSituacaoIdentificada[1, indice].Value = sit.idSituacaoIdentificada;
                this.dgvSituacaoIdentificada[2, indice].Value = sit.descricaoSituacaoIdentificada;

                indice++;
            }

            dgvSituacaoIdentificada.Update();

        }

        //atualiza os valores no Data Grid Benefício do Governo
        private void AtualizarDataGridBeneficioGoverno()
        {

            this.dgvBeneficioGoverno.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.beneficioLista.Count > 0)
            {
                this.dgvBeneficioGoverno.Rows.Add(this.beneficioLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (BeneficioGoverno ben in this.beneficioLista)
            {
                this.dgvBeneficioGoverno[1, indice].Value = ben.idBeneficioGoverno;
                this.dgvBeneficioGoverno[2, indice].Value = ben.descricaoBeneficioGoverno;

                indice++;
            }

            dgvBeneficioGoverno.Update();

        }

        //atualiza os valores no Data Grid Cadástro Único
        private void AtualizarDataGridCad()
        {

            this.dgvCad.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.cadastroUnicoLista.Count > 0)
            {
                this.dgvCad.Rows.Add(this.cadastroUnicoLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (CadastroUnico cad in this.cadastroUnicoLista)
            {
                this.dgvCad[1, indice].Value = cad.idCadastroUnico;
                this.dgvCad[2, indice].Value = cad.descricaoCadastroUnico;

                indice++;
            }

            dgvCad.Update();

        }

        //atualiza os valores no Data Grid Situação Familiar
        private void AtualizarDataGridSituacaoFamiliar()
        {

            this.dgvSituacaoFamiliar.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.situacaoFamiliarLista.Count > 0)
            {
                this.dgvSituacaoFamiliar.Rows.Add(this.situacaoFamiliarLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (SituacaoFamiliar sit in this.situacaoFamiliarLista)
            {
                this.dgvSituacaoFamiliar[1, indice].Value = sit.idSituacaoFamiliar;
                this.dgvSituacaoFamiliar[2, indice].Value = sit.descricaoSituacaoFamiliar;

                indice++;
            }

            dgvSituacaoFamiliar.Update();

        }

        //atualiza os valores no Data Grid Atividade CRAS Grupos
        private void AtualizarDataGridAtividade()
        {

            this.dgvAtividade.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.atividadeLista.Count > 0)
            {
                this.dgvAtividade.Rows.Add(this.atividadeLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Atividade atv in this.atividadeLista)
            {
                this.dgvAtividade[1, indice].Value = atv.idAtividade;
                this.dgvAtividade[2, indice].Value = atv.descricaoAtividade;

                indice++;
            }

            dgvAtividade.Update();

        }

        //atualiza os valores no Data Grid Especificação do Atendimento
        private void AtualizarDataGridEspecificacao() {

            this.dgvEspecificacaoAtendimento.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.especificacaoLista.Count > 0)
            {
                this.dgvEspecificacaoAtendimento.Rows.Add(this.especificacaoLista.Count);
            }
            else
            {
                return;
            }

            this.dgvEspecificacaoAtendimento.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            int indice = 0;
            foreach (Especificacao esp in this.especificacaoLista)
            {
                this.dgvEspecificacaoAtendimento[1, indice].Value = esp.idEspecificacao;
                this.dgvEspecificacaoAtendimento[2, indice].Value = 1;
                this.dgvEspecificacaoAtendimento[3, indice].Value = esp.encaminhamentoEspecificacao;
                this.dgvEspecificacaoAtendimento[4, indice].Value = esp.descricaoEspecificacao;

                indice++;
            }

            dgvEspecificacaoAtendimento.Update();


        }


        //---------------------------------------------------------Formulário
        private void btSair_Click(object sender, EventArgs e)
        {

        }

        private void FrmMovimentoDiario_Load(object sender, EventArgs e)
        {
            pbBuscarProvidencia_Click(null, e);
            pbBuscarTipo_Click(null, e);
            pbBuscarSituacaoIdentificada_Click(null, e);
            pbBuscarBeneficioGoverno_Click(null, e);
            pbBuscarCad_Click(null, e);
            pbBuscarSituacaoFamiliar_Click(null, e);
            pbBuscarEspecificacaoAtendimento_Click(null, e);
            pbBuscarAtividadeCras_Click(null, e);
        }


        //---------------------------------------------------------Botões de Busca dos Grid
        //Providencia
        private void pbBuscarProvidencia_Click(object sender, EventArgs e)
        {
            string str;
            str = tbProvidencia.Text;

            if (tbProvidencia.Text.Equals("Providência CRAS ...") || tbProvidencia.Text == string.Empty)
            {
                str = "";
            }

            this.providenciaLista = nProvidencia.BuscarProvidenciaPorNome(str);
            AtualizarDataGridProvidencia();
        }
        
        //Tipo
        private void pbBuscarTipo_Click(object sender, EventArgs e)
        {
            string str;
            str = tbBuscarTipo.Text;

            if (tbBuscarTipo.Text.Equals("Tipo de Atendimento ...") || tbBuscarTipo.Text == string.Empty)
            {
                str = "";
            }

            this.tipoLista = nTipo.BuscarTipoPorNome(str);
            AtualizarDataGridTipo();
        }

        //Situação Identificada
        private void pbBuscarSituacaoIdentificada_Click(object sender, EventArgs e)
        {
            string str;
            str = tbSituacaoIdentificada.Text;

            if (tbSituacaoIdentificada.Text.Equals("Situação Identificada ...") || tbSituacaoIdentificada.Text == string.Empty)
            {
                str = "";
            }

            this.situacaoLista = nSituacaoIdentificada.BuscarSituacaoPorNome(str);
            AtualizarDataGridSituacaoIdentificada();
        }

        //Benefício do Governo
        private void pbBuscarBeneficioGoverno_Click(object sender, EventArgs e)
        {
            string str;
            str = tbBeneficioGoverno.Text;

            if (tbBeneficioGoverno.Text.Equals("Benefício do Governo ...") || tbBeneficioGoverno.Text == string.Empty)
            {
                str = "";
            }

            this.beneficioLista = nBeneficio.BuscarBeneficioGovernoPorNome(str);
            AtualizarDataGridBeneficioGoverno();
        }

        //Cadastro Único
        private void pbBuscarCad_Click(object sender, EventArgs e)
        {
            string str;
            str = tbCad.Text;

            if (tbCad.Text.Equals("Cadastro Único ...") || tbCad.Text == string.Empty)
            {
                str = "";
            }

            this.cadastroUnicoLista = nCadastroUnico.BuscarCadastroUnicoPorNome(str);
            AtualizarDataGridCad();

        }

        //Situação Familiar
        private void pbBuscarSituacaoFamiliar_Click(object sender, EventArgs e)
        {
            string str;
            str = tbSituacaoFamiliar.Text;

            if (tbSituacaoFamiliar.Text.Equals("Situação Familiar ...") || tbSituacaoFamiliar.Text == string.Empty)
            {
                str = "";
            }

            this.situacaoFamiliarLista = nSituacaoFamiliar.BuscarSituacaoPorNome(str);
            AtualizarDataGridSituacaoFamiliar();
        }

        //Especificação do Atendimento
        private void pbBuscarEspecificacaoAtendimento_Click(object sender, EventArgs e)
        {
            string str;
            str = tbEspecificacaoAtendimento.Text;

            if (tbEspecificacaoAtendimento.Text.Equals("Especificação do Atendimento ...") || tbEspecificacaoAtendimento.Text == string.Empty)
            {
                str = "";
            }

            this.especificacaoLista = nEspecificacao.BuscarEspecificacaoPorNome(str);
            AtualizarDataGridEspecificacao();
        }

        //Atividade CRAS Grupos
        private void pbBuscarAtividadeCras_Click(object sender, EventArgs e)
        {
            string str;
            str = tbAtividadeCras.Text;

            if (tbAtividadeCras.Text.Equals("Ativiadade no CRAS ...") || tbAtividadeCras.Text == string.Empty)
            {
                str = "";
            }

            this.atividadeLista = nAtividade.BuscarAtividadePorNome(str);
            AtualizarDataGridAtividade();

        }

        //------------------------------------------------------------------------Caixa de Texto Funcionário
        private void tbBuscarFuncionario_Enter(object sender, EventArgs e)
        {
            tbBuscarFuncionario.Clear();
            pbFuncionario.Image = Properties.Resources.FuncionarioRosa;
            panelBuscarFuncionario.BackColor = Color.DeepPink;
            if (strFuncionario != String.Empty)
            {
                tbBuscarFuncionario.Text = strFuncionario;

            }
        }

        private void tbBuscarFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscarFuncionario.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBuscarFuncionario_Leave(object sender, EventArgs e)
        {
            if (tbBuscarFuncionario.Text == "")
            {
                tbBuscarFuncionario.Text = "Digite o nome do funcionário ...";
                pbFuncionario.Image = Properties.Resources.FuncionarioAzul;
                panelBuscarFuncionario.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarFuncionario.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        //-----------------------------------------------------------------------------Caixa de Texto Cliente
        private void tbCliente_Leave(object sender, EventArgs e)
        {
            if (tbCliente.Text == "")
            {
                tbCliente.Text = "Digite o nome do cliente ...";
                pbCliente.Image = Properties.Resources.ClienteAzul;
                panelCliente.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbCliente.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }

        }

        private void tbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btCliente.PerformClick();
                e.Handled = true;
            }
        }

        private void tbCliente_Enter(object sender, EventArgs e)
        {
            tbCliente.Clear();
            pbCliente.Image = Properties.Resources.ClienteRosa;
            panelCliente.BackColor = Color.DeepPink;
        }

        //-----------------------------------------------------------------------------Caixa de Texto Tipo de Atendimento
        private void tbBuscarTipo_Enter(object sender, EventArgs e)
        {
            tbBuscarTipo.Clear();
            panelTipo.BackColor = Color.DeepPink;

        }

        private void tbBuscarTipo_Leave(object sender, EventArgs e)
        {
            if (tbBuscarTipo.Text == "")
            {
                tbBuscarTipo.Text = "Tipo de Atendimento ...";
                panelTipo.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarTipo.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBuscarTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarTipo_Click(null, e);
                e.Handled = true;
            }
        }
    }
}
