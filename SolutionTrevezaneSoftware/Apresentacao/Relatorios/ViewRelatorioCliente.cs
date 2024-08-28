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
    public partial class ViewRelatorioCliente : Form
    {
        public ViewRelatorioCliente()
        {
            InitializeComponent();
        }

        private void ViewRelatorioCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDeDadosCrasDataSet.tblCliente' table. You can move, or remove it, as needed.
            this.tblClienteTableAdapter.Fill(this.bancoDeDadosCrasDataSet.tblCliente);

            this.repCliente.RefreshReport();
        }




    }
}
