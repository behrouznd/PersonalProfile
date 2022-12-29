using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTransferObject;

namespace Service
{
    internal sealed class PersonalInfoService : IPersonalInfoService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PersonalInfoService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager,
            IMapper mapper)
        {
            this._repository = repositoryManager;
            this._logger = loggerManager;
            this._mapper = mapper;
        }

        public PersonalInfoDto GetPersonalInfo(Guid languageId, bool trackChanges)
        {
            var language = _repository.Language.GetLanguage(languageId, trackChanges);
            if (language == null)
                throw new LanguageNotFoundException(languageId);
            var personaInfoFromDB = _repository.PersonalInfo.GetPersonalInfos(languageId, trackChanges).FirstOrDefault();
            var personalDto = _mapper.Map<PersonalInfoDto>(personaInfoFromDB);
            return personalDto;
        }
    }
}
