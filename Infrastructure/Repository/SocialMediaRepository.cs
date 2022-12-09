using Contracts;
using Entities.Models;

namespace Repository
{
    public class SocialMediaRepository : RepositoryBase<SocialMedia> , ISocialMediaRepository
    {
        public SocialMediaRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
