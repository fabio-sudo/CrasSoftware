namespace Apresentacao
{
    partial class FrmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCliente));
            this.btSair = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbSobrenome = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.lbRg = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.mtbRg = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbCep = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbSobrenome = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.epCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbCliente = new System.Windows.Forms.PictureBox();
            this.tbProntuario = new System.Windows.Forms.TextBox();
            this.lbProntuario = new System.Windows.Forms.Label();
            this.mtbNis = new System.Windows.Forms.MaskedTextBox();
            this.lbNis = new System.Windows.Forms.Label();
            this.tbObservacao = new System.Windows.Forms.TextBox();
            this.lbObservacao = new System.Windows.Forms.Label();
            this.lbEstatus = new System.Windows.Forms.Label();
            this.tgBloqueio = new CustomControls.RJControls.TouglleControl();
            ((System.ComponentModel.ISupportInitialize)(this.epCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(456, 322);
            this.btSair.Margin = new System.Windows.Forms.Padding(2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 34);
            this.btSair.TabIndex = 38;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(17, 89);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 17);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSobrenome.Location = new System.Drawing.Point(17, 118);
            this.lbSobrenome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(81, 17);
            this.lbSobrenome.TabIndex = 4;
            this.lbSobrenome.Text = "Sobrenome";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(335, 260);
            this.lbSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(39, 17);
            this.lbSexo.TabIndex = 32;
            this.lbSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(386, 257);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(2);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(89, 21);
            this.rbMasculino.TabIndex = 33;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFeminino.Location = new System.Drawing.Point(479, 257);
            this.rbFeminino.Margin = new System.Windows.Forms.Padding(2);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(83, 21);
            this.rbFeminino.TabIndex = 34;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRg.Location = new System.Drawing.Point(17, 146);
            this.lbRg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(29, 17);
            this.lbRg.TabIndex = 6;
            this.lbRg.Text = "RG";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(17, 175);
            this.lbCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(34, 17);
            this.lbCpf.TabIndex = 8;
            this.lbCpf.Text = "CPF";
            // 
            // mtbRg
            // 
            this.mtbRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbRg.Location = new System.Drawing.Point(98, 141);
            this.mtbRg.Margin = new System.Windows.Forms.Padding(2);
            this.mtbRg.Mask = "99,999,999-C";
            this.mtbRg.Name = "mtbRg";
            this.mtbRg.Size = new System.Drawing.Size(120, 23);
            this.mtbRg.TabIndex = 7;
            this.mtbRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbRg.Leave += new System.EventHandler(this.mtbRg_Leave);
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpf.Location = new System.Drawing.Point(98, 169);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCpf.Mask = "999,999,999-99";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(120, 23);
            this.mtbCpf.TabIndex = 9;
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCpf.Leave += new System.EventHandler(this.mtbCpf_Leave);
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNascimento.Location = new System.Drawing.Point(335, 231);
            this.lbNascimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(82, 17);
            this.lbNascimento.TabIndex = 30;
            this.lbNascimento.Text = "Nascimento";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.Location = new System.Drawing.Point(17, 203);
            this.lbEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(69, 17);
            this.lbEndereco.TabIndex = 10;
            this.lbEndereco.Text = "Endereço";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndereco.Location = new System.Drawing.Point(98, 197);
            this.tbEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(181, 23);
            this.tbEndereco.TabIndex = 11;
            this.tbEndereco.Leave += new System.EventHandler(this.tbEndereco_Leave);
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(203, 231);
            this.lbNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(19, 13);
            this.lbNumero.TabIndex = 14;
            this.lbNumero.Text = "N°";
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(226, 226);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(54, 23);
            this.tbNumero.TabIndex = 15;
            this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            this.tbNumero.Leave += new System.EventHandler(this.tbNumero_Leave);
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.Location = new System.Drawing.Point(17, 232);
            this.lbBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(46, 17);
            this.lbBairro.TabIndex = 12;
            this.lbBairro.Text = "Bairro";
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCep.Location = new System.Drawing.Point(335, 117);
            this.lbCep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(35, 17);
            this.lbCep.TabIndex = 22;
            this.lbCep.Text = "CEP";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.Location = new System.Drawing.Point(335, 89);
            this.lbCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(52, 17);
            this.lbCidade.TabIndex = 20;
            this.lbCidade.Text = "Cidade";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(335, 147);
            this.lbEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(52, 17);
            this.lbEstado.TabIndex = 24;
            this.lbEstado.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.SystemColors.Window;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbEstado.Location = new System.Drawing.Point(417, 141);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(137, 24);
            this.cbEstado.TabIndex = 25;
            this.cbEstado.Leave += new System.EventHandler(this.cbEstado_Leave);
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(417, 226);
            this.dtpNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(137, 23);
            this.dtpNascimento.TabIndex = 31;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(335, 175);
            this.lbTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(64, 17);
            this.lbTelefone.TabIndex = 26;
            this.lbTelefone.Text = "Telefone";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular.Location = new System.Drawing.Point(335, 203);
            this.lbCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(52, 17);
            this.lbCelular.TabIndex = 28;
            this.lbCelular.Text = "Celular";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(17, 260);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 16;
            this.lbEmail.Text = "Email";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefone.Location = new System.Drawing.Point(417, 169);
            this.mtbTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.mtbTelefone.Mask = "(99) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(137, 23);
            this.mtbTelefone.TabIndex = 27;
            this.mtbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbTelefone.Leave += new System.EventHandler(this.mtbTelefone_Leave);
            // 
            // mtbCelular
            // 
            this.mtbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCelular.Location = new System.Drawing.Point(417, 197);
            this.mtbCelular.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCelular.Mask = "(99) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(137, 23);
            this.mtbCelular.TabIndex = 29;
            this.mtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCelular.Leave += new System.EventHandler(this.mtbCelular_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(98, 254);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(181, 23);
            this.tbEmail.TabIndex = 17;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(98, 84);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(181, 23);
            this.tbNome.TabIndex = 3;
            this.tbNome.Leave += new System.EventHandler(this.tbNome_Leave);
            // 
            // tbSobrenome
            // 
            this.tbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSobrenome.Location = new System.Drawing.Point(98, 112);
            this.tbSobrenome.Margin = new System.Windows.Forms.Padding(2);
            this.tbSobrenome.Name = "tbSobrenome";
            this.tbSobrenome.Size = new System.Drawing.Size(181, 23);
            this.tbSobrenome.TabIndex = 5;
            this.tbSobrenome.Leave += new System.EventHandler(this.tbSobrenome_Leave);
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBairro.Location = new System.Drawing.Point(98, 226);
            this.tbBairro.Margin = new System.Windows.Forms.Padding(2);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(102, 23);
            this.tbBairro.TabIndex = 13;
            this.tbBairro.Leave += new System.EventHandler(this.tbBairro_Leave);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(354, 322);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(98, 34);
            this.btCadastrar.TabIndex = 37;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // tbCidade
            // 
            this.tbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCidade.Location = new System.Drawing.Point(417, 84);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(2);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(137, 23);
            this.tbCidade.TabIndex = 21;
            this.tbCidade.Text = "Pitangueiras";
            this.tbCidade.Leave += new System.EventHandler(this.tbCidade_Leave);
            // 
            // mtbCep
            // 
            this.mtbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCep.Location = new System.Drawing.Point(417, 112);
            this.mtbCep.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCep.Mask = "0000-0000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(137, 23);
            this.mtbCep.TabIndex = 23;
            this.mtbCep.Text = "14750000";
            this.mtbCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCep.Leave += new System.EventHandler(this.mtbCep_Leave);
            // 
            // epCliente
            // 
            this.epCliente.ContainerControl = this;
            // 
            // pbCliente
            // 
            this.pbCliente.Image = global::Apresentacao.Properties.Resources.ClienteLogo;
            this.pbCliente.Location = new System.Drawing.Point(20, 10);
            this.pbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.pbCliente.Name = "pbCliente";
            this.pbCliente.Size = new System.Drawing.Size(39, 42);
            this.pbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCliente.TabIndex = 33;
            this.pbCliente.TabStop = false;
            // 
            // tbProntuario
            // 
            this.tbProntuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProntuario.Location = new System.Drawing.Point(98, 55);
            this.tbProntuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbProntuario.Name = "tbProntuario";
            this.tbProntuario.Size = new System.Drawing.Size(139, 23);
            this.tbProntuario.TabIndex = 1;
            this.tbProntuario.Leave += new System.EventHandler(this.tbProntuario_Leave);
            // 
            // lbProntuario
            // 
            this.lbProntuario.AutoSize = true;
            this.lbProntuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbProntuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProntuario.Location = new System.Drawing.Point(17, 61);
            this.lbProntuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProntuario.Name = "lbProntuario";
            this.lbProntuario.Size = new System.Drawing.Size(74, 17);
            this.lbProntuario.TabIndex = 0;
            this.lbProntuario.Text = "Prontuário";
            // 
            // mtbNis
            // 
            this.mtbNis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNis.Location = new System.Drawing.Point(417, 55);
            this.mtbNis.Margin = new System.Windows.Forms.Padding(2);
            this.mtbNis.Mask = "999,99999,99-99";
            this.mtbNis.Name = "mtbNis";
            this.mtbNis.Size = new System.Drawing.Size(137, 23);
            this.mtbNis.TabIndex = 19;
            this.mtbNis.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbNis.Leave += new System.EventHandler(this.mtbNis_Leave);
            // 
            // lbNis
            // 
            this.lbNis.AutoSize = true;
            this.lbNis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNis.Location = new System.Drawing.Point(335, 61);
            this.lbNis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNis.Name = "lbNis";
            this.lbNis.Size = new System.Drawing.Size(30, 17);
            this.lbNis.TabIndex = 18;
            this.lbNis.Text = "NIS";
            // 
            // tbObservacao
            // 
            this.tbObservacao.Location = new System.Drawing.Point(98, 283);
            this.tbObservacao.Multiline = true;
            this.tbObservacao.Name = "tbObservacao";
            this.tbObservacao.Size = new System.Drawing.Size(182, 73);
            this.tbObservacao.TabIndex = 35;
            // 
            // lbObservacao
            // 
            this.lbObservacao.AutoSize = true;
            this.lbObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObservacao.Location = new System.Drawing.Point(17, 339);
            this.lbObservacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(38, 17);
            this.lbObservacao.TabIndex = 36;
            this.lbObservacao.Text = "Obs.";
            // 
            // lbEstatus
            // 
            this.lbEstatus.AutoSize = true;
            this.lbEstatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbEstatus.Location = new System.Drawing.Point(136, 30);
            this.lbEstatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstatus.Name = "lbEstatus";
            this.lbEstatus.Size = new System.Drawing.Size(41, 15);
            this.lbEstatus.TabIndex = 159;
            this.lbEstatus.Text = "ATIVO";
            // 
            // tgBloqueio
            // 
            this.tgBloqueio.AutoSize = true;
            this.tgBloqueio.Location = new System.Drawing.Point(98, 29);
            this.tgBloqueio.Margin = new System.Windows.Forms.Padding(2);
            this.tgBloqueio.MinimumSize = new System.Drawing.Size(34, 18);
            this.tgBloqueio.Name = "tgBloqueio";
            this.tgBloqueio.OffBackColor = System.Drawing.Color.Gray;
            this.tgBloqueio.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgBloqueio.OnBackColor = System.Drawing.Color.DeepPink;
            this.tgBloqueio.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgBloqueio.Size = new System.Drawing.Size(34, 18);
            this.tgBloqueio.TabIndex = 158;
            this.tgBloqueio.UseVisualStyleBackColor = true;
            this.tgBloqueio.CheckedChanged += new System.EventHandler(this.tgBloqueio_CheckedChanged);
            this.tgBloqueio.Click += new System.EventHandler(this.tgBloqueio_Click);
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(574, 406);
            this.Controls.Add(this.lbEstatus);
            this.Controls.Add(this.tgBloqueio);
            this.Controls.Add(this.lbObservacao);
            this.Controls.Add(this.tbObservacao);
            this.Controls.Add(this.mtbNis);
            this.Controls.Add(this.lbNis);
            this.Controls.Add(this.tbProntuario);
            this.Controls.Add(this.lbProntuario);
            this.Controls.Add(this.mtbCep);
            this.Controls.Add(this.pbCliente);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbSobrenome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbCep);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbNascimento);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.mtbRg);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbRg);
            this.Controls.Add(this.rbFeminino);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.lbSobrenome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.FrmCadastroCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.epCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbSobrenome;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.MaskedTextBox mtbRg;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbSobrenome;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.PictureBox pbCliente;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.ErrorProvider epCliente;
        private System.Windows.Forms.MaskedTextBox mtbNis;
        private System.Windows.Forms.Label lbNis;
        private System.Windows.Forms.TextBox tbProntuario;
        private System.Windows.Forms.Label lbProntuario;
        private System.Windows.Forms.Label lbObservacao;
        private System.Windows.Forms.TextBox tbObservacao;
        private System.Windows.Forms.Label lbEstatus;
        private CustomControls.RJControls.TouglleControl tgBloqueio;

    }
}