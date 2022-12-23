using Shared.DataTransferObject;

namespace Service.Contracts;
public interface ILanguageService
{
    IEnumerable<LanguageDto> GetAllLanguages(bool trackChanges);
}

