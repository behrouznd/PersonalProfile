using Shared.DataTransferObject;

namespace Service.Contracts
{
    public interface IPersonalInfoService
    {
        PersonalInfoDto GetPersonalInfo(Guid languageId, bool trackChanges);
        PersonalInfoDto CreatePersonalInfo(Guid languageId, PersonalInfoForCreationDto personalInfo , bool trackChanges);
        void DeletePersonalInfo(Guid languageId, Guid personalId, bool trackChanges);
        void UpdatePersonalInfoForLanguage(Guid languageId, Guid personalId, PersonalInfoForUpdateDto personalInfo, bool languageTrackChanges, bool personalTrackChanges);

    }
}
