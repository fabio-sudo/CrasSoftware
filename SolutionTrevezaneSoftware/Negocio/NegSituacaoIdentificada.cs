using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegSituacaoIdentificada
    { 

     ConexaoSqlServer sqlserver = new ConexaoSqlServer();

    //Buscando Tipo por descrição
    public SituacaoIdentificadaLista BuscarSituacaoPorNome(string descricao)
    {
        try
        {
            DataTable tabelaResultado;
            SituacaoIdentificada Situacao;
                SituacaoIdentificadaLista Situacaos = new SituacaoIdentificadaLista();

            this.sqlserver.LimparParametros();
            this.sqlserver.AdicionarParametro(new SqlParameter("@descricao", descricao));

            string comando = "exec uspBuscarSituacaoIdentificada @descricao";

            tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

            foreach (DataRow registro in tabelaResultado.Rows)
            {
                    Situacao = new SituacaoIdentificada();

                Situacao.idSituacaoIdentificada = Convert.ToInt32(registro[0]);
                Situacao.descricaoSituacaoIdentificada = registro[1].ToString();
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
    public SituacaoIdentificada BuscarSituacaoPorCodigo(int codigoABuscar)
    {
        try
        {
            DataTable tabelaResultado;

            this.sqlserver.LimparParametros();
            this.sqlserver.AdicionarParametro(new SqlParameter("@codigo", codigoABuscar));

            string comando = "exec uspBuscarSituacaoIdentificadaPorId @codigo";

            tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

            if (tabelaResultado.Rows.Count > 0)
            {
                SituacaoIdentificada Situacao = new SituacaoIdentificada();
                DataRow registro = tabelaResultado.Rows[0];

                Situacao.idSituacaoIdentificada = Convert.ToInt32(registro[0]);
                Situacao.descricaoSituacaoIdentificada = registro[1].ToString();

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
    public Boolean CadastrarSituacao(SituacaoIdentificada Situacao)
    {
        try
        {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", Situacao.descricaoSituacaoIdentificada));

            string comando = " exec uspCadastrarSituacaoIdentificada " +
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
    public Boolean ExcluirSituacao(SituacaoIdentificada Situacao)
    {
        try
        {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", Situacao.idSituacaoIdentificada));

            string comando = "exec uspExcluirSituacaoIdentificada @id";

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
    public Boolean AtualizarSituacao(SituacaoIdentificada Situacao)
    {
        try
        {
            sqlserver.LimparParametros();

            sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", Situacao.idSituacaoIdentificada));
            sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", Situacao.descricaoSituacaoIdentificada));

            string comando = "exec uspAlterarSituacaoIdentificada @id, @descricao";

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
