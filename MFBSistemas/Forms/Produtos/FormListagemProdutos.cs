using MFBSistemas.Forms.Clientes;
using MFBSistemas.Models;
using MFBSistemas.Repositories;
using Microsoft.Data.SqlClient;
using System.Globalization;

namespace MFBSistemas.Forms.Produtos
{
    public partial class FormListagemProdutos : Form
    {
        IProdutoRepository _produtoRepository;
        public FormListagemProdutos(IProdutoRepository produtoRepository)
        {
            InitializeComponent();
            _produtoRepository = produtoRepository;
        }

        private void FormListagemProdutos_Load(object sender, EventArgs e)
        {
            //if (dataGridView1.Columns != null && dataGridView1.Columns.Count > 0) 
            //{
            //    dataGridView1.Columns["PrecoUnit"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
            //}
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastroProduto =
                new FormCadastroProduto(new Models.Produto());

            if (formCadastroProduto.ShowDialog() == DialogResult.OK)
            {
                _produtoRepository.Insert(formCadastroProduto.produto);
                _produtoRepository.Save();

                txtFiltro.Clear();
                btnPesquisar.PerformClick();
            }
        }

        private void btnClearFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (bindingSourceProduto.DataSource == null || bindingSourceProduto.Count == 0)
            {
                MessageBox.Show("Primeiro tem que selecionar um Produto para poder alterá-lo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var produtoAtual = (Produto)bindingSourceProduto.Current;
                FormCadastroProduto formCadastroProduto =
                    new FormCadastroProduto(produtoAtual);

                if (formCadastroProduto.ShowDialog() == DialogResult.OK)
                {
                    _produtoRepository.Update(formCadastroProduto.produto);
                    _produtoRepository.Save();
                    btnPesquisar.PerformClick();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (bindingSourceProduto.DataSource == null || bindingSourceProduto.Count == 0)
            {
                MessageBox.Show("Primeiro tem que selecionar um Produto para poder excluí-lo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Deseja realmente excluir este registro?", "Pergunta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    var produtoAtual = (Produto)bindingSourceProduto.Current;
                    _produtoRepository.Delete(produtoAtual.Id);
                    _produtoRepository.Save();
                    btnPesquisar.PerformClick();
                }
                catch (SqlException sqlExp)
                {
                    MessageBox.Show("O Cliente não pode ser excluído pois possui vendas relacionadas.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            bindingSourceProduto.DataSource = _produtoRepository
                .GetFiltered(txtFiltro.Text);
        }
    }
}
