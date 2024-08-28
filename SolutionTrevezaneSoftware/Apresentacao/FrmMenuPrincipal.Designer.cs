namespace Apresentacao
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btBackup = new System.Windows.Forms.Button();
            this.btAgenda = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btUsuario = new System.Windows.Forms.Button();
            this.btFuncionario = new System.Windows.Forms.Button();
            this.btCliente = new System.Windows.Forms.Button();
            this.panelMenuLogo = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btLogin = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelMenuLogo.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btBackup);
            this.panelMenu.Controls.Add(this.btAgenda);
            this.panelMenu.Controls.Add(this.btSair);
            this.panelMenu.Controls.Add(this.btUsuario);
            this.panelMenu.Controls.Add(this.btFuncionario);
            this.panelMenu.Controls.Add(this.btCliente);
            this.panelMenu.Controls.Add(this.panelMenuLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 603);
            this.panelMenu.TabIndex = 0;
            // 
            // btBackup
            // 
            this.btBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btBackup.FlatAppearance.BorderSize = 0;
            this.btBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBackup.ForeColor = System.Drawing.Color.Gainsboro;
            this.btBackup.Image = global::Apresentacao.Properties.Resources.Backup;
            this.btBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBackup.Location = new System.Drawing.Point(0, 261);
            this.btBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btBackup.Name = "btBackup";
            this.btBackup.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btBackup.Size = new System.Drawing.Size(165, 49);
            this.btBackup.TabIndex = 13;
            this.btBackup.Text = "Backup";
            this.btBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // btAgenda
            // 
            this.btAgenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAgenda.FlatAppearance.BorderSize = 0;
            this.btAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgenda.ForeColor = System.Drawing.Color.Gainsboro;
            this.btAgenda.Image = global::Apresentacao.Properties.Resources.Calendario_Logo;
            this.btAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgenda.Location = new System.Drawing.Point(0, 212);
            this.btAgenda.Margin = new System.Windows.Forms.Padding(2);
            this.btAgenda.Name = "btAgenda";
            this.btAgenda.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btAgenda.Size = new System.Drawing.Size(165, 49);
            this.btAgenda.TabIndex = 12;
            this.btAgenda.Text = " Agenda";
            this.btAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAgenda.UseVisualStyleBackColor = true;
            this.btAgenda.Click += new System.EventHandler(this.btBackupBanco_Click);
            // 
            // btSair
            // 
            this.btSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.ForeColor = System.Drawing.Color.Gainsboro;
            this.btSair.Image = global::Apresentacao.Properties.Resources.Sair;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(0, 554);
            this.btSair.Margin = new System.Windows.Forms.Padding(2);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(165, 49);
            this.btSair.TabIndex = 11;
            this.btSair.Text = " Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btUsuario
            // 
            this.btUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUsuario.FlatAppearance.BorderSize = 0;
            this.btUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btUsuario.Image = global::Apresentacao.Properties.Resources.UsuarioSenha;
            this.btUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsuario.Location = new System.Drawing.Point(0, 163);
            this.btUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btUsuario.Name = "btUsuario";
            this.btUsuario.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btUsuario.Size = new System.Drawing.Size(165, 49);
            this.btUsuario.TabIndex = 10;
            this.btUsuario.Text = "Usuário&Senha";
            this.btUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUsuario.UseVisualStyleBackColor = true;
            this.btUsuario.Click += new System.EventHandler(this.btUsuario_Click);
            // 
            // btFuncionario
            // 
            this.btFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFuncionario.FlatAppearance.BorderSize = 0;
            this.btFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btFuncionario.Image = global::Apresentacao.Properties.Resources.Funcionario;
            this.btFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFuncionario.Location = new System.Drawing.Point(0, 114);
            this.btFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btFuncionario.Name = "btFuncionario";
            this.btFuncionario.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btFuncionario.Size = new System.Drawing.Size(165, 49);
            this.btFuncionario.TabIndex = 2;
            this.btFuncionario.Text = " Funcionario";
            this.btFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFuncionario.UseVisualStyleBackColor = true;
            this.btFuncionario.Click += new System.EventHandler(this.btFuncionario_Click);
            // 
            // btCliente
            // 
            this.btCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCliente.FlatAppearance.BorderSize = 0;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btCliente.Image = global::Apresentacao.Properties.Resources.Cliente;
            this.btCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCliente.Location = new System.Drawing.Point(0, 65);
            this.btCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btCliente.Name = "btCliente";
            this.btCliente.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btCliente.Size = new System.Drawing.Size(165, 49);
            this.btCliente.TabIndex = 1;
            this.btCliente.Text = " Cliente";
            this.btCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // panelMenuLogo
            // 
            this.panelMenuLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelMenuLogo.Controls.Add(this.btHome);
            this.panelMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenuLogo.Name = "panelMenuLogo";
            this.panelMenuLogo.Size = new System.Drawing.Size(165, 65);
            this.panelMenuLogo.TabIndex = 0;
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btHome.Image = global::Apresentacao.Properties.Resources.logoPng;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btHome.Location = new System.Drawing.Point(0, 0);
            this.btHome.Margin = new System.Windows.Forms.Padding(2);
            this.btHome.Name = "btHome";
            this.btHome.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btHome.Size = new System.Drawing.Size(165, 65);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "Trevezane Software";
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTitulo.Controls.Add(this.btLogin);
            this.panelTitulo.Controls.Add(this.btFechar);
            this.panelTitulo.Controls.Add(this.lbTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(165, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(724, 65);
            this.panelTitulo.TabIndex = 0;
            // 
            // btLogin
            // 
            this.btLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLogin.Image = global::Apresentacao.Properties.Resources.Cliente;
            this.btLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogin.Location = new System.Drawing.Point(634, 0);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(90, 65);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Usuário";
            this.btLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btFechar
            // 
            this.btFechar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Image = global::Apresentacao.Properties.Resources.Fechar;
            this.btFechar.Location = new System.Drawing.Point(0, 0);
            this.btFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(56, 65);
            this.btFechar.TabIndex = 0;
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Visible = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitulo.Location = new System.Drawing.Point(327, 18);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(0, 27);
            this.lbTitulo.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDesktop.Controls.Add(this.pictureLogo);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(165, 65);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(724, 538);
            this.panelDesktop.TabIndex = 1;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureLogo.Image = global::Apresentacao.Properties.Resources.PlanoDeFundoLogo;
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(724, 538);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(889, 603);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMenuPrincipal_KeyDown);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuLogo.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Panel panelMenuLogo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btFuncionario;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btUsuario;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button btAgenda;
        private System.Windows.Forms.Button btBackup;

    }
}

