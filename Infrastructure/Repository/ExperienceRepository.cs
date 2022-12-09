using Contracts;
using Entities.Models;

namespace Repository
{
    public class ExperienceRepository : RepositoryBase<Experience> , IExperienceRepository
    {
        public ExperienceRepository(RepositoryContext repositoryContext ) : base( repositoryContext )
        {
        }
    }
}
