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
    public class NegProvidencia
    {
        ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        //Buscando Tipo por descrição
        public ProvidenciaLista BuscarProvidenciaPorNome(string descricao)
        {
            try
            {
                DataTable tabelaResultado;
                Providencia providencia;
                ProvidenciaLista providencias = new ProvidenciaLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@descricao", descricao));

                string comando = "exec uspBuscarProvidencia @descricao";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    providencia = new Providencia();

                    providencia.idProvidencia = Convert.ToInt32(registro[0]);
                    providencia.descricaoProvidencia = registro[1].ToString();

                    providencias.Add(providencia);
                }

                return providencias;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o tipo pela descrição. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscando Tipo por Id
        public Providencia BuscarProvidenciaPorCodigo(int codigoABuscar)
        {
            try
            {
                DataTable tabelaResultado;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@codigo", codigoABuscar));

                string comando = "exec uspBuscarProvidenciaPorId @codigo";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count > 0)
                {
                    Providencia providencia = new Providencia();
                    DataRow registro = tabelaResultado.Rows[0];

                    providencia.idProvidencia = Convert.ToInt32(registro[0]);
                    providencia.descricaoProvidencia = registro[1].ToString();

                    return providencia;
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
        public Boolean CadastrarProvidencia(Providencia providencia)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", providencia.descricaoProvidencia));

                string comando = " exec uspCadastrarProvidencia " +
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
        public Boolean ExcluirProvidencia(Providencia providencia)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", providencia.idProvidencia));

                string comando = "exec uspExcluirProvidencia @id";

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
        public Boolean AtualizarProvidenciaAtendimento(Providencia providencia)
        {
            try
            {
                sqlserver.LimparParametros();

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", providencia.idProvidencia));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", providencia.descricaoProvidencia));

                string comando = "exec uspAlterarProvidencia @id, @descricao";

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
