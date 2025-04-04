using MFBSistemas.Models;
using Microsoft.EntityFrameworkCore;

namespace MFBSistemas.Repositories
{
    public class VendaRepository : Repository<Venda>, IVendaRepository
    {
        public VendaRepository(LocalDBMSSQLLocalDBContext context) : base(context)
        {

        }

        public IEnumerable<Venda> GetFiltered(string nomeCliente = "", DateTime? dataVendaInicio = null, DateTime? dataVendaFim = null, int id = 0)
        {
            var query = _dbSet
                .Include(v => v.Cliente)
                .Include(v => v.VendaProdutos)
                    .ThenInclude(vp => vp.Produto)                
                .AsQueryable();

            if (id > 0)
                query = query.Where(v => v.Id == id);

            if (nomeCliente.Trim().Length > 0)
                query = query.Where(v => v.Cliente.Nome.Contains(nomeCliente));

            if (dataVendaInicio != null)
                query = query.Where(v => v.DataVenda.Date >= dataVendaInicio.Value.Date);

            if (dataVendaFim != null)
                query = query.Where(v => v.DataVenda.Date <= dataVendaFim.Value.Date);

            return query.ToList();
        }
    }
}
