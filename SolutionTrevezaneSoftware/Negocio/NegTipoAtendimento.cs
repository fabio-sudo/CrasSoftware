using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
