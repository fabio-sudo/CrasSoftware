namespace Apresentacao
{
    partial class FrmAgenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            this.cbFalta = new System.Windows.Forms.CheckBox();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.lbdataInicial = new System.Windows.Forms.Label();
            this.pbFiltrar = new System.Windows.Forms.PictureBox();
            this.cbAtendidoBusca = new System.Windows.Forms.CheckBox();
            this.cbAgendadoBusca = new System.Windows.Forms.CheckBox();
            this.btBuscarAgenda = new System.Windows.Forms.Button();
            this.panelBuscarFuncionario = new System.Windows.Forms.Panel();
            this.tbBuscarFuncionario = new System.Windows.Forms.TextBox();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.codigoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbAgendaFuncionario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgendaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFalta
            // 
            this.cbFalta.AutoSize = true;
            this.cbFalta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cbFalta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cbFalta.Location = new System.Drawing.Point(621, 37);
            this.cbFalta.Name = "cbFalta";
            this.cbFalta.Size = new System.Drawing.Size(76, 23);
            this.cbFalta.TabIndex = 197;
            this.cbFalta.Text = "Faltou";
            this.cbFalta.UseVisualStyleBackColor = true;
            this.cbFalta.CheckedChanged += new System.EventHandler(this.cbFalta_CheckedChanged);
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btImprimir.BackColor = System.Drawing.Color.Yellow;
            this.btImprimir.FlatAppearance.BorderSize = 0;
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btImprimir.ForeColor = System.Drawing.Color.Black;
            this.btImprimir.Location = new System.Drawing.Point(214, 518);
            this.btImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(98, 34);
            this.btImprimir.TabIndex = 206;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSelecionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSelecionar.FlatAppearance.BorderSize = 0;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionar.Location = new System.Drawing.Point(112, 518);
            this.btSelecionar.Margin = new System.Windows.Forms.Padding(2);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(98, 34);
            this.btSelecionar.TabIndex = 205;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(10, 518);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(98, 34);
            this.btCadastrar.TabIndex = 203;
            this.btCadastrar.Text = "F10 Agendar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbDataFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDataFinal.Location = new System.Drawing.Point(964, 12);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(46, 19);
            this.lbDataFinal.TabIndex = 200;
            this.lbDataFinal.Text = "Final";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dtpDataFinal.Location = new System.Drawing.Point(968, 35);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(251, 26);
            this.dtpDataFinal.TabIndex = 201;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataInicial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dtpDataInicial.Location = new System.Drawing.Point(711, 35);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(251, 26);
            this.dtpDataInicial.TabIndex = 199;
            // 
            // lbdataInicial
            // 
            this.lbdataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbdataInicial.AutoSize = true;
            this.lbdataInicial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbdataInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbdataInicial.Location = new System.Drawing.Point(707, 12);
            this.lbdataInicial.Name = "lbdataInicial";
            this.lbdataInicial.Size = new System.Drawing.Size(50, 19);
            this.lbdataInicial.TabIndex = 198;
            this.lbdataInicial.Text = "Inicio";
            // 
            // pbFiltrar
            // 
            this.pbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFiltrar.Image = global::Apresentacao.Properties.Resources.FiltroImg;
            this.pbFiltrar.Location = new System.Drawing.Point(1225, 35);
            this.pbFiltrar.Name = "pbFiltrar";
            this.pbFiltrar.Size = new System.Drawing.Size(30, 27);
            this.pbFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFiltrar.TabIndex = 208;
            this.pbFiltrar.TabStop = false;
            // 
            // cbAtendidoBusca
            // 
            this.cbAtendidoBusca.AutoSize = true;
            this.cbAtendidoBusca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cbAtendidoBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cbAtendidoBusca.Location = new System.Drawing.Point(518, 37);
            this.cbAtendidoBusca.Name = "cbAtendidoBusca";
            this.cbAtendidoBusca.Size = new System.Drawing.Size(97, 23);
            this.cbAtendidoBusca.TabIndex = 196;
            this.cbAtendidoBusca.Text = "Atendido";
            this.cbAtendidoBusca.UseVisualStyleBackColor = true;
            this.cbAtendidoBusca.CheckedChanged += new System.EventHandler(this.cbAtendidoBusca_CheckedChanged);
            // 
            // cbAgendadoBusca
            // 
            this.cbAgendadoBusca.AutoSize = true;
            this.cbAgendadoBusca.Checked = true;
            this.cbAgendadoBusca.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAgendadoBusca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cbAgendadoBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cbAgendadoBusca.Location = new System.Drawing.Point(405, 37);
            this.cbAgendadoBusca.Name = "cbAgendadoBusca";
            this.cbAgendadoBusca.Size = new System.Drawing.Size(107, 23);
            this.cbAgendadoBusca.TabIndex = 195;
            this.cbAgendadoBusca.Text = "Agendado";
            this.cbAgendadoBusca.UseVisualStyleBackColor = true;
            this.cbAgendadoBusca.CheckedChanged += new System.EventHandler(this.cbAgendadoBusca_CheckedChanged);
            // 
            // btBuscarAgenda
            // 
            this.btBuscarAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscarAgenda.FlatAppearance.BorderSize = 0;
            this.btBuscarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarAgenda.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscarAgenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscarAgenda.Location = new System.Drawing.Point(302, 27);
            this.btBuscarAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscarAgenda.Name = "btBuscarAgenda";
            this.btBuscarAgenda.Size = new System.Drawing.Size(98, 34);
            this.btBuscarAgenda.TabIndex = 194;
            this.btBuscarAgenda.Text = "F5 Buscar";
            this.btBuscarAgenda.UseVisualStyleBackColor = false;
            this.btBuscarAgenda.Click += new System.EventHandler(this.btBuscarAgenda_Click);
            // 
            // panelBuscarFuncionario
            // 
            this.panelBuscarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarFuncionario.Location = new System.Drawing.Point(10, 58);
            this.panelBuscarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.panelBuscarFuncionario.Name = "panelBuscarFuncionario";
            this.panelBuscarFuncionario.Size = new System.Drawing.Size(287, 2);
            this.panelBuscarFuncionario.TabIndex = 202;
            // 
            // tbBuscarFuncionario
            // 
            this.tbBuscarFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarFuncionario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscarFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarFuncionario.Location = new System.Drawing.Point(40, 39);
            this.tbBuscarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.tbBuscarFuncionario.Name = "tbBuscarFuncionario";
            this.tbBuscarFuncionario.Size = new System.Drawing.Size(257, 19);
            this.tbBuscarFuncionario.TabIndex = 193;
            this.tbBuscarFuncionario.Text = "Digite o nome do funcionário ...";
            this.tbBuscarFuncionario.Enter += new System.EventHandler(this.tbBuscarFuncionario_Enter);
            this.tbBuscarFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarFuncionario_KeyPress);
            this.tbBuscarFuncionario.Leave += new System.EventHandler(this.tbBuscarFuncionario_Leave);
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvAgenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgenda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoFuncionario,
            this.dataAtendimento,
            this.horarioInicial,
            this.horarioFinal,
            this.nomeFuncionario,
            this.sobrenomeFuncionario,
            this.nomeCliente,
            this.sobrenomeCliente,
            this.celularCliente,
            this.situacaoCliente,
            this.estatusAtendimento});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgenda.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAgenda.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAgenda.Location = new System.Drawing.Point(10, 65);
            this.dgvAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvAgenda.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAgenda.RowTemplate.Height = 24;
            this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgenda.Size = new System.Drawing.Size(1245, 449);
            this.dgvAgenda.TabIndex = 204;
            this.dgvAgenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellDoubleClick);
            // 
            // codigoFuncionario
            // 
            this.codigoFuncionario.HeaderText = "Cód";
            this.codigoFuncionario.Name = "codigoFuncionario";
            this.codigoFuncionario.ReadOnly = true;
            this.codigoFuncionario.ToolTipText = "Código do  Funcionário";
            this.codigoFuncionario.Width = 50;
            // 
            // dataAtendimento
            // 
            dataGridViewCellStyle3.Format = "MMMM d dddd ";
            this.dataAtendimento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataAtendimento.HeaderText = "Data";
            this.dataAtendimento.Name = "dataAtendimento";
            this.dataAtendimento.ReadOnly = true;
            this.dataAtendimento.ToolTipText = "Data do Atendimento";
            this.dataAtendimento.Width = 180;
            // 
            // horarioInicial
            // 
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.horarioInicial.DefaultCellStyle = dataGridViewCellStyle4;
            this.horarioInicial.HeaderText = "H.Ínicio";
            this.horarioInicial.Name = "horarioInicial";
            this.horarioInicial.ReadOnly = true;
            this.horarioInicial.ToolTipText = "Hórario Agendamento Inicial";
            // 
            // horarioFinal
            // 
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = null;
            this.horarioFinal.DefaultCellStyle = dataGridViewCellStyle5;
            this.horarioFinal.HeaderText = "H.Final";
            this.horarioFinal.Name = "horarioFinal";
            this.horarioFinal.ReadOnly = true;
            this.horarioFinal.ToolTipText = "Hórario Agendamento Final";
            // 
            // nomeFuncionario
            // 
            this.nomeFuncionario.HeaderText = "Funcionário";
            this.nomeFuncionario.Name = "nomeFuncionario";
            this.nomeFuncionario.ReadOnly = true;
            this.nomeFuncionario.ToolTipText = "Nome do Funcionário";
            this.nomeFuncionario.Width = 150;
            // 
            // sobrenomeFuncionario
            // 
            this.sobrenomeFuncionario.HeaderText = "Sobrenome";
            this.sobrenomeFuncionario.Name = "sobrenomeFuncionario";
            this.sobrenomeFuncionario.ReadOnly = true;
            this.sobrenomeFuncionario.ToolTipText = "Sobrenome do Funcionário";
            this.sobrenomeFuncionario.Width = 120;
            // 
            // nomeCliente
            // 
            this.nomeCliente.HeaderText = "Cliente";
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            this.nomeCliente.Width = 150;
            // 
            // sobrenomeCliente
            // 
            this.sobrenomeCliente.HeaderText = "Sobrenome";
            this.sobrenomeCliente.Name = "sobrenomeCliente";
            this.sobrenomeCliente.ReadOnly = true;
            this.sobrenomeCliente.Width = 120;
            // 
            // celularCliente
            // 
            this.celularCliente.HeaderText = "Celular";
            this.celularCliente.Name = "celularCliente";
            this.celularCliente.ReadOnly = true;
            // 
            // situacaoCliente
            // 
            this.situacaoCliente.HeaderText = "Situação";
            this.situacaoCliente.Name = "situacaoCliente";
            this.situacaoCliente.ReadOnly = true;
            // 
            // estatusAtendimento
            // 
            this.estatusAtendimento.HeaderText = "Estatus";
            this.estatusAtendimento.Name = "estatusAtendimento";
            this.estatusAtendimento.ReadOnly = true;
            // 
            // pbAgendaFuncionario
            // 
            this.pbAgendaFuncionario.Image = global::Apresentacao.Properties.Resources.FuncionarioAzul;
            this.pbAgendaFuncionario.Location = new System.Drawing.Point(10, 27);
            this.pbAgendaFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.pbAgendaFuncionario.Name = "pbAgendaFuncionario";
            this.pbAgendaFuncionario.Size = new System.Drawing.Size(26, 29);
            this.pbAgendaFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAgendaFuncionario.TabIndex = 207;
            this.pbAgendaFuncionario.TabStop = false;
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1264, 565);
            this.Controls.Add(this.cbFalta);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbDataFinal);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.lbdataInicial);
            this.Controls.Add(this.pbFiltrar);
            this.Controls.Add(this.cbAtendidoBusca);
            this.Controls.Add(this.cbAgendadoBusca);
            this.Controls.Add(this.btBuscarAgenda);
            this.Controls.Add(this.panelBuscarFuncionario);
            this.Controls.Add(this.tbBuscarFuncionario);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.pbAgendaFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgenda";
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAgenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgendaFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbFalta;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label lbdataInicial;
        private System.Windows.Forms.PictureBox pbFiltrar;
        private System.Windows.Forms.CheckBox cbAtendidoBusca;
        private System.Windows.Forms.CheckBox cbAgendadoBusca;
        private System.Windows.Forms.Button btBuscarAgenda;
        private System.Windows.Forms.Panel panelBuscarFuncionario;
        private System.Windows.Forms.TextBox tbBuscarFuncionario;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusAtendimento;
        private System.Windows.Forms.PictureBox pbAgendaFuncionario;
    }
}