namespace MFBSistemas.Forms.Produtos
{
    partial class FormCadastroProduto
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
            bindingSourceProduto = new BindingSource(components);
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            btnCancelar = new Button();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceProduto).BeginInit();
            SuspendLayout();
            // 
            // bindingSourceProduto
            // 
            bindingSourceProduto.DataSource = typeof(Models.Produto);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 27);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 11;
            label2.Text = "Descrição";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 27);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 10;
            label1.Text = "Id";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSourceProduto, "Descricao", true));
            textBox2.Location = new Point(139, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceProduto, "Id", true));
            textBox1.Location = new Point(46, 45);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(76, 23);
            textBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 83);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 13;
            label4.Text = "Preço";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bindingSourceProduto, "PrecoUnit", true, DataSourceUpdateMode.OnValidation, null, "C2"));
            textBox4.Location = new Point(46, 101);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(133, 23);
            textBox4.TabIndex = 12;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Image = Properties.Resources.cross_circle;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(358, 178);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 45);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Image = Properties.Resources.check_circle;
            btnOk.ImageAlign = ContentAlignment.MiddleLeft;
            btnOk.Location = new Point(279, 178);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(73, 45);
            btnOk.TabIndex = 14;
            btnOk.Text = "Ok";
            btnOk.TextAlign = ContentAlignment.MiddleRight;
            btnOk.UseVisualStyleBackColor = true;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 249);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormCadastroProduto";
            ShowIcon = false;
            Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)bindingSourceProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSourceProduto;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox4;
        private Button btnCancelar;
        private Button btnOk;
    }
}