using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
namespace Negocio
{
    public class NegMovimentoDiario
    {
        ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        // Cadastro de Movimento Diário
        public bool CadastrarMovimentoDiario(MovimentoDiario movimento)
        {
            try
            {
                sqlserver.LimparParametros();

                // Adiciona os parâmetros
                sqlserver.AdicionarParametro(new SqlParameter("@data", movimento.Data));
                sqlserver.AdicionarParametro(new SqlParameter("@pronturario", movimento.Prontuario));
                sqlserver.AdicionarParametro(new SqlParameter("@nome", movimento.Nome));
                sqlserver.AdicionarParametro(new SqlParameter("@quantidadeCriancas", movimento.QuantidadeCriancas));
                sqlserver.AdicionarParametro(new SqlParameter("@quantidadeAdolecentes", movimento.QuantidadeAdolescentes));
                sqlserver.AdicionarParametro(new SqlParameter("@quantidadeIdosos", movimento.QuantidadeIdosos));
                sqlserver.AdicionarParametro(new SqlParameter("@visitaDomiciliar", movimento.VisitaDomiciliar));
                sqlserver.AdicionarParametro(new SqlParameter("@beneficioConcedido", movimento.BeneficioConcedido));
                sqlserver.AdicionarParametro(new SqlParameter("@inscritoPaif", movimento.InscritoPaif));
                sqlserver.AdicionarParametro(new SqlParameter("@acompanhamentoIndividual", movimento.AcompanhamentoIndividual));
                sqlserver.AdicionarParametro(new SqlParameter("@observacoes", movimento.Observacoes));
                sqlserver.AdicionarParametro(new SqlParameter("@incluidoCad", movimento.IncluidoCad));
                sqlserver.AdicionarParametro(new SqlParameter("@atualizacaoCad", movimento.AtualizacaoCad));
                sqlserver.AdicionarParametro(new SqlParameter("@bpc", movimento.Bpc));
                sqlserver.AdicionarParametro(new SqlParameter("@encaminhadoCreas", movimento.EncaminhadoCreas));
                sqlserver.AdicionarParametro(new SqlParameter("@auxlioNatalidade", movimento.AuxilioNatalidade));
                sqlserver.AdicionarParametro(new SqlParameter("@auxilioFuneral", movimento.AuxilioFuneral));
                sqlserver.AdicionarParametro(new SqlParameter("@beneficioEventual", movimento.BeneficioEventual));
                sqlserver.AdicionarParametro(new SqlParameter("@encaminhamento", movimento.Encaminhamento));
                sqlserver.AdicionarParametro(new SqlParameter("@idCliente", movimento.idCliente.codigoCliente));
                sqlserver.AdicionarParametro(new SqlParameter("@idCad", movimento.idCad.idCadastroUnico));
                sqlserver.AdicionarParametro(new SqlParameter("@idFuncionario", movimento.idFuncionario.codigoFuncionario));

                #region DataTableConversion
                // Converte a lista tipoAtendimentos para DataTable
                if (movimento.tipoAtendimentos.Count > 0)
                {
                    DataTable tipoDataTable = new DataTable();
                    tipoDataTable.Columns.Add("idTipo", typeof(int));

                    foreach (TipoAtendimento tipo in movimento.tipoAtendimentos)
                    {
                        tipoDataTable.Rows.Add(tipo.idTipo);
                    }

                    SqlParameter parametroTipoIds = new SqlParameter
                    {
                        ParameterName = "@tipoIds",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "dbo.TypeIds",
                        Value = tipoDataTable
                    };
                    sqlserver.AdicionarParametro(parametroTipoIds);
                }
                else
                {
                    // Cria um DataTable vazio com a estrutura correta
                    DataTable tipoDataTable = CriarDataTableVazio("idTipo");

                    SqlParameter parametroTipoIds = new SqlParameter
                    {
                        ParameterName = "@tipoIds",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "dbo.TypeIds",
                        Value = tipoDataTable
                    };
                    sqlserver.AdicionarParametro(parametroTipoIds);
                }

                // Converte a lista situacaoFamiliars para DataTable
                if (movimento.situacaoFamiliars.Count > 0)
                {
                    DataTable situacaoFamiliarDataTable = new DataTable();
                    situacaoFamiliarDataTable.Columns.Add("idSituacaoFamiliar", typeof(int));

                    foreach (SituacaoFamiliar situacao in movimento.situacaoFamiliars)
                    {
                        situacaoFamiliarDataTable.Rows.Add(situacao.idSituacaoFamiliar);
                    }

                    SqlParameter parametroSituacaoFamiliarIds = new SqlParameter
                    {
                        ParameterName = "@situacaoIds",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "dbo.SituacaoIds",
                        Value = situacaoFamiliarDataTable
                    };
                    sqlserver.AdicionarParametro(parametroSituacaoFamiliarIds);
                }
                else
                {
                    // Cria um DataTable vazio com a estrutura correta
                    DataTable situacaoFamiliarDataTable = CriarDataTableVazio("idSituacaoFamiliar");

                    SqlParameter parametroSituacaoFamiliarIds = new SqlParameter
                    {
                        ParameterName = "@situacaoIds",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "dbo.SituacaoIds",
                        Value = situacaoFamiliarDataTable
                    };
                    sqlserver.AdicionarParametro(parametroSituacaoFamiliarIds);
                }

                // Converte a lista beneficioGovernos para DataTable
                if (movimento.beneficioGovernos.Count > 0)
                {
                    DataTable beneficioGovernoDataTable = new DataTable();
                    beneficioGovernoDataTable.Columns.Add("idBeneficioGoverno", typeof(int));

                    foreach (BeneficioGoverno beneficio in movimento.beneficioGovernos)
                    {
                        beneficioGovernoDataTable.Rows.Add(beneficio.idBeneficioGoverno);
                    }

                    SqlParameter parametroBeneficioGovernoIds = new SqlParameter
                    {
                        ParameterName = "@beneficioGovernoIds",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "dbo.BeneficioGovernoIds",
                        Value = beneficioGovernoDataTable
                    };
                    sqlserver.AdicionarParametro(parametroBeneficioGovernoIds);
                }
                else
                {
                    // Cria um DataTable vazio com a estrutura correta
                    DataTable beneficioGovernoDataTable = CriarDataTableVazio("idBeneficioGoverno");

                    SqlParameter parametroBeneficioGovernoIds = new SqlParameter
                    {
                        ParameterName = "@beneficioGovernoIds",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "dbo.BeneficioGovernoIds",
                        Value = beneficioGovernoDataTable
                    };
                    sqlserver.AdicionarParametro(parametroBeneficioGovernoIds);
                }

                // Converte a lista providencias para DataTable
                if (movimento.providencias.Count > 0)
                {
                    DataTable providenciaDataTable = new DataTable();
                    providenciaDataTable.Columns.Add("idProvidencia", typeof(int));

                    foreach (Providencia providencia in movimento.providencias)
                    {
                        providenciaDataTable.Rows.Add(providencia.idProvidencia);
                    }

                    SqlParameter parametroProvidenciaIds = new SqlParameter
                    {
                        ParameterName = "@providenciaIds",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "dbo.ProvidenciaIds",
                        Value = providenciaDataTable
                    };
                    sqlserver.AdicionarParametro(parametroProvidenciaIds);
                }
                else
                {
                    // Cria um DataTable vazio com a estrutura correta
                    DataTable providenciaDataTable = CriarDataTableVazio("idProvidencia");

                    SqlParameter parametroProvidenciaIds = new SqlParameter
                    {
                        ParameterName = "@providenciaIds",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "dbo.ProvidenciaIds",
                        Value = providenciaDataTable
                    };
                    sqlserver.AdicionarParametro(parametroProvidenciaIds);
                }

                // Converte a lista atividadeLista para DataTable
                if (movimento.atividadeLista.Count > 0)
                {
                    DataTable atividadeDataTable = new DataTable();
                    atividadeDataTable.Columns.Add("idAtividade", typeof(int));

                    foreach (Atividade atividade in movimento.atividadeLista)
                    {
                        atividadeDataTable.Rows.Add(atividade.idAtividade);
                    }

                    SqlParameter parametroAtividadeIds = new SqlParameter
                    {
                        ParameterName = "@atividadeIds",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "dbo.AtividadeIds",
                        Value = atividadeDataTable
                    };
                    sqlserver.AdicionarParametro(parametroAtividadeIds);
                }
                else
                {
                    // Cria um DataTable vazio com a estrutura correta
                    DataTable atividadeDataTable = CriarDataTableVazio("idAtividade");

                    SqlParameter parametroAtividadeIds = new SqlParameter
                    {
                        ParameterName = "@atividadeIds",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "dbo.AtividadeIds",
                        Value = atividadeDataTable
                    };
                    sqlserver.AdicionarParametro(parametroAtividadeIds);
                }

                // Converte a lista situacaoIdentificadas para DataTable
                if (movimento.situacaoIdentificadas.Count > 0)
                {
                    DataTable situacaoIdentificadaDataTable = new DataTable();
                    situacaoIdentificadaDataTable.Columns.Add("idSituacao", typeof(int));

                    foreach (SituacaoIdentificada situacao in movimento.situacaoIdentificadas)
                    {
                        situacaoIdentificadaDataTable.Rows.Add(situacao.idSituacaoIdentificada);
                    }

                    SqlParameter parametroSituacaoIds = new SqlParameter
                    {
                        ParameterName = "@situacaoIdentificadaIds",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "dbo.SituacaoIdentificadaIds",
                        Value = situacaoIdentificadaDataTable
                    };
                    sqlserver.AdicionarParametro(parametroSituacaoIds);
                }
                else
                {
                    // Cria um DataTable vazio com a estrutura correta
                    DataTable situacaoIdentificadaDataTable = CriarDataTableVazio("idSituacao");

                    SqlParameter parametroSituacaoIds = new SqlParameter
                    {
                        ParameterName = "@situacaoIdentificadaIds",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "dbo.SituacaoIdentificadaIds",
                        Value = situacaoIdentificadaDataTable
                    };
                    sqlserver.AdicionarParametro(parametroSituacaoIds);
                }
                #endregion


                object resposta = sqlserver.ExecutarScalar("uspCadastrarMovimentoDiario", CommandType.StoredProcedure);

                return Convert.ToInt16(resposta) != 2; // Retorna true se não houver erro
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios - Cadastro. " + ex.Message);
            }
        }

