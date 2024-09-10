namespace Apresentacao
{
    partial class FrmAlterarCadastrarExcluirEspecificacao
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
            this.btSair = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbEncaminhamento = new System.Windows.Forms.Label();
            this.cbNenhum = new System.Windows.Forms.RadioButton();
            this.cbEnviado = new System.Windows.Forms.RadioButton();
            this.cbRecebido = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(245, 180);
            this.btSair.Margin = new System.Windows.Forms.Padding(2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 34);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(11, 180);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(98, 34);
            this.btCadastrar.TabIndex = 4;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.DeepPink;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExcluir.Location = new System.Drawing.Point(113, 180);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(98, 34);
            this.btExcluir.TabIndex = 5;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbId.Location = new System.Drawing.Point(86, 33);
            this.tbId.Margin = new System.Windows.Forms.Padding(2);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(50, 23);
            this.tbId.TabIndex = 1;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCodigo.Location = new System.Drawing.Point(59, 37);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(21, 17);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "ID";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbDescricao.Location = new System.Drawing.Point(86, 61);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(258, 23);
            this.tbDescricao.TabIndex = 3;
            this.tbDescricao.Leave += new System.EventHandler(this.tbDescricao_Leave);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDescricao.Location = new System.Drawing.Point(9, 67);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(71, 17);
            this.lbDescricao.TabIndex = 2;
            this.lbDescricao.Text = "Descrição";
            // 
            // pbImg
            // 
            this.pbImg.Image = global::Apresentacao.Properties.Resources.img_Especificacao;
            this.pbImg.Location = new System.Drawing.Point(12, 12);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(39, 42);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 92;
            this.pbImg.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbEncaminhamento
            // 
            this.lbEncaminhamento.AutoSize = true;
            this.lbEncaminhamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEncaminhamento.Location = new System.Drawing.Point(9, 103);
            this.lbEncaminhamento.Name = "lbEncaminhamento";
            this.lbEncaminhamento.Size = new System.Drawing.Size(117, 17);
            this.lbEncaminhamento.TabIndex = 94;
            this.lbEncaminhamento.Text = "Encaminhamento";
            // 
            // cbNenhum
            // 
            this.cbNenhum.AutoSize = true;
            this.cbNenhum.Location = new System.Drawing.Point(11, 123);
            this.cbNenhum.Name = "cbNenhum";
            this.cbNenhum.Size = new System.Drawing.Size(65, 17);
            this.cbNenhum.TabIndex = 95;
            this.cbNenhum.TabStop = true;
            this.cbNenhum.Text = "Nenhum";
            this.cbNenhum.UseVisualStyleBackColor = true;
            // 
            // cbEnviado
            // 
            this.cbEnviado.AutoSize = true;
            this.cbEnviado.Location = new System.Drawing.Point(86, 123);
            this.cbEnviado.Name = "cbEnviado";
            this.cbEnviado.Size = new System.Drawing.Size(64, 17);
            this.cbEnviado.TabIndex = 96;
            this.cbEnviado.TabStop = true;
            this.cbEnviado.Text = "Enviado";
            this.cbEnviado.UseVisualStyleBackColor = true;
            // 
            // cbRecebido
            // 
            this.cbRecebido.AutoSize = true;
            this.cbRecebido.Location = new System.Drawing.Point(156, 123);
            this.cbRecebido.Name = "cbRecebido";
            this.cbRecebido.Size = new System.Drawing.Size(71, 17);
            this.cbRecebido.TabIndex = 97;
            this.cbRecebido.TabStop = true;
            this.cbRecebido.Text = "Recebido";
            this.cbRecebido.UseVisualStyleBackColor = true;
            // 
            // FrmAlterarCadastrarExcluirEspecificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 232);
            this.Controls.Add(this.cbRecebido);
            this.Controls.Add(this.cbEnviado);
            this.Controls.Add(this.cbNenhum);
            this.Controls.Add(this.lbEncaminhamento);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.lbDescricao);
            this.Name = "FrmAlterarCadastrarExcluirEspecificacao";
            this.Text = "Especificação do Atendimento";
            this.Load += new System.EventHandler(this.FrmAlterarCadastrarExcluirEspecificacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAlterarCadastrarExcluirEspecificacao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton cbRecebido;
        private System.Windows.Forms.RadioButton cbEnviado;
        private System.Windows.Forms.RadioButton cbNenhum;
        private System.Windows.Forms.Label lbEncaminhamento;
    }
}