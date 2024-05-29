using Metalcoin.Core.Domain;
using Metalcoin.Core.Interfaces.Repositories;

namespace MetalCoin.Infra.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext db) : base(db)
        {

        }
    }
}
