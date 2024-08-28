namespace Apresentacao.Relatorios
{
    partial class ViewRelatorioAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRelatorioAgenda));
            this.uspBuscarAgendaPorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDeDadosCrasDataSet = new Apresentacao.BancoDeDadosCrasDataSet();
            this.rpvAgenda = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uspBuscarAgendaPorDataTableAdapter = new Apresentacao.BancoDeDadosCrasDataSetTableAdapters.uspBuscarAgendaPorDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uspBuscarAgendaPorDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDadosCrasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // uspBuscarAgendaPorDataBindingSource
            // 
            this.uspBuscarAgendaPorDataBindingSource.DataMember = "uspBuscarAgendaPorData";
            this.uspBuscarAgendaPorDataBindingSource.DataSource = this.bancoDeDadosCrasDataSet;
            // 
            // bancoDeDadosCrasDataSet
            // 
            this.bancoDeDadosCrasDataSet.DataSetName = "BancoDeDadosCrasDataSet";
            this.bancoDeDadosCrasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvAgenda
            // 
            this.rpvAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Dados";
            reportDataSource1.Value = this.uspBuscarAgendaPorDataBindingSource;
            this.rpvAgenda.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvAgenda.LocalReport.ReportEmbeddedResource = "Apresentacao.Relatorios.RepAgenda.rdlc";
            this.rpvAgenda.Location = new System.Drawing.Point(0, 0);
            this.rpvAgenda.Name = "rpvAgenda";
            this.rpvAgenda.Size = new System.Drawing.Size(735, 497);
            this.rpvAgenda.TabIndex = 1;
            // 
            // uspBuscarAgendaPorDataTableAdapter
            // 
            this.uspBuscarAgendaPorDataTableAdapter.ClearBeforeFill = true;
            // 
            // ViewRelatorioAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(735, 497);
            this.Controls.Add(this.rpvAgenda);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewRelatorioAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Agenda";
            this.Load += new System.EventHandler(this.ViewRelatorioAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspBuscarAgendaPorDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDadosCrasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvAgenda;
        private System.Windows.Forms.BindingSource uspBuscarAgendaPorDataBindingSource;
        private BancoDeDadosCrasDataSet bancoDeDadosCrasDataSet;
        private BancoDeDadosCrasDataSetTableAdapters.uspBuscarAgendaPorDataTableAdapter uspBuscarAgendaPorDataTableAdapter;
    }
}