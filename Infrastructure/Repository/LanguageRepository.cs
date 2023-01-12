using Contracts;
using Entities.Models;

namespace Repository
{
    public class LanguageRepository : RepositoryBase<Language> , ILanguageRepository
    {
        public LanguageRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }



        public IEnumerable<Language> GetAllLanguages(bool trackChanges)=>
            FindAll(trackChanges).OrderBy(x => x.Id).ToList();

        public Language GetLanguage(Guid languageId, bool trackChanges)=>
            FindByCondition(x=> x.Id.Equals(languageId),trackChanges)
            .FirstOrDefault();

        public void CreateLanguage(Language language)=>
            Create(language);

        public void DeleteLanguage(Language language)=> Delete(language);
    }
}
