﻿namespace Apresentacao
{
    partial class FrmAlterarExcluirFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterarExcluirFuncionario));
            this.btSair = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.mtbSalario = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.mtbCtps = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbRg = new System.Windows.Forms.MaskedTextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbSobrenome = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbSalario = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbCep = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbCtps = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbRg = new System.Windows.Forms.Label();
            this.lbSobrenome = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btDesfazer = new System.Windows.Forms.Button();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.epFuncionario = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(607, 404);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 38;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlterar.Location = new System.Drawing.Point(27, 404);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(130, 42);
            this.btAlterar.TabIndex = 35;
            this.btAlterar.Text = "F10 Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(556, 268);
            this.dtpNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(181, 26);
            this.dtpNascimento.TabIndex = 29;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbFeminino.Location = new System.Drawing.Point(639, 305);
            this.rbFeminino.Margin = new System.Windows.Forms.Padding(4);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(98, 24);
            this.rbFeminino.TabIndex = 32;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbMasculino.Location = new System.Drawing.Point(525, 305);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(106, 24);
            this.rbMasculino.TabIndex = 31;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piaui",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbEstado.Location = new System.Drawing.Point(556, 162);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(181, 28);
            this.cbEstado.TabIndex = 23;
            // 
            // mtbSalario
            // 
            this.mtbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbSalario.Location = new System.Drawing.Point(556, 337);
            this.mtbSalario.Margin = new System.Windows.Forms.Padding(4);
            this.mtbSalario.Name = "mtbSalario";
            this.mtbSalario.Size = new System.Drawing.Size(181, 27);
            this.mtbSalario.TabIndex = 34;
            this.mtbSalario.TextChanged += new System.EventHandler(this.mtbSalario_TextChanged);
            this.mtbSalario.Leave += new System.EventHandler(this.mtbSalario_Leave);
            // 
            // mtbCelular
            // 
            this.mtbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbCelular.Location = new System.Drawing.Point(556, 233);
            this.mtbCelular.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCelular.Mask = "(99) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(181, 27);
            this.mtbCelular.TabIndex = 27;
            this.mtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCelular.Leave += new System.EventHandler(this.mtbCelular_Leave);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbTelefone.Location = new System.Drawing.Point(556, 198);
            this.mtbTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.mtbTelefone.Mask = "(99) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(181, 27);
            this.mtbTelefone.TabIndex = 25;
            this.mtbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbTelefone.Leave += new System.EventHandler(this.mtbTelefone_Leave);
            // 
            // mtbCep
            // 
            this.mtbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbCep.Location = new System.Drawing.Point(556, 127);
            this.mtbCep.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCep.Mask = "9999-999";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(181, 27);
            this.mtbCep.TabIndex = 21;
            this.mtbCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCep.Leave += new System.EventHandler(this.mtbCep_Leave);
            // 
            // mtbCtps
            // 
            this.mtbCtps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbCtps.Location = new System.Drawing.Point(131, 267);
            this.mtbCtps.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCtps.Mask = "9999999 série 999-9";
            this.mtbCtps.Name = "mtbCtps";
            this.mtbCtps.Size = new System.Drawing.Size(197, 27);
            this.mtbCtps.TabIndex = 11;
            this.mtbCtps.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCtps.Leave += new System.EventHandler(this.mtbCtps_Leave);
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbCpf.Location = new System.Drawing.Point(131, 232);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCpf.Mask = "999,999,999-99";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(197, 27);
            this.mtbCpf.TabIndex = 9;
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCpf.Leave += new System.EventHandler(this.mtbCpf_Leave);
            // 
            // mtbRg
            // 
            this.mtbRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbRg.Location = new System.Drawing.Point(131, 197);
            this.mtbRg.Margin = new System.Windows.Forms.Padding(4);
            this.mtbRg.Mask = "99,999,999-9";
            this.mtbRg.Name = "mtbRg";
            this.mtbRg.Size = new System.Drawing.Size(197, 27);
            this.mtbRg.TabIndex = 7;
            this.mtbRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbRg.Leave += new System.EventHandler(this.mtbRg_Leave);
            // 
            // tbCidade
            // 
            this.tbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCidade.Location = new System.Drawing.Point(556, 92);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(4);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(181, 27);
            this.tbCidade.TabIndex = 19;
            this.tbCidade.Leave += new System.EventHandler(this.tbCidade_Leave);
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbEndereco.Location = new System.Drawing.Point(131, 302);
            this.tbEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(240, 27);
            this.tbEndereco.TabIndex = 13;
            this.tbEndereco.Leave += new System.EventHandler(this.tbEndereco_Leave);
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbBairro.Location = new System.Drawing.Point(131, 337);
            this.tbBairro.Margin = new System.Windows.Forms.Padding(4);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(134, 27);
            this.tbBairro.TabIndex = 15;
            this.tbBairro.Leave += new System.EventHandler(this.tbBairro_Leave);
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbNumero.Location = new System.Drawing.Point(305, 337);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(66, 27);
            this.tbNumero.TabIndex = 17;
            this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            this.tbNumero.Leave += new System.EventHandler(this.tbNumero_Leave);
            // 
            // tbSobrenome
            // 
            this.tbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbSobrenome.Location = new System.Drawing.Point(131, 162);
            this.tbSobrenome.Margin = new System.Windows.Forms.Padding(4);
            this.tbSobrenome.Name = "tbSobrenome";
            this.tbSobrenome.Size = new System.Drawing.Size(240, 27);
            this.tbSobrenome.TabIndex = 5;
            this.tbSobrenome.Leave += new System.EventHandler(this.tbSobrenome_Leave);
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbNome.Location = new System.Drawing.Point(131, 127);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(240, 27);
            this.tbNome.TabIndex = 3;
            this.tbNome.Leave += new System.EventHandler(this.tbNome_Leave);
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSalario.Location = new System.Drawing.Point(447, 344);
            this.lbSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(87, 20);
            this.lbSalario.TabIndex = 33;
            this.lbSalario.Text = "Salário R$";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSexo.Location = new System.Drawing.Point(447, 309);
            this.lbSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(46, 20);
            this.lbSexo.TabIndex = 30;
            this.lbSexo.Text = "Sexo";
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNascimento.Location = new System.Drawing.Point(447, 274);
            this.lbNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(98, 20);
            this.lbNascimento.TabIndex = 28;
            this.lbNascimento.Text = "Nascimento";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTelefone.Location = new System.Drawing.Point(447, 205);
            this.lbTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(73, 20);
            this.lbTelefone.TabIndex = 24;
            this.lbTelefone.Text = "Telefone";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCelular.Location = new System.Drawing.Point(447, 240);
            this.lbCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(62, 20);
            this.lbCelular.TabIndex = 26;
            this.lbCelular.Text = "Celular";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEstado.Location = new System.Drawing.Point(447, 170);
            this.lbEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(61, 20);
            this.lbEstado.TabIndex = 22;
            this.lbEstado.Text = "Estado";
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCep.Location = new System.Drawing.Point(447, 134);
            this.lbCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(43, 20);
            this.lbCep.TabIndex = 20;
            this.lbCep.Text = "CEP";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCidade.Location = new System.Drawing.Point(447, 99);
            this.lbCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(61, 20);
            this.lbCidade.TabIndex = 18;
            this.lbCidade.Text = "Cidade";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbNumero.Location = new System.Drawing.Point(273, 347);
            this.lbNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(24, 17);
            this.lbNumero.TabIndex = 16;
            this.lbNumero.Text = "N°";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbBairro.Location = new System.Drawing.Point(23, 344);
            this.lbBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(55, 20);
            this.lbBairro.TabIndex = 14;
            this.lbBairro.Text = "Bairro";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEndereco.Location = new System.Drawing.Point(23, 309);
            this.lbEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(80, 20);
            this.lbEndereco.TabIndex = 12;
            this.lbEndereco.Text = "Endereço";
            // 
            // lbCtps
            // 
            this.lbCtps.AutoSize = true;
            this.lbCtps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCtps.Location = new System.Drawing.Point(23, 274);
            this.lbCtps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCtps.Name = "lbCtps";
            this.lbCtps.Size = new System.Drawing.Size(53, 20);
            this.lbCtps.TabIndex = 10;
            this.lbCtps.Text = "CTPS";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCpf.Location = new System.Drawing.Point(23, 239);
            this.lbCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(42, 20);
            this.lbCpf.TabIndex = 8;
            this.lbCpf.Text = "CPF";
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbRg.Location = new System.Drawing.Point(23, 204);
            this.lbRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(34, 20);
            this.lbRg.TabIndex = 6;
            this.lbRg.Text = "RG";
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSobrenome.Location = new System.Drawing.Point(23, 169);
            this.lbSobrenome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(94, 20);
            this.lbSobrenome.TabIndex = 4;
            this.lbSobrenome.Text = "Sobrenome";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNome.Location = new System.Drawing.Point(23, 134);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(53, 20);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Image = global::Apresentacao.Properties.Resources.FuncionarioLogo;
            this.pbFuncionario.Location = new System.Drawing.Point(27, 12);
            this.pbFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(52, 52);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncionario.TabIndex = 54;
            this.pbFuncionario.TabStop = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.DeepPink;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExcluir.Location = new System.Drawing.Point(163, 404);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(130, 42);
            this.btExcluir.TabIndex = 36;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btDesfazer
            // 
            this.btDesfazer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDesfazer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btDesfazer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDesfazer.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btDesfazer.ForeColor = System.Drawing.Color.Black;
            this.btDesfazer.Location = new System.Drawing.Point(299, 404);
            this.btDesfazer.Name = "btDesfazer";
            this.btDesfazer.Size = new System.Drawing.Size(130, 42);
            this.btDesfazer.TabIndex = 37;
            this.btDesfazer.Text = "F5 Desfazer";
            this.btDesfazer.UseVisualStyleBackColor = false;
            this.btDesfazer.Click += new System.EventHandler(this.btDesfazer_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCodigo.Location = new System.Drawing.Point(23, 100);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(61, 20);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCodigo.Location = new System.Drawing.Point(131, 93);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(66, 27);
            this.tbCodigo.TabIndex = 1;
            // 
            // epFuncionario
            // 
            this.epFuncionario.ContainerControl = this;
            // 
            // FrmAlterarExcluirFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(771, 470);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.btDesfazer);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.rbFeminino);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.mtbSalario);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.mtbCep);
            this.Controls.Add(this.mtbCtps);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.mtbRg);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbSobrenome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.pbFuncionario);
            this.Controls.Add(this.lbSalario);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.lbNascimento);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.lbCep);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbCtps);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbRg);
            this.Controls.Add(this.lbSobrenome);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAlterarExcluirFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar & Excluir - Funcionário";
            this.Load += new System.EventHandler(this.FrmAlterarExcluirFuncionario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAlterarExcluirFuncionario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.MaskedTextBox mtbSalario;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.MaskedTextBox mtbCtps;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.MaskedTextBox mtbRg;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbSobrenome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbCtps;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.Label lbSobrenome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btDesfazer;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.ErrorProvider epFuncionario;
    }
}