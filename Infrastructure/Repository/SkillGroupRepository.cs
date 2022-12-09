using Contracts;
using Entities.Models;

namespace Repository
{
    public class SkillGroupRepository : RepositoryBase<SkillGroup> , ISkillGroupRepository
    {
        public SkillGroupRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
