using MFBSistemas.Helper;
using MFBSistemas.Models;
using MFBSistemas.Repositories;

namespace MFBSistemas.Forms.Venda
{
    public partial class FormListagemVenda : Form
    {
        IVendaRepository _vendaRepository;
        IClienteRepository _clienteRepository;
        IProdutoRepository _produtoRepository;

        public FormListagemVenda(IVendaRepository vendaRepository, IClienteRepository clienteRepository, IProdutoRepository produtoRepository)
        {
            InitializeComponent();
            _vendaRepository = vendaRepository;
            _clienteRepository = clienteRepository;
            _produtoRepository = produtoRepository;

            bindingSourceCliente.DataSource = _clienteRepository.GetAll();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var venda = new Models.Venda() { VendaProdutos = new List<Models.VendaProduto>() };

            FormCadastroVenda formCadastroVenda =
                new FormCadastroVenda(_produtoRepository, _clienteRepository);

            if (formCadastroVenda.ShowDialog() == DialogResult.OK)
            {
                venda = formCadastroVenda.venda;
                _vendaRepository.Insert(venda);
                _vendaRepository.Save();
                btnPesquisar.PerformClick();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var vendas = _vendaRepository
                .GetFiltered(txtCliente.Text, dtInicio.Value.Date, dtFim.Value.Date)
                .OrderBy(v => v.DataVenda)
                .ToList();


            bindingSourceVenda.DataSource = vendas;
        }

        private void bindingSourceVenda_PositionChanged(object sender, EventArgs e)
        {
            Models.Venda vendaSelecionada = (Models.Venda)bindingSourceVenda.Current;

            // Trabalhando a impressão
            listBox1.Items.Clear();
            var impressao = Impressao
                .RetornaImpressao(vendaSelecionada, _produtoRepository.GetAll().ToList())
                .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in impressao)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
