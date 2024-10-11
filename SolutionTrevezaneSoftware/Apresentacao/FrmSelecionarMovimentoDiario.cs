using Negocio;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmSelecionarMovimentoDiario : FrmModelo
    {

        NegMovimentoDiario nMovimento = new NegMovimentoDiario();
        public MovimentoDiarioLista movimentos;
        MovimentoDiario movimentoSelecionado = new MovimentoDiario();

        //Funcionario
        string strFuncionario;
        Funcionario funcionarioLogado;
        Funcionario objFuncionario = new Funcionario();

        //Usuário
        string strUsuario;

        public FrmSelecionarMovimentoDiario()
        {
            InitializeComponent();
        }

        //Método obter inicio e fim do mes 
        private void ObterUltimoDiaDoMes()
        {
            // Obtém o ano e mês da data atual
            int ano = DateTime.Now.Year;
            int mes = DateTime.Now.Month;

            // Obtém o número de dias do mês
            int ultimoDiaDoMes = DateTime.DaysInMonth(ano, mes);


            // Cria uma nova data com o último dia do mês
            DateTime ultimoDia = new DateTime(ano, mes, ultimoDiaDoMes);

            // Atribui a data ao seu controle
            dtpDataFinal.Value = ultimoDia;



            // Cria uma nova data com o primeiro dia do mês
            DateTime primeiroDiaDoMes = new DateTime(ano, mes, 1);

            // Atribui a data ao seu controle (ajuste de acordo com seu projeto)
            dtpDataInicial.Value = primeiroDiaDoMes;



            //----------------------Alinha Grid
            // Após a configuração do seu DataGridView
            dgvSelecionar.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSelecionar.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSelecionar.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSelecionar.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSelecionar.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSelecionar.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;//Alinha cabeçário
            dgvSelecionar.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        // Método para formatar o CPF
        private string FormatarCPF(string cpf)
        {
            if (cpf.Length == 11)
            {
                return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";
            }

            return cpf;
        }

        private bool IsValidCPF(string cpf)
        {
            // Remove caracteres especiais
            cpf = cpf.Replace(".", "").Replace("-", "");

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11 || !ulong.TryParse(cpf, out _))
                return false;

            // Validação dos dígitos verificadores
            int[] pesos1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] pesos2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            // Cálculo do primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * pesos1[i];

            int digito1 = (soma * 10) % 11;
            if (digito1 == 10) digito1 = 0;

            // Cálculo do segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * pesos2[i];

            int digito2 = (soma * 10) % 11;
            if (digito2 == 10) digito2 = 0;

            return cpf[9] == digito1.ToString()[0] && cpf[10] == digito2.ToString()[0];
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {

            this.dgvSelecionar.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.movimentos.Count > 0)
            {
                this.dgvSelecionar.Rows.Add(this.movimentos.Count);
            }
            else
            {
                return;
            }

            int indice = 0;

            foreach (MovimentoDiario mov in this.movimentos)
            {
                this.dgvSelecionar[0, indice].Value = mov.IdMovimentoDiario;
                this.dgvSelecionar[1, indice].Value = mov.Data;
                this.dgvSelecionar[2, indice].Value = mov.Prontuario;
                this.dgvSelecionar[3, indice].Value = mov.Nome;
                this.dgvSelecionar[4, indice].Value = mov.QuantidadeCriancas;
                this.dgvSelecionar[5, indice].Value = mov.QuantidadeAdolescentes;
                this.dgvSelecionar[6, indice].Value = mov.QuantidadeIdosos;
                this.dgvSelecionar[7, indice].Value = mov.VisitaDomiciliar == true ? "Sim" : "Não";
                this.dgvSelecionar[8, indice].Value = mov.Encaminhamento == true ? "Sim" : "Não"; ;
                this.dgvSelecionar[9, indice].Value = mov.BeneficioConcedido == true ? "Sim" : "Não"; ;
                this.dgvSelecionar[10, indice].Value = mov.InscritoPaif == true ? "Sim" : "Não"; ;
                this.dgvSelecionar[11, indice].Value = mov.AcompanhamentoIndividual == true ? "Sim" : "Não"; ;
                this.dgvSelecionar[12, indice].Value = mov.Observacoes;

                indice++;
            }

            dgvSelecionar.Update();

        }

        private void metodoConstrutor()
        {
            try
            {
                funcionarioLogado = FrmMenuPrincipal.userLogado;
                if (funcionarioLogado.nomeFuncionario == "Josi" || funcionarioLogado.nomeFuncionario == "JOSI")
                { return; }
                else
                {
                    objFuncionario = funcionarioLogado;
                    tbFuncionario.Text = objFuncionario.nomeFuncionario;
                    tbFuncionario.Enabled = false;
                    pbFuncionario.Enabled = false;
                    tbBuscar.Focus();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //---------------------Inicialização do Formulário
        private void FrmSelecionarMovimentoDiario_Load(object sender, EventArgs e)
        {
            //Buscar inicio e fim do mes
            ObterUltimoDiaDoMes();
        }

        //----------------------Caixa de Texto Funcionário
        private void tbFuncionario_Leave(object sender, EventArgs e)
        {
            if (tbFuncionario.Text == "")
            {
                tbFuncionario.Text = "Digite o nome do funcionário ...";
                pbFuncionario.Image = Properties.Resources.FuncionarioAzul;
                panelBuscarFuncionario.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbFuncionario.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscarFuncionario.PerformClick();
                e.Handled = true;
            }
        }

        private void tbFuncionario_Enter(object sender, EventArgs e)
        {
            tbFuncionario.Clear();
            pbFuncionario.Image = Properties.Resources.FuncionarioRosa;
            panelBuscarFuncionario.BackColor = Color.DeepPink;
            if (strFuncionario != String.Empty)
            {
                tbFuncionario.Text = strFuncionario;

            }
        }

        private void btBuscarFuncionario_Click(object sender, EventArgs e)
        {
            strFuncionario = tbFuncionario.Text;


            if (tbFuncionario.Text.Equals("Digite o nome do funcionário ...") || tbFuncionario.Text == string.Empty)
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

                    tbFuncionario.Text = funcionarioLogado.nomeFuncionario;
                }
            }
        }

        //----------------------Buscar Usuário

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcionarioLogado != null)
                {
                    if (IsValidCPF(tbBuscar.Text) == true)
                    {


                        movimentos = nMovimento.BuscarMovimentoDiarioPorDataECPF(dtpDataInicial.Value, dtpDataFinal.Value, tbBuscar.Text.Replace(".", "").Replace("-", ""), funcionarioLogado.codigoFuncionario);
                        AtualizarDataGrid();
                        if (movimentos.Count == 0)
                        {
                            {
                                MessageBox.Show("CPF não está vinculado ao usuários atendidos!", "Buscar Por CPF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                        }

                    }
                    else
                    {

                        if (tbBuscar.Text == "Digite o nome do Usuário ou CPF ..." || tbBuscar.Text == String.Empty)
                        {
                            strUsuario = "";

                        }
                        else { strUsuario = tbBuscar.Text; }
                        movimentos = nMovimento.BuscarMovimentoDiarioPorDataUsuario(dtpDataInicial.Value, dtpDataFinal.Value, strUsuario, funcionarioLogado.codigoFuncionario);
                        AtualizarDataGrid();
                    }
                }
                else { MessageBox.Show("Selecione o Funcionário!", "Aviso Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            }

            catch (Exception ex) { MessageBox.Show("Erro ao buscar movimento diaário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tbBuscar_Leave(object sender, EventArgs e)
        {
            if (tbBuscar.Text == "")
            {
                tbBuscar.Text = "Digite o nome do Usuário ou CPF ...";
                panelBuscar.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscar.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBuscar_Enter(object sender, EventArgs e)
        {
            tbBuscar.Clear();
            panelBuscar.BackColor = Color.DeepPink;

            if (strUsuario != String.Empty)
            {
                tbBuscar.Text = strUsuario;

            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            // Remove qualquer formatação anterior
            string texto = tbBuscar.Text.Replace(".", "").Replace("-", "").Replace(" ", "");

            // Se o texto contém apenas números e não está vazio
            if (texto.All(char.IsDigit) && !string.IsNullOrEmpty(texto))
            {
                // Aplica a máscara de CPF
                tbBuscar.Text = FormatarCPF(texto);
            }
        }

        //---------------------Buscar Por Periodo
        private void pbFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcionarioLogado != null)
                {
                    if (tbBuscar.Text == "Digite o nome do Usuário ou CPF ..." || tbBuscar.Text == String.Empty)
                    {
                        strUsuario = "";

                    }
                    movimentos = nMovimento.BuscarMovimentoDiarioPorDataFuncionario(dtpDataInicial.Value, dtpDataFinal.Value, strUsuario, funcionarioLogado.codigoFuncionario);
                    AtualizarDataGrid();
                }
                else { MessageBox.Show("Selecione o Funcionário!", "Aviso Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            }

            catch (Exception ex) { MessageBox.Show("Erro ao buscar movimento diaário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //---------------------Botões
        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (this.dgvSelecionar.Rows.Count > 0)
            {
                int indiceRegistroSelecionado = Convert.ToInt32(dgvSelecionar.CurrentRow.Cells[0].Value);
                foreach (MovimentoDiario mov in movimentos)
                {
                    if (mov.IdMovimentoDiario == indiceRegistroSelecionado)
                    {
                        movimentoSelecionado = mov;
                        nMovimento.PreencherListasMovimentoDiario(movimentoSelecionado);
                        break;
                    }
                }

                //Envia o movimendo diario para atualização ou exclusão
                FrmMovimentoDiario frmMovimento = new FrmMovimentoDiario(funcionarioLogado, movimentoSelecionado);
                DialogResult result =
                frmMovimento.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Atualiza os dados no data grid
                    btBuscar.PerformClick();
                }
            }
        }

        private void dgvSelecionar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btAlterar.PerformClick();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FrmMovimentoDiario frmMovimentoDiario = new FrmMovimentoDiario(funcionarioLogado, null);
            frmMovimentoDiario.ShowDialog();
        }

        //---------------------------------------------------------Final Form
    }
}
