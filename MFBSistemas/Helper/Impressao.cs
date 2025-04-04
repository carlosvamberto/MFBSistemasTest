using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFBSistemas.Helper
{
    public static class Impressao
    {
        public static string LinhaSimples(int x) 
            => new string('-',x);

        public static string LinhaDupla(int x) 
            => new string('=', x);

        public static string FormatoMoeda(decimal x, int tamanho)
            => new string(' ',tamanho - 1 - x.ToString("C2").Length) + x.ToString("C2");

        public static string FormatoNumero(int x, int tamanho)
            => new string(' ', tamanho - 1 - x.ToString().Length) + x.ToString();

        public static string RetornaImpressao(Models.Venda venda, List<Models.Produto> produtos)
        {
            StringBuilder impressao = new StringBuilder();
            string linha;

            // Imprimindo cabeçalho
            impressao.AppendLine(LinhaDupla(60));
            impressao.AppendLine("MBF Materiais Elétricos S/A");
            impressao.AppendLine(venda.DataVenda.ToLongDateString());
            impressao.AppendLine(LinhaDupla(60));

            // Cebaçalho da Tabela
            linha = "Produto".PadRight(30, ' ')
                + "Preço".PadLeft(12, ' ')
                + "Qtd".PadLeft(5, ' ')
                + "Total".PadLeft(12, ' ');
            impressao.AppendLine(linha);

            impressao.AppendLine(LinhaSimples(60));

            // Imprimindo itens
            foreach (var item in venda.VendaProdutos)
            {
                string produtoDescricao = produtos.Find(x => x.Id == item.ProdutoId).Descricao;
                linha = produtoDescricao.PadRight(30, ' ')
                    + item.PrecoUnit.ToString("C2").PadLeft(12, ' ')
                    + item.Quantidade.ToString().PadLeft(5, ' ')
                    + item.Total.ToString("C2").PadLeft(12, ' ');
                impressao.AppendLine(linha);
            }
            impressao.AppendLine(LinhaSimples(60));

            // Total
            decimal total = venda.VendaProdutos.Sum(x => x.Total);
            linha = total.ToString("C2").PadLeft(60, ' ');
            impressao.AppendLine(linha);


            return impressao.ToString();
        }

    }
}
