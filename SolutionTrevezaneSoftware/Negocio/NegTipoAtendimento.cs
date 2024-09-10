using ObjetoTransferencia;
using System;
using System.Data.SqlClient;
using System.Data;
using AcessoDados;

namespace Negocio
{
    public class NegTipoAtendimento
    {


        ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        //Buscando Tipo por descrição
        public TipoLista BuscarTipoPorNome(string descricao)
        {
            try
            {
                DataTable tabelaResultado;
                TipoAtendimento tipo;
                TipoLista tipos = new TipoLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@descricao", descricao));

                string comando = "exec uspBuscarTipo @descricao";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    tipo = new TipoAtendimento();

                    tipo.idTipo = Convert.ToInt32(registro[0]);
                    tipo.descricaoTipo = registro[1].ToString();

                    tipos.Add(tipo);
                }

                return tipos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o tipo pela descrição. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscando Tipo por Id
        public TipoAtendimento BuscarTipoPorCodigo(int codigoABuscar)
        {
            try
            {
                DataTable tabelaResultado;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@codigo", codigoABuscar));

                string comando = "exec uspBuscarTipoPorId @codigo";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count > 0)
                {
                    TipoAtendimento tipo = new TipoAtendimento();
                    DataRow registro = tabelaResultado.Rows[0];

                    tipo.idTipo = Convert.ToInt32(registro[0]);
                    tipo.descricaoTipo = registro[1].ToString();

                    return tipo;
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
        public Boolean CadastrarTipoAtendimento(TipoAtendimento tipoAtendimento)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", tipoAtendimento.descricaoTipo));
              
                string comando = " exec uspCadastrarTipo " +
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
        public Boolean ExcluirTipoAtendimento(TipoAtendimento tipoAtendimento)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", tipoAtendimento.idTipo));

                string comando = "exec uspExcluirTipo @id";

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
        public Boolean AtualizarTipoAtendimento(TipoAtendimento tipoAtendimento)
        {
            try
            {
                sqlserver.LimparParametros();

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", tipoAtendimento.idTipo));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", tipoAtendimento.descricaoTipo));
             
                string comando = "exec uspAlterarTipo @id, @descricao";

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
