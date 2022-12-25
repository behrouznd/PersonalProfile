using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTransferObject;

namespace Service
{
    internal sealed class LanguageService: ILanguageService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public LanguageService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager,
            IMapper mapper)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
            this._mapper = mapper;
        }

   
        public IEnumerable<LanguageDto> GetAllLanguages(bool trackChanges)
        {             
            var languages = _repository.Language.GetAllLanguages(trackChanges);
            var langiagesDto = _mapper.Map<IEnumerable<LanguageDto>>(languages);
            return langiagesDto;             
        }

        public LanguageDto GetLanguage(Guid languageId, bool trackChanges)
        {
            var language = _repository.Language.GetLanguage(languageId, trackChanges);
            if (language == null)
                throw new LanguageNotFoundException(languageId);

            var lauguageDto = _mapper.Map<LanguageDto>(language);
            return lauguageDto;
        }
    }
}
