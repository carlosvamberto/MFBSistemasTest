using MFBSistemas.Models;

namespace MFBSistemas.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        IEnumerable<Produto> GetFiltered(string nome = "", int id = 0);
    }
}
