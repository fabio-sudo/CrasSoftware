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
    public partial class FrmCadastroAgenda : Form
    {
        Funcionario funcionarioLogado;

        Funcionario objFuncionario = new Funcionario();
        NegFuncionario nFuncionario = new NegFuncionario();

        Cliente objCliente = new Cliente();
        NegCliente nCliente = new NegCliente();

        Agenda objAgenda = new Agenda();
        NegAgenda nAgenda = new NegAgenda();
        AgendaLista agendaLista = new AgendaLista();

        DateTime dataIniciaDate;
        DateTime dataFinalDate;

        public FrmCadastroAgenda()
        {
            InitializeComponent();
        }

        private void tgAtendido_Click(object sender, EventArgs e)
        {

        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvAgenda.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.agendaLista.Count > 0)
            {
                this.dgvAgenda.Rows.Add(this.agendaLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Agenda agenda in this.agendaLista)
            {
                this.dgvAgenda[0, indice].Value = agenda.codigoAgenda;
                this.dgvAgenda[1, indice].Value = agenda.dataAgenda;
                this.dgvAgenda[2, indice].Value = agenda.inicioAgenda;
                this.dgvAgenda[3, indice].Value = agenda.finalAgenda;
                this.dgvAgenda[4, indice].Value = agenda.funcionario.nomeFuncionario;
                this.dgvAgenda[5, indice].Value = agenda.funcionario.sobrenomeFuncionario;
                this.dgvAgenda[6, indice].Value = agenda.cliente.nomeCliente;
                this.dgvAgenda[7, indice].Value = agenda.cliente.sobrenomeCliente;

                indice++;
            }

            dgvAgenda.Update();

        }

        //Metodo para validar campos
        public Boolean ValidaCadastroAgenda()
        {

            string dataInicialString = dtpInicial.Value.ToString("HH:mm");
            string dataFinalString = dtpFinal.Value.ToString("HH:mm");

            dataIniciaDate = Convert.ToDateTime(dataInicialString);
            dataFinalDate = Convert.ToDateTime(dataFinalString);


            if (dataIniciaDate >= dataFinalDate)
            {
                MessageBox.Show("Verifique as datas, Data inicial maior que Data final do atendimento!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpInicial.Focus();

                return false;
            }
            else if (tbFuncionario.Text.Trim() == String.Empty || tbFuncionario.Text == "Digite o nome do funcionário ...")
            {
                MessageBox.Show("Informe o Funcionário!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFuncionario.Clear();
                tbFuncionario.Focus();

                return false;
            }
            else if (tbBuscarCliente.Text.Trim() == String.Empty || tbBuscarCliente.Text == "Digite o nome do cliente ...")
            {
                MessageBox.Show("Informe o Cliente!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbBuscarCliente.Clear();
                tbBuscarCliente.Focus();

                return false;
            }

            else
                return true;

        }

        //Metodo para limpar os campos
        public void LimpaCampos()
        {
            tbFuncionario.Text = "Digite o nome do funcionário ...";
            tbBuscarCliente.Text = "Digite o nome do cliente ...";
            tbSobrenome.Clear();
            mtbCelular.Clear();
            objCliente = new Cliente();

            objFuncionario = null;

            dtpInicial.Value = DateTime.Now;
            dtpFinal.Value = DateTime.Now;

            tbBuscarFuncionario.Text = "Digite o nome do funcionário ...";
            dgvAgenda.Rows.Clear();

            cbAgendadoBusca.Checked = true;
            cbAtendidoBusca.Checked = false;

            funcionarioLogado = FrmMenuPrincipal.userLogado;
            if (funcionarioLogado.nomeFuncionario == "Josi" || funcionarioLogado.nomeFuncionario == "JOSI")
            { return;}else{
                objFuncionario = funcionarioLogado;
                tbFuncionario.Text = objFuncionario.nomeFuncionario;
                tbBuscarFuncionario.Text = objFuncionario.nomeFuncionario;
                btBuscarAgenda.PerformClick();
            
            }
        }

        //Valida o preenchimento da agenda
        private Boolean metodoValidaAgenda(Agenda agendaValida)
        {

            AgendaLista agendaListaValida = new AgendaLista();
            agendaListaValida = nAgenda.ValidaAgenda(agendaValida);

            foreach (Agenda agenda in agendaListaValida)
            {

                DateTime dataValida = dataIniciaDate;
                DateTime dataValidaFinal = dataFinalDate;

                TimeSpan time = agenda.finalAgenda - agenda.inicioAgenda;
                int minutos = Convert.ToInt32(time.TotalMinutes);
                int contador = 0;

                while (contador <= minutos)
                {
                    if (dataValida.TimeOfDay == agenda.inicioAgenda.TimeOfDay
                        || dataValida.TimeOfDay == agenda.finalAgenda.TimeOfDay
                        || dataValidaFinal.TimeOfDay == agenda.inicioAgenda.TimeOfDay
                        || dataValidaFinal.TimeOfDay == agenda.finalAgenda.TimeOfDay)
                    {
                        DialogResult resposta;
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                        " Cliente:" + agenda.cliente.nomeCliente + " " + agenda.cliente.sobrenomeCliente + "\r\n" +
                        " Agendado Dia: " + agenda.dataAgenda.Day + "\r\n" +
                        " Horário: " + agenda.inicioAgenda.TimeOfDay + " ás " + agenda.finalAgenda.TimeOfDay,
                        Properties.Resources.DialogErro,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "OK", "",
                        true);

                        resposta = frmCaixa.ShowDialog();

                        return false;
                    }
                    else
                    {

                        dataValida = dataValida.AddMinutes(1);
                        dataFinalDate = dataFinalDate.AddMinutes(-1);
                    }
                    contador++;
                }

            }

            return true;
        }

        //--------------------Estatus
        private void tgAtendido_Click_1(object sender, EventArgs e)
        {
            if (lbEstatus.Text == "ATENDIDO")
            {
                lbEstatus.Text = "AGENDADO";
            }
            else { lbEstatus.Text = "ATENDIDO"; }
        }

        //-------------------Caixa de Texto
        private void tbBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (tbBuscarCliente.Text == "")
            {
                tbBuscarCliente.Text = "Digite o nome do cliente ...";
                pbUsuario.Image = Properties.Resources.ClienteAzul;
                panelBuscarCliente.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarCliente.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }

        }

        private void tbBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btCliente.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBuscarCliente_Enter(object sender, EventArgs e)
        {
            tbBuscarCliente.Clear();
            pbUsuario.Image = Properties.Resources.ClienteRosa;
            panelBuscarCliente.BackColor = Color.DeepPink;
        }

        private void tbFuncionario_Leave(object sender, EventArgs e)
        {
            if (tbFuncionario.Text == "")
            {
                tbFuncionario.Text = "Digite o nome do funcionário ...";
                pbFuncionario.Image = Properties.Resources.FuncionarioAzul;
                panelFuncionario.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbFuncionario.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btFuncionario.PerformClick();
                e.Handled = true;
            }
        }

        private void tbFuncionario_Enter(object sender, EventArgs e)
        {
            tbFuncionario.Clear();
            pbFuncionario.Image = Properties.Resources.FuncionarioRosa;
            panelFuncionario.BackColor = Color.DeepPink;
        }

        //---------------------Formulário
        private void FrmCadastroAgenda_Load(object sender, EventArgs e)
        {
            funcionarioLogado = FrmMenuPrincipal.userLogado;
            if (funcionarioLogado.nomeFuncionario == "Josi" || funcionarioLogado.nomeFuncionario == "JOSI")
            { return; }
            else
            {
                objFuncionario = funcionarioLogado;
                tbFuncionario.Text = objFuncionario.nomeFuncionario;
                tbBuscarFuncionario.Text = objFuncionario.nomeFuncionario;
                btBuscarAgenda.PerformClick();

            }
        }

        //-------------------Botões
        private void btFuncionario_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbFuncionario.Text, out n);
            if (ehUmNumero == true)
            {
                objFuncionario = nFuncionario.BuscarFuncionarioPorCodigo(n);
                if (objFuncionario != null)
                {
                    this.tbFuncionario.Text = objFuncionario.nomeFuncionario;
                    tbBuscarFuncionario.Text = objFuncionario.telefoneFuncionario;
                    btBuscarAgenda.PerformClick();
                }
                else
                    tbFuncionario.Clear();
            }
            else
            {
                FrmSelecionarFuncionario frmSelecionarFuncionario = new FrmSelecionarFuncionario(tbFuncionario.Text);
                DialogResult resultado = frmSelecionarFuncionario.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    this.objFuncionario = frmSelecionarFuncionario.FuncionarioSelecionado;
                    this.tbFuncionario.Text = objFuncionario.nomeFuncionario;
                    tbBuscarFuncionario.Text = objFuncionario.telefoneFuncionario;
                    btBuscarAgenda.PerformClick();
                }

            }
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbBuscarCliente.Text, out n);
            if (ehUmNumero == true)
            {
                objCliente = nCliente.BuscarClientePorCodigo(n);
                if (objCliente != null)
                {
                    this.tbBuscarCliente.Text = objCliente.nomeCliente;
                    this.tbBuscarCliente.Text = objCliente.nomeCliente;
                    this.tbSobrenome.Text = objCliente.sobrenomeCliente;
                    this.mtbCelular.Text = objCliente.celularCliente;

                    tbSituacao.Focus();
                }
                else
                    tbBuscarCliente.Clear();
            }
            else
            {
                FrmSelecionarCliente frmSelecionarCliente = new FrmSelecionarCliente(tbBuscarCliente.Text);
                DialogResult resultado = frmSelecionarCliente.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    this.objCliente = frmSelecionarCliente.clienteSelecionado;
                    this.tbBuscarCliente.Text = objCliente.nomeCliente;
                    this.tbSobrenome.Text = objCliente.sobrenomeCliente;
                    this.mtbCelular.Text = objCliente.celularCliente;

                    tbSituacao.Focus();
                }

            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidaCadastroAgenda() == true)
            {
                try
                {

                    Agenda agendaCad = new Agenda();
                    agendaCad.cliente = new Cliente();
                    agendaCad.funcionario = new Funcionario();

                    agendaCad.funcionario = objFuncionario;
                    agendaCad.dataAgenda = this.dtpDiaSemana.Value;
                    agendaCad.inicioAgenda = dataIniciaDate;
                    agendaCad.finalAgenda = dataFinalDate;

                    agendaCad.estatusAgenda = lbEstatus.Text;
                    agendaCad.situacaoAgenda = tbSituacao.Text;

                    if (objCliente.nomeCliente == null)
                    {
                        agendaCad.cliente.nomeCliente = tbBuscarCliente.Text;
                        agendaCad.cliente.sobrenomeCliente = tbSobrenome.Text;
                        agendaCad.cliente.celularCliente = mtbCelular.Text;
                    }
                    else
                    {

                        agendaCad.cliente = objCliente;
                    }


                    if (metodoValidaAgenda(agendaCad) == true)
                    {

                        if (nAgenda.CadastrarAgenda(agendaCad) == true)
                        {
                            DialogResult resposta;
                            //Criando Caixa de dialogo
                            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                            " Cadastro Realizado com Sucesso! \r\n" +
                            "Deseja Continuar No Cadastro De Usuário?",
                            Properties.Resources.DialogOK,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Sim", "Não",
                            false);

                            resposta = frmCaixa.ShowDialog();
                            if (resposta != DialogResult.Yes)
                            {
                                this.DialogResult = DialogResult.OK;
                                this.Close();

                            }
                            else
                                LimpaCampos();
                            btBuscarAgenda.PerformClick();
                            dtpDiaSemana.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Erro ao realizar o Cadastro !", "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dtpDiaSemana.Focus();
                            return;
                        }
                    }//Validação



                }

                catch (Exception ex)
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                    "Erro ao cadastrar Movimento Agenda \r\n" + ex.Message,
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);

                    frmCaixa.ShowDialog();
                }
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Cadastro da Agenda ?",
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

        //----------------Buscar Agendamento por Funcionário
        private void tbBuscarFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscarAgenda.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBuscarFuncionario_Leave(object sender, EventArgs e)
        {
            if (tbBuscarFuncionario.Text == "")
            {
                tbBuscarFuncionario.Text = "Digite o nome do funcionário ...";
                pbAgendaFuncionario.Image = Properties.Resources.FuncionarioAzul;
                panelBuscarFuncionario.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarFuncionario.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBuscarFuncionario_Enter(object sender, EventArgs e)
        {
            tbBuscarFuncionario.Clear();
            pbAgendaFuncionario.Image = Properties.Resources.FuncionarioRosa;
            panelBuscarFuncionario.BackColor = Color.DeepPink;
        }

        private void btBuscarAgenda_Click(object sender, EventArgs e)
        {
            string funcionario;
            string status;
            funcionario = tbBuscarFuncionario.Text;


            if (tbBuscarFuncionario.Text.Equals("Digite o nome do funcionário ...") || tbBuscarFuncionario.Text == string.Empty)
            {
                funcionario = "";
            }

            if (cbAgendadoBusca.Checked == true && cbAtendidoBusca.Checked == true) { status = ""; }
            else if (cbAgendadoBusca.Checked == true && cbAtendidoBusca.Checked == false) { status = cbAgendadoBusca.Text; }
            else if (cbAgendadoBusca.Checked == false && cbAtendidoBusca.Checked == true) { status = cbAtendidoBusca.Text; }
            else { status = ""; }


            agendaLista = nAgenda.BuscarAgendaPorNome(funcionario, status, dtpDiaSemana.Value);

            AtualizarDataGrid();
        }

        //----------------Preenchimento de Horas
        private void dtpInicial_ValueChanged(object sender, EventArgs e)
        {
            dtpFinal.Value = dtpInicial.Value.AddMinutes(39);
        }

        private void FrmCadastroAgenda_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {

                btSair.PerformClick();

            }
            //F5 defazer
            else if (e.KeyCode.Equals(Keys.F5) == true)
            {

                btBuscarAgenda.PerformClick();

            }
            //F10 Alterar
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {

                btCadastrar.PerformClick();

            }
        }




    
    }
}