        public bool CadastrarTexte()
        {
            try
            {
                List<string> lista = new List<string>
        {
            "Descrição 1",
            "Descrição 2",
            "Descrição 3"
        };

                sqlserver.LimparParametros();

                DataTable dtDescricoes = new DataTable();
                dtDescricoes.Columns.Add("descricao", typeof(string));

                foreach (var descricao in lista)
                {
                    dtDescricoes.Rows.Add(descricao);
                }

                var parameter = new SqlParameter
                {
                    ParameterName = "@Descricoes",
                    SqlDbType = SqlDbType.Structured,
                    TypeName = "dbo.Texte",
                    Value = dtDescricoes
                };

                sqlserver.AdicionarParametro(parameter);

                // Chamar o procedimento armazenado sem o EXEC
                var registrosInseridos = sqlserver.ExecutarScalar("uspCadastrarTexte", CommandType.StoredProcedure);
                Console.WriteLine($"Registros inseridos: {registrosInseridos}");

                return registrosInseridos != null && Convert.ToInt32(registrosInseridos) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar texte: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                throw;
            }
        }



        public DataTable ToDataTable<T>(List<T> items)
        {
            var dataTable = new DataTable(typeof(T).Name);

            if (items == null || items.Count == 0)
            {
                return dataTable; // Retorna um DataTable vazio
            }

            // Cria as colunas do DataTable
            foreach (var prop in typeof(T).GetProperties())
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            // Adiciona as linhas
            foreach (var item in items)
            {
                var values = new object[dataTable.Columns.Count];
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    values[i] = typeof(T).GetProperties()[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        // Método auxiliar para criar um DataTable vazio com a estrutura correta
        private DataTable CriarDataTableVazio(string nomeColuna)
        {
            DataTable table = new DataTable();
            table.Columns.Add(nomeColuna, typeof(int));
            return table;
        }


        public MovimentoDiarioLista BuscarMovimentoDiarioPorDataUsuario(DateTime dataInicial, DateTime dataFinal, string nomeUsuario, int idFuncionario)
        {
            try
            {
                // Limpa os parâmetros anteriores
                sqlserver.LimparParametros();

                // Adiciona os parâmetros necessários para a busca
                sqlserver.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
                sqlserver.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));
                sqlserver.AdicionarParametro(new SqlParameter("@nomeUsuario", nomeUsuario ?? (object)DBNull.Value));
                sqlserver.AdicionarParametro(new SqlParameter("@idFuncionario", idFuncionario));

                // Executa a consulta e obtém o resultado
                DataTable tabelaResultado = sqlserver.ExecutarConsulta("uspBuscarMovimentoDiarioPorDataUsuario", CommandType.StoredProcedure);

                // Cria uma lista para armazenar os resultados
                MovimentoDiarioLista listaMovimentoDiario = new MovimentoDiarioLista();

                // Preenche a lista com os dados retornados
                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    MovimentoDiario movimento = new MovimentoDiario
                    {
                        IdMovimentoDiario = Convert.ToInt32(registro[0]),
                        Data = registro[1] != DBNull.Value ? Convert.ToDateTime(registro[1]) : (DateTime?)null,
                        Prontuario = registro[2].ToString(),
                        Nome = registro[3].ToString(),
                        QuantidadeCriancas = registro[4] != DBNull.Value ? Convert.ToInt32(registro[4]) : (int?)null,
                        QuantidadeAdolescentes = registro[5] != DBNull.Value ? Convert.ToInt32(registro[5]) : (int?)null,
                        QuantidadeIdosos = registro[6] != DBNull.Value ? Convert.ToInt32(registro[6]) : (int?)null,
                        VisitaDomiciliar = registro[7] != DBNull.Value ? Convert.ToBoolean(registro[7]) : (bool?)null,
                        BeneficioConcedido = registro[8] != DBNull.Value ? Convert.ToBoolean(registro[8]) : (bool?)null,
                        InscritoPaif = registro[9] != DBNull.Value ? Convert.ToBoolean(registro[9]) : (bool?)null,
                        AcompanhamentoIndividual = registro[10] != DBNull.Value ? Convert.ToBoolean(registro[10]) : (bool?)null,
                        Observacoes = registro[11].ToString(),
                        IncluidoCad = registro[12] != DBNull.Value ? Convert.ToBoolean(registro[12]) : (bool?)null,
                        AtualizacaoCad = registro[13] != DBNull.Value ? Convert.ToBoolean(registro[13]) : (bool?)null,
                        Bpc = registro[14] != DBNull.Value ? Convert.ToBoolean(registro[14]) : (bool?)null,
                        EncaminhadoCreas = registro[15] != DBNull.Value ? Convert.ToBoolean(registro[15]) : (bool?)null,
                        AuxilioNatalidade = registro[16] != DBNull.Value ? Convert.ToBoolean(registro[16]) : (bool?)null,
                        AuxilioFuneral = registro[17] != DBNull.Value ? Convert.ToBoolean(registro[17]) : (bool?)null,
                        BeneficioEventual = registro[18] != DBNull.Value ? Convert.ToBoolean(registro[18]) : (bool?)null,
                        Encaminhamento = registro[19] != DBNull.Value ? Convert.ToBoolean(registro[19]) : (bool?)null,
                        idCliente = registro[20] != DBNull.Value ? new Cliente { codigoCliente = Convert.ToInt32(registro[20]) } : null,
                        idCad = registro[21] != DBNull.Value ? new CadastroUnico { idCadastroUnico = Convert.ToInt32(registro[21]) } : null,
                        idFuncionario = registro[22] != DBNull.Value ? new Funcionario { codigoFuncionario = Convert.ToInt32(registro[22]) } : null,

                        // As listas permanecem vazias e serão preenchidas se necessário
                        tipoAtendimentos = new TipoLista(),
                        providencias = new ProvidenciaLista(),
                        situacaoIdentificadas = new SituacaoIdentificadaLista(),
                        beneficioGovernos = new BeneficioGovernoLista(),
                        cadastroUnicos = new CadastroUnicoLista(),
                        situacaoFamiliars = new SituacaoFamilizarLista(),
                        atividadeLista = new AtividadeLista(),
                        especificacaoLista = new EspecificacaoLista()
                    };

                    // Adiciona o objeto movimento na lista
                    listaMovimentoDiario.Add(movimento);
                }

                return listaMovimentoDiario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar movimentos diários. " + ex.Message);
            }
        }

