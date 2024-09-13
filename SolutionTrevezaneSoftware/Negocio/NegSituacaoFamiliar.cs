using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data.SqlClient;
using System.Data;


namespace Negocio
{
    public class NegSituacaoFamiliar
    {
        ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        //Buscando Tipo por descrição
        public SituacaoFamilizarLista BuscarSituacaoPorNome(string descricao)
        {
            try
            {
                DataTable tabelaResultado;
                SituacaoFamiliar Situacao;
                SituacaoFamilizarLista Situacaos = new SituacaoFamilizarLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@descricao", descricao));

                string comando = "exec uspBuscarSituacaoFamiliar @descricao";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    Situacao = new SituacaoFamiliar();

                    Situacao.idSituacaoFamiliar = Convert.ToInt32(registro[0]);
                    Situacao.descricaoSituacaoFamiliar = registro[1].ToString();
                    Situacao.selecionado = false;

                    Situacaos.Add(Situacao);
                }

                return Situacaos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o tipo pela descrição. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscando Tipo por Id
        public SituacaoFamiliar BuscarSituacaoPorCodigo(int codigoABuscar)
        {
            try
            {
                DataTable tabelaResultado;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@codigo", codigoABuscar));

                string comando = "exec uspBuscarSituacaoFamiliarPorId @codigo";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count > 0)
                {
                    SituacaoFamiliar Situacao = new SituacaoFamiliar();
                    DataRow registro = tabelaResultado.Rows[0];

                    Situacao.idSituacaoFamiliar = Convert.ToInt32(registro[0]);
                    Situacao.descricaoSituacaoFamiliar = registro[1].ToString();

                    return Situacao;
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
        public Boolean CadastrarSituacao(SituacaoFamiliar Situacao)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", Situacao.descricaoSituacaoFamiliar));

                string comando = " exec uspCadastrarSituacaoFamiliar " +
                   "@descricao";

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
        public Boolean ExcluirSituacao(SituacaoFamiliar Situacao)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", Situacao.idSituacaoFamiliar));

                string comando = "exec uspExcluirSituacaoFamiliar @id";

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
        public Boolean AtualizarSituacao(SituacaoFamiliar Situacao)
        {
            try
            {
                sqlserver.LimparParametros();

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", Situacao.idSituacaoFamiliar));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", Situacao.descricaoSituacaoFamiliar));

                string comando = "exec uspAlterarSituacaoFamiliar @id, @descricao";

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
