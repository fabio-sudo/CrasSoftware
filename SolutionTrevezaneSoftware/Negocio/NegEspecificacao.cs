using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data.SqlClient;
using System.Data;


namespace Negocio
{
    public class NegEspecificacao
    {
        ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        //Buscando Tipo por descrição
        public EspecificacaoLista BuscarEspecificacaoPorNome(string descricao)
        {
            try
            {
                DataTable tabelaResultado;
                Especificacao especificacao;
                EspecificacaoLista especificacoes = new EspecificacaoLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@descricao", descricao));

                string comando = "exec uspBuscarEspecificacao @descricao";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    especificacao = new Especificacao();

                    especificacao.idEspecificacao = Convert.ToInt32(registro[0]);
                    especificacao.descricaoEspecificacao = registro[1].ToString();
                    especificacao.encaminhamentoEspecificacao = registro[2].ToString();
                    especificacao.quantidade = 1;
                    especificacao.selecionado = false;

                    especificacoes.Add(especificacao);
                }

                return especificacoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o tipo pela descrição. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscando Tipo por Id
        public Especificacao BuscarEspecificacaoPorCodigo(int codigoABuscar)
        {
            try
            {
                DataTable tabelaResultado;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@codigo", codigoABuscar));

                string comando = "exec uspBuscarEspecificacaoPorId @codigo";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count > 0)
                {
                    Especificacao especificacao = new Especificacao();
                    DataRow registro = tabelaResultado.Rows[0];

                    especificacao.idEspecificacao = Convert.ToInt32(registro[0]);
                    especificacao.descricaoEspecificacao = registro[1].ToString();
                    especificacao.encaminhamentoEspecificacao = registro[2].ToString();

                    return especificacao;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o tipo  pela descrição. [Negócios]. Motivo: " + ex.Message);
            }
        }


        //Cadastro de Tipo de Atendimento
        public Boolean CadastrarEspecificacao(Especificacao especificacao)
        {
            try
            {

                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", especificacao.descricaoEspecificacao));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@encaminhamento", especificacao.encaminhamentoEspecificacao));

                // Formata o comando SQL corretamente
                string comando = "exec uspCadastrarEspecificacao @descricao, @encaminhamento";


                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;
                }
                else
                    return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios - Cadastro. " + ex.Message);

            }
        }

        //Exclusao de Tipo de Atendimento 
        public Boolean ExcluirEspecificacao(Especificacao especificacao)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", especificacao.idEspecificacao));

                string comando = "exec uspExcluirEspecificacao @id";

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Vinculado a movimetno diario
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir os dados do Tipo. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Alteração Tipo Atendimento
        public Boolean AtualizarEspecificacaoAtendimento(Especificacao especificacao)
        {
            try
            {
                sqlserver.LimparParametros();

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", especificacao.idEspecificacao));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", especificacao.descricaoEspecificacao));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@encaminhamento", especificacao.encaminhamentoEspecificacao));

                string comando = "exec uspAlterarEspecificacao @id, @descricao, @encaminhamento";

                sqlserver.ExecutarScalar(comando, CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível atualizar os dados do Tipo. Motivo: " + ex.Message);
            }
        }
    }
}
