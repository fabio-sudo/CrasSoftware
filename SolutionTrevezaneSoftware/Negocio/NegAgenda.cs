using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegAgenda
    {
        ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        //Cadastro de usuario e senha 
        public Boolean CadastrarAgenda(Agenda agenda)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoFuncionario", agenda.funcionario.codigoFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataAgenda", agenda.dataAgenda));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataInicial", agenda.inicioAgenda));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataFinal", agenda.finalAgenda));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoCliente", agenda.cliente.codigoCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeCliente", agenda.cliente.nomeCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@sobrenomeCliente", agenda.cliente.sobrenomeCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@celularCliente", agenda.cliente.celularCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@situacaoCliente", agenda.situacaoAgenda));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@estatusAgenda", agenda.estatusAgenda));

                string comando = " exec uspCadastrarAgenda " +
                   "@codigoFuncionario, @dataAgenda, @dataInicial, @dataFinal, @codigoCliente, @nomeCliente, @sobrenomeCliente, @celularCliente, @situacaoCliente, @estatusAgenda";

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) != 1)
                {
                    return true;
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios - Cadastro. " + ex.Message);

            }
        }

        //Metodo para Alterar cliente
        public Boolean AtualizarAgenda(Agenda agenda)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoAgenda", agenda.codigoAgenda));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoFuncionario", agenda.funcionario.codigoFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataAgenda", agenda.dataAgenda));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataInicial", agenda.inicioAgenda));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataFinal", agenda.finalAgenda));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoCliente", agenda.cliente.codigoCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeCliente", agenda.cliente.nomeCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@sobrenomeCliente", agenda.cliente.sobrenomeCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@celularCliente", agenda.cliente.celularCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@situacaoCliente", agenda.situacaoAgenda));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@estatusAgenda", agenda.estatusAgenda));


                string comando = " exec uspAlterarAgenda " +
                               "@codigoAgenda, @codigoFuncionario, @dataAgenda, @dataInicial, @dataFinal, @codigoCliente, @nomeCliente, @sobrenomeCliente, @celularCliente, @situacaoCliente, @estatusAgenda";

                sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios - Alteração Agenda. " + ex.Message);
            }
        }

        //Excluir Cliente
        public Boolean ExcluirAgenda(Agenda agenda)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", agenda.codigoAgenda));

                string comando = "exec uspExcluirAgenda @codigo";

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);
                if (Convert.ToInt16(Resposta) == 1)
                {
                    return false;//Erro ao excluir Agenda
                }
                else
                    return true;
            }

            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios = Excluir Agenda. " + ex.Message);
            }


        }

        //Verifica se Funcionário ja tem Usuário no sistema
        public AgendaLista ValidaAgenda(Agenda agendaValida)
        {
            try
            {
                DataTable tabelaResultado;//Recebe dados table SQL
                Agenda agenda;//
                AgendaLista agendaLista = new AgendaLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@data", agendaValida.dataAgenda));
                this.sqlserver.AdicionarParametro(new SqlParameter("@funcionario", agendaValida.funcionario.codigoFuncionario));

                string comando = "exec uspValidaAgenda @data, @funcionario";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count == 0)
                {
                    //  throw new Exception("Não foram encontrados registros.");
                }

                foreach (DataRow registro in tabelaResultado.Rows)
                {

                    agenda = new Agenda();
                    agenda.funcionario = new Funcionario();
                    agenda.cliente = new Cliente();

                    agenda.codigoAgenda = Convert.ToInt32(registro[0]);
                    //Funcionario
                    agenda.funcionario.nomeFuncionario = registro[1].ToString();
                    agenda.funcionario.sobrenomeFuncionario = registro[2].ToString();
                    //Cliente
                    agenda.cliente.nomeCliente = registro[3].ToString();
                    agenda.cliente.sobrenomeCliente = registro[4].ToString();
                    //Data
                    agenda.dataAgenda = Convert.ToDateTime(registro[5]);
                    agenda.inicioAgenda = Convert.ToDateTime(registro[6].ToString());
                    agenda.finalAgenda = Convert.ToDateTime(registro[7].ToString());

                    agendaLista.Add(agenda);
                }

                return agendaLista;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar a Agenda. [Negócios]. Motivo: " + ex.Message);
            }
        }

        public AgendaLista BuscarAgendaPorNome(string nomeFuncionario, string estatus, DateTime dataAgenda)
        {
            try
            {
                DataTable tabelaResultado;//Recebe dados table SQL
                Agenda agenda;//
                AgendaLista agendaLista = new AgendaLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@nome", nomeFuncionario));
                this.sqlserver.AdicionarParametro(new SqlParameter("@estatus", estatus));
                this.sqlserver.AdicionarParametro(new SqlParameter("@data", dataAgenda));

                string comando = "exec uspBuscarAgenda @nome, @estatus, @data";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count == 0)
                {
                    //  throw new Exception("Não foram encontrados registros.");
                }

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    agenda = new Agenda();//Cria novo cliente no loop
                    agenda.funcionario = new Funcionario();
                    agenda.cliente = new Cliente();

                    agenda.codigoAgenda = Convert.ToInt32(registro[0]);

                    agenda.dataAgenda = Convert.ToDateTime(registro[1]);
                    agenda.inicioAgenda = Convert.ToDateTime(registro[2].ToString());
                    agenda.finalAgenda = Convert.ToDateTime(registro[3].ToString());

                    agenda.funcionario.nomeFuncionario = registro[4].ToString();
                    agenda.funcionario.sobrenomeFuncionario = registro[5].ToString();

                    agenda.cliente.nomeCliente = registro[6].ToString();
                    agenda.cliente.sobrenomeCliente = registro[7].ToString();

                    agendaLista.Add(agenda);
                }

                return agendaLista;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar a Agenda pelo nome. [Negócios]. Motivo: " + ex.Message);
            }

        }

        public AgendaLista BuscarAgendaPorData(string nomeFuncionario, string estatus, DateTime dataInicio, DateTime dataFinal)
        {
            try
            {
                DataTable tabelaResultado;//Recebe dados table SQL
                Agenda agenda;//
                AgendaLista agendaLista = new AgendaLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@nome", nomeFuncionario));
                this.sqlserver.AdicionarParametro(new SqlParameter("@estatus", estatus));
                this.sqlserver.AdicionarParametro(new SqlParameter("@dataInicio", dataInicio));
                this.sqlserver.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));

                string comando = "exec uspBuscarAgendaPorData @nome, @estatus, @dataInicio, @dataFinal";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count == 0)
                {
                    //  throw new Exception("Não foram encontrados registros.");
                }

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    agenda = new Agenda();//Cria novo cliente no loop
                    agenda.funcionario = new Funcionario();
                    agenda.cliente = new Cliente();

                    agenda.codigoAgenda = Convert.ToInt32(registro[0]);

                    agenda.dataAgenda = Convert.ToDateTime(registro[1]);
                    agenda.inicioAgenda = Convert.ToDateTime(registro[2].ToString());
                    agenda.finalAgenda = Convert.ToDateTime(registro[3].ToString());

                    agenda.funcionario.codigoFuncionario = Convert.ToInt32(registro[4]);
                    agenda.funcionario.nomeFuncionario = registro[5].ToString();
                    agenda.funcionario.sobrenomeFuncionario = registro[6].ToString();

                    agenda.cliente.nomeCliente = registro[7].ToString();
                    agenda.cliente.sobrenomeCliente = registro[8].ToString();
                    agenda.cliente.celularCliente = registro[9].ToString();

                    agenda.situacaoAgenda = registro[10].ToString();
                    agenda.estatusAgenda = registro[11].ToString();

                    agendaLista.Add(agenda);
                }

                return agendaLista;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar a Agenda pelo nome. [Negócios]. Motivo: " + ex.Message);
            }

        }

    }
}
