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
    public class NegBeneficioGoverno
    {
        ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        //Buscando Tipo por descrição
        public BeneficioGovernoLista BuscarBeneficioGovernoPorNome(string descricao)
        {
            try
            {
                DataTable tabelaResultado;
                BeneficioGoverno beneficio;
                BeneficioGovernoLista beneficios = new BeneficioGovernoLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@descricao", descricao));

                string comando = "exec uspBuscarBeneficioGoverno @descricao";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    beneficio = new BeneficioGoverno();

                    beneficio.idBeneficioGoverno = Convert.ToInt32(registro[0]);
                    beneficio.descricaoBeneficioGoverno = registro[1].ToString();

                    beneficios.Add(beneficio);
                }

                return beneficios;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o tipo pela descrição. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscando Tipo por Id
        public BeneficioGoverno BuscarBeneficioGovernoPorCodigo(int codigoABuscar)
        {
            try
            {
                DataTable tabelaResultado;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@codigo", codigoABuscar));

                string comando = "exec uspBuscarBeneficioGovernoPorId @codigo";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count > 0)
                {
                    BeneficioGoverno beneficio = new BeneficioGoverno();
                    DataRow registro = tabelaResultado.Rows[0];

                    beneficio.idBeneficioGoverno = Convert.ToInt32(registro[0]);
                    beneficio.descricaoBeneficioGoverno = registro[1].ToString();

                    return beneficio;
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
        public Boolean CadastrarBeneficioGoverno(BeneficioGoverno beneficio)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", beneficio.descricaoBeneficioGoverno));

                string comando = " exec uspCadastrarBeneficioGoverno " +
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
        public Boolean ExcluirBeneficioGoverno(BeneficioGoverno beneficio)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", beneficio.idBeneficioGoverno));

                string comando = "exec uspExcluirBeneficioGoverno @id";

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
        public Boolean AtualizarBeneficioGoverno(BeneficioGoverno beneficio)
        {
            try
            {
                sqlserver.LimparParametros();

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@id", beneficio.idBeneficioGoverno));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", beneficio.descricaoBeneficioGoverno));

                string comando = "exec uspAlterarBeneficioGoverno @id, @descricao";

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
