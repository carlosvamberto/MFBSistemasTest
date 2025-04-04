using MFBSistemas.Helper;
using MFBSistemas.Repositories;
using System.Reflection;

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

        private void btnPDF_Click(object sender, EventArgs e)
        {
            string caminhoArquivo = Assembly.GetExecutingAssembly().Location + @"RelatorioVendas.pdf";
            PdfExporter.ExportDataGridViewToPDF(dataGridView1, caminhoArquivo);
        }
    }
}
