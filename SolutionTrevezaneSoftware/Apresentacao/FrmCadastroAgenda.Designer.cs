namespace Apresentacao
{
    partial class FrmCadastroAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroAgenda));
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.lbDataAgendamento = new System.Windows.Forms.Label();
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
            this.pbAgendaFuncionario = new System.Windows.Forms.PictureBox();
            this.dtpDiaSemana = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.lbSituacao = new System.Windows.Forms.Label();
            this.tbSituacao = new System.Windows.Forms.TextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.tbSobrenome = new System.Windows.Forms.TextBox();
            this.lbSobrenome = new System.Windows.Forms.Label();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.panelFuncionario = new System.Windows.Forms.Panel();
            this.btFuncionario = new System.Windows.Forms.Button();
            this.tbFuncionario = new System.Windows.Forms.TextBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.panelBuscarCliente = new System.Windows.Forms.Panel();
            this.btCliente = new System.Windows.Forms.Button();
            this.tbBuscarCliente = new System.Windows.Forms.TextBox();
            this.lbFinal = new System.Windows.Forms.Label();
            this.lbInicio = new System.Windows.Forms.Label();
            this.lbEstatus = new System.Windows.Forms.Label();
            this.pbTitulo = new System.Windows.Forms.PictureBox();
            this.tbIndice = new System.Windows.Forms.TextBox();
            this.tgAtendido = new CustomControls.RJControls.TouglleControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgendaFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpInicial
            // 
            this.dtpInicial.CustomFormat = "HH:mm";
            this.dtpInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicial.Location = new System.Drawing.Point(218, 87);
            this.dtpInicial.Margin = new System.Windows.Forms.Padding(2);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(66, 23);
            this.dtpInicial.TabIndex = 183;
            this.dtpInicial.ValueChanged += new System.EventHandler(this.dtpInicial_ValueChanged);
            // 
            // lbDataAgendamento
            // 
            this.lbDataAgendamento.AutoSize = true;
            this.lbDataAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataAgendamento.Location = new System.Drawing.Point(15, 68);
            this.lbDataAgendamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataAgendamento.Name = "lbDataAgendamento";
            this.lbDataAgendamento.Size = new System.Drawing.Size(130, 17);
            this.lbDataAgendamento.TabIndex = 180;
            this.lbDataAgendamento.Text = "Data Agendamento";
            // 
            // cbAtendidoBusca
            // 
            this.cbAtendidoBusca.AutoSize = true;
            this.cbAtendidoBusca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cbAtendidoBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cbAtendidoBusca.Location = new System.Drawing.Point(865, 91);
            this.cbAtendidoBusca.Name = "cbAtendidoBusca";
            this.cbAtendidoBusca.Size = new System.Drawing.Size(97, 23);
            this.cbAtendidoBusca.TabIndex = 203;
            this.cbAtendidoBusca.Text = "Atendido";
            this.cbAtendidoBusca.UseVisualStyleBackColor = true;
            // 
            // cbAgendadoBusca
            // 
            this.cbAgendadoBusca.AutoSize = true;
            this.cbAgendadoBusca.Checked = true;
            this.cbAgendadoBusca.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAgendadoBusca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cbAgendadoBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cbAgendadoBusca.Location = new System.Drawing.Point(752, 91);
            this.cbAgendadoBusca.Name = "cbAgendadoBusca";
            this.cbAgendadoBusca.Size = new System.Drawing.Size(107, 23);
            this.cbAgendadoBusca.TabIndex = 202;
            this.cbAgendadoBusca.Text = "Agendado";
            this.cbAgendadoBusca.UseVisualStyleBackColor = true;
            // 
            // btBuscarAgenda
            // 
            this.btBuscarAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscarAgenda.FlatAppearance.BorderSize = 0;
            this.btBuscarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarAgenda.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscarAgenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscarAgenda.Location = new System.Drawing.Point(649, 80);
            this.btBuscarAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscarAgenda.Name = "btBuscarAgenda";
            this.btBuscarAgenda.Size = new System.Drawing.Size(98, 34);
            this.btBuscarAgenda.TabIndex = 201;
            this.btBuscarAgenda.Text = "F5 Buscar";
            this.btBuscarAgenda.UseVisualStyleBackColor = false;
            this.btBuscarAgenda.Click += new System.EventHandler(this.btBuscarAgenda_Click);
            // 
            // panelBuscarFuncionario
            // 
            this.panelBuscarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarFuncionario.Location = new System.Drawing.Point(358, 112);
            this.panelBuscarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.panelBuscarFuncionario.Name = "panelBuscarFuncionario";
            this.panelBuscarFuncionario.Size = new System.Drawing.Size(287, 2);
            this.panelBuscarFuncionario.TabIndex = 204;
            // 
            // tbBuscarFuncionario
            // 
            this.tbBuscarFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarFuncionario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscarFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarFuncionario.Location = new System.Drawing.Point(388, 93);
            this.tbBuscarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.tbBuscarFuncionario.Name = "tbBuscarFuncionario";
            this.tbBuscarFuncionario.Size = new System.Drawing.Size(257, 19);
            this.tbBuscarFuncionario.TabIndex = 200;
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
            this.sobrenomeCliente});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgenda.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAgenda.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAgenda.Location = new System.Drawing.Point(358, 120);
            this.dgvAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvAgenda.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAgenda.RowTemplate.Height = 24;
            this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgenda.Size = new System.Drawing.Size(994, 382);
            this.dgvAgenda.TabIndex = 205;
            // 
            // codigoFuncionario
            // 
            this.codigoFuncionario.HeaderText = "Cód";
            this.codigoFuncionario.Name = "codigoFuncionario";
            this.codigoFuncionario.ReadOnly = true;
            this.codigoFuncionario.ToolTipText = "Código do  Funcionário";
            this.codigoFuncionario.Visible = false;
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
            // pbAgendaFuncionario
            // 
            this.pbAgendaFuncionario.Image = global::Apresentacao.Properties.Resources.FuncionarioAzul;
            this.pbAgendaFuncionario.Location = new System.Drawing.Point(358, 81);
            this.pbAgendaFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.pbAgendaFuncionario.Name = "pbAgendaFuncionario";
            this.pbAgendaFuncionario.Size = new System.Drawing.Size(26, 29);
            this.pbAgendaFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAgendaFuncionario.TabIndex = 209;
            this.pbAgendaFuncionario.TabStop = false;
            // 
            // dtpDiaSemana
            // 
            this.dtpDiaSemana.CustomFormat = "MMMM d dddd ";
            this.dtpDiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpDiaSemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDiaSemana.Location = new System.Drawing.Point(15, 87);
            this.dtpDiaSemana.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDiaSemana.Name = "dtpDiaSemana";
            this.dtpDiaSemana.Size = new System.Drawing.Size(199, 23);
            this.dtpDiaSemana.TabIndex = 181;
            // 
            // dtpFinal
            // 
            this.dtpFinal.CustomFormat = "HH:mm";
            this.dtpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinal.Location = new System.Drawing.Point(288, 87);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(66, 23);
            this.dtpFinal.TabIndex = 185;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(15, 468);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(98, 34);
            this.btCadastrar.TabIndex = 198;
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
            this.btSair.Location = new System.Drawing.Point(233, 468);
            this.btSair.Margin = new System.Windows.Forms.Padding(2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 34);
            this.btSair.TabIndex = 199;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbSituacao
            // 
            this.lbSituacao.AutoSize = true;
            this.lbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSituacao.Location = new System.Drawing.Point(12, 415);
            this.lbSituacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSituacao.Name = "lbSituacao";
            this.lbSituacao.Size = new System.Drawing.Size(63, 17);
            this.lbSituacao.TabIndex = 197;
            this.lbSituacao.Text = "Situação";
            // 
            // tbSituacao
            // 
            this.tbSituacao.Location = new System.Drawing.Point(99, 287);
            this.tbSituacao.Multiline = true;
            this.tbSituacao.Name = "tbSituacao";
            this.tbSituacao.Size = new System.Drawing.Size(232, 145);
            this.tbSituacao.TabIndex = 196;
            // 
            // mtbCelular
            // 
            this.mtbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCelular.Location = new System.Drawing.Point(99, 254);
            this.mtbCelular.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCelular.Mask = "(99) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(232, 23);
            this.mtbCelular.TabIndex = 195;
            this.mtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular.Location = new System.Drawing.Point(12, 260);
            this.lbCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(52, 17);
            this.lbCelular.TabIndex = 194;
            this.lbCelular.Text = "Celular";
            // 
            // tbSobrenome
            // 
            this.tbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSobrenome.Location = new System.Drawing.Point(99, 223);
            this.tbSobrenome.Margin = new System.Windows.Forms.Padding(2);
            this.tbSobrenome.Name = "tbSobrenome";
            this.tbSobrenome.Size = new System.Drawing.Size(232, 23);
            this.tbSobrenome.TabIndex = 193;
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSobrenome.Location = new System.Drawing.Point(12, 227);
            this.lbSobrenome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(81, 17);
            this.lbSobrenome.TabIndex = 192;
            this.lbSobrenome.Text = "Sobrenome";
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Image = global::Apresentacao.Properties.Resources.FuncionarioAzul;
            this.pbFuncionario.Location = new System.Drawing.Point(15, 126);
            this.pbFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(26, 28);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncionario.TabIndex = 208;
            this.pbFuncionario.TabStop = false;
            // 
            // panelFuncionario
            // 
            this.panelFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelFuncionario.Location = new System.Drawing.Point(15, 156);
            this.panelFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.panelFuncionario.Name = "panelFuncionario";
            this.panelFuncionario.Size = new System.Drawing.Size(258, 2);
            this.panelFuncionario.TabIndex = 188;
            // 
            // btFuncionario
            // 
            this.btFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionario.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.btFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFuncionario.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btFuncionario.ImageKey = "Cliente.png";
            this.btFuncionario.Location = new System.Drawing.Point(276, 124);
            this.btFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btFuncionario.Name = "btFuncionario";
            this.btFuncionario.Size = new System.Drawing.Size(55, 34);
            this.btFuncionario.TabIndex = 187;
            this.btFuncionario.Text = "Buscar";
            this.btFuncionario.UseVisualStyleBackColor = false;
            this.btFuncionario.Click += new System.EventHandler(this.btFuncionario_Click);
            // 
            // tbFuncionario
            // 
            this.tbFuncionario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFuncionario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbFuncionario.Location = new System.Drawing.Point(45, 136);
            this.tbFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.tbFuncionario.Name = "tbFuncionario";
            this.tbFuncionario.Size = new System.Drawing.Size(226, 16);
            this.tbFuncionario.TabIndex = 186;
            this.tbFuncionario.Text = "Digite o nome do funcionário ...";
            this.tbFuncionario.Enter += new System.EventHandler(this.tbFuncionario_Enter);
            this.tbFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFuncionario_KeyPress);
            this.tbFuncionario.Leave += new System.EventHandler(this.tbBuscarFuncionario_Leave);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::Apresentacao.Properties.Resources.ClienteAzul;
            this.pbUsuario.Location = new System.Drawing.Point(15, 178);
            this.pbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(26, 29);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 207;
            this.pbUsuario.TabStop = false;
            // 
            // panelBuscarCliente
            // 
            this.panelBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarCliente.Location = new System.Drawing.Point(15, 209);
            this.panelBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.panelBuscarCliente.Name = "panelBuscarCliente";
            this.panelBuscarCliente.Size = new System.Drawing.Size(258, 2);
            this.panelBuscarCliente.TabIndex = 191;
            // 
            // btCliente
            // 
            this.btCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.btCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btCliente.ImageKey = "Cliente.png";
            this.btCliente.Location = new System.Drawing.Point(276, 176);
            this.btCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(55, 34);
            this.btCliente.TabIndex = 190;
            this.btCliente.Text = "Buscar";
            this.btCliente.UseVisualStyleBackColor = false;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // tbBuscarCliente
            // 
            this.tbBuscarCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarCliente.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarCliente.Location = new System.Drawing.Point(45, 190);
            this.tbBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbBuscarCliente.Name = "tbBuscarCliente";
            this.tbBuscarCliente.Size = new System.Drawing.Size(226, 16);
            this.tbBuscarCliente.TabIndex = 189;
            this.tbBuscarCliente.Text = "Digite o nome do cliente ...";
            this.tbBuscarCliente.Enter += new System.EventHandler(this.tbBuscarCliente_Enter);
            this.tbBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarCliente_KeyPress);
            this.tbBuscarCliente.Leave += new System.EventHandler(this.tbBuscarCliente_Leave);
            // 
            // lbFinal
            // 
            this.lbFinal.AutoSize = true;
            this.lbFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinal.Location = new System.Drawing.Point(285, 68);
            this.lbFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(38, 17);
            this.lbFinal.TabIndex = 184;
            this.lbFinal.Text = "Final";
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInicio.Location = new System.Drawing.Point(215, 68);
            this.lbInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(40, 17);
            this.lbInicio.TabIndex = 182;
            this.lbInicio.Text = "Início";
            // 
            // lbEstatus
            // 
            this.lbEstatus.AutoSize = true;
            this.lbEstatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbEstatus.Location = new System.Drawing.Point(96, 38);
            this.lbEstatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstatus.Name = "lbEstatus";
            this.lbEstatus.Size = new System.Drawing.Size(71, 15);
            this.lbEstatus.TabIndex = 179;
            this.lbEstatus.Text = "AGENDADO";
            // 
            // pbTitulo
            // 
            this.pbTitulo.Image = global::Apresentacao.Properties.Resources.calendario_64;
            this.pbTitulo.Location = new System.Drawing.Point(15, 11);
            this.pbTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pbTitulo.Name = "pbTitulo";
            this.pbTitulo.Size = new System.Drawing.Size(39, 42);
            this.pbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTitulo.TabIndex = 206;
            this.pbTitulo.TabStop = false;
            // 
            // tbIndice
            // 
            this.tbIndice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbIndice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIndice.Font = new System.Drawing.Font("Arial", 8F);
            this.tbIndice.Location = new System.Drawing.Point(1122, 16);
            this.tbIndice.Multiline = true;
            this.tbIndice.Name = "tbIndice";
            this.tbIndice.Size = new System.Drawing.Size(229, 99);
            this.tbIndice.TabIndex = 210;
            this.tbIndice.Text = "Terça:\r\nMonica Manhã 08:00 as 11:00 Tarde: 13:00 as 16:00\r\nKarina  Manhã 08:00 as" +
    " 12:00\r\nMarcela Manhã 08:30 as 14:30\r\nDayane Manhã 08:00 as 12:00\r\n\r\n";
            // 
            // tgAtendido
            // 
            this.tgAtendido.AutoSize = true;
            this.tgAtendido.Enabled = false;
            this.tgAtendido.Location = new System.Drawing.Point(58, 35);
            this.tgAtendido.Margin = new System.Windows.Forms.Padding(2);
            this.tgAtendido.MinimumSize = new System.Drawing.Size(34, 18);
            this.tgAtendido.Name = "tgAtendido";
            this.tgAtendido.OffBackColor = System.Drawing.Color.Gray;
            this.tgAtendido.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgAtendido.OnBackColor = System.Drawing.Color.DeepPink;
            this.tgAtendido.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgAtendido.Size = new System.Drawing.Size(34, 18);
            this.tgAtendido.TabIndex = 178;
            this.tgAtendido.UseVisualStyleBackColor = true;
            this.tgAtendido.Click += new System.EventHandler(this.tgAtendido_Click_1);
            // 
            // FrmCadastroAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1363, 513);
            this.Controls.Add(this.tbIndice);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.lbDataAgendamento);
            this.Controls.Add(this.cbAtendidoBusca);
            this.Controls.Add(this.cbAgendadoBusca);
            this.Controls.Add(this.btBuscarAgenda);
            this.Controls.Add(this.panelBuscarFuncionario);
            this.Controls.Add(this.tbBuscarFuncionario);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.pbAgendaFuncionario);
            this.Controls.Add(this.dtpDiaSemana);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.lbSituacao);
            this.Controls.Add(this.tbSituacao);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.tbSobrenome);
            this.Controls.Add(this.lbSobrenome);
            this.Controls.Add(this.pbFuncionario);
            this.Controls.Add(this.panelFuncionario);
            this.Controls.Add(this.btFuncionario);
            this.Controls.Add(this.tbFuncionario);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.panelBuscarCliente);
            this.Controls.Add(this.btCliente);
            this.Controls.Add(this.tbBuscarCliente);
            this.Controls.Add(this.lbFinal);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.lbEstatus);
            this.Controls.Add(this.tgAtendido);
            this.Controls.Add(this.pbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmCadastroAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Agenda";
            this.Load += new System.EventHandler(this.FrmCadastroAgenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroAgenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgendaFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label lbDataAgendamento;
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
        private System.Windows.Forms.PictureBox pbAgendaFuncionario;
        private System.Windows.Forms.DateTimePicker dtpDiaSemana;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lbSituacao;
        private System.Windows.Forms.TextBox tbSituacao;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.TextBox tbSobrenome;
        private System.Windows.Forms.Label lbSobrenome;
        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.Panel panelFuncionario;
        private System.Windows.Forms.Button btFuncionario;
        private System.Windows.Forms.TextBox tbFuncionario;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Panel panelBuscarCliente;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.TextBox tbBuscarCliente;
        private System.Windows.Forms.Label lbFinal;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.Label lbEstatus;
        private CustomControls.RJControls.TouglleControl tgAtendido;
        private System.Windows.Forms.PictureBox pbTitulo;
        private System.Windows.Forms.TextBox tbIndice;

    }
}