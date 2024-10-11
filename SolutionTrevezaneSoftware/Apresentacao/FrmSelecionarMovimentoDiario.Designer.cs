namespace Apresentacao
{
    partial class FrmSelecionarMovimentoDiario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSelecionar = new System.Windows.Forms.DataGridView();
            this.idMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prontuarioMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeCriancas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeAdolecentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeIdosos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitaMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encaminhamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beneficioConcedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inseridoPaif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acompanhamentoIndividual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesMovivmento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.lbdataInicial = new System.Windows.Forms.Label();
            this.pbFiltrar = new System.Windows.Forms.PictureBox();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btBuscarFuncionario = new System.Windows.Forms.Button();
            this.panelBuscarFuncionario = new System.Windows.Forms.Panel();
            this.tbFuncionario = new System.Windows.Forms.TextBox();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelecionar
            // 
            this.dgvSelecionar.AllowUserToAddRows = false;
            this.dgvSelecionar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvSelecionar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelecionar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelecionar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSelecionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelecionar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMovimento,
            this.dataMovimento,
            this.prontuarioMovimento,
            this.nomeCliente,
            this.quantidadeCriancas,
            this.quantidadeAdolecentes,
            this.quantidadeIdosos,
            this.visitaMovimento,
            this.Encaminhamento,
            this.beneficioConcedido,
            this.inseridoPaif,
            this.acompanhamentoIndividual,
            this.observacoesMovivmento});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelecionar.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSelecionar.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSelecionar.Location = new System.Drawing.Point(15, 76);
            this.dgvSelecionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSelecionar.Name = "dgvSelecionar";
            this.dgvSelecionar.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvSelecionar.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSelecionar.RowTemplate.Height = 24;
            this.dgvSelecionar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelecionar.Size = new System.Drawing.Size(2033, 795);
            this.dgvSelecionar.TabIndex = 4;
            this.dgvSelecionar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelecionar_CellDoubleClick);
            // 
            // idMovimento
            // 
            this.idMovimento.HeaderText = "ID";
            this.idMovimento.MinimumWidth = 6;
            this.idMovimento.Name = "idMovimento";
            this.idMovimento.ReadOnly = true;
            this.idMovimento.Visible = false;
            this.idMovimento.Width = 30;
            // 
            // dataMovimento
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataMovimento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataMovimento.HeaderText = "Data";
            this.dataMovimento.MinimumWidth = 6;
            this.dataMovimento.Name = "dataMovimento";
            this.dataMovimento.ReadOnly = true;
            this.dataMovimento.ToolTipText = "Data do movimento diário";
            this.dataMovimento.Width = 70;
            // 
            // prontuarioMovimento
            // 
            this.prontuarioMovimento.HeaderText = "Prontuário";
            this.prontuarioMovimento.MinimumWidth = 6;
            this.prontuarioMovimento.Name = "prontuarioMovimento";
            this.prontuarioMovimento.ToolTipText = "Número do Pontuário do Usuário";
            this.prontuarioMovimento.Width = 80;
            // 
            // nomeCliente
            // 
            this.nomeCliente.HeaderText = "Usuário";
            this.nomeCliente.MinimumWidth = 6;
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ToolTipText = "Nome completo do usuário atendido";
            this.nomeCliente.Width = 200;
            // 
            // quantidadeCriancas
            // 
            this.quantidadeCriancas.HeaderText = "Qtd.Cç";
            this.quantidadeCriancas.MinimumWidth = 6;
            this.quantidadeCriancas.Name = "quantidadeCriancas";
            this.quantidadeCriancas.ToolTipText = "Quantiade de Crianças da Família";
            this.quantidadeCriancas.Width = 65;
            // 
            // quantidadeAdolecentes
            // 
            this.quantidadeAdolecentes.HeaderText = "Qtd.Adol";
            this.quantidadeAdolecentes.MinimumWidth = 6;
            this.quantidadeAdolecentes.Name = "quantidadeAdolecentes";
            this.quantidadeAdolecentes.ToolTipText = "Quantiade de Adolescentes da Família";
            this.quantidadeAdolecentes.Width = 65;
            // 
            // quantidadeIdosos
            // 
            this.quantidadeIdosos.HeaderText = "Qtd.Idos";
            this.quantidadeIdosos.MinimumWidth = 6;
            this.quantidadeIdosos.Name = "quantidadeIdosos";
            this.quantidadeIdosos.ToolTipText = "Quantiade de Idosos da Família";
            this.quantidadeIdosos.Width = 65;
            // 
            // visitaMovimento
            // 
            this.visitaMovimento.HeaderText = "Visita";
            this.visitaMovimento.MinimumWidth = 6;
            this.visitaMovimento.Name = "visitaMovimento";
            this.visitaMovimento.ToolTipText = "Visita realizada ao Usuário";
            this.visitaMovimento.Width = 50;
            // 
            // Encaminhamento
            // 
            this.Encaminhamento.HeaderText = "Encam.";
            this.Encaminhamento.MinimumWidth = 6;
            this.Encaminhamento.Name = "Encaminhamento";
            this.Encaminhamento.ToolTipText = "Encaminhamento realizado";
            this.Encaminhamento.Width = 90;
            // 
            // beneficioConcedido
            // 
            this.beneficioConcedido.HeaderText = "Ben. Conc";
            this.beneficioConcedido.MinimumWidth = 6;
            this.beneficioConcedido.Name = "beneficioConcedido";
            this.beneficioConcedido.ToolTipText = "Benefício concedido para o usuário";
            this.beneficioConcedido.Width = 95;
            // 
            // inseridoPaif
            // 
            this.inseridoPaif.HeaderText = "Ins. PAIF";
            this.inseridoPaif.MinimumWidth = 6;
            this.inseridoPaif.Name = "inseridoPaif";
            this.inseridoPaif.ToolTipText = "Usuário inserido no PAIF";
            this.inseridoPaif.Width = 90;
            // 
            // acompanhamentoIndividual
            // 
            this.acompanhamentoIndividual.HeaderText = "Acom. Ind";
            this.acompanhamentoIndividual.MinimumWidth = 6;
            this.acompanhamentoIndividual.Name = "acompanhamentoIndividual";
            this.acompanhamentoIndividual.ToolTipText = "Acompanhamento Individual com o usuário";
            this.acompanhamentoIndividual.Width = 95;
            // 
            // observacoesMovivmento
            // 
            this.observacoesMovivmento.HeaderText = "Obeservações";
            this.observacoesMovivmento.MinimumWidth = 6;
            this.observacoesMovivmento.Name = "observacoesMovivmento";
            this.observacoesMovivmento.Width = 600;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(819, 30);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(131, 42);
            this.btBuscar.TabIndex = 59;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscar.Location = new System.Drawing.Point(429, 68);
            this.panelBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(383, 2);
            this.panelBuscar.TabIndex = 60;
            // 
            // tbBuscar
            // 
            this.tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscar.Location = new System.Drawing.Point(469, 44);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(343, 20);
            this.tbBuscar.TabIndex = 58;
            this.tbBuscar.Text = "Digite o nome do Usuário ou CPF ...";
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            this.tbBuscar.Enter += new System.EventHandler(this.tbBuscar_Enter);
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscar_KeyPress);
            this.tbBuscar.Leave += new System.EventHandler(this.tbBuscar_Leave);
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = global::Apresentacao.Properties.Resources.CrediarioPendenteAviso;
            this.pbBuscar.Location = new System.Drawing.Point(429, 30);
            this.pbBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(35, 36);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 61;
            this.pbBuscar.TabStop = false;
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbDataFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDataFinal.Location = new System.Drawing.Point(1831, 11);
            this.lbDataFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(55, 24);
            this.lbDataFinal.TabIndex = 211;
            this.lbDataFinal.Text = "Final";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(1836, 38);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(163, 30);
            this.dtpDataFinal.TabIndex = 212;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataInicial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(1664, 38);
            this.dtpDataInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(163, 30);
            this.dtpDataInicial.TabIndex = 210;
            // 
            // lbdataInicial
            // 
            this.lbdataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbdataInicial.AutoSize = true;
            this.lbdataInicial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbdataInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbdataInicial.Location = new System.Drawing.Point(1659, 11);
            this.lbdataInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdataInicial.Name = "lbdataInicial";
            this.lbdataInicial.Size = new System.Drawing.Size(60, 24);
            this.lbdataInicial.TabIndex = 209;
            this.lbdataInicial.Text = "Inicio";
            // 
            // pbFiltrar
            // 
            this.pbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFiltrar.Image = global::Apresentacao.Properties.Resources.FiltroImg;
            this.pbFiltrar.Location = new System.Drawing.Point(2008, 37);
            this.pbFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.pbFiltrar.Name = "pbFiltrar";
            this.pbFiltrar.Size = new System.Drawing.Size(40, 33);
            this.pbFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFiltrar.TabIndex = 213;
            this.pbFiltrar.TabStop = false;
            this.pbFiltrar.Click += new System.EventHandler(this.pbFiltrar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.DeepPink;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlterar.Location = new System.Drawing.Point(151, 891);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(131, 42);
            this.btAlterar.TabIndex = 215;
            this.btAlterar.Text = "F4 Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(15, 891);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(131, 42);
            this.btCadastrar.TabIndex = 214;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(1917, 891);
            this.btSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(131, 42);
            this.btSair.TabIndex = 216;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            // 
            // btBuscarFuncionario
            // 
            this.btBuscarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscarFuncionario.FlatAppearance.BorderSize = 0;
            this.btBuscarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarFuncionario.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscarFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscarFuncionario.Location = new System.Drawing.Point(343, 31);
            this.btBuscarFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBuscarFuncionario.Name = "btBuscarFuncionario";
            this.btBuscarFuncionario.Size = new System.Drawing.Size(81, 42);
            this.btBuscarFuncionario.TabIndex = 324;
            this.btBuscarFuncionario.Text = "Buscar";
            this.btBuscarFuncionario.UseVisualStyleBackColor = false;
            this.btBuscarFuncionario.Click += new System.EventHandler(this.btBuscarFuncionario_Click);
            // 
            // panelBuscarFuncionario
            // 
            this.panelBuscarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarFuncionario.Location = new System.Drawing.Point(15, 68);
            this.panelBuscarFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBuscarFuncionario.Name = "panelBuscarFuncionario";
            this.panelBuscarFuncionario.Size = new System.Drawing.Size(323, 2);
            this.panelBuscarFuncionario.TabIndex = 325;
            // 
            // tbFuncionario
            // 
            this.tbFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFuncionario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbFuncionario.Location = new System.Drawing.Point(55, 44);
            this.tbFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFuncionario.Name = "tbFuncionario";
            this.tbFuncionario.Size = new System.Drawing.Size(283, 20);
            this.tbFuncionario.TabIndex = 323;
            this.tbFuncionario.Text = "Digite o nome do funcionário ...";
            this.tbFuncionario.Enter += new System.EventHandler(this.tbFuncionario_Enter);
            this.tbFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFuncionario_KeyPress);
            this.tbFuncionario.Leave += new System.EventHandler(this.tbFuncionario_Leave);
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Image = global::Apresentacao.Properties.Resources.FuncionarioAzul;
            this.pbFuncionario.Location = new System.Drawing.Point(15, 30);
            this.pbFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(35, 36);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncionario.TabIndex = 326;
            this.pbFuncionario.TabStop = false;
            // 
            // FrmSelecionarMovimentoDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 946);
            this.Controls.Add(this.btBuscarFuncionario);
            this.Controls.Add(this.panelBuscarFuncionario);
            this.Controls.Add(this.tbFuncionario);
            this.Controls.Add(this.pbFuncionario);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.lbDataFinal);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.lbdataInicial);
            this.Controls.Add(this.pbFiltrar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.dgvSelecionar);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmSelecionarMovimentoDiario";
            this.Text = "Movimento Diário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSelecionarMovimentoDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelecionar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label lbdataInicial;
        private System.Windows.Forms.PictureBox pbFiltrar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btBuscarFuncionario;
        private System.Windows.Forms.Panel panelBuscarFuncionario;
        private System.Windows.Forms.TextBox tbFuncionario;
        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMovimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataMovimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn prontuarioMovimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeCriancas;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeAdolecentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeIdosos;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitaMovimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encaminhamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn beneficioConcedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn inseridoPaif;
        private System.Windows.Forms.DataGridViewTextBoxColumn acompanhamentoIndividual;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesMovivmento;
    }
}