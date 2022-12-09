using Contracts;
using Entities.Models;

namespace Repository
{
    internal class EducationRepository : RepositoryBase<Education> , IEducationRepository
    {
        public EducationRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {
        }
    }
}
