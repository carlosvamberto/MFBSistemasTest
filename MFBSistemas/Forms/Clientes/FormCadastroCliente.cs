using Model = MFBSistemas.Models;

namespace MFBSistemas.Forms.Clientes
{
    public partial class FormCadastroCliente : Form
    {
        public Model.Cliente cliente;

        public FormCadastroCliente(Model.Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            bindingSourceCliente.DataSource = this.cliente;            
        }
    }
}
