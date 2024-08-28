namespace Apresentacao
{
    partial class FrmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.codigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroProntuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nisCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.tbBuscarCliente = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panelBuscarCliente = new System.Windows.Forms.Panel();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.pbFiltrar = new System.Windows.Forms.PictureBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.btImprimir = new System.Windows.Forms.Button();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.cbInativo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCliente,
            this.numeroProntuario,
            this.nisCliente,
            this.nomeCliente,
            this.sobrenomeCliente,
            this.sexoCliente,
            this.rgCliente,
            this.cpfCliente,
            this.dataNascimento,
            this.enderecoCliente,
            this.bairroCliente,
            this.numeroCliente,
            this.cepCliente,
            this.cidadeCliente,
            this.estadoCliente,
            this.telefoneCliente,
            this.celularCliente,
            this.emailCliente,
            this.estatusCliente,
            this.observacaoCliente});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCliente.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCliente.Location = new System.Drawing.Point(9, 65);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(810, 457);
            this.dgvCliente.TabIndex = 2;
            this.dgvCliente.DoubleClick += new System.EventHandler(this.dgvCliente_DoubleClick);
            // 
            // codigoCliente
            // 
            this.codigoCliente.HeaderText = "Cód";
            this.codigoCliente.Name = "codigoCliente";
            this.codigoCliente.ReadOnly = true;
            this.codigoCliente.ToolTipText = "Código";
            this.codigoCliente.Width = 50;
            // 
            // numeroProntuario
            // 
            this.numeroProntuario.DataPropertyName = "numeroProntuario";
            this.numeroProntuario.HeaderText = "Prontuário";
            this.numeroProntuario.Name = "numeroProntuario";
            this.numeroProntuario.ReadOnly = true;
            this.numeroProntuario.ToolTipText = "Prontuário do Cliente";
            this.numeroProntuario.Width = 90;
            // 
            // nisCliente
            // 
            this.nisCliente.DataPropertyName = "nisCliente";
            this.nisCliente.HeaderText = "NIS";
            this.nisCliente.Name = "nisCliente";
            this.nisCliente.ReadOnly = true;
            this.nisCliente.ToolTipText = "Cád Único NIS";
            // 
            // nomeCliente
            // 
            this.nomeCliente.HeaderText = "Nome";
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            this.nomeCliente.ToolTipText = "Nome ";
            this.nomeCliente.Width = 150;
            // 
            // sobrenomeCliente
            // 
            this.sobrenomeCliente.HeaderText = "Sobrenome";
            this.sobrenomeCliente.Name = "sobrenomeCliente";
            this.sobrenomeCliente.ReadOnly = true;
            this.sobrenomeCliente.ToolTipText = "Sobrenome";
            this.sobrenomeCliente.Width = 130;
            // 
            // sexoCliente
            // 
            this.sexoCliente.HeaderText = "Sexo";
            this.sexoCliente.Name = "sexoCliente";
            this.sexoCliente.ReadOnly = true;
            this.sexoCliente.ToolTipText = "Sexo ";
            this.sexoCliente.Width = 90;
            // 
            // rgCliente
            // 
            this.rgCliente.HeaderText = "RG";
            this.rgCliente.Name = "rgCliente";
            this.rgCliente.ReadOnly = true;
            this.rgCliente.ToolTipText = "RG ";
            this.rgCliente.Width = 80;
            // 
            // cpfCliente
            // 
            this.cpfCliente.HeaderText = "CPF";
            this.cpfCliente.Name = "cpfCliente";
            this.cpfCliente.ReadOnly = true;
            this.cpfCliente.ToolTipText = "CPF";
            this.cpfCliente.Width = 80;
            // 
            // dataNascimento
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataNascimento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataNascimento.HeaderText = "Nascimento";
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.ReadOnly = true;
            this.dataNascimento.ToolTipText = "Data de Nascimento";
            this.dataNascimento.Width = 90;
            // 
            // enderecoCliente
            // 
            this.enderecoCliente.HeaderText = "Endereço";
            this.enderecoCliente.Name = "enderecoCliente";
            this.enderecoCliente.ReadOnly = true;
            this.enderecoCliente.ToolTipText = "Endereço";
            this.enderecoCliente.Width = 200;
            // 
            // bairroCliente
            // 
            this.bairroCliente.HeaderText = "Bairro";
            this.bairroCliente.Name = "bairroCliente";
            this.bairroCliente.ReadOnly = true;
            this.bairroCliente.ToolTipText = "Bairro";
            this.bairroCliente.Width = 90;
            // 
            // numeroCliente
            // 
            this.numeroCliente.HeaderText = "Número";
            this.numeroCliente.Name = "numeroCliente";
            this.numeroCliente.ReadOnly = true;
            this.numeroCliente.ToolTipText = "Número";
            this.numeroCliente.Width = 70;
            // 
            // cepCliente
            // 
            this.cepCliente.HeaderText = "CEP";
            this.cepCliente.Name = "cepCliente";
            this.cepCliente.ReadOnly = true;
            this.cepCliente.ToolTipText = "CEP";
            this.cepCliente.Width = 80;
            // 
            // cidadeCliente
            // 
            this.cidadeCliente.HeaderText = "Cidade";
            this.cidadeCliente.Name = "cidadeCliente";
            this.cidadeCliente.ReadOnly = true;
            this.cidadeCliente.ToolTipText = "Cidade";
            // 
            // estadoCliente
            // 
            this.estadoCliente.HeaderText = "Estado";
            this.estadoCliente.Name = "estadoCliente";
            this.estadoCliente.ReadOnly = true;
            this.estadoCliente.ToolTipText = "Estado";
            // 
            // telefoneCliente
            // 
            this.telefoneCliente.HeaderText = "Telefone";
            this.telefoneCliente.Name = "telefoneCliente";
            this.telefoneCliente.ReadOnly = true;
            this.telefoneCliente.ToolTipText = "Telefone ";
            this.telefoneCliente.Width = 90;
            // 
            // celularCliente
            // 
            this.celularCliente.HeaderText = "Celular";
            this.celularCliente.Name = "celularCliente";
            this.celularCliente.ReadOnly = true;
            this.celularCliente.ToolTipText = "Celular";
            this.celularCliente.Width = 90;
            // 
            // emailCliente
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.emailCliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.emailCliente.HeaderText = "Data";
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.ReadOnly = true;
            this.emailCliente.ToolTipText = "Data Cadastro";
            this.emailCliente.Width = 150;
            // 
            // estatusCliente
            // 
            this.estatusCliente.HeaderText = "Estatus";
            this.estatusCliente.Name = "estatusCliente";
            this.estatusCliente.ReadOnly = true;
            // 
            // observacaoCliente
            // 
            this.observacaoCliente.HeaderText = "Observação";
            this.observacaoCliente.Name = "observacaoCliente";
            this.observacaoCliente.ReadOnly = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(9, 527);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(98, 34);
            this.btCadastrar.TabIndex = 3;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // tbBuscarCliente
            // 
            this.tbBuscarCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarCliente.Location = new System.Drawing.Point(39, 38);
            this.tbBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbBuscarCliente.Name = "tbBuscarCliente";
            this.tbBuscarCliente.Size = new System.Drawing.Size(257, 19);
            this.tbBuscarCliente.TabIndex = 0;
            this.tbBuscarCliente.Text = "Digite o nome do cliente ...";
            this.tbBuscarCliente.Enter += new System.EventHandler(this.tbBuscarCliente_Enter);
            this.tbBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarCliente_KeyPress);
            this.tbBuscarCliente.Leave += new System.EventHandler(this.tbBuscarCliente_Leave);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(301, 26);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(98, 34);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // panelBuscarCliente
            // 
            this.panelBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarCliente.Location = new System.Drawing.Point(9, 57);
            this.panelBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.panelBuscarCliente.Name = "panelBuscarCliente";
            this.panelBuscarCliente.Size = new System.Drawing.Size(287, 2);
            this.panelBuscarCliente.TabIndex = 5;
            // 
            // btSelecionar
            // 
            this.btSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSelecionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSelecionar.FlatAppearance.BorderSize = 0;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionar.Location = new System.Drawing.Point(111, 527);
            this.btSelecionar.Margin = new System.Windows.Forms.Padding(2);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(98, 34);
            this.btSelecionar.TabIndex = 4;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::Apresentacao.Properties.Resources.ClienteAzul;
            this.pbUsuario.Location = new System.Drawing.Point(9, 26);
            this.pbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(26, 29);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUsuario.TabIndex = 7;
            this.pbUsuario.TabStop = false;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.mtbCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.mtbCPF.Location = new System.Drawing.Point(614, 35);
            this.mtbCPF.Mask = "999,999,999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(169, 26);
            this.mtbCPF.TabIndex = 8;
            this.mtbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // pbFiltrar
            // 
            this.pbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFiltrar.Image = global::Apresentacao.Properties.Resources.FiltroImg;
            this.pbFiltrar.Location = new System.Drawing.Point(789, 35);
            this.pbFiltrar.Name = "pbFiltrar";
            this.pbFiltrar.Size = new System.Drawing.Size(30, 26);
            this.pbFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFiltrar.TabIndex = 9;
            this.pbFiltrar.TabStop = false;
            this.pbFiltrar.Click += new System.EventHandler(this.pbFiltrar_Click);
            // 
            // lbCPF
            // 
            this.lbCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbCPF.Location = new System.Drawing.Point(566, 42);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(42, 19);
            this.lbCPF.TabIndex = 10;
            this.lbCPF.Text = "CPF";
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btImprimir.BackColor = System.Drawing.Color.Yellow;
            this.btImprimir.FlatAppearance.BorderSize = 0;
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btImprimir.ForeColor = System.Drawing.Color.Black;
            this.btImprimir.Location = new System.Drawing.Point(213, 527);
            this.btImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(98, 34);
            this.btImprimir.TabIndex = 11;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cbAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cbAtivo.Location = new System.Drawing.Point(404, 37);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(67, 23);
            this.cbAtivo.TabIndex = 12;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // cbInativo
            // 
            this.cbInativo.AutoSize = true;
            this.cbInativo.Checked = true;
            this.cbInativo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInativo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cbInativo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cbInativo.Location = new System.Drawing.Point(477, 37);
            this.cbInativo.Name = "cbInativo";
            this.cbInativo.Size = new System.Drawing.Size(112, 23);
            this.cbInativo.TabIndex = 13;
            this.cbInativo.Text = "Bloqueado";
            this.cbInativo.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(829, 577);
            this.Controls.Add(this.cbInativo);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.pbFiltrar);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.panelBuscarCliente);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbBuscarCliente);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dgvCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox tbBuscarCliente;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panelBuscarCliente;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.PictureBox pbFiltrar;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroProntuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nisCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoCliente;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.CheckBox cbInativo;
    }
}