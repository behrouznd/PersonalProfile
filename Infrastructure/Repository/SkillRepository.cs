using Contracts;
using Entities.Models;

namespace Repository
{
    public class SkillRepository : RepositoryBase<Skill> , ISkillRepository
    {
        public SkillRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
