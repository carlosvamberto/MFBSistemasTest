

using MFBSistemas.Models;

namespace MFBSistemas.Repositories
{
    public class RelatoriosRepository : IRelatoriosRepository
    {
        protected readonly LocalDBMSSQLLocalDBContext _context;

        public RelatoriosRepository(LocalDBMSSQLLocalDBContext context)
        {
            _context = context;
        }

        public IEnumerable<VwRelatorioProdutosVenda> GetRelatorioProdutosVendas(DateTime? startDate = null, DateTime? endDate = null)
        {
            var query = _context.VwRelatorioProdutosVendas.AsQueryable();

            if (startDate != null)
            {
                query = query.Where(v => v.DataVenda.Date >= startDate.Value.Date); 
            }

            if (endDate != null)
            {
                query = query.Where(v => v.DataVenda.Date <= endDate.Value.Date);
            }

            return query
                .OrderByDescending(v => v.TotalVendido)
                .ToList();
        }
    }
}
