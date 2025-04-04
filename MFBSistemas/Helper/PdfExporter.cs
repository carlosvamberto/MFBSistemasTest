using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Diagnostics;

namespace MFBSistemas.Helper
{
    public class PdfExporter
    {
        public static void ExportDataGridViewToPDF(DataGridView dgv, string filePath)
        {
            // Configuração do QuestPDF
            QuestPDF.Settings.License = LicenseType.Community;

            // Criando o documento PDF
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(30);
                    page.Size(PageSizes.A4);

                    page.Header().Text("Relatório de Vendas").FontSize(20).SemiBold();

                    page.Content().Table(table =>
                    {
                        // Define colunas de acordo com o número de colunas do DataGridView
                        table.ColumnsDefinition(columns =>
                        {
                            foreach (DataGridViewColumn column in dgv.Columns)
                            {
                                columns.RelativeColumn();
                            }
                        });

                        // Adiciona os cabeçalhos da tabela
                        table.Header(header =>
                        {
                            foreach (DataGridViewColumn column in dgv.Columns)
                            {
                                header.Cell().BorderBottom(1).Text(column.HeaderText).SemiBold();
                            }
                        });

                        // Adiciona os dados da DataGridView
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (row.IsNewRow) continue; // Ignora linha em branco
                            int lin = row.Index + 1;
                            table.Cell().Row((uint)lin); // Define a linha correta
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string text = cell.Value?.ToString() ?? "";
                                table.Cell().BorderBottom(0.5f).Text(text);
                            }
                        }
                    });

                    page.Footer().AlignCenter().Text($"Gerado em {DateTime.Now:dd/MM/yyyy HH:mm}");
                });
            })
            .GeneratePdf(filePath);

            MessageBox.Show("PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // **Abre o PDF automaticamente**
            Process.Start(new ProcessStartInfo()
            {
                FileName = filePath,
                UseShellExecute = true // Permite que o SO escolha o programa para abrir
            });
        }
    }
}
