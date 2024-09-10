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
    public class NegCadastroUnico
    {
        ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        //Buscando CadastroUnico por descrição
        public CadastroUnicoLista BuscarCadastroUnicoPorNome(string descricao)
        {
            try
            {
                DataTable tabelaResultado;
                CadastroUnico cad;
                CadastroUnicoLista cads = new CadastroUnicoLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@descricao", descricao));

                string comando = "exec uspBuscarCad @descricao";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    cad = new CadastroUnico();

                    cad.idCadastroUnico = Convert.ToInt32(registro[0]);
                    cad.descricaoCadastroUnico = registro[1].ToString();

                    cads.Add(cad);
                }

                return cads;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o tipo pela descrição. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscando CadastroUnico por Id
        public CadastroUnico BuscarCadastroUnicoPorCodigo(int codigoABuscar)
        {
            try
            {
                DataTable tabelaResultado;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@codigo", codigoABuscar));

                string comando = "exec uspBuscarCadPorId @codigo";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count > 0)
                {
                    CadastroUnico cad = new CadastroUnico();
                    DataRow registro = tabelaResultado.Rows[0];

                    cad.idCadastroUnico = Convert.ToInt32(registro[0]);
                    cad.descricaoCadastroUnico = registro[1].ToString();

                    return cad;
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
        public Boolean CadastrarCadastroUnico(CadastroUnico cadastroUnico)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", cadastroUnico.descricaoCadastroUnico));

                string comando = " exec uspCadastrarCadastroUnico " +
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
        public Boolean ExcluirCadastroUnico(CadastroUnico cadastroUnico)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", cadastroUnico.idCadastroUnico));

                string comando = "exec uspExcluirCadastroUnico @id";

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
                throw new Exception("Não foi possível excluir os dados. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Alteração Tipo Atendimento
        public Boolean AtualizarCadastroUnico(CadastroUnico cadastroUnico)
        {
            try
            {
                sqlserver.LimparParametros();

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", cadastroUnico.idCadastroUnico));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", cadastroUnico.descricaoCadastroUnico));

                string comando = "exec uspAlterarCadastroUnico @id, @descricao";

                sqlserver.ExecutarScalar(comando, CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível atualizar os dados. Motivo: " + ex.Message);
            }
        }

    }
}
