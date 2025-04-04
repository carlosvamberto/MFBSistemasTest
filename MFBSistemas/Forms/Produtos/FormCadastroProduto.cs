using Model = MFBSistemas.Models;

namespace MFBSistemas.Forms.Produtos
{
    public partial class FormCadastroProduto : Form
    {
        public Model.Produto produto;
        public FormCadastroProduto(Model.Produto produto)
        {
            InitializeComponent();
            this.produto = produto;
            bindingSourceProduto.DataSource = this.produto;
        }        
    }
}
