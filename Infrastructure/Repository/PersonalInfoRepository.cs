using Contracts;
using Entities.Models;

namespace Repository
{
    public class PersonalInfoRepository : RepositoryBase<PersonalInfo> , IPersonalInfoRepository
    {
        public PersonalInfoRepository(RepositoryContext repositoryContext ) : base( repositoryContext )
        {
        }

        public IEnumerable<PersonalInfo> GetPersonalInfos(Guid languageId, bool trackChanges)=>
            FindByConditionIncluding(x=>x.LanguageId.Equals(languageId), trackChanges, 
                "Educations", "Experiences", "Certificates", "SocialMedias")
            .ToList();

         
    }
}
