using MFBSistemas.Helper;
using MFBSistemas.Models;
using MFBSistemas.Repositories;

namespace MFBSistemas.Forms.Venda
{
    public partial class FormCadastroVenda : Form
    {
        private IProdutoRepository _produtoRepository;
        private IClienteRepository _clienteRepository;

        private List<Produto> _produtos;
        private List<Cliente> _clientes;

        public Models.Venda venda { get; set; }

        public FormCadastroVenda(IProdutoRepository produtoRepository, IClienteRepository clienteRepository)
        {
            InitializeComponent();

            venda = new Models.Venda { DataVenda = DateTime.Now, VendaProdutos = new List<VendaProduto>() };
            _produtoRepository = produtoRepository;
            _clienteRepository = clienteRepository;
        }

        private void FormCadastroVenda_Load(object sender, EventArgs e)
        {
            // Preparando os dados do Cliente para o Combobox
            _clientes = _clienteRepository
                .GetAll()
                .OrderBy(c => c.Nome)
                .ToList();

            bindingSourceClientes.DataSource = _clientes;

            // Preparando os dados do Produto para o Combobox
            _produtos =
                _produtoRepository
                .GetAll()
                .OrderBy(p => p.Descricao)
                .ToList();

            bindingSourceProdutos.DataSource = _produtos;

            // Preparando bindSource de vendaproduto
            bindingSourceVendaProdutos.DataSource = new Models.VendaProduto();

            /*
            CboProdutoId.DataSource = _produtos;
            CboProdutoId.ValueMember = "Id";
            CboProdutoId.DisplayMember = "Descricao";
            */
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaSoma();
        }

        private void AtualizaSoma()
        {
            var currentVenda = (VendaProduto)bindingSourceVendaProdutos.Current;

            int produtoId = cboProduto.SelectedValue != null
                ? (int)cboProduto.SelectedValue
                : 0;

            if (currentVenda != null && produtoId != 0)
            {
                currentVenda.Quantidade = (int)numericUpDown1.Value;
                currentVenda.ProdutoId = produtoId;
                currentVenda.PrecoUnit = _produtos.Find(p => p.Id == produtoId).PrecoUnit;
                currentVenda.Total = currentVenda.PrecoUnit * currentVenda.Quantidade;

                // Atualiza os controles vinculados
                bindingSourceVendaProdutos.ResetCurrentItem();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            AtualizaSoma();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var currentVenda = (VendaProduto)bindingSourceVendaProdutos.Current;
            //currentVenda.Produto = _produtos.Find(p => p.Id == currentVenda.ProdutoId);
            venda.VendaProdutos.Add(currentVenda);

            // Limpa os campos
            bindingSourceVendaProdutos.DataSource = new Models.VendaProduto();
            numericUpDown1.Value = 1;

            // Atualiza os controles vinculados
            bindingSourceVendaProdutos.ResetCurrentItem();

            // Preparando bindSource de vendaproduto da listagem
            bindingSourceVendaProdutoLista.DataSource = venda.VendaProdutos;


            // Atualiza os controles vinculados
            bindingSourceVendaProdutoLista.ResetCurrentItem();


            // Trabalhando a impressão
            listBox1.Items.Clear();
            var impressao = Impressao
                .RetornaImpressao(venda, _produtos)
                .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in impressao)
            {
                listBox1.Items.Add(item);
            }

            AtualizaSomaTotal();
        }

        private void AtualizaSomaTotal()
        {
            decimal somaTotal = venda.VendaProdutos.Sum(vp => vp.Total);
            lblTotalCompra.Text = somaTotal.ToString("C2");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            venda.ClienteId = ((Cliente)cboClientes.SelectedItem).Id;
            DialogResult = DialogResult.OK;
        }
    }
}
