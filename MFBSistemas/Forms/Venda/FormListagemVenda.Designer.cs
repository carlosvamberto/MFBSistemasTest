namespace MFBSistemas.Forms.Venda
{
    partial class FormListagemVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListagemVenda));
            panel2 = new Panel();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            btnPesquisar = new Button();
            btnClear = new Button();
            dtFim = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            dtInicio = new DateTimePicker();
            txtCliente = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataVendaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ClienteNome = new DataGridViewTextBoxColumn();
            bindingSourceVenda = new BindingSource(components);
            toolTip = new ToolTip(components);
            toolTipDica = new ToolTip(components);
            bindingSourceCliente = new BindingSource(components);
            listBox1 = new ListBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCliente).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(btnAdicionar);
            panel2.Controls.Add(btnPesquisar);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(dtFim);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtInicio);
            panel2.Controls.Add(txtCliente);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1204, 57);
            panel2.TabIndex = 1;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.Image = Properties.Resources.trash_list;
            btnExcluir.Location = new Point(1158, 8);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(40, 40);
            btnExcluir.TabIndex = 8;
            toolTip.SetToolTip(btnExcluir, "Excluir");
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.Location = new Point(1112, 9);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(40, 40);
            btnAdicionar.TabIndex = 7;
            toolTip.SetToolTip(btnAdicionar, "Incluir");
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(508, 10);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(132, 40);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            toolTipDica.SetToolTip(btnPesquisar, "Você pode pesquisar pelo nome ou parte dele.\r\nSe o filtro estiver em branco, listará todos os produtos.\r\nMarque os checkbox de Datas para fazer parte dos filtros.");
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderColor = Color.White;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(230, 27);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(20, 21);
            btnClear.TabIndex = 5;
            btnClear.Text = "X";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dtFim
            // 
            dtFim.Checked = false;
            dtFim.CustomFormat = "dd/MM/yyyy";
            dtFim.Format = DateTimePickerFormat.Custom;
            dtFim.Location = new Point(394, 27);
            dtFim.Name = "dtFim";
            dtFim.ShowCheckBox = true;
            dtFim.Size = new Size(108, 23);
            dtFim.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 9);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 3;
            label3.Text = "Até";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 9);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "A partir de";
            // 
            // dtInicio
            // 
            dtInicio.Checked = false;
            dtInicio.CustomFormat = "dd/MM/yyyy";
            dtInicio.Format = DateTimePickerFormat.Custom;
            dtInicio.Location = new Point(271, 27);
            dtInicio.Name = "dtInicio";
            dtInicio.ShowCheckBox = true;
            dtInicio.Size = new Size(108, 23);
            dtInicio.TabIndex = 2;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(12, 27);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(218, 23);
            txtCliente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dataVendaDataGridViewTextBoxColumn, ClienteNome });
            dataGridView1.DataSource = bindingSourceVenda;
            dataGridView1.Location = new Point(12, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(715, 515);
            dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataVendaDataGridViewTextBoxColumn
            // 
            dataVendaDataGridViewTextBoxColumn.DataPropertyName = "DataVenda";
            dataVendaDataGridViewTextBoxColumn.HeaderText = "DataVenda";
            dataVendaDataGridViewTextBoxColumn.Name = "dataVendaDataGridViewTextBoxColumn";
            dataVendaDataGridViewTextBoxColumn.ReadOnly = true;
            dataVendaDataGridViewTextBoxColumn.Width = 150;
            // 
            // ClienteNome
            // 
            ClienteNome.DataPropertyName = "ClienteNome";
            ClienteNome.HeaderText = "ClienteNome";
            ClienteNome.Name = "ClienteNome";
            ClienteNome.ReadOnly = true;
            ClienteNome.Width = 200;
            // 
            // bindingSourceVenda
            // 
            bindingSourceVenda.DataSource = typeof(Models.Venda);
            bindingSourceVenda.PositionChanged += bindingSourceVenda_PositionChanged;
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
            // bindingSourceCliente
            // 
            bindingSourceCliente.DataSource = typeof(Models.Cliente);
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 14;
            listBox1.Location = new Point(733, 72);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(463, 522);
            listBox1.TabIndex = 9;
            // 
            // FormListagemVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 599);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "FormListagemVenda";
            Text = "FormListagemVenda";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private DateTimePicker dtInicio;
        private TextBox txtCliente;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dtFim;
        private Label label3;
        private Button btnClear;
        private ToolTip toolTip;
        private ToolTip toolTipDica;
        private BindingSource bindingSourceVenda;
        private Button btnPesquisar;
        private Button btnAdicionar;
        private Button btnExcluir;
        private BindingSource bindingSourceCliente;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ClienteNome;
        private ListBox listBox1;
    }
}