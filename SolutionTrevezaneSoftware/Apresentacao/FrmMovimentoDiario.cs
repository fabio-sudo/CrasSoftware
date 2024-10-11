using Negocio;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Apresentacao
{
    public partial class FrmMovimentoDiario : Form
    {
        //Movimento Diário
        MovimentoDiario objMovimentoDiario = new MovimentoDiario();


        //Funcionario
        string strFuncionario;
        Funcionario funcionarioLogado;

        //Cliente
        string strCliente;
        Cliente clienteSelecionado = new Cliente();
        NegCliente nCliente = new NegCliente();

        //--------------------Grides

        #region DeclaraçãoObjetosGrides
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

        #endregion

        public FrmMovimentoDiario([Optional] Funcionario objFuncionario, [Optional] MovimentoDiario objMovimento)
        {
            InitializeComponent();

            if (objFuncionario != null)
            {

                funcionarioLogado = objFuncionario;
            }

            if (objMovimento != null)
            {

                objMovimentoDiario = objMovimento;
            }
            else { objMovimentoDiario = null; }

        }

        //----------------------------------------------------------Construtor

        #region Métodos
        private Boolean metodoValidaCadastro()
        {
            if ((tbBuscarFuncionario.Text == "") || (tbBuscarFuncionario.Text == "Digite o nome do funcionário ..."))
            {
                MessageBox.Show("Selecione o funcionário responsável pelo atendimento!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                tbBuscarFuncionario.Focus();
                return false;
            }

            if (tbNome.Text == "")
            {
                MessageBox.Show("Por favor informe nome do usuário atendido!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                tbNome.Focus();
                return false;
            }

            return true;

        }

        private void metodoInicializaDataGrid()
        {

            AtualizarDataGridTipo(tipoLista);
            AtualizarDataGridProvidencia(providenciaLista);
            AtualizarDataGridSituacaoIdentificada(situacaoLista);
            AtualizarDataGridBeneficioGoverno(beneficioLista);
            AtualizarDataGridCad(cadastroUnicoLista);
            AtualizarDataGridSituacaoFamiliar(situacaoFamiliarLista);
            AtualizarDataGridEspecificacao(especificacaoLista);
            AtualizarDataGridAtividade(atividadeLista);

        }

        private void limparDataGrid(DataGridView grid)
        {
            if (grid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.Cells[0] is DataGridViewCheckBoxCell checkBoxCell)
                    {
                        checkBoxCell.Value = false;
                    }
                }
            }
        }

        private void metodoLimpaCampos()
        {

            metodoInicializaDataGrid();

            //Cliente
            clienteSelecionado = new Cliente();
            tbCliente.Text = "Digite o nome do cliente...";

            //Usuario
            tbProntuario.Clear();
            tbObservacao.Clear();
            tbNome.Clear();
            nudAdolescente.Value = 0;
            nudCriancas.Value = 0;
            nudIdoso.Value = 0;
            cbVisita.Checked = false;



            //Limpa seleção do datagrid view
            limparDataGrid(dgvSelecionarTipo);
            limparDataGrid(dgvProvidencia);
            limparDataGrid(dgvSituacaoIdentificada);
            limparDataGrid(dgvBeneficioGoverno);
            limparDataGrid(dgvCad);
            limparDataGrid(dgvSituacaoFamiliar);
            limparDataGrid(dgvAtividade);

            //Data Grid Especificação
            if (dgvEspecificacaoAtendimento.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvEspecificacaoAtendimento.Rows)
                {
                    if (row.Cells[0] is DataGridViewCheckBoxCell checkBoxCell)
                    {
                        checkBoxCell.Value = false;
                    }
                    if (row.Cells[2] is DataGridViewTextBoxCell textBoxCell)
                    {
                        textBoxCell.Value = "1";
                    }

                }
            }


            //Chek Box
            cbEncaminhamento.Checked = false;
            cbBeneficioConcedido.Checked = false;
            cbInseridoPaif.Checked = false;
            cbAcompanhamentoIndividual.Checked = false;

            cbRmaIncluidoCad.Checked = false;
            cbRmaBpc.Checked = false;
            cbRmaAuxilioNatalidade.Checked = false;

            cbRmaAtualizacaoCad.Checked = false;
            cbRmaEncaminhadoCreas.Checked = false;
            cbRmaAuxilioFuneral.Checked = false;
            cbRmaBeneficioEventual.Checked = false;

        }

        //Lista Genérica
        public void PreencherListaSelecionados<T>(List<T> listaFonte, List<T> listaDestino, Func<T, bool> selecionadoPredicate) where T : class
        {
            if (listaFonte.Count > 0)
            {
                listaDestino.Clear();
                var itensSelecionados = listaFonte.Where(selecionadoPredicate).ToList();


                foreach (var item in itensSelecionados)
                {
                    listaDestino.Add(item);
                }
            }
            else
            {

                listaDestino = null;
            }


        }

        private void metodoPreencheFormulario()
        {
            if (objMovimentoDiario != null)
            {
                if (objMovimentoDiario.idCliente.codigoCliente != 0)
                {
                    clienteSelecionado = nCliente.BuscarClientePorCodigo(objMovimentoDiario.idCliente.codigoCliente);
                    objMovimentoDiario.idCliente = clienteSelecionado;
                    strCliente = clienteSelecionado.nomeCliente;
                    tbCliente.Text = strCliente;
                }

                tbProntuario.Text = objMovimentoDiario.Prontuario;
                tbNome.Text = objMovimentoDiario.Nome;
                nudCriancas.Value = (decimal)objMovimentoDiario.QuantidadeCriancas;
                nudAdolescente.Value = (decimal)objMovimentoDiario.QuantidadeAdolescentes;
                nudIdoso.Value = (decimal)objMovimentoDiario.QuantidadeIdosos;
                cbVisita.Checked = (bool)objMovimentoDiario.VisitaDomiciliar;
                tbObservacao.Text = objMovimentoDiario.Observacoes;

                //-------------Realizações
                cbEncaminhamento.Checked = (bool)objMovimentoDiario.Encaminhamento;
                cbBeneficioConcedido.Checked = (bool)objMovimentoDiario.BeneficioConcedido;
                cbInseridoPaif.Checked = (bool)objMovimentoDiario.InscritoPaif;
                cbAcompanhamentoIndividual.Checked = (bool)objMovimentoDiario.AcompanhamentoIndividual;

                //------------- RMA
                cbRmaIncluidoCad.Checked = (bool)objMovimentoDiario.IncluidoCad;
                cbRmaBpc.Checked = (bool)objMovimentoDiario.Bpc;
                cbRmaAuxilioNatalidade.Checked = (bool)objMovimentoDiario.AuxilioNatalidade;

                cbRmaAtualizacaoCad.Checked = (bool)objMovimentoDiario.AtualizacaoCad;
                cbRmaEncaminhadoCreas.Checked = (bool)objMovimentoDiario.EncaminhadoCreas;
                cbRmaAuxilioFuneral.Checked = (bool)objMovimentoDiario.AuxilioFuneral;
                cbRmaBeneficioEventual.Checked = (bool)objMovimentoDiario.BeneficioEventual;

                btPreencher.Visible = false;
                btCadastrar.Text = "F10 Alterar";
                btCadastrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            }
            else
            {

                btPreencher.Visible = true;
                btCadastrar.Text = "F10 Cadastrar";
                btCadastrar.BackColor = System.Drawing.Color.Turquoise;

            }
        }

        private void metodoPreencheGrids()
        {

            if (objMovimentoDiario != null)
            {
                //TIPO
                foreach (TipoAtendimento tipo in objMovimentoDiario.tipoAtendimentos)
                {
                    var obj = tipoLista.FirstOrDefault(t => t.idTipo == tipo.idTipo);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }

                //Providencia
                foreach (Providencia prov in objMovimentoDiario.providencias)
                {
                    var obj = providenciaLista.FirstOrDefault(t => t.idProvidencia == prov.idProvidencia);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }


                //SituacaoIdentificada
                foreach (SituacaoIdentificada sit in objMovimentoDiario.situacaoIdentificadas)
                {
                    var obj = situacaoLista.FirstOrDefault(t => t.idSituacaoIdentificada == sit.idSituacaoIdentificada);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }


                //Beneficio
                foreach (BeneficioGoverno ben in objMovimentoDiario.beneficioGovernos)
                {
                    var obj = beneficioLista.FirstOrDefault(t => t.idBeneficioGoverno == ben.idBeneficioGoverno);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }


                //CAD
                //Caso o objeto venha preenchido ja seleciona os itens no datagrid
                if (objMovimentoDiario != null)
                {
                    var obj = cadastroUnicoLista.FirstOrDefault(t => t.idCadastroUnico == objMovimentoDiario.idCad.idCadastroUnico);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }

                //Situação Familiar
                foreach (SituacaoFamiliar sit in objMovimentoDiario.situacaoFamiliars)
                {
                    var obj = situacaoFamiliarLista.FirstOrDefault(t => t.idSituacaoFamiliar == sit.idSituacaoFamiliar);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }

                //Atividade 
                foreach (Atividade atv in objMovimentoDiario.atividadeLista)
                {
                    var obj = atividadeLista.FirstOrDefault(t => t.idAtividade == atv.idAtividade);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }
            }

            AtualizarDataGridTipo(tipoLista);
            AtualizarDataGridProvidencia(providenciaLista);
            AtualizarDataGridSituacaoIdentificada(situacaoLista);
            AtualizarDataGridBeneficioGoverno(beneficioLista);
            AtualizarDataGridCad(cadastroUnicoLista);
            AtualizarDataGridSituacaoFamiliar(situacaoFamiliarLista);
            AtualizarDataGridAtividade(atividadeLista);
        }

        #endregion

        //--------------------------------------------------------Preencher Grid

        #region AtualizaGrides

        //atualiza os valores no Data Grid Tipo
        private void AtualizarDataGridTipo(TipoLista lista)
        {

            this.dgvSelecionarTipo.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (lista.Count > 0)
            {
                this.dgvSelecionarTipo.Rows.Add(lista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (TipoAtendimento tipo in lista)
            {
                this.dgvSelecionarTipo[0, indice].Value = tipo.selecionado;
                this.dgvSelecionarTipo[1, indice].Value = tipo.idTipo;
                this.dgvSelecionarTipo[2, indice].Value = tipo.descricaoTipo;

                indice++;
            }

            dgvSelecionarTipo.Update();

        }

        //atualiza os valores no Data Grid Providencia
        private void AtualizarDataGridProvidencia(ProvidenciaLista lista)
        {

            this.dgvProvidencia.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (lista.Count > 0)
            {
                this.dgvProvidencia.Rows.Add(lista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Providencia prov in lista)
            {
                this.dgvProvidencia[0, indice].Value = prov.selecionado;
                this.dgvProvidencia[1, indice].Value = prov.idProvidencia;
                this.dgvProvidencia[2, indice].Value = prov.descricaoProvidencia;

                indice++;
            }

            dgvProvidencia.Update();

        }

        //atualiza os valores no Data Grid Situação Identificada
        private void AtualizarDataGridSituacaoIdentificada(SituacaoIdentificadaLista lista)
        {

            this.dgvSituacaoIdentificada.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (lista.Count > 0)
            {
                this.dgvSituacaoIdentificada.Rows.Add(lista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (SituacaoIdentificada sit in lista)
            {
                this.dgvSituacaoIdentificada[0, indice].Value = sit.selecionado;
                this.dgvSituacaoIdentificada[1, indice].Value = sit.idSituacaoIdentificada;
                this.dgvSituacaoIdentificada[2, indice].Value = sit.descricaoSituacaoIdentificada;

                indice++;
            }

            dgvSituacaoIdentificada.Update();

        }

        //atualiza os valores no Data Grid Benefício do Governo
        private void AtualizarDataGridBeneficioGoverno(BeneficioGovernoLista lista)
        {

            this.dgvBeneficioGoverno.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (lista.Count > 0)
            {
                this.dgvBeneficioGoverno.Rows.Add(lista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (BeneficioGoverno ben in lista)
            {
                this.dgvBeneficioGoverno[0, indice].Value = ben.selecionado;
                this.dgvBeneficioGoverno[1, indice].Value = ben.idBeneficioGoverno;
                this.dgvBeneficioGoverno[2, indice].Value = ben.descricaoBeneficioGoverno;

                indice++;
            }

            dgvBeneficioGoverno.Update();

        }

        //atualiza os valores no Data Grid Cadástro Único
        private void AtualizarDataGridCad(CadastroUnicoLista lista)
        {

            this.dgvCad.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (lista.Count > 0)
            {
                this.dgvCad.Rows.Add(lista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (CadastroUnico cad in lista)
            {
                this.dgvCad[0, indice].Value = cad.selecionado;
                this.dgvCad[1, indice].Value = cad.idCadastroUnico;
                this.dgvCad[2, indice].Value = cad.descricaoCadastroUnico;

                indice++;
            }

            dgvCad.Update();

        }

        //atualiza os valores no Data Grid Situação Familiar
        private void AtualizarDataGridSituacaoFamiliar(SituacaoFamilizarLista lista)
        {

            this.dgvSituacaoFamiliar.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (lista.Count > 0)
            {
                this.dgvSituacaoFamiliar.Rows.Add(lista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (SituacaoFamiliar sit in lista)
            {
                this.dgvSituacaoFamiliar[0, indice].Value = sit.selecionado;
                this.dgvSituacaoFamiliar[1, indice].Value = sit.idSituacaoFamiliar;
                this.dgvSituacaoFamiliar[2, indice].Value = sit.descricaoSituacaoFamiliar;

                indice++;
            }

            dgvSituacaoFamiliar.Update();

        }

        //atualiza os valores no Data Grid Atividade CRAS Grupos
        private void AtualizarDataGridAtividade(AtividadeLista lista)
        {

            this.dgvAtividade.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (lista.Count > 0)
            {
                this.dgvAtividade.Rows.Add(lista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Atividade atv in lista)
            {
                this.dgvAtividade[0, indice].Value = atv.selecionado;
                this.dgvAtividade[1, indice].Value = atv.idAtividade;
                this.dgvAtividade[2, indice].Value = atv.descricaoAtividade;

                indice++;
            }

            dgvAtividade.Update();

        }

        //atualiza os valores no Data Grid Especificação do Atendimento
        private void AtualizarDataGridEspecificacao(EspecificacaoLista lista)
        {

            this.dgvEspecificacaoAtendimento.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (lista.Count > 0)
            {
                this.dgvEspecificacaoAtendimento.Rows.Add(lista.Count);
            }
            else
            {
                return;
            }

            this.dgvEspecificacaoAtendimento.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            int indice = 0;
            foreach (Especificacao esp in lista)
            {
                this.dgvEspecificacaoAtendimento[0, indice].Value = esp.selecionado;
                this.dgvEspecificacaoAtendimento[1, indice].Value = esp.idEspecificacao;
                this.dgvEspecificacaoAtendimento[2, indice].Value = esp.quantidade;
                this.dgvEspecificacaoAtendimento[3, indice].Value = esp.encaminhamentoEspecificacao;
                this.dgvEspecificacaoAtendimento[4, indice].Value = esp.descricaoEspecificacao;

                indice++;
            }

            dgvEspecificacaoAtendimento.Update();


        }

        #endregion

        //---------------------------------------------------------Botões

        #region Formulário
        private void btSair_Click(object sender, EventArgs e)
        {

            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do movimento diário?",
            Properties.Resources.DialogQuestion,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Sim", "Não",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void btBuscarFuncionario_Click(object sender, EventArgs e)
        {
            strFuncionario = tbBuscarFuncionario.Text;


            if (tbBuscarFuncionario.Text.Equals("Digite o nome do funcionário ...") || tbBuscarFuncionario.Text == string.Empty)
            {
                strFuncionario = "";
            }


            FrmSelecionarFuncionario frmFuncionario = new FrmSelecionarFuncionario(strFuncionario);
            DialogResult result = frmFuncionario.ShowDialog();

            if (result == DialogResult.OK)
            {
                funcionarioLogado = frmFuncionario.FuncionarioSelecionado;
                if (funcionarioLogado.nomeFuncionario != string.Empty)
                {

                    tbBuscarFuncionario.Text = funcionarioLogado.nomeFuncionario;
                }
            }



        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            strCliente = tbCliente.Text;


            if (tbCliente.Text.Equals("Digite o nome do cliente ...") || tbCliente.Text == string.Empty)
            {
                strCliente = "";
            }


            FrmSelecionarCliente frmCliente = new FrmSelecionarCliente(strCliente);
            DialogResult result = frmCliente.ShowDialog();

            if (result == DialogResult.OK)
            {
                clienteSelecionado = frmCliente.clienteSelecionado;
                if (clienteSelecionado.nomeCliente != string.Empty)
                {
                    tbCliente.Text = clienteSelecionado.nomeCliente;
                    tbProntuario.Text = clienteSelecionado.prontuarioCliente;
                    tbNome.Text = clienteSelecionado.nomeCliente;
                    nudCriancas.Focus();
                }
            }
        }

        //---------------------------------------------------------Formulário
        private void FrmMovimentoDiario_Load(object sender, EventArgs e)
        {
            //------------Preencher Grids
            pbBuscarProvidencia_Click(null, e);
            pbBuscarTipo_Click(null, e);
            pbBuscarSituacaoIdentificada_Click(null, e);
            pbBuscarBeneficioGoverno_Click(null, e);
            pbBuscarCad_Click(null, e);
            pbBuscarSituacaoFamiliar_Click(null, e);
            pbBuscarEspecificacaoAtendimento_Click(null, e);
            pbBuscarAtividadeCras_Click(null, e);

            //------------Funcionario
            if (funcionarioLogado != null)
            {
                strFuncionario = funcionarioLogado.nomeFuncionario;
            }

            //-----------------------------Form Alterar Excluir
            metodoPreencheFormulario();
        }
        #endregion

        //---------------------------------------------------------Botões de Busca dos Grid

        #region BotõesGride
        //Tipo
        private void pbBuscarTipo_Click(object sender, EventArgs e)
        {
            string str = tbBuscarTipo.Text;

            if (tbBuscarTipo.Text.Equals("Tipo de Atendimento ...") || tbBuscarTipo.Text == string.Empty)
            {
                str = "";
            }

            // Verifica se a lista tipoLista tem itens
            if (tipoLista != null)
            {
                // Filtra a lista tipoLista usando IndexOf para comparação insensível a maiúsculas/minúsculas
                var resultados = tipoLista.Where(t => t.descricaoTipo.IndexOf(str, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                if (resultados.Count > 0)
                {
                    // Cria uma nova lista filtrada e atualiza o DataGrid
                    TipoLista listaFiltrada = new TipoLista();
                    listaFiltrada.AddRange(resultados);
                    //dgvSelecionarTipo.Rows.Clear();
                    AtualizarDataGridTipo(listaFiltrada);
                    tbBuscarTipo.Focus();
                }
                else
                {
                    MessageBox.Show("Nenhum tipo de atendimento encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbBuscarTipo.Clear();
                }
            }

            else//Caso a lista não tenha itens
            {
                // Caso a lista esteja vazia, busca na fonte original
                this.tipoLista = nTipo.BuscarTipoPorNome(str);


                //Caso o objeto venha preenchido ja seleciona os itens no datagrid
                if (objMovimentoDiario != null)
                {
                    foreach (TipoAtendimento tipo in objMovimentoDiario.tipoAtendimentos)
                    {
                        var obj = tipoLista.FirstOrDefault(t => t.idTipo == tipo.idTipo);
                        if (obj != null)
                        {

                            obj.selecionado = true;
                        }
                    }
                }


                AtualizarDataGridTipo(tipoLista);
            }
        }

        //Providencia
        private void pbBuscarProvidencia_Click(object sender, EventArgs e)
        {
            string str;
            str = tbProvidencia.Text;

            if (tbProvidencia.Text.Equals("Providência CRAS ...") || tbProvidencia.Text == string.Empty)
            {
                str = "";
            }

            // Verifica se a lista tipoLista tem itens
            if (providenciaLista != null)
            {
                // Filtra a lista tipoLista usando IndexOf para comparação insensível a maiúsculas/minúsculas
                var resultados = providenciaLista.Where(t => t.descricaoProvidencia.IndexOf(str, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                if (resultados.Count > 0)
                {
                    // Cria uma nova lista filtrada e atualiza o DataGrid
                    ProvidenciaLista listaFiltrada = new ProvidenciaLista();
                    listaFiltrada.AddRange(resultados);
                    //dgvSelecionarTipo.Rows.Clear();
                    AtualizarDataGridProvidencia(listaFiltrada);
                    tbProvidencia.Focus();
                }
                else
                {
                    MessageBox.Show("Nenhuma providência encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbProvidencia.Clear();
                }
            }
            else//Caso a lista não tenha itens
            {

                this.providenciaLista = nProvidencia.BuscarProvidenciaPorNome(str);

                //Caso o objeto venha preenchido ja seleciona os itens no datagrid
                if (objMovimentoDiario != null)
                {
                    foreach (Providencia prov in objMovimentoDiario.providencias)
                    {
                        var obj = providenciaLista.FirstOrDefault(t => t.idProvidencia == prov.idProvidencia);
                        if (obj != null)
                        {

                            obj.selecionado = true;
                        }
                    }
                }
                AtualizarDataGridProvidencia(providenciaLista);

            }
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

            // Verifica se a lista tipoLista tem itens
            if (situacaoLista != null)
            {
                // Filtra a lista tipoLista usando IndexOf para comparação insensível a maiúsculas/minúsculas
                var resultados = situacaoLista.Where(t => t.descricaoSituacaoIdentificada.IndexOf(str, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                if (resultados.Count > 0)
                {
                    // Cria uma nova lista filtrada e atualiza o DataGrid
                    SituacaoIdentificadaLista listaFiltrada = new SituacaoIdentificadaLista();
                    listaFiltrada.AddRange(resultados);
                    //dgvSelecionarTipo.Rows.Clear();
                    AtualizarDataGridSituacaoIdentificada(listaFiltrada);
                    tbSituacaoIdentificada.Focus();
                }
                else
                {
                    MessageBox.Show("Nenhuma situação encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbSituacaoIdentificada.Clear();
                }
            }
            else//Caso a lista não tenha itens
            {
                this.situacaoLista = nSituacaoIdentificada.BuscarSituacaoPorNome(str);


                //Caso o objeto venha preenchido ja seleciona os itens no datagrid
                if (objMovimentoDiario != null)
                {
                    foreach (SituacaoIdentificada sit in objMovimentoDiario.situacaoIdentificadas)
                    {
                        var obj = situacaoLista.FirstOrDefault(t => t.idSituacaoIdentificada == sit.idSituacaoIdentificada);
                        if (obj != null)
                        {

                            obj.selecionado = true;
                        }
                    }
                }


                AtualizarDataGridSituacaoIdentificada(situacaoLista);
            }

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

            // Verifica se a lista tipoLista tem itens
            if (beneficioLista != null)
            {
                // Filtra a lista tipoLista usando IndexOf para comparação insensível a maiúsculas/minúsculas
                var resultados = beneficioLista.Where(t => t.descricaoBeneficioGoverno.IndexOf(str, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                if (resultados.Count > 0)
                {
                    // Cria uma nova lista filtrada e atualiza o DataGrid
                    BeneficioGovernoLista listaFiltrada = new BeneficioGovernoLista();
                    listaFiltrada.AddRange(resultados);
                    //dgvSelecionarTipo.Rows.Clear();
                    AtualizarDataGridBeneficioGoverno(listaFiltrada);
                    tbBeneficioGoverno.Focus();
                }
                else
                {
                    MessageBox.Show("Nenhum Benefício encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbBeneficioGoverno.Clear();
                }
            }
            else//Caso a lista não tenha itens
            {

                this.beneficioLista = nBeneficio.BuscarBeneficioGovernoPorNome(str);


                //Caso o objeto venha preenchido ja seleciona os itens no datagrid
                if (objMovimentoDiario != null)
                {
                    foreach (BeneficioGoverno ben in objMovimentoDiario.beneficioGovernos)
                    {
                        var obj = beneficioLista.FirstOrDefault(t => t.idBeneficioGoverno == ben.idBeneficioGoverno);
                        if (obj != null)
                        {

                            obj.selecionado = true;
                        }
                    }
                }



                AtualizarDataGridBeneficioGoverno(beneficioLista);

            }

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

            // Verifica se a lista tipoLista tem itens
            if (cadastroUnicoLista != null)
            {
                // Filtra a lista tipoLista usando IndexOf para comparação insensível a maiúsculas/minúsculas
                var resultados = cadastroUnicoLista.Where(t => t.descricaoCadastroUnico.IndexOf(str, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                if (resultados.Count > 0)
                {
                    // Cria uma nova lista filtrada e atualiza o DataGrid
                    CadastroUnicoLista listaFiltrada = new CadastroUnicoLista();
                    listaFiltrada.AddRange(resultados);
                    //dgvSelecionarTipo.Rows.Clear();
                    AtualizarDataGridCad(listaFiltrada);
                    tbCad.Focus();
                }
                else
                {
                    MessageBox.Show("Nenhum CAD encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbCad.Clear();
                }
            }
            else//Caso a lista não tenha itens
            {
                this.cadastroUnicoLista = nCadastroUnico.BuscarCadastroUnicoPorNome(str);


                //Caso o objeto venha preenchido ja seleciona os itens no datagrid
                if (objMovimentoDiario != null)
                {
                    var obj = cadastroUnicoLista.FirstOrDefault(t => t.idCadastroUnico == objMovimentoDiario.idCad.idCadastroUnico);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }

                AtualizarDataGridCad(cadastroUnicoLista);
            }

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

            // Verifica se a lista tipoLista tem itens
            if (situacaoFamiliarLista != null)
            {
                // Filtra a lista tipoLista usando IndexOf para comparação insensível a maiúsculas/minúsculas
                var resultados = situacaoFamiliarLista.Where(t => t.descricaoSituacaoFamiliar.IndexOf(str, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                if (resultados.Count > 0)
                {
                    // Cria uma nova lista filtrada e atualiza o DataGrid
                    SituacaoFamilizarLista listaFiltrada = new SituacaoFamilizarLista();
                    listaFiltrada.AddRange(resultados);
                    //dgvSelecionarTipo.Rows.Clear();
                    AtualizarDataGridSituacaoFamiliar(listaFiltrada);
                    tbSituacaoFamiliar.Focus();
                }
                else
                {
                    MessageBox.Show("Nenhuma Situação Familiar encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbSituacaoFamiliar.Clear();
                }
            }
            else//Caso a lista não tenha itens
            {


                this.situacaoFamiliarLista = nSituacaoFamiliar.BuscarSituacaoPorNome(str);

                //Caso o objeto venha preenchido ja seleciona os itens no datagrid
                if (objMovimentoDiario != null)
                {
                    foreach (SituacaoFamiliar sit in objMovimentoDiario.situacaoFamiliars)
                    {
                        var obj = situacaoFamiliarLista.FirstOrDefault(t => t.idSituacaoFamiliar == sit.idSituacaoFamiliar);
                        if (obj != null)
                        {

                            obj.selecionado = true;
                        }
                    }
                }

                AtualizarDataGridSituacaoFamiliar(situacaoFamiliarLista);
            }
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

            // Verifica se a lista tipoLista tem itens
            if (atividadeLista != null)
            {
                // Filtra a lista tipoLista usando IndexOf para comparação insensível a maiúsculas/minúsculas
                var resultados = atividadeLista.Where(t => t.descricaoAtividade.IndexOf(str, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                if (resultados.Count > 0)
                {
                    // Cria uma nova lista filtrada e atualiza o DataGrid
                    AtividadeLista listaFiltrada = new AtividadeLista();
                    listaFiltrada.AddRange(resultados);
                    //dgvSelecionarTipo.Rows.Clear();
                    AtualizarDataGridAtividade(listaFiltrada);
                    tbAtividadeCras.Focus();
                }
                else
                {
                    MessageBox.Show("Nenhuma Atividade encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbAtividadeCras.Clear();
                }
            }
            else//Caso a lista não tenha itens
            {
                this.atividadeLista = nAtividade.BuscarAtividadePorNome(str);


                //Caso o objeto venha preenchido ja seleciona os itens no datagrid
                if (objMovimentoDiario != null)
                {
                    foreach (Atividade atv in objMovimentoDiario.atividadeLista)
                    {
                        var obj = atividadeLista.FirstOrDefault(t => t.idAtividade == atv.idAtividade);
                        if (obj != null)
                        {

                            obj.selecionado = true;
                        }
                    }
                }


                AtualizarDataGridAtividade(atividadeLista);

            }

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

            // Verifica se a lista tipoLista tem itens
            if (especificacaoLista != null)
            {
                // Filtra a lista tipoLista usando IndexOf para comparação insensível a maiúsculas/minúsculas
                var resultados = especificacaoLista.Where(t => t.descricaoEspecificacao.IndexOf(str, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                if (resultados.Count > 0)
                {
                    // Cria uma nova lista filtrada e atualiza o DataGrid
                    EspecificacaoLista listaFiltrada = new EspecificacaoLista();
                    listaFiltrada.AddRange(resultados);

                    //dgvSelecionarTipo.Rows.Clear();
                    AtualizarDataGridEspecificacao(listaFiltrada);
                    tbEspecificacaoAtendimento.Focus();
                }
                else
                {
                    MessageBox.Show("Nenhuma Especificação do Atendimento encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbEspecificacaoAtendimento.Clear();
                }
            }
            else//Caso a lista não tenha itens
            {

                this.especificacaoLista = nEspecificacao.BuscarEspecificacaoPorNome(str);
                AtualizarDataGridEspecificacao(especificacaoLista);
            }
        }

        #endregion

        //------------------------------------------------------------------------Caixa de Texto 

        #region CaixaDeTexto
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

            if (strCliente != String.Empty)
            {
                tbCliente.Text = strCliente;
            }
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


        //-----------------------------------------------------------------------------Caixa de Texto Providência
        private void tbProvidencia_Enter(object sender, EventArgs e)
        {
            tbProvidencia.Clear();
            panelProvidencia.BackColor = Color.DeepPink;
        }

        private void tbProvidencia_Leave(object sender, EventArgs e)
        {
            if (tbProvidencia.Text == "")
            {
                tbProvidencia.Text = "Providência CRAS ...";
                panelProvidencia.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbProvidencia.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbProvidencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarProvidencia_Click(null, e);
                e.Handled = true;
            }
        }

        //-----------------------------------------------------------------------------Caixa de Texto Situação Identificada
        private void tbSituacaoIdentificada_Enter(object sender, EventArgs e)
        {
            tbSituacaoIdentificada.Clear();
            panelSituacaoIdentificada.BackColor = Color.DeepPink;
        }

        private void tbSituacaoIdentificada_Leave(object sender, EventArgs e)
        {
            if (tbSituacaoIdentificada.Text == "")
            {
                tbSituacaoIdentificada.Text = "Situação Identificada ...";
                panelSituacaoIdentificada.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbSituacaoIdentificada.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbSituacaoIdentificada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarSituacaoIdentificada_Click(null, e);
                e.Handled = true;
            }
        }

        //-----------------------------------------------------------------------------Caixa de Texto Benefício Governo
        private void tbBeneficioGoverno_Enter(object sender, EventArgs e)
        {
            tbBeneficioGoverno.Clear();
            panelBeneficioGoverno.BackColor = Color.DeepPink;
        }

        private void tbBeneficioGoverno_Leave(object sender, EventArgs e)
        {
            if (tbBeneficioGoverno.Text == "")
            {
                tbBeneficioGoverno.Text = "Benefício do Governo ...";
                panelBeneficioGoverno.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBeneficioGoverno.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBeneficioGoverno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarBeneficioGoverno_Click(null, e);
                e.Handled = true;
            }
        }

        //-----------------------------------------------------------------------------Caixa de Texto Cadastro Único
        private void tbCad_Enter(object sender, EventArgs e)
        {
            tbCad.Clear();
            panelCad.BackColor = Color.DeepPink;
        }

        private void tbCad_Leave(object sender, EventArgs e)
        {
            if (tbCad.Text == "")
            {
                tbCad.Text = "Cadastro Único ...";
                panelCad.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbCad.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbCad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarCad_Click(null, e);
                e.Handled = true;
            }
        }


        //-----------------------------------------------------------------------------Caixa de Texto Situação Familiar
        private void tbSituacaoFamiliar_Enter(object sender, EventArgs e)
        {
            tbSituacaoFamiliar.Clear();
            painelSituacaoFamiliar.BackColor = Color.DeepPink;
        }

        private void tbSituacaoFamiliar_Leave(object sender, EventArgs e)
        {
            if (tbSituacaoFamiliar.Text == "")
            {
                tbSituacaoFamiliar.Text = "Situação Familiar ...";
                painelSituacaoFamiliar.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbSituacaoFamiliar.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbSituacaoFamiliar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarSituacaoFamiliar_Click(null, e);
                e.Handled = true;
            }
        }

        //-----------------------------------------------------------------------------Caixa de Texto Atividade Cras

        private void tbAtividadeCras_Enter(object sender, EventArgs e)
        {
            tbAtividadeCras.Clear();
            panelAtividade.BackColor = Color.DeepPink;
        }

        private void tbAtividadeCras_Leave(object sender, EventArgs e)
        {
            if (tbAtividadeCras.Text == "")
            {
                tbAtividadeCras.Text = "Ativiadade no CRAS...";
                panelAtividade.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbAtividadeCras.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbAtividadeCras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarAtividadeCras_Click(null, e);
                e.Handled = true;
            }
        }


        //-----------------------------------------------------------------------------Caixa de Texto Especificação Atendimento
        private void tbEspecificacaoAtendimento_Enter(object sender, EventArgs e)
        {
            tbEspecificacaoAtendimento.Clear();
            panelEspecificacao.BackColor = Color.DeepPink;
        }

        private void tbEspecificacaoAtendimento_Leave(object sender, EventArgs e)
        {
            if (tbEspecificacaoAtendimento.Text == "")
            {
                tbEspecificacaoAtendimento.Text = "Especificação do Atendimento ...";
                panelEspecificacao.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbEspecificacaoAtendimento.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }

        }

        private void tbEspecificacaoAtendimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarEspecificacaoAtendimento_Click(null, e);
                e.Handled = true;
            }
        }



        #endregion

        //------------------------------------------------------------------------Data Grid Eventos

        #region DataGridCheck
        //TIPO
        private void dgvSelecionarTipo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula alterada está em uma linha válida
            if (e.RowIndex >= 0 && dgvSelecionarTipo.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Obtém o valor da célula de checkbox
                bool isChecked = Convert.ToBoolean(dgvSelecionarTipo[e.ColumnIndex, e.RowIndex].Value);

                // Atualiza o item correspondente na lista `tipoLista`
                int idTipo = Convert.ToInt32(dgvSelecionarTipo[1, e.RowIndex].Value); // Supondo que a coluna 1 contém o idTipo
                var tipo = tipoLista.FirstOrDefault(t => t.idTipo == idTipo);

                if (tipo != null)
                {
                    tipo.selecionado = isChecked; // Atualiza o valor selecionado com o estado do checkbox

                    // Opcional: Atualiza o DataGrid para refletir a mudança (caso seja necessário)
                    //AtualizarDataGridTipo(tipoLista);
                }
            }
        }

        private void dgvSelecionarTipo_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //Garante que o evento CellValueChanged seja disparado imediatamente após o clique no checkbox
            if (dgvSelecionarTipo.IsCurrentCellDirty)
            {
                dgvSelecionarTipo.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        //Providencia
        private void dgvProvidencia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula alterada está em uma linha válida
            if (e.RowIndex >= 0 && dgvProvidencia.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Obtém o valor da célula de checkbox
                bool isChecked = Convert.ToBoolean(dgvProvidencia[e.ColumnIndex, e.RowIndex].Value);

                // Atualiza o item correspondente na lista `tipoLista`
                int id = Convert.ToInt32(dgvProvidencia[1, e.RowIndex].Value); // Supondo que a coluna 1 contém o idTipo
                var obj = providenciaLista.FirstOrDefault(t => t.idProvidencia == id);

                if (obj != null)
                {
                    obj.selecionado = isChecked; // Atualiza o valor selecionado com o estado do checkbox

                    // Opcional: Atualiza o DataGrid para refletir a mudança (caso seja necessário)
                    //AtualizarDataGridTipo(tipoLista);
                }
            }
        }

        private void dgvProvidencia_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {        //Garante que o evento CellValueChanged seja disparado imediatamente após o clique no checkbox
            if (dgvProvidencia.IsCurrentCellDirty)
            {
                dgvProvidencia.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        //Situação Identificada
        private void dgvSituacaoIdentificada_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvSituacaoIdentificada.IsCurrentCellDirty)
            {
                dgvSituacaoIdentificada.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvSituacaoIdentificada_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            // Verifica se a célula alterada está em uma linha válida
            if (e.RowIndex >= 0 && dgvSituacaoIdentificada.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Obtém o valor da célula de checkbox
                bool isChecked = Convert.ToBoolean(dgvSituacaoIdentificada[e.ColumnIndex, e.RowIndex].Value);

                // Atualiza o item correspondente na lista `tipoLista`
                int id = Convert.ToInt32(dgvSituacaoIdentificada[1, e.RowIndex].Value); // Supondo que a coluna 1 contém o idTipo
                var obj = situacaoLista.FirstOrDefault(t => t.idSituacaoIdentificada == id);

                if (obj != null)
                {
                    obj.selecionado = isChecked; // Atualiza o valor selecionado com o estado do checkbox

                    // Opcional: Atualiza o DataGrid para refletir a mudança (caso seja necessário)
                    //AtualizarDataGridTipo(tipoLista);
                }
            }

        }


        //Benefício do Governo
        private void dgvBeneficioGoverno_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvBeneficioGoverno.IsCurrentCellDirty)
            {
                dgvBeneficioGoverno.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvBeneficioGoverno_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula alterada está em uma linha válida
            if (e.RowIndex >= 0 && dgvBeneficioGoverno.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Obtém o valor da célula de checkbox
                bool isChecked = Convert.ToBoolean(dgvBeneficioGoverno[e.ColumnIndex, e.RowIndex].Value);

                // Atualiza o item correspondente na lista `tipoLista`
                int id = Convert.ToInt32(dgvBeneficioGoverno[1, e.RowIndex].Value); // Supondo que a coluna 1 contém o idTipo
                var obj = beneficioLista.FirstOrDefault(t => t.idBeneficioGoverno == id);

                if (obj != null)
                {
                    obj.selecionado = isChecked; // Atualiza o valor selecionado com o estado do checkbox

                    // Opcional: Atualiza o DataGrid para refletir a mudança (caso seja necessário)
                    //AtualizarDataGridTipo(tipoLista);
                }
            }
        }

        //CAD
        private void dgvCad_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCad.IsCurrentCellDirty)
            {
                dgvCad.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvCad_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula alterada está em uma linha válida
            if (e.RowIndex >= 0 && dgvCad.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Obtém o valor da célula de checkbox
                bool isChecked = Convert.ToBoolean(dgvCad[e.ColumnIndex, e.RowIndex].Value);

                // Atualiza o item correspondente na lista `tipoLista`
                int id = Convert.ToInt32(dgvCad[1, e.RowIndex].Value); // Supondo que a coluna 1 contém o idTipo
                var obj = cadastroUnicoLista.FirstOrDefault(t => t.idCadastroUnico == id);

                if (obj != null)
                {
                    obj.selecionado = isChecked; // Atualiza o valor selecionado com o estado do checkbox

                    // Opcional: Atualiza o DataGrid para refletir a mudança (caso seja necessário)
                    //AtualizarDataGridTipo(tipoLista);
                }
            }

        }

        //Situacao Familiar
        private void dgvSituacaoFamiliar_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvSituacaoFamiliar.IsCurrentCellDirty)
            {
                dgvSituacaoFamiliar.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvSituacaoFamiliar_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula alterada está em uma linha válida
            if (e.RowIndex >= 0 && dgvSituacaoFamiliar.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Obtém o valor da célula de checkbox
                bool isChecked = Convert.ToBoolean(dgvSituacaoFamiliar[e.ColumnIndex, e.RowIndex].Value);

                // Atualiza o item correspondente na lista `tipoLista`
                int id = Convert.ToInt32(dgvSituacaoFamiliar[1, e.RowIndex].Value); // Supondo que a coluna 1 contém o idTipo
                var obj = situacaoFamiliarLista.FirstOrDefault(t => t.idSituacaoFamiliar == id);

                if (obj != null)
                {
                    obj.selecionado = isChecked; // Atualiza o valor selecionado com o estado do checkbox

                    // Opcional: Atualiza o DataGrid para refletir a mudança (caso seja necessário)
                    //AtualizarDataGridTipo(tipoLista);
                }
            }
        }

        //Atividade CRAS
        private void dgvAtividade_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvAtividade.IsCurrentCellDirty)
            {
                dgvAtividade.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvAtividade_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a célula alterada está em uma linha válida
            if (e.RowIndex >= 0 && dgvAtividade.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Obtém o valor da célula de checkbox
                bool isChecked = Convert.ToBoolean(dgvAtividade[e.ColumnIndex, e.RowIndex].Value);

                // Atualiza o item correspondente na lista `tipoLista`
                int id = Convert.ToInt32(dgvAtividade[1, e.RowIndex].Value); // Supondo que a coluna 1 contém o idTipo
                var obj = atividadeLista.FirstOrDefault(t => t.idAtividade == id);

                if (obj != null)
                {
                    obj.selecionado = isChecked; // Atualiza o valor selecionado com o estado do checkbox

                    // Opcional: Atualiza o DataGrid para refletir a mudança (caso seja necessário)
                    //AtualizarDataGridTipo(tipoLista);
                }
            }
        }

        //Especificação
        private void dgvEspecificacaoAtendimento_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvEspecificacaoAtendimento.IsCurrentCellDirty)
            {
                dgvEspecificacaoAtendimento.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvEspecificacaoAtendimento_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Verifica se a célula alterada está em uma linha válida
                if (e.RowIndex >= 0 && dgvEspecificacaoAtendimento.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
                {
                    // Obtém o valor da célula de checkbox
                    bool isChecked = Convert.ToBoolean(dgvEspecificacaoAtendimento[e.ColumnIndex, e.RowIndex].Value);

                    // Atualiza o item correspondente na lista `tipoLista`
                    int id = Convert.ToInt32(dgvEspecificacaoAtendimento[1, e.RowIndex].Value); // Supondo que a coluna 1 contém o idTipo
                    int qtd = Convert.ToInt32(dgvEspecificacaoAtendimento[2, e.RowIndex].Value);

                    var obj = especificacaoLista.FirstOrDefault(t => t.idEspecificacao == id);

                    if (obj != null)
                    {
                        obj.selecionado = isChecked; // Atualiza o valor selecionado com o estado do checkbox
                        obj.quantidade = qtd;

                        // Opcional: Atualiza o DataGrid para refletir a mudança (caso seja necessário)
                        //AtualizarDataGridTipo(tipoLista);
                    }
                }
                // Verifica se a coluna alterada é a coluna 2
                else if (e.ColumnIndex == 2)
                {
                    // Obtém o novo valor da quantidade
                    int qtd = Convert.ToInt32(dgvEspecificacaoAtendimento[e.ColumnIndex, e.RowIndex].Value);

                    // Atualiza o item correspondente na lista `tipoLista`
                    int id = Convert.ToInt32(dgvEspecificacaoAtendimento[1, e.RowIndex].Value); // Supondo que a coluna 1 contém o idTipo

                    var obj = especificacaoLista.FirstOrDefault(t => t.idEspecificacao == id);

                    if (obj != null)
                    {
                        obj.quantidade = qtd;
                    }
                }
            }
        }

        #endregion

        //----------------------------------------------------------Botões

        #region Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (metodoValidaCadastro() == true)
                {
                    // Instanciar um novo objeto MovimentoDiario
                    MovimentoDiario objMovimentoDiario = new MovimentoDiario();


                    if (clienteSelecionado != null)
                    {
                        objMovimentoDiario.idCliente = new Cliente();
                        objMovimentoDiario.idCliente = clienteSelecionado;

                    }
                    else
                    {
                        objMovimentoDiario.idCliente = new Cliente();
                        objMovimentoDiario.idCliente.codigoCliente = 0;
                    }


                    objMovimentoDiario.idFuncionario = new Funcionario();
                    objMovimentoDiario.idFuncionario = funcionarioLogado;

                    // Preencher as propriedades básicas
                    objMovimentoDiario.Data = DateTime.Now;
                    objMovimentoDiario.Prontuario = tbProntuario.Text;
                    objMovimentoDiario.Nome = tbNome.Text;
                    objMovimentoDiario.QuantidadeCriancas = int.Parse(nudCriancas.Text);
                    objMovimentoDiario.QuantidadeAdolescentes = int.Parse(nudAdolescente.Text);
                    objMovimentoDiario.QuantidadeIdosos = int.Parse(nudIdoso.Text);
                    objMovimentoDiario.VisitaDomiciliar = cbVisita.Checked;
                    objMovimentoDiario.Observacoes = tbObservacao.Text;

                    // Inicializar e preencher listas selecionadas
                    objMovimentoDiario.tipoAtendimentos = new TipoLista();
                    PreencherListaSelecionados(tipoLista, objMovimentoDiario.tipoAtendimentos, t => t.selecionado);

                    objMovimentoDiario.providencias = new ProvidenciaLista();
                    PreencherListaSelecionados(providenciaLista, objMovimentoDiario.providencias, p => p.selecionado);

                    objMovimentoDiario.situacaoIdentificadas = new SituacaoIdentificadaLista();
                    PreencherListaSelecionados(situacaoLista, objMovimentoDiario.situacaoIdentificadas, s => s.selecionado);

                    objMovimentoDiario.beneficioGovernos = new BeneficioGovernoLista();
                    PreencherListaSelecionados(beneficioLista, objMovimentoDiario.beneficioGovernos, b => b.selecionado);

                    objMovimentoDiario.cadastroUnicos = new CadastroUnicoLista();
                    PreencherListaSelecionados(cadastroUnicoLista, objMovimentoDiario.cadastroUnicos, c => c.selecionado);

                    objMovimentoDiario.situacaoFamiliars = new SituacaoFamilizarLista();
                    PreencherListaSelecionados(situacaoFamiliarLista, objMovimentoDiario.situacaoFamiliars, s => s.selecionado);

                    objMovimentoDiario.atividadeLista = new AtividadeLista();
                    PreencherListaSelecionados(atividadeLista, objMovimentoDiario.atividadeLista, a => a.selecionado);

                    objMovimentoDiario.especificacaoLista = new EspecificacaoLista();
                    PreencherListaSelecionados(especificacaoLista, objMovimentoDiario.especificacaoLista, g => g.selecionado);


                    //CAD
                    if (cadastroUnicoLista != null && cadastroUnicoLista.Any())
                    {
                        objMovimentoDiario.idCad = cadastroUnicoLista.FirstOrDefault();
                    }

                    //-------------Realizações
                    objMovimentoDiario.Encaminhamento = cbEncaminhamento.Checked;
                    objMovimentoDiario.BeneficioConcedido = cbBeneficioConcedido.Checked;
                    objMovimentoDiario.InscritoPaif = cbInseridoPaif.Checked;
                    objMovimentoDiario.AcompanhamentoIndividual = cbAcompanhamentoIndividual.Checked;

                    //-------------RMA
                    objMovimentoDiario.IncluidoCad = cbRmaIncluidoCad.Checked;
                    objMovimentoDiario.Bpc = cbRmaBpc.Checked;
                    objMovimentoDiario.AuxilioNatalidade = cbRmaAuxilioNatalidade.Checked;

                    objMovimentoDiario.AtualizacaoCad = cbRmaAtualizacaoCad.Checked;
                    objMovimentoDiario.EncaminhadoCreas = cbRmaEncaminhadoCreas.Checked;
                    objMovimentoDiario.AuxilioFuneral = cbRmaAuxilioFuneral.Checked;
                    objMovimentoDiario.BeneficioEventual = cbRmaBeneficioEventual.Checked;

                    // Instanciar a camada de negócios
                    NegMovimentoDiario negocioMovimento = new NegMovimentoDiario();

                    // Cadastrar o movimento diário
                    if (negocioMovimento.CadastrarMovimentoDiario(objMovimentoDiario))
                    {
                        MessageBox.Show("Movimento Diário cadastrado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("O cadastro não foi realizado. Verifique os dados informados.");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Exceção: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btPreencher_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado.codigoCliente != 0)
            {
                NegMovimentoDiario nMovimento = new NegMovimentoDiario();
                objMovimentoDiario = nMovimento.BuscarMovimentoDiarioUltimo(clienteSelecionado.codigoCliente);

                if (objMovimentoDiario != null)
                {
                    nMovimento.PreencherListasMovimentoDiario(objMovimentoDiario);
                    metodoPreencheFormulario();
                    metodoPreencheGrids();

                    btCadastrar.Text = "F10 Cadastrar";
                    btCadastrar.BackColor = System.Drawing.Color.Turquoise;
                }
                else
                {
                    MessageBox.Show("Não existem lançamentos registrados do usuário selecionado!",
            "Erro ao Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário do CRAS para preenhcher os dados com o último atendimento!",
                    "Erro ao Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        //---------------------------------------------------------Botões Cadastro
        private void pbAdicionarTipo_Click(object sender, EventArgs e)
        {
            FrmSelecionarTipoAtendimento frmTipo = new FrmSelecionarTipoAtendimento();
            frmTipo.ShowDialog();

            //Atualiza lista
            tipoLista = nTipo.BuscarTipoPorNome("");

            //mantem os objetos ja cadastrados selecionados
            if (objMovimentoDiario != null)
            {
                foreach (TipoAtendimento tipo in objMovimentoDiario.tipoAtendimentos)
                {
                    var obj = tipoLista.FirstOrDefault(t => t.idTipo == tipo.idTipo);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }
            }

            AtualizarDataGridTipo(tipoLista);

        }

        private void pbAdicionarProvidencia_Click(object sender, EventArgs e)
        {
            FrmSelecionarProvidenciaCras frmProvidencia = new FrmSelecionarProvidenciaCras();
            frmProvidencia.ShowDialog();

            //Atualiza lista
            providenciaLista = nProvidencia.BuscarProvidenciaPorNome("");

            //mantem os objetos ja cadastrados selecionados
            if (objMovimentoDiario != null)
            {
                foreach (Providencia prov in objMovimentoDiario.providencias)
                {
                    var obj = providenciaLista.FirstOrDefault(t => t.idProvidencia == prov.idProvidencia);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }
            }

            AtualizarDataGridProvidencia(providenciaLista);
        }

        private void pbAdicionarSituacaoIdentificada_Click(object sender, EventArgs e)
        {
            FrmSelecionarSituacaoIdentificada frmSituacao = new FrmSelecionarSituacaoIdentificada();
            frmSituacao.ShowDialog();

            //Atualiza lista
            situacaoLista = nSituacaoIdentificada.BuscarSituacaoPorNome("");

            //mantem os objetos ja cadastrados selecionados
            if (objMovimentoDiario != null)
            {
                foreach (SituacaoIdentificada sit in objMovimentoDiario.situacaoIdentificadas)
                {
                    var obj = situacaoLista.FirstOrDefault(t => t.idSituacaoIdentificada == sit.idSituacaoIdentificada);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }
            }

            AtualizarDataGridSituacaoIdentificada(situacaoLista);
        }

        private void pbAdicionarBeneficioGoverno_Click(object sender, EventArgs e)
        {
            FrmSelecionarBeneficioGoverno frmBeneficio = new FrmSelecionarBeneficioGoverno();
            frmBeneficio.ShowDialog();

            //Atualiza lista
            beneficioLista = nBeneficio.BuscarBeneficioGovernoPorNome("");

            //mantem os objetos ja cadastrados selecionados
            if (objMovimentoDiario != null)
            {
                foreach (BeneficioGoverno ben in objMovimentoDiario.beneficioGovernos)
                {
                    var obj = beneficioLista.FirstOrDefault(t => t.idBeneficioGoverno == ben.idBeneficioGoverno);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }
            }

            AtualizarDataGridBeneficioGoverno(beneficioLista);
        }

        private void pbAdicionarCad_Click(object sender, EventArgs e)
        {
            FrmSelecionarCadastroUnico frmCad = new FrmSelecionarCadastroUnico();
            frmCad.ShowDialog();

            //Atualiza lista
            cadastroUnicoLista = nCadastroUnico.BuscarCadastroUnicoPorNome("");

            //mantem os objetos ja cadastrados selecionados
            if (objMovimentoDiario != null)
            {
                //Caso o objeto venha preenchido ja seleciona os itens no datagrid
                if (objMovimentoDiario != null)
                {
                    var obj = cadastroUnicoLista.FirstOrDefault(t => t.idCadastroUnico == objMovimentoDiario.idCad.idCadastroUnico);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }
            }

            AtualizarDataGridCad(cadastroUnicoLista);
        }

        private void pbAdicionarSituacaoFamiliar_Click(object sender, EventArgs e)
        {
            FrmSelecionarSituacaoFamiliar frmSituacao = new FrmSelecionarSituacaoFamiliar();
            frmSituacao.ShowDialog();

            //Atualiza lista
            situacaoFamiliarLista = nSituacaoFamiliar.BuscarSituacaoPorNome("");

            //mantem os objetos ja cadastrados selecionados
            if (objMovimentoDiario != null)
            {
                foreach (SituacaoFamiliar sit in objMovimentoDiario.situacaoFamiliars)
                {
                    var obj = situacaoFamiliarLista.FirstOrDefault(t => t.idSituacaoFamiliar == sit.idSituacaoFamiliar);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }
            }

            AtualizarDataGridSituacaoFamiliar(situacaoFamiliarLista);
        }

        private void pbAdicionarAtividadeCras_Click(object sender, EventArgs e)
        {
            FrmSelecionarAtividadeCras frmAtividade = new FrmSelecionarAtividadeCras();
            frmAtividade.ShowDialog();

            //Atualiza lista
            atividadeLista = nAtividade.BuscarAtividadePorNome("");

            //mantem os objetos ja cadastrados selecionados
            if (objMovimentoDiario != null)
            {
                foreach (Atividade atv in objMovimentoDiario.atividadeLista)
                {
                    var obj = atividadeLista.FirstOrDefault(t => t.idAtividade == atv.idAtividade);
                    if (obj != null)
                    {

                        obj.selecionado = true;
                    }
                }
            }

            AtualizarDataGridAtividade(atividadeLista);
        }

        private void pbSelecionarEspecificacaoAtendimento_Click(object sender, EventArgs e)
        {
            FrmSelecionarEspecificacao frmEspecificacao = new FrmSelecionarEspecificacao("");
            frmEspecificacao.ShowDialog();

        }

        #endregion


    }
}




