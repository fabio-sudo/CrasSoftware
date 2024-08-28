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

    public partial class FrmSelecionarTipoAtendimento : Form
    {


        NegTipoAtendimento nTipo = new NegTipoAtendimento();
        public TipoLista tipoLista;
        public TipoLista tipoListaSelecionado;
        public TipoAtendimento tipoSelecionado;
        string strDescricao;

        public FrmSelecionarTipoAtendimento([Optional] string descricaoTipo, [Optional] TipoLista Itemselecionado)
        {
            InitializeComponent();

            if(Itemselecionado.Count > 0 )
            {
                tipoListaSelecionado = Itemselecionado;

            }

            if (descricaoTipo != String.Empty)
            {
                strDescricao = descricaoTipo;
            }
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvSelecionar.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.tipoLista.Count > 0)
            {
                this.dgvSelecionar.Rows.Add(this.tipoLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (TipoAtendimento tipo in this.tipoLista)
            {
                this.dgvSelecionar[1, indice].Value = tipo.idTipo;
                this.dgvSelecionar[2, indice].Value = tipo.descricaoTipo;

                indice++;
            }

            dgvSelecionar.Update();

        }

        //-------------------Caixa de Texto
        private void tbBuscar_Leave(object sender, EventArgs e)
        {
            if (tbBuscar.Text == "")
            {
                tbBuscar.Text = "Digite a descrição ...";
                panelBuscar.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscar.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBuscar_Enter(object sender, EventArgs e)
        {
            tbBuscar.Clear();
            panelBuscar.BackColor = Color.DeepPink;
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }


        //-------------------Botões
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Seleção de Tipo de Atendimento?",
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

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string str;
            str = tbBuscar.Text;

            if (tbBuscar.Text.Equals("Digite a descrição ...") || tbBuscar.Text == string.Empty)
            {
                str = "";
            }

            this.tipoLista = nTipo.BuscarTipoPorNome(str);
            AtualizarDataGrid();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //DialogResult resultado;

            //FrmCadastroCliente frmCliente = new FrmCadastroCliente();
            //resultado = frmCliente.ShowDialog();

            //if (resultado == DialogResult.OK)
            //{

            //    btBuscar.PerformClick();
            //}
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        if (dgvCliente.RowCount > 0)
        //        {
        //            int indiceRegistroSelecionado = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
        //            foreach (Cliente clie in clienteLista)
        //            {
        //                if (clie.codigoCliente == indiceRegistroSelecionado)
        //                {

        //                    clienteSelecionado = clie;
        //                    break;
        //                }

        //            }

        //            FrmAlterarExcluirCliente frmAlterarExcluirCliente = new FrmAlterarExcluirCliente(clienteSelecionado);

        //            DialogResult resposta;

        //            resposta = frmAlterarExcluirCliente.ShowDialog();

        //            if (resposta == DialogResult.Yes)
        //            {
        //                //atualizar o gride quando o formulario voltar ao foco
        //                btBuscar.PerformClick();
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        //Criando Caixa de dialogo
        //        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
        //        "Erro ao selecionar o Cliente!",
        //        Properties.Resources.DialogErro,
        //        Color.White,
        //        Color.Black,
        //        "Ok", "",
        //        false);
        //        frmCaixa.ShowDialog();

        //        //Volata o focu para caixa de texto de busca de Funcionario
        //        tbBuscarCliente.Focus();
        //    }

        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            //if (this.dgvCliente.Rows.Count > 0)
            //{
            //    int indiceRegistroSelecionado = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
            //    foreach (Cliente clie in clienteLista)
            //    {
            //        if (clie.codigoCliente == indiceRegistroSelecionado)
            //        {
            //            clienteSelecionado = clie;
            //            this.DialogResult = DialogResult.OK;
            //            this.Close();
            //            break;

            //        }
            //    }

            //}
        }

        //-----------------------------Formulário
        private void FrmSelecionarTipoAtendimento_Load(object sender, EventArgs e)
        {
            if (strDescricao != String.Empty)
            {
                tbBuscar.Text = strDescricao;
                btBuscar.PerformClick();
            }
        }

        private void FrmSelecionarTipoAtendimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btSelecionar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F4) == true)
            {
                btAlterar.PerformClick();
            }
        }

        //---------------------------Data Grid
        private void dgvSelecionar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btSelecionar.PerformClick();
        }
    }
}
