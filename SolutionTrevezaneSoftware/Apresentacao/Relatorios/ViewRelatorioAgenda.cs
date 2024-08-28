using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Relatorios
{
    public partial class ViewRelatorioAgenda : Form
    {

        string funcionario;
        string estatus;
        DateTime dataInicio;
        DateTime dataFim;

        public ViewRelatorioAgenda(string funcionarioAgenda, string statusAgenda, DateTime dataInicial, DateTime dataFinal)
        {
            InitializeComponent();

            funcionario = funcionarioAgenda;
            estatus = statusAgenda;
            dataInicio = dataInicial;
            dataFim = dataFinal;
        }

        private void ViewRelatorioAgenda_Load(object sender, EventArgs e)
        {
            try
            {
                this.uspBuscarAgendaPorDataTableAdapter.Fill(bancoDeDadosCrasDataSet.uspBuscarAgendaPorData, funcionario, estatus, dataInicio, dataFim);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.rpvAgenda.RefreshReport();
        }



    }
}
