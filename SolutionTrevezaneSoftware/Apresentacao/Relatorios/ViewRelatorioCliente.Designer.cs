namespace Apresentacao.Relatorios
{
    partial class ViewRelatorioCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRelatorioCliente));
            this.bancoDeDadosCrasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDeDadosCrasDataSet = new Apresentacao.BancoDeDadosCrasDataSet();
            this.repCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblClienteTableAdapter = new Apresentacao.BancoDeDadosCrasDataSetTableAdapters.tblClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDadosCrasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDadosCrasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bancoDeDadosCrasDataSetBindingSource
            // 
            this.bancoDeDadosCrasDataSetBindingSource.DataMember = "tblCliente";
            this.bancoDeDadosCrasDataSetBindingSource.DataSource = this.bancoDeDadosCrasDataSet;
            // 
            // bancoDeDadosCrasDataSet
            // 
            this.bancoDeDadosCrasDataSet.DataSetName = "BancoDeDadosCrasDataSet";
            this.bancoDeDadosCrasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repCliente
            // 
            this.repCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repCliente.DocumentMapWidth = 44;
            reportDataSource1.Name = "Dados";
            this.repCliente.LocalReport.DataSources.Add(reportDataSource1);
            this.repCliente.LocalReport.ReportEmbeddedResource = "Apresentacao.Relatorios.RepCliente.rdlc";
            this.repCliente.Location = new System.Drawing.Point(0, 0);
            this.repCliente.Name = "repCliente";
            this.repCliente.Size = new System.Drawing.Size(623, 486);
            this.repCliente.TabIndex = 0;
            // 
            // tblClienteTableAdapter
            // 
            this.tblClienteTableAdapter.ClearBeforeFill = true;
            // 
            // ViewRelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(623, 486);
            this.Controls.Add(this.repCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewRelatorioCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Cliente";
            this.Load += new System.EventHandler(this.ViewRelatorioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDadosCrasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDadosCrasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repCliente;
        private System.Windows.Forms.BindingSource bancoDeDadosCrasDataSetBindingSource;
        private BancoDeDadosCrasDataSet bancoDeDadosCrasDataSet;
        private BancoDeDadosCrasDataSetTableAdapters.tblClienteTableAdapter tblClienteTableAdapter;






    }
}