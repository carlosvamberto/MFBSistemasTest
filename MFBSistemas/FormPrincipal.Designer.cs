namespace MFBSistemas
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            movimentosToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            tabControlMDI = new TabControl();
            relatorioDeVendasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, movimentosToolStripMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1254, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(122, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(122, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // movimentosToolStripMenuItem
            // 
            movimentosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vendaToolStripMenuItem });
            movimentosToolStripMenuItem.Name = "movimentosToolStripMenuItem";
            movimentosToolStripMenuItem.Size = new Size(86, 20);
            movimentosToolStripMenuItem.Text = "&Movimentos";
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(106, 22);
            vendaToolStripMenuItem.Text = "Venda";
            vendaToolStripMenuItem.Click += vendaToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatorioDeVendasToolStripMenuItem });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // tabControlMDI
            // 
            tabControlMDI.Dock = DockStyle.Fill;
            tabControlMDI.Location = new Point(0, 24);
            tabControlMDI.Name = "tabControlMDI";
            tabControlMDI.SelectedIndex = 0;
            tabControlMDI.Size = new Size(1254, 631);
            tabControlMDI.TabIndex = 1;
            // 
            // relatorioDeVendasToolStripMenuItem
            // 
            relatorioDeVendasToolStripMenuItem.Name = "relatorioDeVendasToolStripMenuItem";
            relatorioDeVendasToolStripMenuItem.Size = new Size(180, 22);
            relatorioDeVendasToolStripMenuItem.Text = "RelatorioDeVendas";
            relatorioDeVendasToolStripMenuItem.Click += relatorioDeVendasToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 655);
            Controls.Add(tabControlMDI);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "MFB Sistemas";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem movimentosToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private TabControl tabControlMDI;
        private ToolStripMenuItem relatorioDeVendasToolStripMenuItem;
    }
}
