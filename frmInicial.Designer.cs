namespace exemploFrmWindows
{
    partial class frmInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcClientes = new System.Windows.Forms.TabControl();
            this.tpClientes = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpFornecedores = new System.Windows.Forms.TabPage();
            this.tpFuncionarios = new System.Windows.Forms.TabPage();
            this.menuCadastro = new System.Windows.Forms.MenuStrip();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.miClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.miFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.miFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selecionarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conteúdoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.índiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelCliente = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colunaCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tcClientes.SuspendLayout();
            this.tpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuCadastro.SuspendLayout();
            this.painelCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(666, 215);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(666, 239);
            this.toolStripContainer1.TabIndex = 0;
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuCadastro);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tcClientes);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 215);
            this.panel1.TabIndex = 0;
            // 
            // tcClientes
            // 
            this.tcClientes.Controls.Add(this.tpClientes);
            this.tcClientes.Controls.Add(this.tpFornecedores);
            this.tcClientes.Controls.Add(this.tpFuncionarios);
            this.tcClientes.Location = new System.Drawing.Point(10, 4);
            this.tcClientes.Name = "tcClientes";
            this.tcClientes.SelectedIndex = 0;
            this.tcClientes.Size = new System.Drawing.Size(653, 211);
            this.tcClientes.TabIndex = 0;
            this.tcClientes.Visible = false;
            // 
            // tpClientes
            // 
            this.tpClientes.Controls.Add(this.dataGridView1);
            this.tpClientes.Controls.Add(this.painelCliente);
            this.tpClientes.Location = new System.Drawing.Point(4, 22);
            this.tpClientes.Name = "tpClientes";
            this.tpClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tpClientes.Size = new System.Drawing.Size(645, 185);
            this.tpClientes.TabIndex = 0;
            this.tpClientes.Text = "Clientes";
            this.tpClientes.UseVisualStyleBackColor = true;
            this.tpClientes.Click += new System.EventHandler(this.tpClientes_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaCPF,
            this.colunaRG,
            this.colunaNome});
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 181);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tpFornecedores
            // 
            this.tpFornecedores.Location = new System.Drawing.Point(4, 22);
            this.tpFornecedores.Name = "tpFornecedores";
            this.tpFornecedores.Padding = new System.Windows.Forms.Padding(3);
            this.tpFornecedores.Size = new System.Drawing.Size(645, 185);
            this.tpFornecedores.TabIndex = 1;
            this.tpFornecedores.Text = "Fornecedores";
            this.tpFornecedores.UseVisualStyleBackColor = true;
            // 
            // tpFuncionarios
            // 
            this.tpFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tpFuncionarios.Name = "tpFuncionarios";
            this.tpFuncionarios.Size = new System.Drawing.Size(645, 185);
            this.tpFuncionarios.TabIndex = 2;
            this.tpFuncionarios.Text = "Funcionários";
            this.tpFuncionarios.UseVisualStyleBackColor = true;
            // 
            // menuCadastro
            // 
            this.menuCadastro.Dock = System.Windows.Forms.DockStyle.None;
            this.menuCadastro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastro,
            this.editarToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuCadastro.Location = new System.Drawing.Point(0, 0);
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(666, 24);
            this.menuCadastro.TabIndex = 0;
            this.menuCadastro.Text = "Cadastro";
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miClientes,
            this.miFornecedores,
            this.toolStripSeparator,
            this.miFuncionarios});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(66, 20);
            this.mnuCadastro.Text = "&Cadastro";
            // 
            // miClientes
            // 
            this.miClientes.Image = ((System.Drawing.Image)(resources.GetObject("miClientes.Image")));
            this.miClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miClientes.Name = "miClientes";
            this.miClientes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miClientes.Size = new System.Drawing.Size(188, 22);
            this.miClientes.Text = "&Clientes";
            this.miClientes.Click += new System.EventHandler(this.miClientes_Click);
            // 
            // miFornecedores
            // 
            this.miFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("miFornecedores.Image")));
            this.miFornecedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miFornecedores.Name = "miFornecedores";
            this.miFornecedores.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miFornecedores.Size = new System.Drawing.Size(188, 22);
            this.miFornecedores.Text = "&Fornecedores";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(185, 6);
            // 
            // miFuncionarios
            // 
            this.miFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("miFuncionarios.Image")));
            this.miFuncionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miFuncionarios.Name = "miFuncionarios";
            this.miFuncionarios.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miFuncionarios.Size = new System.Drawing.Size(188, 22);
            this.miFuncionarios.Text = "Funcion&ários";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem,
            this.toolStripSeparator3,
            this.recortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.toolStripSeparator4,
            this.selecionarTudoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.desfazerToolStripMenuItem.Text = "&Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.refazerToolStripMenuItem.Text = "&Refazer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(156, 6);
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recortarToolStripMenuItem.Image")));
            this.recortarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.recortarToolStripMenuItem.Text = "Recor&tar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripMenuItem.Image")));
            this.colarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.colarToolStripMenuItem.Text = "C&olar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(156, 6);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            this.selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            this.selecionarTudoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.selecionarTudoToolStripMenuItem.Text = "Selecionar &Tudo";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarToolStripMenuItem,
            this.opçõesToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferra&mentas";
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.opçõesToolStripMenuItem.Text = "&Opções";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conteúdoToolStripMenuItem,
            this.índiceToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.toolStripSeparator5,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Aj&uda";
            // 
            // conteúdoToolStripMenuItem
            // 
            this.conteúdoToolStripMenuItem.Name = "conteúdoToolStripMenuItem";
            this.conteúdoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.conteúdoToolStripMenuItem.Text = "&Conteúdo";
            // 
            // índiceToolStripMenuItem
            // 
            this.índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            this.índiceToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.índiceToolStripMenuItem.Text = "Í&ndice";
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pesquisarToolStripMenuItem.Text = "&Pesquisar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(124, 6);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre...";
            // 
            // painelCliente
            // 
            this.painelCliente.Controls.Add(this.btnVoltar);
            this.painelCliente.Controls.Add(this.btnExcluir);
            this.painelCliente.Controls.Add(this.btnSalvar);
            this.painelCliente.Controls.Add(this.txtNome);
            this.painelCliente.Controls.Add(this.label3);
            this.painelCliente.Controls.Add(this.txtRG);
            this.painelCliente.Controls.Add(this.label2);
            this.painelCliente.Controls.Add(this.txtCPF);
            this.painelCliente.Controls.Add(this.label1);
            this.painelCliente.Location = new System.Drawing.Point(9, 6);
            this.painelCliente.Name = "painelCliente";
            this.painelCliente.Size = new System.Drawing.Size(634, 178);
            this.painelCliente.TabIndex = 1;
            this.painelCliente.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(216, 129);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(111, 129);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(20, 129);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(59, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(369, 20);
            this.txtNome.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(59, 46);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "RG";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(60, 12);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "CPF";
            // 
            // colunaCPF
            // 
            this.colunaCPF.HeaderText = "CPF";
            this.colunaCPF.Name = "colunaCPF";
            this.colunaCPF.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colunaRG
            // 
            this.colunaRG.HeaderText = "RG";
            this.colunaRG.Name = "colunaRG";
            // 
            // colunaNome
            // 
            this.colunaNome.HeaderText = "Nome";
            this.colunaNome.Name = "colunaNome";
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 239);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuCadastro;
            this.Name = "frmInicial";
            this.Text = "Sistema de Administração Advocatícia";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tcClientes.ResumeLayout(false);
            this.tpClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuCadastro.ResumeLayout(false);
            this.menuCadastro.PerformLayout();
            this.painelCliente.ResumeLayout(false);
            this.painelCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem miClientes;
        private System.Windows.Forms.ToolStripMenuItem miFornecedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem miFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conteúdoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem índiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcClientes;
        private System.Windows.Forms.TabPage tpClientes;
        private System.Windows.Forms.TabPage tpFornecedores;
        private System.Windows.Forms.TabPage tpFuncionarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel painelCliente;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
    }
}

