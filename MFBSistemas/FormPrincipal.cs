using Unity;

namespace MFBSistemas
{
    public partial class FormPrincipal : Form
    {

        private readonly IUnityContainer _container;

        // Construtor que recebe o container DI
        public FormPrincipal(IUnityContainer container)
        {
            InitializeComponent();
            _container = container;
            // Configura o MDI Container e o TabControl conforme necess�rio
            this.IsMdiContainer = true;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Resolve a inst�ncia do FormListagemClientes pelo container
            var formListagemClientes = _container.Resolve<Forms.Clientes.FormListagemClientes>();

            // Configura o formul�rio para se comportar como conte�do de uma aba
            formListagemClientes.TopLevel = false;
            formListagemClientes.FormBorderStyle = FormBorderStyle.None;
            formListagemClientes.Dock = DockStyle.Fill;

            // Cria uma nova aba com o t�tulo do formul�rio
            TabPage novaAba = new TabPage(formListagemClientes.Text);

            // Adiciona o formul�rio � aba
            novaAba.Controls.Add(formListagemClientes);

            // Adiciona a aba ao TabControl do FormPrincipal (supondo que o TabControl se chame "tabControlMDI")
            tabControlMDI.TabPages.Add(novaAba);

            // Exibe o formul�rio
            formListagemClientes.Show();
        }

        private void AparenciaTabMDI()
        {
            tabControlMDI.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControlMDI.DrawItem += new DrawItemEventHandler(tabControlMDI_DrawItem);

        }

        private void tabControlMDI_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Obtenha a aba atual
            TabPage tabPage = tabControlMDI.TabPages[e.Index];
            Rectangle tabRect = tabControlMDI.GetTabRect(e.Index);

            // Defina a cor de fundo desejada (exemplo: azul claro)
            using (SolidBrush backgroundBrush = new SolidBrush(Color.LightBlue))
            {
                e.Graphics.FillRectangle(backgroundBrush, tabRect);
            }

            // Se desejar, desenhe a borda da aba
            using (Pen borderPen = new Pen(Color.Gray))
            {
                e.Graphics.DrawRectangle(borderPen, tabRect);
            }

            // Desenhe o texto da aba centralizado
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabControlMDI.Font, tabRect, tabPage.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Resolve a inst�ncia do FormListagemProdutos pelo container
            var formListagemProdutos = _container.Resolve<Forms.Produtos.FormListagemProdutos>();

            // Configura o formul�rio para se comportar como conte�do de uma aba
            formListagemProdutos.TopLevel = false;
            formListagemProdutos.FormBorderStyle = FormBorderStyle.None;
            formListagemProdutos.Dock = DockStyle.Fill;

            // Cria uma nova aba com o t�tulo do formul�rio
            TabPage novaAba = new TabPage(formListagemProdutos.Text);

            // Adiciona o formul�rio � aba
            novaAba.Controls.Add(formListagemProdutos);

            // Adiciona a aba ao TabControl do FormPrincipal (supondo que o TabControl se chame "tabControlMDI")
            tabControlMDI.TabPages.Add(novaAba);

            // Exibe o formul�rio
            formListagemProdutos.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Resolve a inst�ncia do FormListagemVenda pelo container
            var formListagemVenda = _container.Resolve<Forms.Venda.FormListagemVenda>();

            // Configura o formul�rio para se comportar como conte�do de uma aba
            formListagemVenda.TopLevel = false;
            formListagemVenda.FormBorderStyle = FormBorderStyle.None;
            formListagemVenda.Dock = DockStyle.Fill;

            // Cria uma nova aba com o t�tulo do formul�rio
            TabPage novaAba = new TabPage(formListagemVenda.Text);

            // Adiciona o formul�rio � aba
            novaAba.Controls.Add(formListagemVenda);

            // Adiciona a aba ao TabControl do FormPrincipal (supondo que o TabControl se chame "tabControlMDI")
            tabControlMDI.TabPages.Add(novaAba);

            // Exibe o formul�rio
            formListagemVenda.Show();
        }

        private void relatorioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Resolve a inst�ncia do FormListagemVenda pelo container
            var formRelVenda = _container.Resolve<Forms.Relatorios.FormRelPorutosVenda>();

            // Configura o formul�rio para se comportar como conte�do de uma aba
            formRelVenda.TopLevel = false;
            formRelVenda.FormBorderStyle = FormBorderStyle.None;
            formRelVenda.Dock = DockStyle.Fill;

            // Cria uma nova aba com o t�tulo do formul�rio
            TabPage novaAba = new TabPage(formRelVenda.Text);

            // Adiciona o formul�rio � aba
            novaAba.Controls.Add(formRelVenda);

            // Adiciona a aba ao TabControl do FormPrincipal (supondo que o TabControl se chame "tabControlMDI")
            tabControlMDI.TabPages.Add(novaAba);

            // Exibe o formul�rio
            formRelVenda.Show();
        }
    }
}
