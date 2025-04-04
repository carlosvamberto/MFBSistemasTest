using MFBSistemas.Models;

namespace MFBSistemas.Repositories
{    
    public interface IRelatoriosRepository
    {
        IEnumerable<Models.VwRelatorioProdutosVenda> GetRelatorioProdutosVendas(DateTime? startDate = null, DateTime? endDate = null);
    }
}
