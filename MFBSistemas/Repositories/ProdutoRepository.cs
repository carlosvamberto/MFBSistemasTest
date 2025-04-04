using MFBSistemas.Models;

namespace MFBSistemas.Repositories
{
    public class ProdutoRepository : Repository<Produto> , IProdutoRepository
    {
        public ProdutoRepository(LocalDBMSSQLLocalDBContext context) : base(context)
        {
            
        }

        public IEnumerable<Produto> GetFiltered(string nome = "", int id = 0)
        {
            var query = _dbSet.AsQueryable();

            if (id > 0)
                query = query.Where(c => c.Id == id);

            if (nome.Trim().Length > 0)
                query = query.Where(c => c.Descricao.Contains(nome));

            return query.ToList();
        }
    }
}
