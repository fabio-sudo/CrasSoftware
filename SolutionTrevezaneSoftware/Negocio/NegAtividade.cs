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
    public class NegAtividade
    {

        ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        //Buscando Tipo por descrição
        public AtividadeLista BuscarAtividadePorNome(string descricao)
        {
            try
            {
                DataTable tabelaResultado;
                Atividade atividade;
                AtividadeLista atividades = new AtividadeLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@descricao", descricao));

                string comando = "exec uspBuscarAtividade @descricao";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    atividade = new Atividade();

                    atividade.idAtividade = Convert.ToInt32(registro[0]);
                    atividade.descricaoAtividade = registro[1].ToString();

                    atividades.Add(atividade);
                }

                return atividades;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o tipo pela descrição. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscando Tipo por Id
        public Atividade BuscarAtividadePorCodigo(int codigoABuscar)
        {
            try
            {
                DataTable tabelaResultado;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@codigo", codigoABuscar));

                string comando = "exec uspBuscarAtividadePorId @codigo";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count > 0)
                {
                    Atividade atividade = new Atividade();
                    DataRow registro = tabelaResultado.Rows[0];

                    atividade.idAtividade = Convert.ToInt32(registro[0]);
                    atividade.descricaoAtividade = registro[1].ToString();

                    return atividade;
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
        public Boolean CadastrarAtividade(Atividade atividade)
        {
            try
            {
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", atividade.descricaoAtividade));

                string comando = " exec uspCadastrarAtividade " +
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
        public Boolean ExcluirAtividade(Atividade atividade)
        {
            try
            {

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", atividade.idAtividade));

                string comando = "exec uspExcluirAtividade @id";

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
        public Boolean AtualizarAtividade(Atividade atividade)
        {
            try
            {
                sqlserver.LimparParametros();

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", atividade.idAtividade));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", atividade.descricaoAtividade));

                string comando = "exec uspAlterarAtividade @id, @descricao";

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
