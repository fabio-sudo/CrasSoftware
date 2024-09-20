using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
                    sqlserver.AdicionarParametro(new SqlParameter("@tipoIds", DBNull.Value));
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
                    sqlserver.AdicionarParametro(new SqlParameter("@situacaoIds", DBNull.Value));
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
                    sqlserver.AdicionarParametro(new SqlParameter("@beneficioGovernoIds", DBNull.Value));
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
                    sqlserver.AdicionarParametro(new SqlParameter("@providenciaIds", DBNull.Value));
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
                    sqlserver.AdicionarParametro(new SqlParameter("@atividadeIds", DBNull.Value));
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
                    sqlserver.AdicionarParametro(new SqlParameter("@situacaoIdentificadaIds", DBNull.Value));
                }
                #endregion


                //string comando = "exec uspCadastrarMovimentoDiario" +
                //    "@data, @pronturario, @nome, @quantidadeCriancas, @quantidadeAdolecentes, @quantidadeIdosos, " +
                //    "@visitaDomiciliar, @beneficioConcedido, @inscritoPaif, @acompanhamentoIndividual, @observacoes, " +
                //    "@incluidoCad, @atualizacaoCad, @bpc, @encaminhadoCreas, @auxlioNatalidade, @auxilioFuneral, " +
                //    "@beneficioEventual, @encaminhamento, @idCliente, @idCad, @idFuncionario, @tipoIds, @situacaoIds, " +
                //    "@beneficioGovernoIds, @providenciaIds, @atividadeIds, @situacaoIdentificadaIds";

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




    }
}





