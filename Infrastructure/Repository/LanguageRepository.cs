using Contracts;
using Entities.Models;

namespace Repository
{
    public class LanguageRepository : RepositoryBase<Language> , ILanguageRepository
    {
        public LanguageRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
