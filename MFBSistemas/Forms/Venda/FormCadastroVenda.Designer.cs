namespace MFBSistemas.Forms.Venda
{
    partial class FormCadastroVenda
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
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cboClientes = new ComboBox();
            bindingSourceVendas = new BindingSource(components);
            bindingSourceClientes = new BindingSource(components);
            panel1 = new Panel();
            numericUpDown1 = new NumericUpDown();
            bindingSourceVendaProdutos = new BindingSource(components);
            label6 = new Label();
            btnAdicionar = new Button();
            txtPreco = new TextBox();
            label5 = new Label();
            cboProduto = new ComboBox();
            bindingSourceProdutos = new BindingSource(components);
            label4 = new Label();
            label3 = new Label();
            bindingSourceVendaProdutoLista = new BindingSource(components);
            lblTotalCompra = new Label();
            listBox1 = new ListBox();
            btnCancelar = new Button();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceClientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVendaProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVendaProdutoLista).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "Data";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyy";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(12, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(99, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // cboClientes
            // 
            cboClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboClientes.DataBindings.Add(new Binding("SelectedValue", bindingSourceVendas, "ClienteId", true));
            cboClientes.DataSource = bindingSourceClientes;
            cboClientes.DisplayMember = "Nome";
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(117, 27);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(409, 23);
            cboClientes.TabIndex = 2;
            cboClientes.ValueMember = "Id";
            // 
            // bindingSourceVendas
            // 
            bindingSourceVendas.DataSource = typeof(Models.Venda);
            // 
            // bindingSourceClientes
            // 
            bindingSourceClientes.DataSource = typeof(Models.Cliente);
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cboProduto);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 99);
            panel1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DataBindings.Add(new Binding("Value", bindingSourceVendaProdutos, "Quantidade", true));
            numericUpDown1.Location = new Point(361, 27);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(96, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // bindingSourceVendaProdutos
            // 
            bindingSourceVendaProdutos.DataSource = typeof(Models.VendaProduto);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.DataBindings.Add(new Binding("Text", bindingSourceVendaProdutos, "Total", true));
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(3, 65);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 5;
            label6.Text = "R$ 0,00";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Image = Properties.Resources.add;
            btnAdicionar.Location = new Point(463, 8);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(46, 46);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtPreco
            // 
            txtPreco.BorderStyle = BorderStyle.FixedSingle;
            txtPreco.DataBindings.Add(new Binding("Text", bindingSourceVendaProdutos, "PrecoUnit", true, DataSourceUpdateMode.OnValidation, null, "C2"));
            txtPreco.Location = new Point(255, 27);
            txtPreco.Name = "txtPreco";
            txtPreco.ReadOnly = true;
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(255, 9);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 1;
            label5.Text = "Preço";
            // 
            // cboProduto
            // 
            cboProduto.DataBindings.Add(new Binding("SelectedValue", bindingSourceVendaProdutos, "ProdutoId", true));
            cboProduto.DataSource = bindingSourceProdutos;
            cboProduto.DisplayMember = "Descricao";
            cboProduto.FlatStyle = FlatStyle.System;
            cboProduto.FormattingEnabled = true;
            cboProduto.Location = new Point(3, 27);
            cboProduto.Name = "cboProduto";
            cboProduto.Size = new Size(246, 23);
            cboProduto.TabIndex = 2;
            cboProduto.ValueMember = "Id";
            cboProduto.SelectedIndexChanged += cboProduto_SelectedIndexChanged;
            // 
            // bindingSourceProdutos
            // 
            bindingSourceProdutos.DataSource = typeof(Models.Produto);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 9);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 1;
            label4.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 1;
            label3.Text = "Produto";
            // 
            // bindingSourceVendaProdutoLista
            // 
            bindingSourceVendaProdutoLista.DataSource = typeof(Models.VendaProduto);
            // 
            // lblTotalCompra
            // 
            lblTotalCompra.AutoSize = true;
            lblTotalCompra.Font = new Font("Segoe UI", 14F);
            lblTotalCompra.Location = new Point(532, 398);
            lblTotalCompra.Name = "lblTotalCompra";
            lblTotalCompra.Size = new Size(72, 25);
            lblTotalCompra.TabIndex = 6;
            lblTotalCompra.Text = "R$ 0,00";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 14;
            listBox1.Location = new Point(532, 24);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(508, 368);
            listBox1.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Image = Properties.Resources.cross_circle;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(944, 398);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 45);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Image = Properties.Resources.check_circle;
            btnOk.ImageAlign = ContentAlignment.MiddleLeft;
            btnOk.Location = new Point(806, 398);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(132, 45);
            btnOk.TabIndex = 8;
            btnOk.Text = "Fechar compra";
            btnOk.TextAlign = ContentAlignment.MiddleRight;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // FormCadastroVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(listBox1);
            Controls.Add(lblTotalCompra);
            Controls.Add(panel1);
            Controls.Add(cboClientes);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCadastroVenda";
            Text = "Cadastro de Venda";
            Load += FormCadastroVenda_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSourceVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVendaProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVendaProdutoLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private ComboBox cboClientes;
        private Panel panel1;
        private Button btnAdicionar;
        private TextBox txtPreco;
        private Label label5;
        private ComboBox cboProduto;
        private Label label4;
        private Label label3;
        private BindingSource bindingSourceVendaProdutos;
        private BindingSource bindingSourceProdutos;
        private BindingSource bindingSourceClientes;
        private BindingSource bindingSourceVendas;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Label lblTotalCompra;
        private BindingSource bindingSourceVendaProdutoLista;
        private DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private ListBox listBox1;
        private Button btnCancelar;
        private Button btnOk;
    }
}