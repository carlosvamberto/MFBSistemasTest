namespace MFBSistemas.Forms.Clientes
{
    partial class FormCadastroCliente
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
            bindingSourceCliente = new BindingSource(components);
            btnOk = new Button();
            btnCancelar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCliente).BeginInit();
            SuspendLayout();
            // 
            // bindingSourceCliente
            // 
            bindingSourceCliente.DataSource = typeof(Models.Cliente);
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Image = Properties.Resources.check_circle;
            btnOk.ImageAlign = ContentAlignment.MiddleLeft;
            btnOk.Location = new Point(263, 153);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(73, 45);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.TextAlign = ContentAlignment.MiddleRight;
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Image = Properties.Resources.cross_circle;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(342, 153);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 45);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceCliente, "Id", true));
            textBox1.Location = new Point(29, 47);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(76, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSourceCliente, "Nome", true));
            textBox2.Location = new Point(122, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSourceCliente, "Email", true));
            textBox3.Location = new Point(29, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bindingSourceCliente, "Telefone", true));
            textBox4.Location = new Point(304, 110);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(133, 23);
            textBox4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 6;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 29);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 92);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 92);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 9;
            label4.Text = "Telefone";
            // 
            // FormCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 214);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Name = "FormCadastroCliente";
            ShowIcon = false;
            Text = "Cadastro de Cliente";
            ((System.ComponentModel.ISupportInitialize)bindingSourceCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSourceCliente;
        private Button btnOk;
        private Button btnCancelar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}