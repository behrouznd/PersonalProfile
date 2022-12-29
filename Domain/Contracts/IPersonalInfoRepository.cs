using Entities.Models;

namespace Contracts;
public interface IPersonalInfoRepository
{
    IEnumerable<PersonalInfo> GetPersonalInfos(Guid languageId, bool trackChanges);
}

