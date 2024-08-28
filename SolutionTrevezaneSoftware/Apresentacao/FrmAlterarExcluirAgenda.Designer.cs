namespace Apresentacao
{
    partial class FrmAlterarExcluirAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterarExcluirAgenda));
            this.cbFaltou = new System.Windows.Forms.CheckBox();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.lbFinal = new System.Windows.Forms.Label();
            this.lbInicio = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.btExcluir = new System.Windows.Forms.Button();
            this.lbDataAgendamento = new System.Windows.Forms.Label();
            this.dtpDiaSemana = new System.Windows.Forms.DateTimePicker();
            this.btAlterar = new System.Windows.Forms.Button();
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
            this.lbEstatus = new System.Windows.Forms.Label();
            this.tgAtendido = new CustomControls.RJControls.TouglleControl();
            this.pbTitulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFaltou
            // 
            this.cbFaltou.AutoSize = true;
            this.cbFaltou.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cbFaltou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cbFaltou.Location = new System.Drawing.Point(268, 30);
            this.cbFaltou.Name = "cbFaltou";
            this.cbFaltou.Size = new System.Drawing.Size(91, 23);
            this.cbFaltou.TabIndex = 252;
            this.cbFaltou.Text = "FALTOU";
            this.cbFaltou.UseVisualStyleBackColor = true;
            this.cbFaltou.CheckedChanged += new System.EventHandler(this.cbFaltou_CheckedChanged);
            // 
            // dtpFinal
            // 
            this.dtpFinal.CustomFormat = "HH:mm";
            this.dtpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinal.Location = new System.Drawing.Point(290, 87);
            this.dtpFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(66, 23);
            this.dtpFinal.TabIndex = 251;
            // 
            // lbFinal
            // 
            this.lbFinal.AutoSize = true;
            this.lbFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinal.Location = new System.Drawing.Point(287, 68);
            this.lbFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(42, 16);
            this.lbFinal.TabIndex = 250;
            this.lbFinal.Text = "Final";
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInicio.Location = new System.Drawing.Point(217, 68);
            this.lbInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(45, 16);
            this.lbInicio.TabIndex = 248;
            this.lbInicio.Text = "Início";
            // 
            // dtpInicial
            // 
            this.dtpInicial.CustomFormat = "HH:mm";
            this.dtpInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicial.Location = new System.Drawing.Point(220, 87);
            this.dtpInicial.Margin = new System.Windows.Forms.Padding(2);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(66, 23);
            this.dtpInicial.TabIndex = 249;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.DeepPink;
            this.btExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExcluir.Location = new System.Drawing.Point(119, 471);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(98, 34);
            this.btExcluir.TabIndex = 247;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // lbDataAgendamento
            // 
            this.lbDataAgendamento.AutoSize = true;
            this.lbDataAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataAgendamento.Location = new System.Drawing.Point(17, 68);
            this.lbDataAgendamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataAgendamento.Name = "lbDataAgendamento";
            this.lbDataAgendamento.Size = new System.Drawing.Size(141, 16);
            this.lbDataAgendamento.TabIndex = 246;
            this.lbDataAgendamento.Text = "Data Agendamento";
            // 
            // dtpDiaSemana
            // 
            this.dtpDiaSemana.CustomFormat = "MMMM d dddd ";
            this.dtpDiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpDiaSemana.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDiaSemana.Location = new System.Drawing.Point(17, 87);
            this.dtpDiaSemana.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDiaSemana.Name = "dtpDiaSemana";
            this.dtpDiaSemana.Size = new System.Drawing.Size(199, 23);
            this.dtpDiaSemana.TabIndex = 228;
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlterar.Location = new System.Drawing.Point(17, 471);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(98, 34);
            this.btAlterar.TabIndex = 241;
            this.btAlterar.Text = "F10 Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(258, 471);
            this.btSair.Margin = new System.Windows.Forms.Padding(2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 34);
            this.btSair.TabIndex = 242;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbSituacao
            // 
            this.lbSituacao.AutoSize = true;
            this.lbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSituacao.Location = new System.Drawing.Point(14, 415);
            this.lbSituacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSituacao.Name = "lbSituacao";
            this.lbSituacao.Size = new System.Drawing.Size(69, 16);
            this.lbSituacao.TabIndex = 239;
            this.lbSituacao.Text = "Situação";
            // 
            // tbSituacao
            // 
            this.tbSituacao.Location = new System.Drawing.Point(88, 287);
            this.tbSituacao.Multiline = true;
            this.tbSituacao.Name = "tbSituacao";
            this.tbSituacao.Size = new System.Drawing.Size(268, 145);
            this.tbSituacao.TabIndex = 240;
            // 
            // mtbCelular
            // 
            this.mtbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCelular.Location = new System.Drawing.Point(121, 254);
            this.mtbCelular.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCelular.Mask = "(99) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(235, 23);
            this.mtbCelular.TabIndex = 238;
            this.mtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular.Location = new System.Drawing.Point(17, 258);
            this.lbCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(57, 16);
            this.lbCelular.TabIndex = 237;
            this.lbCelular.Text = "Celular";
            // 
            // tbSobrenome
            // 
            this.tbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSobrenome.Location = new System.Drawing.Point(121, 223);
            this.tbSobrenome.Margin = new System.Windows.Forms.Padding(2);
            this.tbSobrenome.Name = "tbSobrenome";
            this.tbSobrenome.Size = new System.Drawing.Size(235, 23);
            this.tbSobrenome.TabIndex = 236;
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSobrenome.Location = new System.Drawing.Point(14, 227);
            this.lbSobrenome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(88, 16);
            this.lbSobrenome.TabIndex = 235;
            this.lbSobrenome.Text = "Sobrenome";
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Image = global::Apresentacao.Properties.Resources.FuncionarioAzul;
            this.pbFuncionario.Location = new System.Drawing.Point(17, 126);
            this.pbFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(26, 28);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncionario.TabIndex = 245;
            this.pbFuncionario.TabStop = false;
            // 
            // panelFuncionario
            // 
            this.panelFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelFuncionario.Location = new System.Drawing.Point(17, 156);
            this.panelFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.panelFuncionario.Name = "panelFuncionario";
            this.panelFuncionario.Size = new System.Drawing.Size(258, 2);
            this.panelFuncionario.TabIndex = 231;
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
            this.btFuncionario.Location = new System.Drawing.Point(278, 124);
            this.btFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btFuncionario.Name = "btFuncionario";
            this.btFuncionario.Size = new System.Drawing.Size(78, 34);
            this.btFuncionario.TabIndex = 230;
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
            this.tbFuncionario.Location = new System.Drawing.Point(47, 136);
            this.tbFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.tbFuncionario.Name = "tbFuncionario";
            this.tbFuncionario.Size = new System.Drawing.Size(226, 16);
            this.tbFuncionario.TabIndex = 229;
            this.tbFuncionario.Text = "Digite o nome do funcionário ...";
            this.tbFuncionario.Enter += new System.EventHandler(this.tbFuncionario_Enter);
            this.tbFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFuncionario_KeyPress);
            this.tbFuncionario.Leave += new System.EventHandler(this.tbFuncionario_Leave);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::Apresentacao.Properties.Resources.ClienteAzul;
            this.pbUsuario.Location = new System.Drawing.Point(17, 178);
            this.pbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(26, 29);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 244;
            this.pbUsuario.TabStop = false;
            // 
            // panelBuscarCliente
            // 
            this.panelBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarCliente.Location = new System.Drawing.Point(17, 209);
            this.panelBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.panelBuscarCliente.Name = "panelBuscarCliente";
            this.panelBuscarCliente.Size = new System.Drawing.Size(258, 2);
            this.panelBuscarCliente.TabIndex = 234;
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
            this.btCliente.Location = new System.Drawing.Point(278, 176);
            this.btCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(78, 34);
            this.btCliente.TabIndex = 233;
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
            this.tbBuscarCliente.Location = new System.Drawing.Point(47, 190);
            this.tbBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbBuscarCliente.Name = "tbBuscarCliente";
            this.tbBuscarCliente.Size = new System.Drawing.Size(226, 16);
            this.tbBuscarCliente.TabIndex = 232;
            this.tbBuscarCliente.Text = "Digite o nome do cliente ...";
            this.tbBuscarCliente.Enter += new System.EventHandler(this.tbBuscarCliente_Enter);
            this.tbBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarCliente_KeyPress);
            this.tbBuscarCliente.Leave += new System.EventHandler(this.tbBuscarCliente_Leave);
            // 
            // lbEstatus
            // 
            this.lbEstatus.AutoSize = true;
            this.lbEstatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbEstatus.Location = new System.Drawing.Point(98, 38);
            this.lbEstatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstatus.Name = "lbEstatus";
            this.lbEstatus.Size = new System.Drawing.Size(71, 15);
            this.lbEstatus.TabIndex = 227;
            this.lbEstatus.Text = "AGENDADO";
            // 
            // tgAtendido
            // 
            this.tgAtendido.AutoSize = true;
            this.tgAtendido.Location = new System.Drawing.Point(60, 35);
            this.tgAtendido.Margin = new System.Windows.Forms.Padding(2);
            this.tgAtendido.MinimumSize = new System.Drawing.Size(34, 18);
            this.tgAtendido.Name = "tgAtendido";
            this.tgAtendido.OffBackColor = System.Drawing.Color.Gray;
            this.tgAtendido.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgAtendido.OnBackColor = System.Drawing.Color.DeepPink;
            this.tgAtendido.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgAtendido.Size = new System.Drawing.Size(34, 18);
            this.tgAtendido.TabIndex = 226;
            this.tgAtendido.UseVisualStyleBackColor = true;
            this.tgAtendido.Click += new System.EventHandler(this.tgAtendido_Click);
            // 
            // pbTitulo
            // 
            this.pbTitulo.Image = global::Apresentacao.Properties.Resources.calendario_64;
            this.pbTitulo.Location = new System.Drawing.Point(17, 11);
            this.pbTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pbTitulo.Name = "pbTitulo";
            this.pbTitulo.Size = new System.Drawing.Size(39, 42);
            this.pbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTitulo.TabIndex = 243;
            this.pbTitulo.TabStop = false;
            // 
            // FrmAlterarExcluirAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(371, 516);
            this.Controls.Add(this.cbFaltou);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.lbFinal);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lbDataAgendamento);
            this.Controls.Add(this.dtpDiaSemana);
            this.Controls.Add(this.btAlterar);
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
            this.Controls.Add(this.lbEstatus);
            this.Controls.Add(this.tgAtendido);
            this.Controls.Add(this.pbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAlterarExcluirAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar & Excluir Agenda";
            this.Load += new System.EventHandler(this.FrmAlterarExcluirAgenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAlterarExcluirAgenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbFaltou;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label lbFinal;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label lbDataAgendamento;
        private System.Windows.Forms.DateTimePicker dtpDiaSemana;
        private System.Windows.Forms.Button btAlterar;
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
        private System.Windows.Forms.Label lbEstatus;
        private CustomControls.RJControls.TouglleControl tgAtendido;
        private System.Windows.Forms.PictureBox pbTitulo;
    }
}