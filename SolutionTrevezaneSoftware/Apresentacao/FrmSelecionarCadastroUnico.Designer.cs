namespace Apresentacao
{
    partial class FrmSelecionarCadastroUnico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarCadastroUnico));
            this.btBuscar = new System.Windows.Forms.Button();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.dgvSelecionar = new System.Windows.Forms.DataGridView();
            this.idCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(303, 11);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(98, 34);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscar.Location = new System.Drawing.Point(11, 42);
            this.panelBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(287, 2);
            this.panelBuscar.TabIndex = 2;
            // 
            // tbBuscar
            // 
            this.tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscar.Location = new System.Drawing.Point(41, 23);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(257, 19);
            this.tbBuscar.TabIndex = 0;
            this.tbBuscar.Text = "Digite a descrição ...";
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.DeepPink;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlterar.Location = new System.Drawing.Point(258, 282);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(98, 34);
            this.btAlterar.TabIndex = 6;
            this.btAlterar.Text = "F4 Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(156, 282);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(98, 34);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(360, 282);
            this.btSair.Margin = new System.Windows.Forms.Padding(2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 34);
            this.btSair.TabIndex = 7;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            // 
            // btSelecionar
            // 
            this.btSelecionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSelecionar.FlatAppearance.BorderSize = 0;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionar.Location = new System.Drawing.Point(11, 282);
            this.btSelecionar.Margin = new System.Windows.Forms.Padding(2);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(98, 34);
            this.btSelecionar.TabIndex = 4;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            // 
            // dgvSelecionar
            // 
            this.dgvSelecionar.AllowUserToAddRows = false;
            this.dgvSelecionar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvSelecionar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelecionar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelecionar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSelecionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelecionar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCadastro,
            this.descricaoCadastro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelecionar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSelecionar.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSelecionar.Location = new System.Drawing.Point(11, 49);
            this.dgvSelecionar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSelecionar.Name = "dgvSelecionar";
            this.dgvSelecionar.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvSelecionar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSelecionar.RowTemplate.Height = 24;
            this.dgvSelecionar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelecionar.Size = new System.Drawing.Size(447, 229);
            this.dgvSelecionar.TabIndex = 3;
            // 
            // idCadastro
            // 
            this.idCadastro.HeaderText = "ID";
            this.idCadastro.Name = "idCadastro";
            this.idCadastro.ReadOnly = true;
            // 
            // descricaoCadastro
            // 
            this.descricaoCadastro.HeaderText = "Descrição";
            this.descricaoCadastro.Name = "descricaoCadastro";
            this.descricaoCadastro.ReadOnly = true;
            this.descricaoCadastro.ToolTipText = "Descrição cadastro único";
            this.descricaoCadastro.Width = 300;
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = global::Apresentacao.Properties.Resources.cadImg;
            this.pbBuscar.Location = new System.Drawing.Point(11, 11);
            this.pbBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(26, 29);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 21;
            this.pbBuscar.TabStop = false;
            // 
            // FrmSelecionarCadastroUnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(475, 334);
            this.Controls.Add(this.dgvSelecionar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.pbBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmSelecionarCadastroUnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Unico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.DataGridView dgvSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoCadastro;
    }
}