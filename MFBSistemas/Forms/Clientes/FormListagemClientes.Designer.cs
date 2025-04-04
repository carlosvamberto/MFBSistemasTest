namespace MFBSistemas.Forms.Clientes
{
    partial class FormListagemClientes
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListagemClientes));
            panel1 = new Panel();
            btnClearFiltro = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            btnAdicionar = new Button();
            btnPesquisar = new Button();
            txtFiltro = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            toolTip = new ToolTip(components);
            toolTipDica = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClearFiltro);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(txtFiltro);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 52);
            panel1.TabIndex = 0;
            // 
            // btnClearFiltro
            // 
            btnClearFiltro.BackColor = Color.White;
            btnClearFiltro.FlatAppearance.BorderSize = 0;
            btnClearFiltro.FlatStyle = FlatStyle.Flat;
            btnClearFiltro.Location = new Point(455, 26);
            btnClearFiltro.Name = "btnClearFiltro";
            btnClearFiltro.Size = new Size(28, 23);
            btnClearFiltro.TabIndex = 6;
            btnClearFiltro.Text = "X";
            toolTip.SetToolTip(btnClearFiltro, "Limpa o filtro");
            btnClearFiltro.UseVisualStyleBackColor = false;
            btnClearFiltro.Click += btnClearFiltro_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.Image = Properties.Resources.trash_list;
            btnExcluir.Location = new Point(748, 9);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(40, 40);
            btnExcluir.TabIndex = 5;
            toolTip.SetToolTip(btnExcluir, "Excluir");
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAlterar.Image = Properties.Resources.replace;
            btnAlterar.Location = new Point(702, 9);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(40, 40);
            btnAlterar.TabIndex = 4;
            toolTip.SetToolTip(btnAlterar, "Alterar");
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.Location = new Point(656, 9);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(40, 40);
            btnAdicionar.TabIndex = 3;
            toolTip.SetToolTip(btnAdicionar, "Incluir");
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(489, 9);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(132, 40);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            toolTipDica.SetToolTip(btnPesquisar, "Você pode pesquisar pelo nome ou parte dele.\r\nSe o filtro estiver em branco, listará todos os clientes.");
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(12, 26);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(447, 23);
            txtFiltro.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Filtro";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn });
            dataGridView1.DataSource = clienteBindingSource;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.ImeMode = ImeMode.Off;
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 371);
            dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            telefoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // toolTip
            // 
            toolTip.BackColor = Color.FromArgb(255, 255, 128);
            // 
            // toolTipDica
            // 
            toolTipDica.BackColor = SystemColors.HotTrack;
            toolTipDica.ForeColor = Color.White;
            toolTipDica.ToolTipIcon = ToolTipIcon.Info;
            toolTipDica.ToolTipTitle = "Dica:";
            // 
            // FormListagemClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FormListagemClientes";
            Text = "Listagem Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPesquisar;
        private TextBox txtFiltro;
        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource clienteBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private Button btnExcluir;
        private Button btnAlterar;
        private Button btnAdicionar;
        private ToolTip toolTip;
        private ToolTip toolTipDica;
        private Button btnClearFiltro;
    }
}