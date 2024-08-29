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
    public partial class FrmAlterarCadastrarExcluirCadastroUnico : FrmModelo
    {
        string modeloFormulario;
        CadastroUnico cadastroUnico;
        private NegCadastroUnico nCadastroUnico = new NegCadastroUnico();

        public FrmAlterarCadastrarExcluirCadastroUnico(string strFormulario, [Optional] CadastroUnico cad)
        {
            InitializeComponent();

            if (strFormulario != string.Empty)
            {
                //construtor
                modeloFormulario = strFormulario;
            }

            if (cad != null)
            {
                //Objeto
                cadastroUnico = cad;
            }
        }


        //Método Designer formulário
        public void metodoConstrutor()
        {
            if (modeloFormulario == "cadastrar")
            {
                this.Text = "Cadastrar Cadastro Único";
                tbId.Visible = false;
                lbCodigo.Visible = false;
                this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
                this.btCadastrar.Text = "F10 Cadastrar";
                btExcluir.Visible = false;

            }
            else
            {
                this.Text = "Alterar e Excluir Cadastro Único";
                this.btCadastrar.BackColor = System.Drawing.Color.DeepSkyBlue;
                this.btCadastrar.Text = "F5 Alterar";
                btExcluir.Visible = true;
                tbId.Visible = true;
                lbCodigo.Visible = true;

                tbId.Text = cadastroUnico.idCadastroUnico.ToString();
                tbDescricao.Text = cadastroUnico.descricaoCadastroUnico;
            }



        }

        //Metodo para validar campos
        public Boolean metodoValidaCampos()
        {

            if (tbDescricao.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe a Descrição!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDescricao.Clear();
                tbDescricao.Focus();

                return false;
            }

            return true;
        }

        //Ativa Erro Provider
        public void metodoEp(TextBox txt)
        {
            if (txt != null)
            {
                //Verifica se o campo for preenchido
                if (txt.Text == String.Empty)
                {
                    errorProvider1.SetError(txt, "Campo obrigatório!");
                    return;
                }
                else
                    errorProvider1.Clear();
            }
        }

        //Limpa Campos
        public void metodoLimpaCampos()
        {
            tbDescricao.Text = string.Empty;
        }

        //--------------------Formulário
        private void FrmAlterarCadastrarExcluirCadastroUnico_Load(object sender, EventArgs e)
        {
            metodoConstrutor();
        }
        private void tbDescricao_Leave(object sender, EventArgs e)
        {
            metodoEp(tbDescricao);
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair ?",
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

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (modeloFormulario == "cadastrar")//Cadastrar
                {
                    CadastroUnico cadCadastro = new CadastroUnico();

                    //tipoAtendimento.idTipo = int.Parse(tbId.Text);
                    cadCadastro.descricaoCadastroUnico = tbDescricao.Text;

                    if (nCadastroUnico.CadastrarCadastroUnico(cadCadastro) == true)
                    {
                        DialogResult resposta;
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                        " Cadastro Realizado com Sucesso! \r\n" +
                        "Deseja Continuar cadastrando?",
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
                            metodoLimpaCampos();
                        tbDescricao.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao realizar o Cadastro !", "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbDescricao.Focus();
                        return;
                    }

                }
                else//Alterar
                {
                    //Validas se os campos estão preenchidos
                    if (metodoValidaCampos() == true)
                    {

                        DialogResult resposta;
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Alteração",
                        " Deseja realmente realizar a alteração dos dados?",
                        Properties.Resources.Alterar,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Confirmar", "Cancelar",
                        false);

                        //Verifica se o usuário realmente quer alterar os dados do cliente.
                        resposta = frmCaixa.ShowDialog();
                        if (resposta == DialogResult.Yes)
                        {
                            CadastroUnico cadAlterado = new CadastroUnico();

                            cadAlterado.idCadastroUnico = int.Parse(tbId.Text);
                            cadAlterado.descricaoCadastroUnico = tbDescricao.Text;

                            //Realizando o Cadastro
                            if (nCadastroUnico.AtualizarCadastroUnico(cadAlterado) == true)
                            {

                                //Criando Caixa de dialogo
                                frmCaixa = new FrmCaixaDialogo("Alteração",
                                "Alteração realizado com sucesso !\r\n" +
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
                            else
                            {
                                MessageBox.Show("Não foi possível atualizar os dados. Erro no banco de Dados!");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar os dados. Motivo: " + ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
           

            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
            " Deseja realmente realizar a exclusão?",
            Properties.Resources.Excluir,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Confirmar", "Cancelar",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                if (nCadastroUnico.ExcluirCadastroUnico(cadastroUnico) == true)
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
                    "Não foi possível realizar a exclusão! \r\n" +
                    "Item está relacionado ao movimento diário!",
                    Properties.Resources.DialogWarning,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    true);
                    frmCaixa.ShowDialog();
                    //Fecha o formulário
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }


        private void FrmAlterarCadastrarExcluirCadastroUnico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btCadastrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                if (btExcluir.Visible == true)
                {
                    btExcluir.PerformClick();
                }
            }
        }
    }
}
