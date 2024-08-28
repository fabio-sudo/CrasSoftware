using Apresentacao.Relatorios;
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
    public partial class FrmAgenda : Form
    {

        Agenda agendaSelecionado = new Agenda();
        NegAgenda nAgenda = new NegAgenda();
        AgendaLista agendaLista = new AgendaLista();

        string funcionario = "";
        string status = "";


        public FrmAgenda()
        {
            InitializeComponent();
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
                this.dgvAgenda[8, indice].Value = agenda.cliente.celularCliente;
                this.dgvAgenda[9, indice].Value = agenda.situacaoAgenda;
                this.dgvAgenda[10, indice].Value = agenda.estatusAgenda;

                indice++;
            }

            dgvAgenda.Update();

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

        private void tbBuscarFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscarAgenda.PerformClick();
                e.Handled = true;
            }
        }

        //-------------------Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastroAgenda frmAgenda = new FrmCadastroAgenda();
            frmAgenda.ShowDialog();
            btBuscarAgenda.PerformClick();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAgenda.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvAgenda.CurrentRow.Cells[0].Value);
                    foreach (Agenda agenda in agendaLista)
                    {
                        if (agenda.codigoAgenda == indiceRegistroSelecionado)
                        {

                            agendaSelecionado = agenda;
                            break;

                        }


                    }

                    FrmAlterarExcluirAgenda frmAlterarExcluirAgenda = new FrmAlterarExcluirAgenda(agendaSelecionado);

                    DialogResult resposta;

                    resposta = frmAlterarExcluirAgenda.ShowDialog();

                    if (resposta == DialogResult.Yes)
                    {
                        //atualizar o gride quando o formulario voltar ao foco
                        btBuscarAgenda.PerformClick();
                    }
                }
            }
            catch
            {
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao selecionar a Agenda!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de cliente
                tbBuscarFuncionario.Focus();
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            ViewRelatorioAgenda relAgenda = new ViewRelatorioAgenda(funcionario, status, dtpDataInicial.Value, dtpDataFinal.Value);
            relAgenda.ShowDialog();
        }

        private void btBuscarAgenda_Click(object sender, EventArgs e)
        {
            funcionario = tbBuscarFuncionario.Text;


            if (tbBuscarFuncionario.Text.Equals("Digite o nome do funcionário ...") || tbBuscarFuncionario.Text == string.Empty)
            {
                funcionario = "";
            }

            if (cbAgendadoBusca.Checked == true && cbAtendidoBusca.Checked == true)
            { status = ""; }
            else if (cbAgendadoBusca.Checked == true && cbAtendidoBusca.Checked == false)
            { status = cbAgendadoBusca.Text; }
            else if (cbAgendadoBusca.Checked == false && cbAtendidoBusca.Checked == true)
            { status = cbAtendidoBusca.Text; }
            else if (cbFalta.Checked == true) { status = cbFalta.Text; }
            else { status = ""; }


            agendaLista = nAgenda.BuscarAgendaPorData(funcionario, status, dtpDataInicial.Value, dtpDataFinal.Value);

            AtualizarDataGrid();
        }

        //--------------------Caixa de seleção
        private void cbFalta_CheckedChanged(object sender, EventArgs e)
        {
            cbAgendadoBusca.Checked = false;
            cbAtendidoBusca.Checked = false;
        }

        private void cbAgendadoBusca_CheckedChanged(object sender, EventArgs e)
        {
            cbFalta.Checked = false;
        }

        private void cbAtendidoBusca_CheckedChanged(object sender, EventArgs e)
        {
            cbFalta.Checked = false;
        }

        //-------------------Data Gride
        private void dgvAgenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmAgenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscarAgenda.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btSelecionar.PerformClick();
            }
            //ESC é no menu principal
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {

        }



    }
}
