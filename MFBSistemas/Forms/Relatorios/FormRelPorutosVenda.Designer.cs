namespace MFBSistemas.Forms.Relatorios
{
    partial class FormRelPorutosVenda
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
            dtFim = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            dtInicio = new DateTimePicker();
            btnPesquisar = new Button();
            dataGridView1 = new DataGridView();
            bindingSourceRelatorioProdutosVenda = new BindingSource(components);
            produtoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataVendaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalVendidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRelatorioProdutosVenda).BeginInit();
            SuspendLayout();
            // 
            // dtFim
            // 
            dtFim.Checked = false;
            dtFim.CustomFormat = "dd/MM/yyyy";
            dtFim.Format = DateTimePickerFormat.Custom;
            dtFim.Location = new Point(135, 28);
            dtFim.Name = "dtFim";
            dtFim.ShowCheckBox = true;
            dtFim.Size = new Size(108, 23);
            dtFim.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 10);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 6;
            label3.Text = "Até";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 7;
            label2.Text = "A partir de";
            // 
            // dtInicio
            // 
            dtInicio.Checked = false;
            dtInicio.CustomFormat = "dd/MM/yyyy";
            dtInicio.Format = DateTimePickerFormat.Custom;
            dtInicio.Location = new Point(12, 28);
            dtInicio.Name = "dtInicio";
            dtInicio.ShowCheckBox = true;
            dtInicio.Size = new Size(108, 23);
            dtInicio.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(249, 9);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(130, 42);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { produtoIdDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, dataVendaDataGridViewTextBoxColumn, totalVendidoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSourceRelatorioProdutosVenda;
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(758, 330);
            dataGridView1.TabIndex = 10;
            // 
            // bindingSourceRelatorioProdutosVenda
            // 
            bindingSourceRelatorioProdutosVenda.DataSource = typeof(Models.VwRelatorioProdutosVenda);
            // 
            // produtoIdDataGridViewTextBoxColumn
            // 
            produtoIdDataGridViewTextBoxColumn.DataPropertyName = "ProdutoId";
            produtoIdDataGridViewTextBoxColumn.HeaderText = "ProdutoId";
            produtoIdDataGridViewTextBoxColumn.Name = "produtoIdDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // dataVendaDataGridViewTextBoxColumn
            // 
            dataVendaDataGridViewTextBoxColumn.DataPropertyName = "DataVenda";
            dataVendaDataGridViewTextBoxColumn.HeaderText = "DataVenda";
            dataVendaDataGridViewTextBoxColumn.Name = "dataVendaDataGridViewTextBoxColumn";
            // 
            // totalVendidoDataGridViewTextBoxColumn
            // 
            totalVendidoDataGridViewTextBoxColumn.DataPropertyName = "TotalVendido";
            totalVendidoDataGridViewTextBoxColumn.HeaderText = "TotalVendido";
            totalVendidoDataGridViewTextBoxColumn.Name = "totalVendidoDataGridViewTextBoxColumn";
            // 
            // FormRelPorutosVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnPesquisar);
            Controls.Add(dtFim);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtInicio);
            Name = "FormRelPorutosVenda";
            Text = "FormRelPorutosVenda";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRelatorioProdutosVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtFim;
        private Label label3;
        private Label label2;
        private DateTimePicker dtInicio;
        private Button btnPesquisar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn produtoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalVendidoDataGridViewTextBoxColumn;
        private BindingSource bindingSourceRelatorioProdutosVenda;
    }
}