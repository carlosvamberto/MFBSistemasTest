using MFBSistemas.Models;

namespace MFBSistemas.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(LocalDBMSSQLLocalDBContext context) : base(context)
        {
            
        }

        public IEnumerable<Cliente> GetFiltered(string nome = "", int id = 0)
        {
            var query = _dbSet.AsQueryable();

            if (id > 0)
                query = query.Where(c => c.Id == id);

            if (nome.Trim().Length > 0)
                query = query.Where(c => c.Nome.Contains(nome));

            return query.ToList();
        }
    }
}
