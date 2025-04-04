using MFBSistemas.Models;
using MFBSistemas.Repositories;
using Microsoft.Data.SqlClient;

namespace MFBSistemas.Forms.Clientes
{
    public partial class FormListagemClientes : Form
    {
        private IClienteRepository _clienteRepository;
        public FormListagemClientes(IClienteRepository repoCliente)
        {
            InitializeComponent();
            _clienteRepository = repoCliente;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = _clienteRepository
                .GetFiltered(txtFiltro.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (clienteBindingSource.DataSource == null || clienteBindingSource.Count == 0)
            {
                MessageBox.Show("Primeiro tem que selecionar um Cliente para poder alterá-lo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var clienteAtual = (Cliente)clienteBindingSource.Current;
                FormCadastroCliente formCadastroCliente =
                    new FormCadastroCliente(clienteAtual);

                if (formCadastroCliente.ShowDialog() == DialogResult.OK)
                {
                    _clienteRepository.Update(formCadastroCliente.cliente);
                    _clienteRepository.Save();
                    btnPesquisar.PerformClick();
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCadastroCliente =
                new FormCadastroCliente(new Cliente());

            if (formCadastroCliente.ShowDialog() == DialogResult.OK)
            {
                _clienteRepository.Insert(formCadastroCliente.cliente);
                _clienteRepository.Save();

                txtFiltro.Clear();
                btnPesquisar.PerformClick();
            }            
        }

        private void btnClearFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (clienteBindingSource.DataSource == null || clienteBindingSource.Count == 0)
            {
                MessageBox.Show("Primeiro tem que selecionar um Cliente para poder excluí-lo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Deseja realmente excluir este registro?","Pergunta", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)== DialogResult.Yes)
            {
                try
                {
                    var clienteAtual = (Cliente)clienteBindingSource.Current;
                    _clienteRepository.Delete(clienteAtual.Id);
                    _clienteRepository.Save();
                    btnPesquisar.PerformClick();
                }
                catch (SqlException sqlExp)
                {
                    MessageBox.Show("O Cliente não pode ser excluído pois possui vendas relacionadas.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