        public MovimentoDiarioLista BuscarMovimentoDiarioPorDataFuncionario(DateTime dataInicial, DateTime dataFinal, string nomeUsuario, int idFuncionario)
        {
            try
            {
                // Limpa os parâmetros anteriores
                sqlserver.LimparParametros();

                // Adiciona os parâmetros necessários para a busca
                sqlserver.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
                sqlserver.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));
                sqlserver.AdicionarParametro(new SqlParameter("@nomeUsuario", nomeUsuario ?? (object)DBNull.Value));
                sqlserver.AdicionarParametro(new SqlParameter("@idFuncionario", idFuncionario));

                // Executa a consulta e obtém o resultado
                DataTable tabelaResultado = sqlserver.ExecutarConsulta("uspBuscarMovimentoDiarioPorDataFuncionario", CommandType.StoredProcedure);

                // Cria uma lista para armazenar os resultados
                MovimentoDiarioLista listaMovimentoDiario = new MovimentoDiarioLista();

                // Preenche a lista com os dados retornados
                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    MovimentoDiario movimento = new MovimentoDiario
                    {
                        IdMovimentoDiario = Convert.ToInt32(registro[0]),
                        Data = registro[1] != DBNull.Value ? Convert.ToDateTime(registro[1]) : (DateTime?)null,
                        Prontuario = registro[2].ToString(),
                        Nome = registro[3].ToString(),
                        QuantidadeCriancas = registro[4] != DBNull.Value ? Convert.ToInt32(registro[4]) : (int?)null,
                        QuantidadeAdolescentes = registro[5] != DBNull.Value ? Convert.ToInt32(registro[5]) : (int?)null,
                        QuantidadeIdosos = registro[6] != DBNull.Value ? Convert.ToInt32(registro[6]) : (int?)null,
                        VisitaDomiciliar = registro[7] != DBNull.Value ? Convert.ToBoolean(registro[7]) : (bool?)null,
                        BeneficioConcedido = registro[8] != DBNull.Value ? Convert.ToBoolean(registro[8]) : (bool?)null,
                        InscritoPaif = registro[9] != DBNull.Value ? Convert.ToBoolean(registro[9]) : (bool?)null,
                        AcompanhamentoIndividual = registro[10] != DBNull.Value ? Convert.ToBoolean(registro[10]) : (bool?)null,
                        Observacoes = registro[11].ToString(),
                        IncluidoCad = registro[12] != DBNull.Value ? Convert.ToBoolean(registro[12]) : (bool?)null,
                        AtualizacaoCad = registro[13] != DBNull.Value ? Convert.ToBoolean(registro[13]) : (bool?)null,
                        Bpc = registro[14] != DBNull.Value ? Convert.ToBoolean(registro[14]) : (bool?)null,
                        EncaminhadoCreas = registro[15] != DBNull.Value ? Convert.ToBoolean(registro[15]) : (bool?)null,
                        AuxilioNatalidade = registro[16] != DBNull.Value ? Convert.ToBoolean(registro[16]) : (bool?)null,
                        AuxilioFuneral = registro[17] != DBNull.Value ? Convert.ToBoolean(registro[17]) : (bool?)null,
                        BeneficioEventual = registro[18] != DBNull.Value ? Convert.ToBoolean(registro[18]) : (bool?)null,
                        Encaminhamento = registro[19] != DBNull.Value ? Convert.ToBoolean(registro[19]) : (bool?)null,
                        idCliente = registro[20] != DBNull.Value ? new Cliente { codigoCliente = Convert.ToInt32(registro[20]) } : null,
                        idCad = registro[21] != DBNull.Value ? new CadastroUnico { idCadastroUnico = Convert.ToInt32(registro[21]) } : null,
                        idFuncionario = registro[22] != DBNull.Value ? new Funcionario { codigoFuncionario = Convert.ToInt32(registro[22]) } : null,

                        // As listas permanecem vazias e serão preenchidas se necessário
                        tipoAtendimentos = new TipoLista(),
                        providencias = new ProvidenciaLista(),
                        situacaoIdentificadas = new SituacaoIdentificadaLista(),
                        beneficioGovernos = new BeneficioGovernoLista(),
                        cadastroUnicos = new CadastroUnicoLista(),
                        situacaoFamiliars = new SituacaoFamilizarLista(),
                        atividadeLista = new AtividadeLista(),
                        especificacaoLista = new EspecificacaoLista()
                    };

