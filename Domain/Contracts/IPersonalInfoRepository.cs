using Entities.Models;

namespace Contracts;
public interface IPersonalInfoRepository
{
    PersonalInfo GetPersonalInfo(Guid personalId, bool trackChanges);
    IEnumerable<PersonalInfo> GetPersonalInfos(Guid languageId, bool trackChanges);
    void CreatePersonalInfoForLanguage(Guid languageId, PersonalInfo personalInfo);
    void DeletePersonalInfo(PersonalInfo personalInfo);
}

