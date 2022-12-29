using Shared.DataTransferObject;

namespace Service.Contracts
{
    public interface IPersonalInfoService
    {
        PersonalInfoDto GetPersonalInfo(Guid languageId, bool trackChanges);
    }
}
