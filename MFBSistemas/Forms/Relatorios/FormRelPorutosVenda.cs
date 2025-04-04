using MFBSistemas.Repositories;

namespace MFBSistemas.Forms.Relatorios
{
    public partial class FormRelPorutosVenda : Form
    {
        IRelatoriosRepository _relatorioRepository;
        public FormRelPorutosVenda(IRelatoriosRepository relatorioRepository)
        {
            InitializeComponent();
            _relatorioRepository = relatorioRepository;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime? dateInicio = null;
            DateTime? dateFim = null;

            if (dtInicio.Checked) dateInicio = dtInicio.Value.Date;
            if (dtFim.Checked) dateFim = dtFim.Value.Date;


            var relatorio = 
                _relatorioRepository.GetRelatorioProdutosVendas(dateInicio, dateFim);

            bindingSourceRelatorioProdutosVenda.DataSource = relatorio;
        }
    }
}
