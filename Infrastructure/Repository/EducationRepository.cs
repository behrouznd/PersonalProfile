using Contracts;
using Entities.Models;

namespace Repository
{
    internal class EducationRepository : RepositoryBase<Education> , IEducationRepository
    {
        public EducationRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {
        }

        public IEnumerable<Education> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.Id), trackChanges).ToList();
         
    }
}
