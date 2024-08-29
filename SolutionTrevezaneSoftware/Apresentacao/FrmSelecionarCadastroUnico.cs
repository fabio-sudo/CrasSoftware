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
    public partial class FrmSelecionarCadastroUnico : Form
    {
        NegCadastroUnico nCadastroUnico = new NegCadastroUnico();
        public CadastroUnicoLista cadastroUnicoLista;
        public CadastroUnico cadastroUnico;
        string strDescricao;


        public FrmSelecionarCadastroUnico([Optional] string descricao)
        {
            InitializeComponent();


            if (!string.IsNullOrEmpty(descricao))
            {
                strDescricao = descricao;
            }
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {

            this.dgvSelecionar.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.cadastroUnicoLista.Count > 0)
            {
                this.dgvSelecionar.Rows.Add(this.cadastroUnicoLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (CadastroUnico cad in this.cadastroUnicoLista)
            {
                this.dgvSelecionar[0, indice].Value = cad.idCadastroUnico;
                this.dgvSelecionar[1, indice].Value = cad.descricaoCadastroUnico;

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

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string str;
            str = tbBuscar.Text;

            if (tbBuscar.Text.Equals("Digite a descrição ...") || tbBuscar.Text == string.Empty)
            {
                str = "";
            }

            this.cadastroUnicoLista = nCadastroUnico.BuscarCadastroUnicoPorNome(str);
            AtualizarDataGrid();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            FrmAlterarCadastrarExcluirCadastroUnico formulario = new FrmAlterarCadastrarExcluirCadastroUnico("cadastrar");
            resultado = formulario.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                btBuscar.PerformClick();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSelecionar.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvSelecionar.CurrentRow.Cells[0].Value);
                    foreach (CadastroUnico cad in cadastroUnicoLista)
                    {
                        if (cad.idCadastroUnico == indiceRegistroSelecionado)
                        {

                            cadastroUnico = cad;
                            break;
                        }

                    }

                    FrmAlterarCadastrarExcluirCadastroUnico frmAlterarExcluir = new FrmAlterarCadastrarExcluirCadastroUnico("", cadastroUnico);

                    DialogResult resposta;

                    resposta = frmAlterarExcluir.ShowDialog();

                    if (resposta == DialogResult.Yes)
                    {
                        //atualizar o gride quando o formulario voltar ao foco
                        btBuscar.PerformClick();
                    }
                }
            }
            catch
            {
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao selecionar item data grid!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de Funcionario
                tbBuscar.Focus();
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair?",
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


        //------------------------Formulário
        private void FrmSelecionarCadastroUnico_Load(object sender, EventArgs e)
        {
            if (strDescricao != String.Empty)
            {
                tbBuscar.Text = strDescricao;
                btBuscar.PerformClick();
            }
        }

        private void FrmSelecionarCadastroUnico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
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

        private void dgvSelecionar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btAlterar.PerformClick();
        }


    }
}