                    // Adiciona o objeto movimento na lista
                    listaMovimentoDiario.Add(movimento);
                }

                return listaMovimentoDiario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar movimentos diários. " + ex.Message);
            }
        }

        public MovimentoDiarioLista BuscarMovimentoDiarioPorDataECPF(DateTime dataInicial, DateTime dataFinal, string cpfCliente, int idFuncionario)
        {
            try
            {
                // Limpa os parâmetros anteriores
                sqlserver.LimparParametros();

                // Adiciona os parâmetros necessários para a busca
                sqlserver.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
                sqlserver.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));
                sqlserver.AdicionarParametro(new SqlParameter("@cpfCliente", cpfCliente ?? (object)DBNull.Value)); // Alterado para cpfCliente
                sqlserver.AdicionarParametro(new SqlParameter("@idFuncionario", idFuncionario));

                // Executa a consulta e obtém o resultado
                DataTable tabelaResultado = sqlserver.ExecutarConsulta("uspBuscarMovimentoDiarioPorDataECPF", CommandType.StoredProcedure); // Alterado para o novo nome do SP

                // Cria uma lista para armazenar os resultados
                MovimentoDiarioLista listaMovimentoDiario = new MovimentoDiarioLista();

                // Preenche a lista com os dados retornados
                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    MovimentoDiario movimento = new MovimentoDiario
                    {
                        IdMovimentoDiario = Convert.ToInt32(registro[0]),
                        Data = registro[1] != DBNull.Value ? Convert.ToDateTime(registro[1]) : (DateTime?)null,
                        Prontuario = registro[2].ToString(),
                        Nome = registro[3].ToString(),
                        QuantidadeCriancas = registro[4] != DBNull.Value ? Convert.ToInt32(registro[4]) : (int?)null,
                        QuantidadeAdolescentes = registro[5] != DBNull.Value ? Convert.ToInt32(registro[5]) : (int?)null,
                        QuantidadeIdosos = registro[6] != DBNull.Value ? Convert.ToInt32(registro[6]) : (int?)null,
                        VisitaDomiciliar = registro[7] != DBNull.Value ? Convert.ToBoolean(registro[7]) : (bool?)null,
                        BeneficioConcedido = registro[8] != DBNull.Value ? Convert.ToBoolean(registro[8]) : (bool?)null,
                        InscritoPaif = registro[9] != DBNull.Value ? Convert.ToBoolean(registro[9]) : (bool?)null,
                        AcompanhamentoIndividual = registro[10] != DBNull.Value ? Convert.ToBoolean(registro[10]) : (bool?)null,
                        Observacoes = registro[11].ToString(),
                        IncluidoCad = registro[12] != DBNull.Value ? Convert.ToBoolean(registro[12]) : (bool?)null,
                        AtualizacaoCad = registro[13] != DBNull.Value ? Convert.ToBoolean(registro[13]) : (bool?)null,
                        Bpc = registro[14] != DBNull.Value ? Convert.ToBoolean(registro[14]) : (bool?)null,
                        EncaminhadoCreas = registro[15] != DBNull.Value ? Convert.ToBoolean(registro[15]) : (bool?)null,
                        AuxilioNatalidade = registro[16] != DBNull.Value ? Convert.ToBoolean(registro[16]) : (bool?)null,
                        AuxilioFuneral = registro[17] != DBNull.Value ? Convert.ToBoolean(registro[17]) : (bool?)null,
                        BeneficioEventual = registro[18] != DBNull.Value ? Convert.ToBoolean(registro[18]) : (bool?)null,
                        Encaminhamento = registro[19] != DBNull.Value ? Convert.ToBoolean(registro[19]) : (bool?)null,
                        idCliente = registro[20] != DBNull.Value ? new Cliente { codigoCliente = Convert.ToInt32(registro[20]) } : null,
                        idCad = registro[21] != DBNull.Value ? new CadastroUnico { idCadastroUnico = Convert.ToInt32(registro[21]) } : null,
                        idFuncionario = registro[22] != DBNull.Value ? new Funcionario { codigoFuncionario = Convert.ToInt32(registro[22]) } : null,

                        // As listas permanecem vazias e serão preenchidas se necessário
                        tipoAtendimentos = new TipoLista(),
                        providencias = new ProvidenciaLista(),
                        situacaoIdentificadas = new SituacaoIdentificadaLista(),
                        beneficioGovernos = new BeneficioGovernoLista(),
                        cadastroUnicos = new CadastroUnicoLista(),
                        situacaoFamiliars = new SituacaoFamilizarLista(),
                        atividadeLista = new AtividadeLista(),
                        especificacaoLista = new EspecificacaoLista()
                    };

                    // Adiciona o objeto movimento na lista
                    listaMovimentoDiario.Add(movimento);
                }

                return listaMovimentoDiario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar movimentos diários. " + ex.Message);
            }
        }

        public void PreencherListasMovimentoDiario(MovimentoDiario movimento)
        {
            try
            {
                // Limpa os parâmetros anteriores
                sqlserver.LimparParametros();

                // Adiciona o parâmetro necessário para a busca
                sqlserver.AdicionarParametro(new SqlParameter("@idMovimentoDiario", movimento.IdMovimentoDiario));

                // Executa a consulta e obtém o resultado
                DataTable tabelaResultado = sqlserver.ExecutarConsulta("uspBuscarRelacionadosPorMovimentoDiario", CommandType.StoredProcedure);

                if (tabelaResultado.Rows.Count > 0)
                {
                    DataRow registro = tabelaResultado.Rows[0];

                    // Preenche a lista de tipos
                    if (registro["tipoIds"] != DBNull.Value)
                    {
                        string tipoIds = registro["tipoIds"].ToString();
                        var tipos = tipoIds.Split(',').Select(id => new TipoAtendimento { idTipo = Convert.ToInt32(id.Trim()) }).ToList();
                        movimento.tipoAtendimentos.AddRange(tipos);
                    }

                    // Preenche a lista de situações
                    if (registro["situacaoFamiliarIds"] != DBNull.Value)
                    {
                        string situacaoIds = registro["situacaoFamiliarIds"].ToString();
                        var situacoes = situacaoIds.Split(',').Select(id => new SituacaoFamiliar { idSituacaoFamiliar = Convert.ToInt32(id.Trim()) }).ToList();
                        movimento.situacaoFamiliars.AddRange(situacoes);
                    }

                    // Preenche a lista de benefícios do governo
                    if (registro["beneficioGovernoIds"] != DBNull.Value)
                    {
                        string beneficioGovernoIds = registro["beneficioGovernoIds"].ToString();
                        var beneficios = beneficioGovernoIds.Split(',').Select(id => new BeneficioGoverno { idBeneficioGoverno = Convert.ToInt32(id.Trim()) }).ToList();
                        movimento.beneficioGovernos.AddRange(beneficios);
                    }

                    // Preenche a lista de providências
                    if (registro["providenciaIds"] != DBNull.Value)
                    {
                        string providenciaIds = registro["providenciaIds"].ToString();
                        var providencias = providenciaIds.Split(',').Select(id => new Providencia { idProvidencia = Convert.ToInt32(id.Trim()) }).ToList();
                        movimento.providencias.AddRange(providencias);
                    }

                    // Preenche a lista de atividades
                    if (registro["atividadeIds"] != DBNull.Value)
                    {
                        string atividadeIds = registro["atividadeIds"].ToString();
                        var atividades = atividadeIds.Split(',').Select(id => new Atividade { idAtividade = Convert.ToInt32(id.Trim()) }).ToList();
                        movimento.atividadeLista.AddRange(atividades);
                    }

                    // Preenche a lista de situações identificadas
                    if (registro["situacaoIdentificadaIds"] != DBNull.Value)
                    {
                        string situacaoIdentificadaIds = registro["situacaoIdentificadaIds"].ToString();
                        var situacoesIdentificadas = situacaoIdentificadaIds.Split(',').Select(id => new SituacaoIdentificada { idSituacaoIdentificada = Convert.ToInt32(id.Trim()) }).ToList();
                        movimento.situacaoIdentificadas.AddRange(situacoesIdentificadas);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao preencher listas de movimento diário. " + ex.Message);
            }
        }

    }
}





