using Contracts;
using Entities.Models;

namespace Repository
{
    public class PortfolioRepository : RepositoryBase<Portfolio> , IPortfolioRepository
    {
        public PortfolioRepository(RepositoryContext repositoryContext ) : base( repositoryContext )
        {                
        }
    }
}
