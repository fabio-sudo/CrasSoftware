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
    public partial class FrmAlterarExcluirAgenda : Form
    {
        Funcionario objFuncionario = new Funcionario();
        NegFuncionario nFuncionario = new NegFuncionario();

        Cliente objCliente = new Cliente();
        NegCliente nCliente = new NegCliente();

        Agenda objAgenda = new Agenda();
        NegAgenda nAgenda = new NegAgenda();
        AgendaLista agendaLista = new AgendaLista();

        DateTime dataIniciaDate;
        DateTime dataFinalDate;


        public FrmAlterarExcluirAgenda(Agenda agendaSelecionada)
        {
            InitializeComponent();

            this.objAgenda = agendaSelecionada;
        }

        //----------Metodos
        private void metodoIniciaFormulario()
        {

            if (objAgenda.estatusAgenda == "AGENDADO")
            {

                tgAtendido.Checked = false;
                lbEstatus.Text = "AGENDADO";
            }
            else if (objAgenda.estatusAgenda == "ATENDIDO")
            {

                tgAtendido.Checked = true;
                lbEstatus.Text = "ATENDIDO";

            }
            else
            {
                tgAtendido.Checked = false;
                lbEstatus.Text = "AGENDADO";
                cbFaltou.Checked = true;
            }


            dtpDiaSemana.Value = objAgenda.dataAgenda;
            dtpInicial.Value = objAgenda.inicioAgenda;
            dtpFinal.Value = objAgenda.finalAgenda;

            tbFuncionario.Text = objAgenda.funcionario.nomeFuncionario;
            tbBuscarCliente.Text = objAgenda.cliente.nomeCliente;
            tbSobrenome.Text = objAgenda.cliente.sobrenomeCliente;
            mtbCelular.Text = objAgenda.cliente.celularCliente;
            tbSituacao.Text = objAgenda.situacaoAgenda;

            objFuncionario = objAgenda.funcionario;
            objCliente = objAgenda.cliente;

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

                        if (agenda.codigoAgenda == objAgenda.codigoAgenda) { return true; }//Caso o horário for o mesmo doque esta agnedados

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

        //----------Formulário
        private void FrmAlterarExcluirAgenda_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
        }

        private void FrmAlterarExcluirAgenda_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {

                btSair.PerformClick();

            }
            //F5 defazer
            else if (e.KeyCode.Equals(Keys.F2) == true)
            {

                btExcluir.PerformClick();

            }
            //F10 Alterar
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {

                btAlterar.PerformClick();

            }
        }

        //---------Ciaxa de Seleção
        private void tgAtendido_Click(object sender, EventArgs e)
        {
            if (lbEstatus.Text == "AGENDADO")
            {
                lbEstatus.Text = "ATENDIDO";
                cbFaltou.Checked = false;
            }
            else { lbEstatus.Text = "AGENDADO"; }
        }

        private void cbFaltou_CheckedChanged(object sender, EventArgs e)
        {
            tgAtendido.Checked = false;
            lbEstatus.Text = "AGENDADO";
        }

        //----------Caixa de Texto
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

        //----------------Botões
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
                    tbBuscarCliente.Focus();
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
                    tbBuscarCliente.Focus();
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

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidaCadastroAgenda() == true)
                {

                    DialogResult resposta;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Alteração",
                    " Deseja realmente Alterar os dados da Agenda ?",
                    Properties.Resources.Alterar,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Confirmar", "Cancelar",
                    false);

                    //Verifica se o usuário realmente quer alterar os dados do cliente.
                    resposta = frmCaixa.ShowDialog();
                    if (resposta == DialogResult.Yes)
                    {
                        Agenda agendaAlterada = new Agenda();
                        agendaAlterada.cliente = new Cliente();
                        agendaAlterada.funcionario = new Funcionario();

                        agendaAlterada.codigoAgenda = objAgenda.codigoAgenda;
                        agendaAlterada.funcionario = objFuncionario;
                        agendaAlterada.dataAgenda = this.dtpDiaSemana.Value;
                        agendaAlterada.inicioAgenda = dataIniciaDate;
                        agendaAlterada.finalAgenda = dataFinalDate;
                        agendaAlterada.situacaoAgenda = tbSituacao.Text;

                        if (cbFaltou.Checked == false)
                        {
                            agendaAlterada.estatusAgenda = lbEstatus.Text;
                        }
                        else { agendaAlterada.estatusAgenda = cbFaltou.Text; }


                        if (objCliente.nomeCliente == null)
                        {
                            agendaAlterada.cliente.nomeCliente = tbBuscarCliente.Text;
                            agendaAlterada.cliente.sobrenomeCliente = tbSobrenome.Text;
                            agendaAlterada.cliente.celularCliente = mtbCelular.Text;
                        }
                        else
                        {

                            agendaAlterada.cliente = objCliente;
                        }

                        if (metodoValidaAgenda(agendaAlterada) == true)
                        {
                            //Realizando o Cadastro
                            if (nAgenda.AtualizarAgenda(agendaAlterada) == true)
                            {

                                //Criando Caixa de dialogo
                                frmCaixa = new FrmCaixaDialogo("Alteração",
                                "Cliente Alterado com sucesso !\r\n" +
                                "Alterações Finalizadas ?",
                                Properties.Resources.DialogOK,
                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                Color.White,
                                "Sim", "Não",
                                false);
                                resposta = frmCaixa.ShowDialog();

                                if (resposta == DialogResult.Yes)
                                {
                                    //Retornando que exclusão foi realizada com sucesso
                                    this.DialogResult = DialogResult.Yes;
                                    this.Close();
                                }
                                else
                                    return;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar os dados do Cliente. Motivo: " + ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
            " Deseja realmente Excluir o Agenda ?",
            Properties.Resources.Excluir,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Confirmar", "Cancelar",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                if (nAgenda.ExcluirAgenda(objAgenda) == true)
                {
                    //Criando Caixa de dialogo
                    frmCaixa = new FrmCaixaDialogo("Exclusão",
                    " Exclusão realizada com sucesso !",
                    Properties.Resources.DialogOK,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                   "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                    //Retornando que exclusão foi realizada com sucesso
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {

                    //Criando Caixa de dialogo
                    frmCaixa = new FrmCaixaDialogo("Exclusão",
                    "Não foi possível realizar a exclusão da Agenda ! \r\n" +
                    "Agenda está vinculado a Funcionário!",
                    Properties.Resources.DialogWarning,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                    //Fecha o formulário
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Cadastro de Cliente ?",
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

    }
}
