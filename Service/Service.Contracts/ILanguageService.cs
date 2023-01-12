using Shared.DataTransferObject;

namespace Service.Contracts;
public interface ILanguageService
{
    IEnumerable<LanguageDto> GetAllLanguages(bool trackChanges);

    LanguageDto GetLanguage(Guid languageId,bool trackChanges);

    LanguageDto CreateLanguage(LanguageForCreationDto language);

    void DeleteLanguage(Guid languageId, bool trackChanges);

}

