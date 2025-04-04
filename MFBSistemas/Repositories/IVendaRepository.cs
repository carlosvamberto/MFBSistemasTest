using MFBSistemas.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MFBSistemas.Repositories
{
    public interface IVendaRepository : IRepository<Venda>
    {
        IEnumerable<Venda> GetFiltered(string nomeCliente = "", DateTime? dataVendaInicio = null, DateTime? dataVendaFim = null, int id = 0);
    }
}
