using Contracts;
using Entities.Models;

namespace Repository
{
    public class PersonalInfoRepository : RepositoryBase<PersonalInfo> , IPersonalInfoRepository
    {
        public PersonalInfoRepository(RepositoryContext repositoryContext ) : base( repositoryContext )
        {
        }

        public PersonalInfo GetPersonalInfo(Guid personalId, bool trackChanges) => 
            FindByCondition( x=>x.Id.Equals( personalId ) , trackChanges).FirstOrDefault();   


        public IEnumerable<PersonalInfo> GetPersonalInfos(Guid languageId, bool trackChanges)=>
            FindByConditionIncluding(x=>x.LanguageId.Equals(languageId), trackChanges, 
                "Educations", "Experiences", "Certificates", "SocialMedias")
            .ToList();


        public void CreatePersonalInfoForLanguage(Guid languageId, PersonalInfo personalInfo)
        {
            personalInfo.LanguageId = languageId;
            Create(personalInfo);
        }

        public void DeletePersonalInfo(PersonalInfo personalInfo)=> Delete(personalInfo);

        
    }
}
