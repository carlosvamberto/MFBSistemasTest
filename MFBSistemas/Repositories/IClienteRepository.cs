using MFBSistemas.Models;

namespace MFBSistemas.Repositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        IEnumerable<Cliente> GetFiltered(string nome = "", int id = 0);
    }
}
